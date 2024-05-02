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
        public Home()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
            Scale(2.25f);
            CenterToScreen();
        }
    }
}
