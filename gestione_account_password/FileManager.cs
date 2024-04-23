using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_account_password
{
    public sealed class FileManager
    {
        private static FileManager instance = null;
        private static readonly object padlock = new object();

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
                        if (instance == null)
                        {
                            instance = new FileManager();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
