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
using System.IO;

namespace gestione_account_password
{
    /// <summary>
    /// Lets the user change the master password
    /// </summary>
    public partial class ChangeMasterPassword : Form
    {
        private string fileName;
        private string currentUser;
        private Form previousForm;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="username"> Used as key to decrypt the old password </param>
        public ChangeMasterPassword(string username, Form homeForm)
        {
            InitializeComponent();
            CenterToScreen();
            previousForm = homeForm;

            fileName = "data.json";
            currentUser = username;
        }

        private void ChangeMasterPassword_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Lets the user change the master password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            // Check if the fields are empty
            string oldPassword = OldPassBox.Text;
            string newPassword = NewPassBox.Text;

            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please fill in both password fields.", "Error", MessageBoxButtons.OK);
                return;
            }

            // Get the master accounts from the file
            FileManager fm = FileManager.Instance;
            List<MasterAccount> mas = fm.Deserializer(fileName);
            bool result = false;

            // Iterate through the master accounts to find the current user
            foreach (MasterAccount ma in mas)
            {
                // If the user is found, check if the old password is correct
                if (ma.MasterName == currentUser && ma.Password.DecryptPassword(currentUser) == oldPassword)
                {
                    // If the old password is correct, change it
                    ma.Password = new(newPassword, currentUser);
                    ma.LastChange = DateTime.Today;
                    result = true;
                    break;
                }
            }

            // If the change worked correctly, serialize the changes
            if (result)
            {
                string updatedJson = JsonConvert.SerializeObject(mas, Formatting.Indented);
                fm.DefaultSerializer(fileName, updatedJson, FileMode.Create);
                MessageBox.Show("Password changed successfully. For security reasons the application will shut down now.", "Success", MessageBoxButtons.OK);
                Application.Exit();
            }
            
            MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK);
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            Close();
        }
    }
}
