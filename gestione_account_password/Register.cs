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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            SetPlaceholder(NameMasterAccount, "Insert your master account name here");
            SetPlaceholder(PassMasterAccount, "Insert your master account password here");
        }

        private void Register_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = SystemColors.GrayText;
            }

            textBox.GotFocus += (sender, e) => RemovePlaceholder(textBox, placeholder);
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }

            textBox.GotFocus -= (sender, e) => RemovePlaceholder(textBox, placeholder);
        }

        private void NameMasterAccount_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox != null)
            {
                RemovePlaceholder(textBox, "Insert your master account name here");
            }
        }

        private void NameMasterAccount_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox != null)
            {
                SetPlaceholder(textBox, "Insert your master account name here");
            }
        }

        private void PassMasterAccount_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox != null)
            {
                RemovePlaceholder(textBox, "Insert your master account password here");
            }
        }

        private void PassMasterAccount_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox != null)
            {
                SetPlaceholder(textBox, "Insert your master account password here");
            }
        }

        private void RegToLog_MouseClick(object sender, MouseEventArgs e)
        {
            Login formLogin = new();
            formLogin.Show();
            Hide();
        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            Service formService = new();
            formService.Show();
            formService.Focus();
            Close();
        }

        private void NameMasterAccount_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox != null)
            {
                RemovePlaceholder(textBox, "Insert your master account name here");
                textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void PassMasterAccount_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox != null)
            {
                RemovePlaceholder(textBox, "Insert your master account password here");
                textBox.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
