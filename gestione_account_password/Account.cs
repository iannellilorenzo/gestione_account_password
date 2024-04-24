using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_account_password
{
    public class Account
    {
        private string _name;
        private string _email;
        private PasswordManager _password;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public PasswordManager Password
        {
            get => _password;
            set => _password = value;
        }

        public Account()
        {
            Name = "";
            Email = "";
            Password = new("");
        }

        public Account(string name, string email, PasswordManager password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
