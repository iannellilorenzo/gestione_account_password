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
    public partial class Access : Form
    {
        public Access()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register formRegister = new();
            formRegister.Show();
            Hide();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            Login formLogin = new();
            formLogin.Show();
            Hide();
        }
    }
}
