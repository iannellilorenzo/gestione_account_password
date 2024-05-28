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
            AddAccountPanel.BringToFront();
        }

        private void ResetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reset password");
        }

        /// <summary>
        /// Prints every saved account details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (print == "")
            {
                PrinterList.Items.Add("No accounts found.");
            }
            else
            {
                PrinterList.Items.Add(print);
            }
        }

        /// <summary>
        /// Gets saved account details in a string ready to be displayed on screen
        /// </summary>
        /// <returns> String ready to be displayed if accounts are found, otherwise returns "No accounts found." </returns>
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
                    string toPrint = "";
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
                        JArray accountsFromJson = (JArray)obj["Accounts"];
                        if (accountsFromJson != null)
                        {
                            foreach (JObject account in accountsFromJson)
                            {
                                string encrPass = (string)account["Password"]["Password"];
                                PasswordManager pass = new(encrPass);
                                toPrint += $"Username: {account["Name"]}, Email: {account["Email"]},\nPassword: {pass.DecryptPassword(currentUser)}, Description: {account["Description"]}\n";
                            }

                            return toPrint;
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

        /// <summary>
        /// Lets the user save a new account, saving username, email, password and a description of what the account is for
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Changes visibility of the winform controls
        /// </summary>
        /// <param name="visibility"> True: Controls become visibile, false: controls become invisible </param>
        /// <param name="textBoxes"> Every textbox that needs to change it's visibility </param>
        private void TextBoxesVisiblityChange(bool visibility, params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Visible = visibility;
            }
        }

        /// <summary>
        /// Changes visibility of the winform controls
        /// </summary>
        /// <param name="visibility"> True: Controls become visibile, false: controls become invisible </param>
        /// <param name="labels"> Every label that needs to change it's visibility </param>
        private void LabelsVisiblityChange(bool visibility, params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.Visible = visibility;
            }
        }

        /// <summary>
        /// Changes visibility of the winform controls
        /// </summary>
        /// <param name="visibility"> True: Controls become visibile, false: controls become invisible </param>
        /// <param name="checkBoxes"> Every textbox that needs to change it's visibility </param>
        private void CheckBoxesVisiblityChange(bool visibility, params CheckBox[] checkBoxes)
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.Visible = visibility;
            }
        }
    }
}
