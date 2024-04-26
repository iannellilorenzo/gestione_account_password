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
            SetPlaceHolder(NameMasterAccount, "Insert master account name here");
            SetPlaceHolder(PassMasterAccount, "Insert master account password here");
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        
        private void SetPlaceHolder(TextBox textBox, string placeHolder)
        {
            if (textBox.Text == "")
            {
                textBox.Text = placeHolder;
                textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void RemovePlaceHolder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void NameMasterAccount_MouseEnter(object sender, EventArgs e)
        {
            RemovePlaceHolder(NameMasterAccount, "Insert master account name here");
        }

        private void NameMasterAccount_MouseLeave(object sender, EventArgs e)
        {
            SetPlaceHolder(NameMasterAccount, "Insert master account name here");
        }

        private void PassMasterAccount_MouseEnter(object sender, EventArgs e)
        {
            RemovePlaceHolder(PassMasterAccount, "Insert master account password here");
        }

        private void PassMasterAccount_MouseLeave(object sender, EventArgs e)
        {
            SetPlaceHolder(PassMasterAccount, "Insert master account password here");
        }
    }
}
