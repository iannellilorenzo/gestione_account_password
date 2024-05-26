using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_account_password
{
    public class MasterAccount
    {
        private string _masterName;
        private PasswordManager _password;
        private DateTime _lastChange;
        private List<Account> _accounts;

        public string MasterName
        {
            get => _masterName;
            set => _masterName = value;
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

        public List<Account> Accounts
        {
            get => _accounts;
            set => _accounts = value;
        }

        public MasterAccount(string masterName, PasswordManager password, DateTime lastChange)
        {
            MasterName = masterName;
            Accounts = new();
            Password = password;
            LastChange = lastChange;
        }
    }
}
