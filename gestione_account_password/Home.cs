using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestione_account_password
{
    public partial class Home : Form
    {
        public string currentUser;
        List<Account> accounts;
        public string fileName;

        public Home(string user)
        {
            InitializeComponent();
            currentUser = user;
            accounts = new();
            fileName = "data.json";
        }

        private void Service_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
            CenterToScreen();
            PrinterList.Hide();
            PrintAccountsPanel.Hide();
            AddAccountPanel.BringToFront();
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

            TextBoxesVisiblityChange(false, UserBox, EmailBox, DescBox);
            LabelsVisiblityChange(false, UserLabel, EmailLabel, PassLenLabel, DescLabel, ClarifyLabel);
            CheckBoxesVisiblityChange(false, UpperCaseBox, NumbersBox, SpecialCharsBox);
            LenBox.Visible = false;
            AddNewAccount.Visible = false;

            PrinterList.BringToFront();

            string print = GetAccounts();
            MessageBox.Show(print);

            // PrinterList.Items.Add(GetAccounts());
        }

        private string GetAccounts()
        {
            FileManager fm = FileManager.Instance;
            List<MasterAccount> masterAccounts = fm.Deserializer(fileName);
            List<Account> accounts = new();
            string fileContent;
            foreach (MasterAccount ma in masterAccounts)
            {
                if (ma.MasterName == currentUser)
                {
                    string toPrint = "Username: ";
                    using (FileStream fs = new(fileName, FileMode.Open, FileAccess.Read))
                    {
                        byte[] bytes = new byte[fs.Length];
                        int bytesRead = fs.Read(bytes, 0, bytes.Length);
                        fileContent = Encoding.UTF8.GetString(bytes);
                        fs.Close();
                    }

                    List<JObject> jsonObjects = JsonConvert.DeserializeObject<List<JObject>>(fileContent);

                    foreach (JObject obj in jsonObjects)
                    {
                        string currentName = (string)obj["Name"];
                        if (currentName == currentUser)
                        {
                            JArray accountsFromJson = (JArray)obj["Accounts"];
                            if (accountsFromJson != null)
                            {
                                foreach (JObject account in accountsFromJson)
                                {
                                    string encrPass = (string)account["Password"]["Password"];
                                    PasswordManager pass = new(encrPass);
                                    toPrint += $"{account["Name"]}, Email: {account["Email"]}, Password: {pass.DecryptPassword(currentUser)}\n";
                                }

                                return toPrint;
                            }
                        }
                    }
                }
            }

            return "No accounts found";
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            PrinterList.Visible = false;
            AddAccount.BackColor = Color.LightSeaGreen;
            PrintAccounts.BackColor = Color.Silver;

            TextBoxesVisiblityChange(true, UserBox, EmailBox, DescBox);
            LabelsVisiblityChange(true, UserLabel, EmailLabel, PassLenLabel, DescLabel, ClarifyLabel);
            CheckBoxesVisiblityChange(true, UpperCaseBox, NumbersBox, SpecialCharsBox);
            LenBox.Visible = true;
            AddNewAccount.Visible = true;

            PrinterList.Hide();
        }

        private void AddNewAccount_Click(object sender, EventArgs e)
        {
            accounts.Add(new(UserBox.Text, EmailBox.Text, new(int.Parse(LenBox.Text), UpperCaseBox.Checked, NumbersBox.Checked, SpecialCharsBox.Checked, currentUser), DescBox.Text));

            string fileContent;
            using (FileStream fs = new(fileName, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fs.Length];
                int bytesRead = fs.Read(bytes, 0, bytes.Length);
                fileContent = Encoding.UTF8.GetString(bytes);
                fs.Close();
            }

            List<JObject> jsonObjects = JsonConvert.DeserializeObject<List<JObject>>(fileContent);

            foreach (JObject obj in jsonObjects)
            {
                string currentName = (string)obj["MasterName"];
                if (currentName == currentUser)
                {
                    obj["Accounts"] = JArray.FromObject(accounts);
                }
            }

            string updatedJson = JsonConvert.SerializeObject(jsonObjects, Formatting.Indented);
            using (FileStream fs = new(fileName, FileMode.Open, FileAccess.Write))
            {
                byte[] data = new UTF8Encoding(true).GetBytes(updatedJson);
                fs.Write(data, 0, data.Length);
                fs.Close();
            }
        }

        private void TextBoxesVisiblityChange(bool visibility, params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Visible = visibility;
            }
        }

        private void LabelsVisiblityChange(bool visibility, params Label[] labels)
        {
            foreach (Label label in labels)
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
