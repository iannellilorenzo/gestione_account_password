using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
                string toSerialize = JsonSerializer.Serialize(masterAccounts);
                File.WriteAllText(fileName, toSerialize);
                return 0;
            }

            List<MasterAccount> masters = JsonSerializer.Deserialize();

            foreach (var item in masterAccounts)
            {
                
            }

            return -1;
        }

        public void Serializer(string fileName, List<Account> accounts, MasterAccount masterAccount)
        {

        }
    }
}
