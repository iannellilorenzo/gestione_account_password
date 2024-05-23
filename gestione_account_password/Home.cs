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

            TextBoxesVisiblityChange(false, UserBox, EmailBox, LenBox, DescBox);
            LabelsVisiblityChange(false, UserLabel, EmailLabel, PassLenLabel, DescLabel, ClarifyLabel);
            CheckBoxesVisiblityChange(false, UpperCaseBox, NumbersBox, SpecialCharsBox);

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

            TextBoxesVisiblityChange(true, UserBox, EmailBox, LenBox, DescBox);
            LabelsVisiblityChange(true, UserLabel, EmailLabel, PassLenLabel, DescLabel, ClarifyLabel);
            CheckBoxesVisiblityChange(true, UpperCaseBox, NumbersBox, SpecialCharsBox);
            
            List<Account> accounts = new();
            accounts.Add(new(UserBox.Text, EmailBox.Text, new(int.Parse(LenBox.Text), UpperCaseBox.Checked, NumbersBox.Checked, SpecialCharsBox.Checked), DescBox.Text));

        }

        private void TextBoxesVisiblityChange(bool visibility, params TextBox[] textBoxes)
        {
            foreach(TextBox textBox in textBoxes)
            {
                textBox.Visible = visibility;
            }
        }

        private void LabelsVisiblityChange(bool visibility, params Label[] labels)
        {
            foreach(Label label in labels)
            {
                label.Visible = visibility;
            }
        }

        private void CheckBoxesVisiblityChange(bool visibility, params CheckBox[] checkBoxes)
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.Visible = visibility;
            }
        }
    }
}
