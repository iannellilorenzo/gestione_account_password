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
            this.PrintAccounts = new System.Windows.Forms.Button();
            this.AddAccount = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.LenBox = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.AddAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintAccounts
            // 
            this.PrintAccounts.BackColor = System.Drawing.Color.Silver;
            this.PrintAccounts.FlatAppearance.BorderSize = 0;
            this.PrintAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintAccounts.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintAccounts.Location = new System.Drawing.Point(-2, 154);
            this.PrintAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.PrintAccounts.Name = "PrintAccounts";
            this.PrintAccounts.Size = new System.Drawing.Size(172, 31);
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
            this.AddAccount.Location = new System.Drawing.Point(-2, 109);
            this.AddAccount.Margin = new System.Windows.Forms.Padding(2);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(172, 31);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterPassowrdToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // masterPassowrdToolStripMenuItem
            // 
            this.masterPassowrdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetPassword});
            this.masterPassowrdToolStripMenuItem.Name = "masterPassowrdToolStripMenuItem";
            this.masterPassowrdToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.masterPassowrdToolStripMenuItem.Text = "Master passowrd";
            // 
            // ResetPassword
            // 
            this.ResetPassword.Name = "ResetPassword";
            this.ResetPassword.Size = new System.Drawing.Size(155, 22);
            this.ResetPassword.Text = "Reset password";
            this.ResetPassword.Click += new System.EventHandler(this.ResetPassword_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(64, 15);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(55, 13);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Username";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(214, 15);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // ClarifyLabel
            // 
            this.ClarifyLabel.AutoSize = true;
            this.ClarifyLabel.Location = new System.Drawing.Point(34, 76);
            this.ClarifyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClarifyLabel.Name = "ClarifyLabel";
            this.ClarifyLabel.Size = new System.Drawing.Size(195, 26);
            this.ClarifyLabel.TabIndex = 4;
            this.ClarifyLabel.Text = "We create a secure password for you!\r\nCheck the preferences you want below:";
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Location = new System.Drawing.Point(376, 15);
            this.DescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(60, 13);
            this.DescLabel.TabIndex = 5;
            this.DescLabel.Text = "Description";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(217, 32);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(76, 20);
            this.EmailBox.TabIndex = 6;
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(378, 32);
            this.DescBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(76, 20);
            this.DescBox.TabIndex = 8;
            // 
            // UpperCaseBox
            // 
            this.UpperCaseBox.AutoSize = true;
            this.UpperCaseBox.Location = new System.Drawing.Point(36, 110);
            this.UpperCaseBox.Margin = new System.Windows.Forms.Padding(2);
            this.UpperCaseBox.Name = "UpperCaseBox";
            this.UpperCaseBox.Size = new System.Drawing.Size(112, 17);
            this.UpperCaseBox.TabIndex = 10;
            this.UpperCaseBox.Text = "Upper case letters";
            this.UpperCaseBox.UseVisualStyleBackColor = true;
            // 
            // NumbersBox
            // 
            this.NumbersBox.AutoSize = true;
            this.NumbersBox.Location = new System.Drawing.Point(36, 131);
            this.NumbersBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumbersBox.Name = "NumbersBox";
            this.NumbersBox.Size = new System.Drawing.Size(68, 17);
            this.NumbersBox.TabIndex = 11;
            this.NumbersBox.Text = "Numbers";
            this.NumbersBox.UseVisualStyleBackColor = true;
            // 
            // SpecialCharsBox
            // 
            this.SpecialCharsBox.AutoSize = true;
            this.SpecialCharsBox.Location = new System.Drawing.Point(36, 152);
            this.SpecialCharsBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpecialCharsBox.Name = "SpecialCharsBox";
            this.SpecialCharsBox.Size = new System.Drawing.Size(114, 17);
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
            this.AddNewAccount.Location = new System.Drawing.Point(134, 254);
            this.AddNewAccount.Margin = new System.Windows.Forms.Padding(2);
            this.AddNewAccount.Name = "AddNewAccount";
            this.AddNewAccount.Size = new System.Drawing.Size(172, 31);
            this.AddNewAccount.TabIndex = 13;
            this.AddNewAccount.Text = "Add new account";
            this.AddNewAccount.UseVisualStyleBackColor = false;
            this.AddNewAccount.Click += new System.EventHandler(this.AddNewAccount_Click);
            // 
            // PassLenLabel
            // 
            this.PassLenLabel.AutoSize = true;
            this.PassLenLabel.Location = new System.Drawing.Point(292, 96);
            this.PassLenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassLenLabel.Name = "PassLenLabel";
            this.PassLenLabel.Size = new System.Drawing.Size(85, 13);
            this.PassLenLabel.TabIndex = 14;
            this.PassLenLabel.Text = "Password length";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(64, 32);
            this.UserBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(76, 20);
            this.UserBox.TabIndex = 1;
            // 
            // AddAccountPanel
            // 
            this.AddAccountPanel.Controls.Add(this.listView1);
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
            this.AddAccountPanel.Location = new System.Drawing.Point(170, 25);
            this.AddAccountPanel.Name = "AddAccountPanel";
            this.AddAccountPanel.Size = new System.Drawing.Size(487, 384);
            this.AddAccountPanel.TabIndex = 0;
            // 
            // LenBox
            // 
            this.LenBox.Location = new System.Drawing.Point(294, 111);
            this.LenBox.Margin = new System.Windows.Forms.Padding(2);
            this.LenBox.Name = "LenBox";
            this.LenBox.Size = new System.Drawing.Size(77, 20);
            this.LenBox.TabIndex = 16;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(487, 384);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 408);
            this.Controls.Add(this.AddAccount);
            this.Controls.Add(this.PrintAccounts);
            this.Controls.Add(this.AddAccountPanel);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "SentinelKey - Home";
            this.Load += new System.EventHandler(this.Service_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AddAccountPanel.ResumeLayout(false);
            this.AddAccountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LenBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PrintAccounts;
        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
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
        private System.Windows.Forms.ListView listView1;
    }
}