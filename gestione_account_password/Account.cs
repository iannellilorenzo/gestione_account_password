using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_account_password
{
    /// <summary>
    /// Contains every detail an account needs
    /// </summary>
    public class Account
    {
        private string _name;
        private string _email;
        private PasswordManager _password;
        private string _description;

        /// <summary>
        /// Properties for the username of the account
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// Properties for the email of the account
        /// </summary>
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        /// <summary>
        /// Properties for the password of the account
        /// </summary>
        public PasswordManager Password
        {
            get => _password;
            set => _password = value;
        }

        /// <summary>
        /// Properties for the description of the account
        /// </summary>
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        /// <summary>
        /// Constructor without parameters to instance an account
        /// </summary>
        public Account()
        {
            Name = "";
            Email = "";
            Password = new();
            Description = "";
        }

        /// <summary>
        /// Constructor with parameters to instance an account
        /// </summary>
        /// <param name="name"> Username of the account </param>
        /// <param name="email"> Email of the account </param>
        /// <param name="password"> Password of the account </param>
        /// <param name="description"> Descriptions of the account </param>
        public Account(string name, string email, PasswordManager password, string description)
        {
            Name = name;
            Email = email;
            Password = password;
            Description = description;
        }
    }
}
