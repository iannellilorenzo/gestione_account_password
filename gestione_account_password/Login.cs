using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestione_account_password
{
    /// <summary>
    /// Form used to let the user log in
    /// </summary>
    public partial class Login : Form
    {
        private static readonly string namePlaceholder = "Insert master account name here";
        private static readonly string passPlaceholder = "Insert master account password here";

        /// <summary>
        /// Constructor that initializes the form
        /// </summary>
        public Login()
        {
            InitializeComponent();
            SetPlaceholder(NameMasterAccount, namePlaceholder);
            SetPlaceholder(PassMasterAccount, passPlaceholder);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
            CenterToScreen();
        }

        /// <summary>
        /// Sets a string as placeholder in a textbox
        /// </summary>
        /// <param name="textBox"> Textbox placeholdered </param>
        /// <param name="placeholder"> Placeholder string </param>
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == "")
            {
                textBox.Text = placeholder;
                textBox.ForeColor = SystemColors.GrayText;
            }
        }

        /// <summary>
        /// Removes the placeholder string inside the textbox
        /// </summary>
        /// <param name="textBox"> Textbox to remove placeholder string from </param>
        /// <param name="placeholder"> Placeholder string to remove </param>
        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
        }
        
        private void NameMasterAccount_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(NameMasterAccount, namePlaceholder);
        }

        private void NameMasterAccount_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(NameMasterAccount, namePlaceholder);
        }

        private void PassMasterAccount_Enter(object sender, EventArgs e)
        {
            PassMasterAccount.UseSystemPasswordChar = true;
            RemovePlaceholder(PassMasterAccount, passPlaceholder);
        }

        private void PassMasterAccount_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(PassMasterAccount, passPlaceholder);
            if (PassMasterAccount.Text == passPlaceholder)
            {
                PassMasterAccount.UseSystemPasswordChar = false;
            }
        }

        private void LogToReg_MouseClick(object sender, MouseEventArgs e)
        {
            Register formRegister = new();
            formRegister.Show();
            Close();
        }

        /// <summary>
        /// Lets the user log into the account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBut_Click(object sender, EventArgs e)
        {
            // FileManager instance to deserialize
            FileManager manager = FileManager.Instance;

            // List of master accounts, will be populated from the json file
            List<MasterAccount> masters = new();

            try
            {
                masters = manager.Deserializer("data.json");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Account does not exist yet, please register first. The program will shut down.", "Error", MessageBoxButtons.OK);
                Application.Exit();
                return;
            }

            string name = NameMasterAccount.Text;
            string password = PassMasterAccount.Text;

            // Iterating through the master accounts, if the username and password are correct, then the user logs in
            foreach (MasterAccount master in masters)
            {
                if (masters.Any(x => x.MasterName == master.MasterName && x.Password.DecryptPassword(x.MasterName) == master.Password.DecryptPassword(x.MasterName)))
                {
                    Home formService = new(name);
                    formService.Show();
                    formService.Focus();
                    Close();
                    return;
                }
            }

            MessageBox.Show("Account not found, check your credentials or register first.", "Error", MessageBoxButtons.OK);
            NameMasterAccount.Text = "";
            PassMasterAccount.Text = "";
            PassMasterAccount.UseSystemPasswordChar = false;

            SetPlaceholder(NameMasterAccount, namePlaceholder);
            SetPlaceholder(PassMasterAccount, passPlaceholder);
        }
    }
}
