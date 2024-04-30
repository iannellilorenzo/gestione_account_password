using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

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

        public int Serializer(string fileName, List<MasterAccount> masterAccounts)
        {
            if (!File.Exists(fileName))
            {
                string toSerialize = JsonConvert.SerializeObject(masterAccounts);
                File.WriteAllText(fileName, toSerialize);
                return 0;
            }

            List<MasterAccount> masters = JsonConvert.DeserializeObject<List<MasterAccount>>(File.ReadAllText(fileName));

            foreach (var item in masters)
            {
                if (masterAccounts.Any(x => x.Name == item.Name && x.Password == item.Password))
                {
                    return -1;
                }
            }

            masters.Add(masterAccounts[0]);
            string updatedJson = JsonConvert.SerializeObject(masters);
            File.WriteAllText(fileName, updatedJson);

            return 0;
        }
    }
}
