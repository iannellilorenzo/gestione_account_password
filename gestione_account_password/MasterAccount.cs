using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_account_password
{
    /// <summary>
    /// Contains the fields of a master account object
    /// </summary>
    public class MasterAccount
    {
        private string _masterName;
        private PasswordManager _password;
        private DateTime _lastChange;
        private List<Account> _accounts;

        /// <summary>
        /// Properties for the username of the master account
        /// </summary>
        public string MasterName
        {
            get => _masterName;
            set => _masterName = value;
        }

        /// <summary>
        /// Properties for the password of the master account
        /// </summary>
        public PasswordManager Password
        {
            get => _password;
            set => _password = value;
        }

        /// <summary>
        /// Properties for the date of the last time the password was changed of the master account
        /// </summary>
        public DateTime LastChange
        {
            get => _lastChange;
            set => _lastChange = value;
        }

        /// <summary>
        /// Properties for the accounts of the master account
        /// </summary>
        public List<Account> Accounts
        {
            get => _accounts;
            set => _accounts = value;
        }

        /// <summary>
        /// Constructor with parameter for a master account object
        /// </summary>
        /// <param name="masterName"> Username of the master account </param>
        /// <param name="password"> Passowrd of the master account </param>
        /// <param name="lastChange"> Date of the last time the password was changed </param>
        public MasterAccount(string masterName, PasswordManager password, DateTime lastChange)
        {
            MasterName = masterName;
            Accounts = new();
            Password = password;
            LastChange = lastChange;
        }
    }
}
