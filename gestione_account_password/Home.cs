﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestione_account_password
{
    public partial class Home : Form
    {
        private string currentUser;
        List<Account> accounts;
        private string fileName;

        /// <summary>
        /// Constructor that initializes the form
        /// </summary>
        /// <param name="user"> Current user logged in </param>
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
            Printer.Hide();
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
            Printer.Columns.Clear();
            Printer.Visible = true;
            AddAccount.BackColor = Color.Silver;
            PrintAccounts.BackColor = Color.LightSeaGreen;

            TextBoxesVisiblityChange(false, UserBox, EmailBox, DescBox);
            LabelsVisiblityChange(false, UserLabel, EmailLabel, PassLenLabel, DescLabel, ClarifyLabel);
            CheckBoxesVisiblityChange(false, UpperCaseBox, NumbersBox, SpecialCharsBox);
            LenBox.Visible = false;
            AddNewAccount.Visible = false;

            Printer.BringToFront();

            List<string> print = PrintAccountsOnDisplay();

            Printer.Columns.Add("Username", "Username");
            Printer.Columns.Add("Password", "Password");
            Printer.Columns.Add("Email", "Email");
            Printer.Columns.Add("Description", "Description");

            foreach(var item in print)
            {
                var splittedString = item.Split(',');
                Printer.Rows.Add(splittedString[0], splittedString[1], splittedString[2], splittedString[3]);
            }
        }

        /// <summary>
        /// Gets the current master account logged in
        /// </summary>
        /// <returns> Master account logged in </returns>
        private MasterAccount GetCurrentMasterAccount()
        {
            FileManager fm = FileManager.Instance;
            List<MasterAccount> masterAccounts = fm.Deserializer(fileName);

            foreach (MasterAccount ma in masterAccounts)
            {
                if (ma.MasterName == currentUser)
                {
                    return ma;
                }
            }

            return null;
        }

        private List<string> PrintAccountsOnDisplay()
        {
            MasterAccount ma = GetCurrentMasterAccount();
            List<string> accountsDetails = new();

            foreach (Account account in ma.Accounts)
            {
                string encrPass = account.Password.Password;
                PasswordManager pass = new(encrPass);
                string decryptedPassword = pass.DecryptPassword(currentUser);
                accountsDetails.Add($"{account.Name},{decryptedPassword},{account.Email},{account.Description}");
            }

            if (accountsDetails.Count == 0)
            {
                accountsDetails.Add("No accounts found");
            }

            return accountsDetails;
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            Printer.Visible = false;
            AddAccount.BackColor = Color.LightSeaGreen;
            PrintAccounts.BackColor = Color.Silver;

            TextBoxesVisiblityChange(true, UserBox, EmailBox, DescBox);
            LabelsVisiblityChange(true, UserLabel, EmailLabel, PassLenLabel, DescLabel, ClarifyLabel);
            CheckBoxesVisiblityChange(true, UpperCaseBox, NumbersBox, SpecialCharsBox);
            LenBox.Visible = true;
            AddNewAccount.Visible = true;

            Printer.Hide();
        }

        /// <summary>
        /// Lets the user save a new account, saving username, email, password and a description of what the account is for
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewAccount_Click(object sender, EventArgs e)
        {
            if (UserBox.Text == "" || EmailBox.Text == "" || DescBox.Text == "" || LenBox.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (UserBox.Text.Contains(",") || EmailBox.Text.Contains(",") || DescBox.Text.Contains(","))
            {
                MessageBox.Show("Fields can't contain commas.", "Error", MessageBoxButtons.OK);
            }

            try
            {
                accounts.Add(new(UserBox.Text, EmailBox.Text, new(int.Parse(LenBox.Text), UpperCaseBox.Checked, NumbersBox.Checked, SpecialCharsBox.Checked, currentUser), DescBox.Text));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Password length must be between 8 and 32 characters.", "Error", MessageBoxButtons.OK);
            }

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

        private void Printer_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExportInCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterAccount ma = GetCurrentMasterAccount();
            string exportString = "DESCRIPTION,USERNAME,EMAIL,PASSWORD\n";

            foreach (Account account in ma.Accounts)
            {
                string encrPass = account.Password.Password;
                PasswordManager pass = new(encrPass);
                string decryptedPassword = pass.DecryptPassword(currentUser);
                exportString += $"{account.Description},{account.Name},{account.Email},{decryptedPassword}";
            }

            if (exportString == "DESCRIPTION,USERNAME,EMAIL,PASSWORD")
            {
                exportString = "No accounts found";
            }

            FileManager fm = FileManager.Instance;
            bool result = false;
            using (FolderBrowserDialog fbd = new())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string path = fbd.SelectedPath;
                    string fullPath = Path.Combine(path, "export.csv");
                    result = fm.ExportAccountsInCSV(fullPath, exportString);
                }
            }

            if (result)
            {
                MessageBox.Show("Accounts exported successfully.", "We're all good here!");
                return;
            }

            MessageBox.Show("Accounts couldn't be exported.", "Something went wrong!");
        }

        private void ExportInJSONFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterAccount ma = GetCurrentMasterAccount();
            FileManager fm = FileManager.Instance;
            bool result = false;

            using (FolderBrowserDialog folderDialog = new())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = folderDialog.SelectedPath;
                    string fullPath = Path.Combine(path, "export.json");
                    result = fm.ExportAccountInJson(fullPath, ma);
                }
            }

            if (result)
            {
                MessageBox.Show("Accounts exported successfully.", "We're all good here!");
                return;
            }

            MessageBox.Show("Accounts couldn't be exported.", "Something went wrong!");
        }

        private void ExportXMLDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gestione_account_password.xml");
                    string destinationPath = Path.Combine(folderDialog.SelectedPath, "documentation.xml");

                    File.Copy(sourcePath, destinationPath, true);
                    MessageBox.Show("Documentation saved successfully!", "We're all good here!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving the documentation: {ex.Message}", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Printer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string cellText = Printer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Clipboard.SetText(cellText);

                Rectangle cell = Printer.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                Point cellLocation = new(cell.X, cell.Y);

                Copy.AutoPopDelay = 2000;
                Copy.InitialDelay = 0;
                Copy.ReshowDelay = 0;
                Copy.ShowAlways = true;

                Copy.Hide(Printer);
                Copy.Show("Successfully copied to clipboard!", Printer, cellLocation, 2000);
            }
        }
    }
}
