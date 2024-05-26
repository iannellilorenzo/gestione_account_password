using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Threading;

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
                if (masterAccounts.Any(x => x.Name == item.Name && x.Password.DecryptPassword(x.Name) == item.Password.DecryptPassword(x.Name)))
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

        public List<MasterAccount> Deserializer(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new InvalidOperationException();
            }

            List<MasterAccount> masterAccounts = new();

            using (FileStream fs = new(fileName, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                string fileContent = Encoding.UTF8.GetString(bytes);
                Thread.Sleep(5000);
                masterAccounts = JsonConvert.DeserializeObject<List<MasterAccount>>(fileContent);
                Thread.Sleep(5000);
                fs.Close();
            }

            return masterAccounts;
        }
    }
}
