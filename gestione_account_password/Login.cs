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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetPlaceholder(NameMasterAccount, "Insert master account name here");
            SetPlaceholder(PassMasterAccount, "Insert master account password here");
        }

        private void Login_Load(object sender, EventArgs e)
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
            RemovePlaceholder(NameMasterAccount, "Insert master account name here");
        }

        private void NameMasterAccount_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(NameMasterAccount, "Insert master account name here");
        }

        private void PassMasterAccount_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(PassMasterAccount, "Insert master account password here");
        }

        private void PassMasterAccount_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(PassMasterAccount, "Insert master account password here");
        }

        private void LogToReg_MouseClick(object sender, MouseEventArgs e)
        {
            Register formRegister = new();
            formRegister.Show();
            Hide();
        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            Service formService = new();
            formService.Show();
            formService.Focus();
            Close();
        }
    }
}
