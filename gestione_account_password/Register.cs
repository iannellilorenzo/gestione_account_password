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
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        
        private void NameAccount_Enter(object sender, EventArgs e)
        {
            if (NameAccount.Text == "Insert your name here")
            {
                NameAccount.Text = "";
                NameAccount.ForeColor = SystemColors.WindowText;
            }
        }

        private void NameAccount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameAccount.Text))
            {
                NameAccount.Text = "Insert your name here";
                NameAccount.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
