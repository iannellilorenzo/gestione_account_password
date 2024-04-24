using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_account_password
{
    public class MasterAccount
    {
        private string _name;
        private PasswordManager _password;
        private DateTime _lastChange;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public PasswordManager Password
        {
            get => _password;
            set => _password = value;
        }

        public DateTime LastChange
        {
            get => _lastChange;
            set => _lastChange = value;
        }

        public MasterAccount()
        {
            Name = "";
            Password = new("");
            LastChange = DateTime.Now;
        }

        public MasterAccount(string name, PasswordManager password, DateTime lastChange)
        {
            Name = name;
            Password = password;
            LastChange = lastChange;
        }
    }
}
