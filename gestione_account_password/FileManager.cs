using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace gestione_account_password
{
    public sealed class FileManager
    {
        private static FileManager instance = null;
        private static readonly object padlock = new();

        private FileManager()
        {

        }

        public static FileManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        instance ??= new FileManager();
                    }
                }

                return instance;
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
            if (!File.Exists(fileName))
            {
                string toSerialize = JsonConvert.SerializeObject(masterAccounts, Formatting.Indented);
                using (FileStream fs = File.Create(fileName))
                {
                    byte[] data = new UTF8Encoding(true).GetBytes(toSerialize);
                    fs.Write(data, 0, data.Length);
                    fs.Close();
                }

                return 0;
            }

            List<MasterAccount> masters;

            using (FileStream fs = new(fileName, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fs.Length];
                int bytesRead = fs.Read(bytes, 0, bytes.Length);
                string fileContent = Encoding.UTF8.GetString(bytes);
                masters = JsonConvert.DeserializeObject<List<MasterAccount>>(fileContent);
                fs.Close();
            }

            foreach (var item in masters)
            {
                if (masterAccounts.Any(x => x.MasterName == item.MasterName && x.Password.DecryptPassword(x.MasterName) == item.Password.DecryptPassword(x.MasterName)))
                {
                    return -1;
                }
            }

            masters.Add(masterAccounts[0]);
            string updatedJson = JsonConvert.SerializeObject(masters, Formatting.Indented);

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
        /// <exception cref="InvalidOperationException"> If the file doesn't exits, it can deserialize from it </exception>
        public List<MasterAccount> Deserializer(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new InvalidOperationException();
            }

            List<MasterAccount> masterAccounts;

            using (FileStream fs = new(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new(fs, Encoding.UTF8))
                {
                    using (JsonTextReader jsonReader = new(sr))
                    {
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
                    sw.WriteLine(contentToExport);
                    result = true;
                    sw.Close();
                }

                fs.Close();
            }

            return result;
        }
    }
}
