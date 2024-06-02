using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestione_account_password
{
    /// <summary>
    /// Actual home of the application, where the user can access all the functionalities
    /// </summary>
    public partial class Home : Form
    {
        #region Global variables

        private string currentUser;
        private List<Account> accounts;
        private string fileName;
        private Account targetAccount;

        #endregion

        #region Default form code

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

        #endregion

        #region UI methods

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

        /// <summary>
        /// Changes the color of the buttons
        /// </summary>
        /// <param name="buttonWithActiveColor"> The button which indicates the active tab </param>
        /// <param name="activeColor"> The color the active tab button needs to be </param>
        /// <param name="inactiveColor"> The color the inactive tabs buttons needs to be </param>
        /// <param name="buttons"> All the inactive tabs buttons </param>
        private void ButtonColorChange(Button buttonWithActiveColor, Color activeColor, Color inactiveColor, params Button[] buttons)
        {
            buttonWithActiveColor.BackColor = activeColor;

            foreach (Button button in buttons)
            {
                button.BackColor = inactiveColor;
            }
        }

        /// <summary>
        /// Just UI stuff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveAccount_Click(object sender, EventArgs e)
        {
            Printer.Visible = false;
            ButtonColorChange(RemoveAccount, Color.LightSeaGreen, Color.Silver, AddAccount, PrintAccounts, ModifyAccount);

            LenBox.Visible = false;
            AddNewAccount.Visible = false;
            PassLenModBox.Visible = false;
            ClarifyModLabel.Visible = false;
            FindAccount.Visible = false;

            ActualRemoveAccount.Visible = true;

            TextBoxesVisiblityChange(false, UserBox, EmailBox, DescBox);
            LabelsVisiblityChange(false, UserLabel, EmailLabel, DescLabel, ClarifyLabel, PassLenLabel);
            CheckBoxesVisiblityChange(false, UpperCaseBox, NumbersBox, SpecialCharsBox);

            TextBoxesVisiblityChange(true, UserFindBox, PassFindBox);
            LabelsVisiblityChange(true, UserFindLabel, PassFindLabel);
        }


        /// <summary>
        /// Prints every saved account details + UI stuff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Print_Click(object sender, EventArgs e)
        {
            #region UI stuff

            Printer.Columns.Clear();
            Printer.Rows.Clear();
            Printer.Visible = true;

            ButtonColorChange(PrintAccounts, Color.LightSeaGreen, Color.Silver, AddAccount, ModifyAccount, RemoveAccount);

            TextBoxesVisiblityChange(false, UserBox, EmailBox, DescBox);
            LabelsVisiblityChange(false, UserLabel, EmailLabel, PassLenLabel, DescLabel, ClarifyLabel);
            CheckBoxesVisiblityChange(false, UpperCaseBox, NumbersBox, SpecialCharsBox);

            TextBoxesVisiblityChange(false, UserFindBox, PassFindBox);
            LabelsVisiblityChange(false, PassFindLabel, UserFindLabel);

            TextBoxesVisiblityChange(false, UserModBox, EmailModBox, DescModBox);
            LabelsVisiblityChange(false, UserModLabel, EmailModLabel, DescModLabel, PassModLabel, PassLenModLabel);
            CheckBoxesVisiblityChange(false, UpperCaseModBox, NumbersModBox, SpecialCharsModBox);

            LenBox.Visible = false;
            AddNewAccount.Visible = false;
            ActualModifyAccount.Visible = false;

            Printer.BringToFront();

            #endregion

            #region Backend

            // Printing the accounts
            List<string> print = PrintAccountsOnDisplay();

            if (print[0] == "No accounts found")
            {
                MessageBox.Show("No accounts found.", "Error", MessageBoxButtons.OK);
                AddAccount_Click(sender, e);
                return;
            }

            Printer.Columns.Add("Username", "Username");
            Printer.Columns.Add("Password", "Password");
            Printer.Columns.Add("Email", "Email");
            Printer.Columns.Add("Description", "Description");

            foreach (var item in print)
            {
                var splittedString = item.Split(',');
                Printer.Rows.Add(splittedString[0], splittedString[1], splittedString[2], splittedString[3]);
            }

            #endregion
        }

        /// <summary>
        /// Just UI stuff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAccount_Click(object sender, EventArgs e)
        {
            Printer.Visible = false;

            ButtonColorChange(AddAccount, Color.LightSeaGreen, Color.Silver, PrintAccounts, ModifyAccount, RemoveAccount);

            TextBoxesVisiblityChange(true, UserBox, EmailBox, DescBox);
            LabelsVisiblityChange(true, UserLabel, EmailLabel, PassLenLabel, DescLabel, ClarifyLabel);
            CheckBoxesVisiblityChange(true, UpperCaseBox, NumbersBox, SpecialCharsBox);

            TextBoxesVisiblityChange(false, UserFindBox, PassFindBox);
            LabelsVisiblityChange(false, UserFindLabel, PassFindLabel);

            TextBoxesVisiblityChange(false, UserModBox, EmailModBox, DescModBox);
            LabelsVisiblityChange(false, UserModLabel, EmailModLabel, DescModLabel, PassModLabel, PassLenModLabel, ClarifyModLabel);
            CheckBoxesVisiblityChange(false, UpperCaseModBox, NumbersModBox, SpecialCharsModBox);
            PassLenModBox.Visible = false;

            LenBox.Visible = true;
            AddNewAccount.Visible = true;
            FindAccount.Visible = false;
            ActualModifyAccount.Visible = false;
            ActualRemoveAccount.Visible = false;
        }

        /// <summary>
        /// Just UI stuff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyAccount_Click(object sender, EventArgs e)
        {
            Printer.Visible = false;

            ButtonColorChange(ModifyAccount, Color.LightSeaGreen, Color.Silver, AddAccount, PrintAccounts, RemoveAccount);

            LenBox.Visible = false;
            AddNewAccount.Visible = false;
            PassLenModBox.Visible = false;
            ClarifyModLabel.Visible = false;

            FindAccount.Visible = true;
            ActualRemoveAccount.Visible = false;

            TextBoxesVisiblityChange(false, UserBox, EmailBox, DescBox);
            LabelsVisiblityChange(false, UserLabel, EmailLabel, DescLabel, ClarifyLabel, PassLenLabel);
            CheckBoxesVisiblityChange(false, UpperCaseBox, NumbersBox, SpecialCharsBox);

            TextBoxesVisiblityChange(true, UserFindBox, PassFindBox);
            LabelsVisiblityChange(true, UserFindLabel, PassFindLabel);
        }

        #endregion

        #region Backend methods

        /// <summary>
        /// Checks if the account the user wants to modify exists, if so does some UI stuff to let the user modify it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindAccount_Click(object sender, EventArgs e)
        {
            // Checks if the user filled in all the fields
            if (UserFindBox.Text == "" || PassFindBox.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK);
                return;
            }

            // Creates a real Account object to compare with the ones in the file
            targetAccount = new(UserFindBox.Text, "", new(PassFindBox.Text, currentUser), "");

            // Gets the master account logged in
            MasterAccount ma = GetCurrentMasterAccount();
            Account accountToModify = null;

            // Iterating through the accounts of the master account
            foreach (Account acct in ma.Accounts)
            {
                // If the account is the one to modify, then it gets modified
                if (acct.Name == targetAccount.Name)
                {
                    accountToModify = acct;
                    break;
                }
            }

            // UI stuff to let the user modify the account
            if (accountToModify != null)
            {
                TextBoxesVisiblityChange(true, UserModBox, EmailModBox, DescModBox);
                LabelsVisiblityChange(true, UserModLabel, EmailModLabel, DescModLabel, PassModLabel, PassLenModLabel, ClarifyModLabel);
                CheckBoxesVisiblityChange(true, UpperCaseModBox, NumbersModBox, SpecialCharsModBox);
                PassLenModBox.Visible = true;
                ActualModifyAccount.Visible = true;
                return;
            }

            MessageBox.Show("Account not found, try again.", "Error", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Lets the user modify an account, changing username, email, description, and password by generating a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActualModifyAccount_Click(object sender, EventArgs e)
        {
            // Getting the master accounts
            FileManager fm = FileManager.Instance;
            string fileContent = fm.DefaultDeserializer(fileName);
            List<MasterAccount> masterAccounts = JsonConvert.DeserializeObject<List<MasterAccount>>(fileContent);

            Account accountToModify = null;

            // Iterating through the master accounts
            foreach (var item in masterAccounts)
            {
                if (item.MasterName == currentUser)
                {
                    foreach (Account acct in item.Accounts)
                    {
                        // If the account is the one to modify, then it gets modified
                        if (acct.Name == targetAccount.Name)
                        {
                            accountToModify = acct;
                            break;
                        }
                    }
                }
            }

            // Checks to see what the user wants to modify
            if (UserModBox.Text != "")
            {
                accountToModify.Name = UserModBox.Text;
            }

            if (EmailModBox.Text != "")
            {
                accountToModify.Email = EmailModBox.Text;
            }

            if (DescModBox.Text != "")
            {
                accountToModify.Description = DescModBox.Text;
            }

            if (PassLenModBox.Value != 7)
            {
                accountToModify.Password = new(int.Parse(PassLenModBox.Text), UpperCaseBox.Checked, NumbersBox.Checked, SpecialCharsBox.Checked, currentUser);
            }

            // Serializing the new account details
            string updatedJson = JsonConvert.SerializeObject(masterAccounts, Formatting.Indented);
            fm.DefaultSerializer(fileName, updatedJson, FileMode.Create);
        }

        /// <summary>
        /// Gets the current master account logged in
        /// </summary>
        /// <returns> Master account logged in </returns>
        private MasterAccount GetCurrentMasterAccount()
        {
            // FileManager instance to deserialize
            FileManager fm = FileManager.Instance;
            List<MasterAccount> masterAccounts = fm.Deserializer(fileName);

            foreach (MasterAccount ma in masterAccounts)
            {
                // If the master account is the one logged in, then it returns it
                if (ma.MasterName == currentUser)
                {
                    return ma;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets a list of all the accounts of the current master account logged in
        /// </summary>
        /// <returns> All the accoutns of the current master account logged in using a list. Every account is a string ready to be printed in a CSV format </returns>
        private List<string> PrintAccountsOnDisplay()
        {
            MasterAccount ma = GetCurrentMasterAccount();
            List<string> accountsDetails = new();

            // Iterating through the accounts of the master account
            foreach (Account account in ma.Accounts)
            {
                string encrPass = account.Password.Password;
                PasswordManager pass = new(encrPass);
                string decryptedPassword = pass.DecryptPassword(currentUser);
                accountsDetails.Add($"{account.Name},{decryptedPassword},{account.Email},{account.Description}");
            }

            // If the master account is null, then it returns an empty list
            if (accountsDetails.Count == 0)
            {
                accountsDetails.Add("No accounts found");
            }

            return accountsDetails;
        }

        /// <summary>
        /// Lets the user save a new account, saving username, email, password and a description of what the account is for
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewAccount_Click(object sender, EventArgs e)
        {
            // Checks if the user filled in all the fields and if the fields are correct
            if (UserBox.Text == "" || EmailBox.Text == "" || DescBox.Text == "" || LenBox.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (UserBox.Text.Contains(",") || EmailBox.Text.Contains(",") || DescBox.Text.Contains(","))
            {
                MessageBox.Show("Fields can't contain commas.", "Error", MessageBoxButtons.OK);
            }

            // Adds the new account to the list
            try
            {
                accounts.Add(new(UserBox.Text, EmailBox.Text, new(int.Parse(LenBox.Text), UpperCaseBox.Checked, NumbersBox.Checked, SpecialCharsBox.Checked, currentUser), DescBox.Text));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Password length must be between 8 and 32 characters.", "Error", MessageBoxButtons.OK);
            }

            // Gets the master accounts
            FileManager fm = FileManager.Instance;
            string fileContent = fm.DefaultDeserializer(fileName);
            List<MasterAccount> masterAccounts = JsonConvert.DeserializeObject<List<MasterAccount>>(fileContent);

            // Iterating through the master accounts
            foreach (var ma in masterAccounts)
            {
                // If the master account is the one logged in, then it gets updated
                if (ma.MasterName == currentUser)
                {
                    ma.Accounts.Clear();
                    ma.Accounts.AddRange(accounts);
                }
            }

            // Serializing the new account details
            string updatedJson = JsonConvert.SerializeObject(masterAccounts, Formatting.Indented);
            fm.DefaultSerializer(fileName, updatedJson, FileMode.Create);
        }

        /// <summary>
        /// Lets the user export the accounts details in a CSV format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportInCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gets the master account logged in
            MasterAccount ma = GetCurrentMasterAccount();
            string exportString = "DESCRIPTION,USERNAME,EMAIL,PASSWORD\n";

            // Iterating through the accounts of the master account
            foreach (Account account in ma.Accounts)
            {
                // Decrypts the password
                string encrPass = account.Password.Password;
                PasswordManager pass = new(encrPass);
                string decryptedPassword = pass.DecryptPassword(currentUser);

                // Adds the account details to the export string
                exportString += $"{account.Description},{account.Name},{account.Email},{decryptedPassword}";
            }

            // If the export string is the default one, then it returns an error message
            if (exportString == "DESCRIPTION,USERNAME,EMAIL,PASSWORD")
            {
                exportString = "No accounts found";
            }

            FileManager fm = FileManager.Instance;
            bool result = false;

                        // Lets the user choose where to save the file
            using (FolderBrowserDialog fbd = new())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    // Gets the path and the full path
                    string path = fbd.SelectedPath;
                    string fullPath = Path.Combine(path, "export.csv");

                    // Exports the accounts
                    fm.ExportAccountsInCSV(fullPath, exportString);
                    result = true;
                }
            }

            // If the export went right, then it shows a success message
            if (result)
            {
                MessageBox.Show("Accounts exported successfully.", "We're all good here!");
                return;
            }

            // If the export went wrong, then it shows an error message
            MessageBox.Show("Accounts couldn't be exported.", "Something went wrong!");
        }

        /// <summary>
        /// Lets the user export the accounts details in a JSON format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportInJSONFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gets the master account logged in
            MasterAccount ma = GetCurrentMasterAccount();
            FileManager fm = FileManager.Instance;
            bool result = false;

            // Lets the user choose where to save the file
            using (FolderBrowserDialog folderDialog = new())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Gets the path and the full path
                    string path = folderDialog.SelectedPath;
                    string fullPath = Path.Combine(path, "export.json");

                    // Exports the accounts
                    fm.ExportAccountInJson(fullPath, ma);
                    result = true;
                }
            }

            // If the export went right, then it shows a success message
            if (result)
            {
                MessageBox.Show("Accounts exported successfully.", "We're all good here!");
                return;
            }

            // If the export went wrong, then it shows an error message
            MessageBox.Show("Accounts couldn't be exported.", "Something went wrong!");
        }

        /// <summary>
        /// Lets the user export the documentation in a XML format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportXMLDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lets the user choose where to save the file
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Gets the path and the full path
                    string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gestione_account_password.xml");
                    string destinationPath = Path.Combine(folderDialog.SelectedPath, "documentation.xml");

                    // Exports the documentation
                    File.Copy(sourcePath, destinationPath, true);

                    // Shows a success message
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

        /// <summary>
        /// Lets the user copy the content of a cell in the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Printer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Checks if the user double clicked on a cell
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Copies the content of the cell in the clipboard
                string cellText = Printer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Clipboard.SetText(cellText);

                // Shows a message to the user using a toolip to let them know the content has been copied
                Rectangle cell = Printer.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                Point cellLocation = new(cell.X, cell.Y);

                Copy.AutoPopDelay = 1000;
                Copy.InitialDelay = 0;
                Copy.ReshowDelay = 0;
                Copy.ShowAlways = true;

                Copy.Hide(Printer);
                Copy.Show("Successfully copied to clipboard!", Printer, cellLocation, 2000);
            }
        }

        /// <summary>
        /// Lets the user remove an account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActualRemoveAccount_Click(object sender, EventArgs e)
        {
            // Checks if the user filled in all the fields
            if (UserFindBox.Text == "" || PassFindBox.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK);
                return;
            }

            // Creating a real Account object to compare with the ones in the file
            targetAccount = new(UserFindBox.Text, "", new(PassFindBox.Text, currentUser), "");

            // Getting the master accounts
            FileManager fm = FileManager.Instance;
            string fileContent = fm.DefaultDeserializer(fileName);
            List<MasterAccount> masterAccounts = JsonConvert.DeserializeObject<List<MasterAccount>>(fileContent);

            bool result = false;

            // Iterating through the master accounts
            foreach (MasterAccount ma in masterAccounts)
            {
                if (ma.MasterName == currentUser)
                {
                    foreach (Account acct in ma.Accounts)
                    {
                        // If the account is the one to remove, then it gets removed
                        if (acct.Name == targetAccount.Name)
                        {
                            ma.Accounts.Remove(acct);
                            result = true;
                            break;
                        }
                    }
                }
            }

            if (result)
            {
                // Serializing the new account details
                string updatedJson = JsonConvert.SerializeObject(masterAccounts, Formatting.Indented);
                fm.DefaultSerializer(fileName, updatedJson, FileMode.Create);
                MessageBox.Show("Account removed successfully.", "We're all good here!", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Account couldn't be removed.", "Something went wrong!", MessageBoxButtons.OK);
        }

        #endregion
    }
}
