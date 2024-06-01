namespace gestione_account_password
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PrintAccounts = new System.Windows.Forms.Button();
            this.AddAccount = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportInCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportInJSONFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportXMLDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterPassowrdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.UserLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ClarifyLabel = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.UpperCaseBox = new System.Windows.Forms.CheckBox();
            this.NumbersBox = new System.Windows.Forms.CheckBox();
            this.SpecialCharsBox = new System.Windows.Forms.CheckBox();
            this.AddNewAccount = new System.Windows.Forms.Button();
            this.PassLenLabel = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.AddAccountPanel = new System.Windows.Forms.Panel();
            this.ActualRemoveAccount = new System.Windows.Forms.Button();
            this.ActualModifyAccount = new System.Windows.Forms.Button();
            this.PassLenModBox = new System.Windows.Forms.NumericUpDown();
            this.PassLenModLabel = new System.Windows.Forms.Label();
            this.SpecialCharsModBox = new System.Windows.Forms.CheckBox();
            this.NumbersModBox = new System.Windows.Forms.CheckBox();
            this.UpperCaseModBox = new System.Windows.Forms.CheckBox();
            this.PassModLabel = new System.Windows.Forms.Label();
            this.DescModBox = new System.Windows.Forms.TextBox();
            this.DescModLabel = new System.Windows.Forms.Label();
            this.EmailModBox = new System.Windows.Forms.TextBox();
            this.EmailModLabel = new System.Windows.Forms.Label();
            this.UserModBox = new System.Windows.Forms.TextBox();
            this.UserModLabel = new System.Windows.Forms.Label();
            this.ClarifyModLabel = new System.Windows.Forms.Label();
            this.PassFindBox = new System.Windows.Forms.TextBox();
            this.PassFindLabel = new System.Windows.Forms.Label();
            this.UserFindBox = new System.Windows.Forms.TextBox();
            this.UserFindLabel = new System.Windows.Forms.Label();
            this.FindAccount = new System.Windows.Forms.Button();
            this.LenBox = new System.Windows.Forms.NumericUpDown();
            this.Printer = new System.Windows.Forms.DataGridView();
            this.Copy = new System.Windows.Forms.ToolTip(this.components);
            this.ModifyAccount = new System.Windows.Forms.Button();
            this.RemoveAccount = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.AddAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassLenModBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintAccounts
            // 
            this.PrintAccounts.BackColor = System.Drawing.Color.Silver;
            this.PrintAccounts.FlatAppearance.BorderSize = 0;
            this.PrintAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintAccounts.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintAccounts.Location = new System.Drawing.Point(-3, 292);
            this.PrintAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintAccounts.Name = "PrintAccounts";
            this.PrintAccounts.Size = new System.Drawing.Size(229, 38);
            this.PrintAccounts.TabIndex = 10;
            this.PrintAccounts.Text = "Print accounts";
            this.PrintAccounts.UseVisualStyleBackColor = false;
            this.PrintAccounts.Click += new System.EventHandler(this.Print_Click);
            // 
            // AddAccount
            // 
            this.AddAccount.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddAccount.FlatAppearance.BorderSize = 0;
            this.AddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccount.Location = new System.Drawing.Point(-3, 134);
            this.AddAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(229, 38);
            this.AddAccount.TabIndex = 11;
            this.AddAccount.Text = "Add new account";
            this.AddAccount.UseVisualStyleBackColor = false;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(935, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Export,
            this.developerOptionsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // Export
            // 
            this.Export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportInCSVToolStripMenuItem,
            this.ExportInJSONFormatToolStripMenuItem});
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(245, 26);
            this.Export.Text = "Export accounts details";
            // 
            // ExportInCSVToolStripMenuItem
            // 
            this.ExportInCSVToolStripMenuItem.Name = "ExportInCSVToolStripMenuItem";
            this.ExportInCSVToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.ExportInCSVToolStripMenuItem.Text = "Export in CSV format";
            this.ExportInCSVToolStripMenuItem.Click += new System.EventHandler(this.ExportInCSVToolStripMenuItem_Click);
            // 
            // ExportInJSONFormatToolStripMenuItem
            // 
            this.ExportInJSONFormatToolStripMenuItem.Name = "ExportInJSONFormatToolStripMenuItem";
            this.ExportInJSONFormatToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.ExportInJSONFormatToolStripMenuItem.Text = "Export in JSON format";
            this.ExportInJSONFormatToolStripMenuItem.Click += new System.EventHandler(this.ExportInJSONFormatToolStripMenuItem_Click);
            // 
            // developerOptionsToolStripMenuItem
            // 
            this.developerOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportXMLDocumentationToolStripMenuItem});
            this.developerOptionsToolStripMenuItem.Name = "developerOptionsToolStripMenuItem";
            this.developerOptionsToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.developerOptionsToolStripMenuItem.Text = "Developer options";
            // 
            // ExportXMLDocumentationToolStripMenuItem
            // 
            this.ExportXMLDocumentationToolStripMenuItem.Name = "ExportXMLDocumentationToolStripMenuItem";
            this.ExportXMLDocumentationToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.ExportXMLDocumentationToolStripMenuItem.Text = "Export XML documentation";
            this.ExportXMLDocumentationToolStripMenuItem.Click += new System.EventHandler(this.ExportXMLDocumentationToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterPassowrdToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // masterPassowrdToolStripMenuItem
            // 
            this.masterPassowrdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetPassword});
            this.masterPassowrdToolStripMenuItem.Name = "masterPassowrdToolStripMenuItem";
            this.masterPassowrdToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.masterPassowrdToolStripMenuItem.Text = "Master passowrd";
            // 
            // ResetPassword
            // 
            this.ResetPassword.Name = "ResetPassword";
            this.ResetPassword.Size = new System.Drawing.Size(224, 26);
            this.ResetPassword.Text = "Reset password";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(85, 18);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(70, 16);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Username";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(292, 18);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 16);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // ClarifyLabel
            // 
            this.ClarifyLabel.AutoSize = true;
            this.ClarifyLabel.Location = new System.Drawing.Point(45, 94);
            this.ClarifyLabel.Name = "ClarifyLabel";
            this.ClarifyLabel.Size = new System.Drawing.Size(238, 32);
            this.ClarifyLabel.TabIndex = 4;
            this.ClarifyLabel.Text = "We create a secure password for you!\r\nCheck the preferences you want below:";
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Location = new System.Drawing.Point(501, 18);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(75, 16);
            this.DescLabel.TabIndex = 5;
            this.DescLabel.Text = "Description";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(296, 39);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 22);
            this.EmailBox.TabIndex = 6;
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(504, 39);
            this.DescBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(100, 22);
            this.DescBox.TabIndex = 8;
            // 
            // UpperCaseBox
            // 
            this.UpperCaseBox.AutoSize = true;
            this.UpperCaseBox.Location = new System.Drawing.Point(48, 135);
            this.UpperCaseBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpperCaseBox.Name = "UpperCaseBox";
            this.UpperCaseBox.Size = new System.Drawing.Size(139, 20);
            this.UpperCaseBox.TabIndex = 10;
            this.UpperCaseBox.Text = "Upper case letters";
            this.UpperCaseBox.UseVisualStyleBackColor = true;
            // 
            // NumbersBox
            // 
            this.NumbersBox.AutoSize = true;
            this.NumbersBox.Location = new System.Drawing.Point(48, 161);
            this.NumbersBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumbersBox.Name = "NumbersBox";
            this.NumbersBox.Size = new System.Drawing.Size(84, 20);
            this.NumbersBox.TabIndex = 11;
            this.NumbersBox.Text = "Numbers";
            this.NumbersBox.UseVisualStyleBackColor = true;
            // 
            // SpecialCharsBox
            // 
            this.SpecialCharsBox.AutoSize = true;
            this.SpecialCharsBox.Location = new System.Drawing.Point(48, 187);
            this.SpecialCharsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpecialCharsBox.Name = "SpecialCharsBox";
            this.SpecialCharsBox.Size = new System.Drawing.Size(141, 20);
            this.SpecialCharsBox.TabIndex = 12;
            this.SpecialCharsBox.Text = "Special characters";
            this.SpecialCharsBox.UseVisualStyleBackColor = true;
            // 
            // AddNewAccount
            // 
            this.AddNewAccount.BackColor = System.Drawing.Color.Silver;
            this.AddNewAccount.FlatAppearance.BorderSize = 0;
            this.AddNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewAccount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewAccount.Location = new System.Drawing.Point(179, 313);
            this.AddNewAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddNewAccount.Name = "AddNewAccount";
            this.AddNewAccount.Size = new System.Drawing.Size(229, 38);
            this.AddNewAccount.TabIndex = 13;
            this.AddNewAccount.Text = "Add new account";
            this.AddNewAccount.UseVisualStyleBackColor = false;
            this.AddNewAccount.Click += new System.EventHandler(this.AddNewAccount_Click);
            // 
            // PassLenLabel
            // 
            this.PassLenLabel.AutoSize = true;
            this.PassLenLabel.Location = new System.Drawing.Point(389, 118);
            this.PassLenLabel.Name = "PassLenLabel";
            this.PassLenLabel.Size = new System.Drawing.Size(106, 16);
            this.PassLenLabel.TabIndex = 14;
            this.PassLenLabel.Text = "Password length";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(85, 39);
            this.UserBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(100, 22);
            this.UserBox.TabIndex = 1;
            // 
            // AddAccountPanel
            // 
            this.AddAccountPanel.Controls.Add(this.ActualRemoveAccount);
            this.AddAccountPanel.Controls.Add(this.ActualModifyAccount);
            this.AddAccountPanel.Controls.Add(this.PassLenModBox);
            this.AddAccountPanel.Controls.Add(this.PassLenModLabel);
            this.AddAccountPanel.Controls.Add(this.SpecialCharsModBox);
            this.AddAccountPanel.Controls.Add(this.NumbersModBox);
            this.AddAccountPanel.Controls.Add(this.UpperCaseModBox);
            this.AddAccountPanel.Controls.Add(this.PassModLabel);
            this.AddAccountPanel.Controls.Add(this.DescModBox);
            this.AddAccountPanel.Controls.Add(this.DescModLabel);
            this.AddAccountPanel.Controls.Add(this.EmailModBox);
            this.AddAccountPanel.Controls.Add(this.EmailModLabel);
            this.AddAccountPanel.Controls.Add(this.UserModBox);
            this.AddAccountPanel.Controls.Add(this.UserModLabel);
            this.AddAccountPanel.Controls.Add(this.ClarifyModLabel);
            this.AddAccountPanel.Controls.Add(this.PassFindBox);
            this.AddAccountPanel.Controls.Add(this.PassFindLabel);
            this.AddAccountPanel.Controls.Add(this.UserFindBox);
            this.AddAccountPanel.Controls.Add(this.UserFindLabel);
            this.AddAccountPanel.Controls.Add(this.FindAccount);
            this.AddAccountPanel.Controls.Add(this.LenBox);
            this.AddAccountPanel.Controls.Add(this.UserBox);
            this.AddAccountPanel.Controls.Add(this.PassLenLabel);
            this.AddAccountPanel.Controls.Add(this.AddNewAccount);
            this.AddAccountPanel.Controls.Add(this.SpecialCharsBox);
            this.AddAccountPanel.Controls.Add(this.NumbersBox);
            this.AddAccountPanel.Controls.Add(this.UpperCaseBox);
            this.AddAccountPanel.Controls.Add(this.DescBox);
            this.AddAccountPanel.Controls.Add(this.EmailBox);
            this.AddAccountPanel.Controls.Add(this.DescLabel);
            this.AddAccountPanel.Controls.Add(this.ClarifyLabel);
            this.AddAccountPanel.Controls.Add(this.EmailLabel);
            this.AddAccountPanel.Controls.Add(this.UserLabel);
            this.AddAccountPanel.Controls.Add(this.Printer);
            this.AddAccountPanel.Location = new System.Drawing.Point(227, 31);
            this.AddAccountPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AddAccountPanel.Name = "AddAccountPanel";
            this.AddAccountPanel.Size = new System.Drawing.Size(708, 473);
            this.AddAccountPanel.TabIndex = 0;
            // 
            // ActualRemoveAccount
            // 
            this.ActualRemoveAccount.BackColor = System.Drawing.Color.Silver;
            this.ActualRemoveAccount.FlatAppearance.BorderSize = 0;
            this.ActualRemoveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualRemoveAccount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualRemoveAccount.Location = new System.Drawing.Point(225, 100);
            this.ActualRemoveAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActualRemoveAccount.Name = "ActualRemoveAccount";
            this.ActualRemoveAccount.Size = new System.Drawing.Size(229, 38);
            this.ActualRemoveAccount.TabIndex = 37;
            this.ActualRemoveAccount.Text = "Remove account";
            this.ActualRemoveAccount.UseVisualStyleBackColor = false;
            this.ActualRemoveAccount.Visible = false;
            this.ActualRemoveAccount.Click += new System.EventHandler(this.ActualRemoveAccount_Click);
            // 
            // ActualModifyAccount
            // 
            this.ActualModifyAccount.BackColor = System.Drawing.Color.Silver;
            this.ActualModifyAccount.FlatAppearance.BorderSize = 0;
            this.ActualModifyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualModifyAccount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualModifyAccount.Location = new System.Drawing.Point(229, 406);
            this.ActualModifyAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActualModifyAccount.Name = "ActualModifyAccount";
            this.ActualModifyAccount.Size = new System.Drawing.Size(229, 38);
            this.ActualModifyAccount.TabIndex = 36;
            this.ActualModifyAccount.Text = "Modify account";
            this.ActualModifyAccount.UseVisualStyleBackColor = false;
            this.ActualModifyAccount.Visible = false;
            this.ActualModifyAccount.Click += new System.EventHandler(this.ActualModifyAccount_Click);
            // 
            // PassLenModBox
            // 
            this.PassLenModBox.Location = new System.Drawing.Point(345, 350);
            this.PassLenModBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassLenModBox.Name = "PassLenModBox";
            this.PassLenModBox.Size = new System.Drawing.Size(103, 22);
            this.PassLenModBox.TabIndex = 35;
            this.PassLenModBox.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.PassLenModBox.Visible = false;
            // 
            // PassLenModLabel
            // 
            this.PassLenModLabel.AutoSize = true;
            this.PassLenModLabel.Location = new System.Drawing.Point(341, 331);
            this.PassLenModLabel.Name = "PassLenModLabel";
            this.PassLenModLabel.Size = new System.Drawing.Size(106, 16);
            this.PassLenModLabel.TabIndex = 34;
            this.PassLenModLabel.Text = "Password length";
            this.PassLenModLabel.Visible = false;
            // 
            // SpecialCharsModBox
            // 
            this.SpecialCharsModBox.AutoSize = true;
            this.SpecialCharsModBox.Location = new System.Drawing.Point(85, 375);
            this.SpecialCharsModBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpecialCharsModBox.Name = "SpecialCharsModBox";
            this.SpecialCharsModBox.Size = new System.Drawing.Size(141, 20);
            this.SpecialCharsModBox.TabIndex = 33;
            this.SpecialCharsModBox.Text = "Special characters";
            this.SpecialCharsModBox.UseVisualStyleBackColor = true;
            this.SpecialCharsModBox.Visible = false;
            // 
            // NumbersModBox
            // 
            this.NumbersModBox.AutoSize = true;
            this.NumbersModBox.Location = new System.Drawing.Point(85, 350);
            this.NumbersModBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumbersModBox.Name = "NumbersModBox";
            this.NumbersModBox.Size = new System.Drawing.Size(84, 20);
            this.NumbersModBox.TabIndex = 32;
            this.NumbersModBox.Text = "Numbers";
            this.NumbersModBox.UseVisualStyleBackColor = true;
            this.NumbersModBox.Visible = false;
            // 
            // UpperCaseModBox
            // 
            this.UpperCaseModBox.AutoSize = true;
            this.UpperCaseModBox.Location = new System.Drawing.Point(85, 324);
            this.UpperCaseModBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpperCaseModBox.Name = "UpperCaseModBox";
            this.UpperCaseModBox.Size = new System.Drawing.Size(139, 20);
            this.UpperCaseModBox.TabIndex = 31;
            this.UpperCaseModBox.Text = "Upper case letters";
            this.UpperCaseModBox.UseVisualStyleBackColor = true;
            this.UpperCaseModBox.Visible = false;
            // 
            // PassModLabel
            // 
            this.PassModLabel.AutoSize = true;
            this.PassModLabel.Location = new System.Drawing.Point(83, 302);
            this.PassModLabel.Name = "PassModLabel";
            this.PassModLabel.Size = new System.Drawing.Size(163, 16);
            this.PassModLabel.TabIndex = 30;
            this.PassModLabel.Text = "Generate a new password";
            this.PassModLabel.Visible = false;
            // 
            // DescModBox
            // 
            this.DescModBox.Location = new System.Drawing.Point(504, 251);
            this.DescModBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescModBox.Name = "DescModBox";
            this.DescModBox.Size = new System.Drawing.Size(100, 22);
            this.DescModBox.TabIndex = 29;
            this.DescModBox.Visible = false;
            // 
            // DescModLabel
            // 
            this.DescModLabel.AutoSize = true;
            this.DescModLabel.Location = new System.Drawing.Point(501, 230);
            this.DescModLabel.Name = "DescModLabel";
            this.DescModLabel.Size = new System.Drawing.Size(103, 16);
            this.DescModLabel.TabIndex = 28;
            this.DescModLabel.Text = "New description";
            this.DescModLabel.Visible = false;
            // 
            // EmailModBox
            // 
            this.EmailModBox.Location = new System.Drawing.Point(296, 251);
            this.EmailModBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailModBox.Name = "EmailModBox";
            this.EmailModBox.Size = new System.Drawing.Size(100, 22);
            this.EmailModBox.TabIndex = 27;
            this.EmailModBox.Visible = false;
            // 
            // EmailModLabel
            // 
            this.EmailModLabel.AutoSize = true;
            this.EmailModLabel.Location = new System.Drawing.Point(292, 230);
            this.EmailModLabel.Name = "EmailModLabel";
            this.EmailModLabel.Size = new System.Drawing.Size(70, 16);
            this.EmailModLabel.TabIndex = 26;
            this.EmailModLabel.Text = "New email";
            this.EmailModLabel.Visible = false;
            // 
            // UserModBox
            // 
            this.UserModBox.Location = new System.Drawing.Point(85, 251);
            this.UserModBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserModBox.Name = "UserModBox";
            this.UserModBox.Size = new System.Drawing.Size(100, 22);
            this.UserModBox.TabIndex = 24;
            this.UserModBox.Visible = false;
            // 
            // UserModLabel
            // 
            this.UserModLabel.AutoSize = true;
            this.UserModLabel.Location = new System.Drawing.Point(85, 230);
            this.UserModLabel.Name = "UserModLabel";
            this.UserModLabel.Size = new System.Drawing.Size(97, 16);
            this.UserModLabel.TabIndex = 25;
            this.UserModLabel.Text = "New username";
            this.UserModLabel.Visible = false;
            // 
            // ClarifyModLabel
            // 
            this.ClarifyModLabel.AutoSize = true;
            this.ClarifyModLabel.Location = new System.Drawing.Point(193, 154);
            this.ClarifyModLabel.Name = "ClarifyModLabel";
            this.ClarifyModLabel.Size = new System.Drawing.Size(279, 64);
            this.ClarifyModLabel.TabIndex = 23;
            this.ClarifyModLabel.Text = "If those are left blank,\r\nthere won\'t be any credential change.\r\nA new password w" +
    "ill be generated if the length\r\nis changed to an accepted value";
            this.ClarifyModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClarifyModLabel.Visible = false;
            // 
            // PassFindBox
            // 
            this.PassFindBox.Location = new System.Drawing.Point(400, 39);
            this.PassFindBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassFindBox.Name = "PassFindBox";
            this.PassFindBox.Size = new System.Drawing.Size(100, 22);
            this.PassFindBox.TabIndex = 22;
            this.PassFindBox.Visible = false;
            // 
            // PassFindLabel
            // 
            this.PassFindLabel.AutoSize = true;
            this.PassFindLabel.Location = new System.Drawing.Point(396, 18);
            this.PassFindLabel.Name = "PassFindLabel";
            this.PassFindLabel.Size = new System.Drawing.Size(67, 16);
            this.PassFindLabel.TabIndex = 21;
            this.PassFindLabel.Text = "Password";
            this.PassFindLabel.Visible = false;
            // 
            // UserFindBox
            // 
            this.UserFindBox.Location = new System.Drawing.Point(191, 39);
            this.UserFindBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserFindBox.Name = "UserFindBox";
            this.UserFindBox.Size = new System.Drawing.Size(100, 22);
            this.UserFindBox.TabIndex = 19;
            this.UserFindBox.Visible = false;
            // 
            // UserFindLabel
            // 
            this.UserFindLabel.AutoSize = true;
            this.UserFindLabel.Location = new System.Drawing.Point(191, 18);
            this.UserFindLabel.Name = "UserFindLabel";
            this.UserFindLabel.Size = new System.Drawing.Size(70, 16);
            this.UserFindLabel.TabIndex = 20;
            this.UserFindLabel.Text = "Username";
            this.UserFindLabel.Visible = false;
            // 
            // FindAccount
            // 
            this.FindAccount.BackColor = System.Drawing.Color.Silver;
            this.FindAccount.FlatAppearance.BorderSize = 0;
            this.FindAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindAccount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindAccount.Location = new System.Drawing.Point(225, 100);
            this.FindAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindAccount.Name = "FindAccount";
            this.FindAccount.Size = new System.Drawing.Size(229, 38);
            this.FindAccount.TabIndex = 18;
            this.FindAccount.Text = "Find account";
            this.FindAccount.UseVisualStyleBackColor = false;
            this.FindAccount.Visible = false;
            this.FindAccount.Click += new System.EventHandler(this.FindAccount_Click);
            // 
            // LenBox
            // 
            this.LenBox.Location = new System.Drawing.Point(392, 137);
            this.LenBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LenBox.Name = "LenBox";
            this.LenBox.Size = new System.Drawing.Size(103, 22);
            this.LenBox.TabIndex = 16;
            this.LenBox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Printer
            // 
            this.Printer.AllowUserToAddRows = false;
            this.Printer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Printer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Printer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Printer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Printer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Printer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Printer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Printer.DefaultCellStyle = dataGridViewCellStyle2;
            this.Printer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Printer.Location = new System.Drawing.Point(0, 0);
            this.Printer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Printer.MultiSelect = false;
            this.Printer.Name = "Printer";
            this.Printer.ReadOnly = true;
            this.Printer.RowHeadersWidth = 51;
            this.Printer.RowTemplate.Height = 24;
            this.Printer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Printer.ShowCellToolTips = false;
            this.Printer.Size = new System.Drawing.Size(708, 473);
            this.Printer.TabIndex = 17;
            this.Printer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Printer_CellDoubleClick);
            // 
            // ModifyAccount
            // 
            this.ModifyAccount.BackColor = System.Drawing.Color.Silver;
            this.ModifyAccount.FlatAppearance.BorderSize = 0;
            this.ModifyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyAccount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyAccount.Location = new System.Drawing.Point(-3, 187);
            this.ModifyAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyAccount.Name = "ModifyAccount";
            this.ModifyAccount.Size = new System.Drawing.Size(229, 38);
            this.ModifyAccount.TabIndex = 13;
            this.ModifyAccount.Text = "Modify account";
            this.ModifyAccount.UseVisualStyleBackColor = false;
            this.ModifyAccount.Click += new System.EventHandler(this.ModifyAccount_Click);
            // 
            // RemoveAccount
            // 
            this.RemoveAccount.BackColor = System.Drawing.Color.Silver;
            this.RemoveAccount.FlatAppearance.BorderSize = 0;
            this.RemoveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAccount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAccount.Location = new System.Drawing.Point(-3, 240);
            this.RemoveAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveAccount.Name = "RemoveAccount";
            this.RemoveAccount.Size = new System.Drawing.Size(229, 38);
            this.RemoveAccount.TabIndex = 14;
            this.RemoveAccount.Text = "Remove account";
            this.RemoveAccount.UseVisualStyleBackColor = false;
            this.RemoveAccount.Click += new System.EventHandler(this.RemoveAccount_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 502);
            this.Controls.Add(this.RemoveAccount);
            this.Controls.Add(this.ModifyAccount);
            this.Controls.Add(this.AddAccount);
            this.Controls.Add(this.PrintAccounts);
            this.Controls.Add(this.AddAccountPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "SentinelKey - Home";
            this.Load += new System.EventHandler(this.Service_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AddAccountPanel.ResumeLayout(false);
            this.AddAccountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassLenModBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PrintAccounts;
        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterPassowrdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetPassword;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label ClarifyLabel;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.CheckBox UpperCaseBox;
        private System.Windows.Forms.CheckBox NumbersBox;
        private System.Windows.Forms.CheckBox SpecialCharsBox;
        private System.Windows.Forms.Button AddNewAccount;
        private System.Windows.Forms.Label PassLenLabel;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Panel AddAccountPanel;
        private System.Windows.Forms.NumericUpDown LenBox;
        private System.Windows.Forms.ToolStripMenuItem developerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportXMLDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportInCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportInJSONFormatToolStripMenuItem;
        private System.Windows.Forms.DataGridView Printer;
        private System.Windows.Forms.ToolTip Copy;
        private System.Windows.Forms.Button ModifyAccount;
        private System.Windows.Forms.Button FindAccount;
        private System.Windows.Forms.TextBox PassFindBox;
        private System.Windows.Forms.Label PassFindLabel;
        private System.Windows.Forms.TextBox UserFindBox;
        private System.Windows.Forms.Label UserFindLabel;
        private System.Windows.Forms.Label ClarifyModLabel;
        private System.Windows.Forms.TextBox DescModBox;
        private System.Windows.Forms.Label DescModLabel;
        private System.Windows.Forms.TextBox EmailModBox;
        private System.Windows.Forms.Label EmailModLabel;
        private System.Windows.Forms.TextBox UserModBox;
        private System.Windows.Forms.Label UserModLabel;
        private System.Windows.Forms.NumericUpDown PassLenModBox;
        private System.Windows.Forms.Label PassLenModLabel;
        private System.Windows.Forms.CheckBox SpecialCharsModBox;
        private System.Windows.Forms.CheckBox NumbersModBox;
        private System.Windows.Forms.CheckBox UpperCaseModBox;
        private System.Windows.Forms.Label PassModLabel;
        private System.Windows.Forms.Button ActualModifyAccount;
        private System.Windows.Forms.Button RemoveAccount;
        private System.Windows.Forms.Button ActualRemoveAccount;
    }
}