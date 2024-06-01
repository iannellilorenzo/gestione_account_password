using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace gestione_account_password
{
    /// <summary>
    /// Manages everything involving files using a secure Singleton pattern
    /// </summary>
    public sealed class FileManager
    {
        // Singleton pattern implementation
        private static FileManager instance = null;
        private static readonly object padlock = new();

        private FileManager()
        {

        }

        /// <summary>
        /// Gets the instance of the class with a simple thread-safe implementation of the Singleton pattern
        /// </summary>
        public static FileManager Instance
        {
            get
            {
                if (instance == null)
                {
                    // Locks the instance to avoid multiple threads to create multiple instances
                    lock (padlock)
                    {
                        // If the instance is null, it creates a new one
                        instance ??= new FileManager();
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Default deserializer to get the content of a file
        /// </summary>
        /// <param name="fileName"> File name + extension </param>
        /// <returns> File content saved as string </returns>
        /// <exception cref="InvalidOperationException"> Thrown if the file doesn't exits, because it can't deserialized </exception>
        public string DefaultDeserializer(string fileName)
        {
            // If the file doesn't exist, the program can't deserialize from it
            string fileContent = "";
            if (!File.Exists(fileName))
            {
                throw new InvalidOperationException();
            }

            // If the file exists, the program can deserialize from it, saving the content in a string
            using (FileStream fs = new(fileName, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fs.Length];
                int bytesRead = fs.Read(bytes, 0, bytes.Length);
                fileContent = Encoding.UTF8.GetString(bytes);
                fs.Close();
            }

            return fileContent;
        }

        /// <summary>
        /// Default serializer to save content in a file
        /// </summary>
        /// <param name="fileName"> File name + extension </param>
        /// <param name="content"> Content to write already serialized </param>
        public void DefaultSerializer(string fileName, string content)
        {
            // Simple serialization to save the content in a file
            using (FileStream fs = new(fileName, FileMode.Create, FileAccess.Write))
            {
                byte[] data = new UTF8Encoding(true).GetBytes(content);
                fs.Write(data, 0, data.Length);
                fs.Close();
            }
        }

        /// <summary>
        /// Serializes a new master account registered
        /// </summary>
        /// <param name="fileName"> Specifies where to serialize </param>
        /// <param name="masterAccounts"> Master account to be serialized </param>
        /// <returns> Int code to determine if the operation was successful or not </returns>
        public int RegisterSerializer(string fileName, List<MasterAccount> masterAccounts)
        {
            // If the file doesn't exist, the master account surely can be serialized right away
            if (!File.Exists(fileName))
            {
                // Serializing the master account
                string toSerialize = JsonConvert.SerializeObject(masterAccounts, Formatting.Indented);
                using (FileStream fs = File.Create(fileName))
                {
                    byte[] data = new UTF8Encoding(true).GetBytes(toSerialize);
                    fs.Write(data, 0, data.Length);
                    fs.Close();
                }

                return 0;
            }

            // If the file exists, the program can deserialize from it, saving the master accounts in memory
            List<MasterAccount> masters;
            string fileContent = DefaultDeserializer(fileName);
            masters = JsonConvert.DeserializeObject<List<MasterAccount>>(fileContent);

            // If the master account is already registered, the operation can't be done
            foreach (var item in masters)
            {
                if (masterAccounts.Any(x => x.MasterName == item.MasterName && x.Password.DecryptPassword(x.MasterName) == item.Password.DecryptPassword(x.MasterName)))
                {
                    return -1;
                }
            }

            // If the master account is not registered, it can be serialized
            masters.Add(masterAccounts[0]);
            string updatedJson = JsonConvert.SerializeObject(masters, Formatting.Indented);

            // Serializing the master account
            using (FileStream fs = new(fileName, FileMode.Open, FileAccess.Write))
            {
                byte[] data = new UTF8Encoding(true).GetBytes(updatedJson);
                fs.Write(data, 0, data.Length);
                fs.Close();
            }

            return 0;
        }

        /// <summary>
        /// Deserializes the file saving in memory master accounts
        /// </summary>
        /// <param name="fileName"> File name to get information from </param>
        /// <returns> Every master account saved on the file </returns>
        /// <exception cref="InvalidOperationException"> Thrown if the file doesn't exits, because it can't deserialized </exception>
        public List<MasterAccount> Deserializer(string fileName)
        {
            // If the file doesn't exist, the program can't deserialize from it
            if (!File.Exists(fileName))
            {
                throw new InvalidOperationException();
            }

            // If the file exists, the program can deserialize from it, saving the master accounts in memory
            List<MasterAccount> masterAccounts;
            using (FileStream fs = new(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new(fs, Encoding.UTF8))
                {
                    using (JsonTextReader jsonReader = new(sr))
                    {
                        // Deserializing the file
                        JsonSerializer ser = new();
                        masterAccounts = ser.Deserialize<List<MasterAccount>>(jsonReader);
                        jsonReader.Close();
                    }

                    sr.Close();
                }

                fs.Close();
            }

            return masterAccounts;
        }

        /// <summary>
        /// Lets the user export the accounts in a CSV file
        /// </summary>
        /// <param name="fullPath"> Directory + file name + extension </param>
        /// <param name="contentToExport"> All the accounts formatted correctly and ready to be exported </param>
        /// <returns> True if it goes right, false if not </returns>
        public bool ExportAccountsInCSV(string fullPath, string contentToExport)
        {
            bool result = false;
            using (FileStream fs = new(fullPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new(fs, Encoding.UTF8))
                {
                    // Writing the content to the file
                    sw.WriteLine(contentToExport);
                    result = true;
                    sw.Close();
                }

                fs.Close();
            }

            return result;
        }

        /// <summary>
        /// Lets the user export the accounts in a JSON file
        /// </summary>
        /// <param name="fullPath"> Directory + file name + extension </param>
        /// <param name="masterAccountDetails"> Master account to get the accounts from </param>
        /// <returns> True if it goes right, false if not </returns>
        public bool ExportAccountInJson(string fullPath, MasterAccount masterAccountDetails)
        {
            // Serializing the accounts to export them in a JSON file
            bool result = false;
            string exportString = JsonConvert.SerializeObject(masterAccountDetails.Accounts, Formatting.Indented);

            using (FileStream fs = new(fullPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new(fs, Encoding.UTF8))
                {
                    // Writing the content to the file
                    sw.Write(exportString);
                    result = true;
                    sw.Close();
                }

                fs.Close();
            }

            return result;
        }
    }
}
