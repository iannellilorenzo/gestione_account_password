using Newtonsoft.Json;
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
        public string user;
        public Home(string currentUser)
        {
            InitializeComponent();
            centerUC = new();
            AddUserControl(centerUC);
            user = currentUser;
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

        private void Print_Click(object sender, EventArgs e)
        {
            PrinterList.Items.Clear();
            PrinterList.Visible = true;
            AddAccount.BackColor = Color.Silver;
            PrintAccounts.BackColor = Color.LightSeaGreen;

            // actually print
        }

        private void GetAccounts()
        {
            FileManager fm = FileManager.Instance;
            List<MasterAccount> masterAccounts = fm.Deserializer("data.json");
            List<Account> accounts = new();
            foreach (MasterAccount ma in masterAccounts)
            {
                if (ma.Name == user)
                {
                    string toPrint = "Username: ";
                    JsonToken token = JsonConvert.DeserializeObject<JsonToken>("Accounts");
                    PrinterList.Items.Add(token.ToString());
                    // da capire come entrare dentro ogni oggetto del json per stampare
                    
                    
                }
            }
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            PrinterList.Visible = false;
            AddAccount.BackColor = Color.LightSeaGreen;
            PrintAccounts.BackColor = Color.Silver;
            
            List<Account> accounts = new List<Account>();
            accounts.Add(new(NameBox.Text, EmailBox.Text, new()));

        }
    }
}
