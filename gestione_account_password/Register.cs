using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gestione_account_password
{
    public partial class Register : Form
    {
        private static readonly string namePlaceholder = "Insert master account name here";
        private static readonly string passPlaceholder = "Insert master account password here";
        private static List<MasterAccount> masterAccountsSaved;

        /// <summary>
        /// Constructor that initializes the form
        /// </summary>
        public Register()
        {
            InitializeComponent();
            SetPlaceholder(NameMasterAccount, namePlaceholder);
            SetPlaceholder(PassMasterAccount, passPlaceholder);
            masterAccountsSaved = new();
        }

        private void Register_Load(object sender, EventArgs e)
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

        private void RegToLog_MouseClick(object sender, MouseEventArgs e)
        {
            Login formLogin = new();
            formLogin.Show();
            Close();
        }

        /// <summary>
        /// Lets the user register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegBut_Click(object sender, EventArgs e)
        {
            // Creates a new master account and it adds it to the list, so that the serialization goes right
            MasterAccount master = new(NameMasterAccount.Text, new(PassMasterAccount.Text, NameMasterAccount.Text), DateTime.Now);
            masterAccountsSaved.Add(master);

            // FileManager instance to serialize a new account registered
            FileManager manager = FileManager.Instance;
            int result = manager.RegisterSerializer("data.json", masterAccountsSaved);

            // Given the result of the serialization, the user knows what to do
            if (result == -1)
            {
                DialogResult choice = MessageBox.Show("Would you like to switch to log in page?", "Account already exists", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    Login formLogin = new();
                    formLogin.Show();
                    Close();
                }
                
                NameMasterAccount.Text = "";
                PassMasterAccount.Text = "";
                PassMasterAccount.UseSystemPasswordChar = false;

                SetPlaceholder(NameMasterAccount, namePlaceholder);
                SetPlaceholder(PassMasterAccount, passPlaceholder);
                return;
            }

            // Once everything is done right, the user can access the services
            Home formService = new(NameMasterAccount.Text);
            formService.Show();
            formService.Focus();
            Close();
        }
    }
}
