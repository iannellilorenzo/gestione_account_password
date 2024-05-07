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
    public partial class Home : Form
    {
        Center centerUC;
        public Home()
        {
            InitializeComponent();
            centerUC = new();
            AddUserControl(centerUC);
        }

        private void Service_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
            CenterToScreen();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            CenterPanel.Controls.Clear();
            CenterPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ResetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reset password");
        }
    }
}
