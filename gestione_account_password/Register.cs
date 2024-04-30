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

namespace gestione_account_password
{
    public partial class Register : Form
    {
        protected static readonly string namePlaceholder = "Insert master account name here";
        protected static readonly string passPlaceholder = "Insert master account password here";
        protected static List<MasterAccount> masterAccountsSaved;

        public Register()
        {
            InitializeComponent();
            SetPlaceholder(NameMasterAccount, namePlaceholder);
            SetPlaceholder(PassMasterAccount, passPlaceholder);
            masterAccountsSaved = [];
        }

        private void Register_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == "")
            {
                textBox.Text = placeholder;
                textBox.ForeColor = SystemColors.GrayText;
            }
        }

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

        private void RegBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PassMasterAccount.Text);
            PasswordManager password = new(PassMasterAccount.Text);
            MasterAccount master = new(NameMasterAccount.Text, password, DateTime.Now);
            MessageBox.Show(master.Password.Password);
            masterAccountsSaved.Add(master);

            FileManager manager = FileManager.Instance;
            int result = manager.RegisterSerializer("data.json", masterAccountsSaved);
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

            Service formService = new();
            formService.Show();
            formService.Focus();
            Close();
        }
    }
}
