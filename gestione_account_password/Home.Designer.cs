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
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.PrinterList = new System.Windows.Forms.ListView();
            this.PrintAccounts = new System.Windows.Forms.Button();
            this.AddAccount = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterPassowrdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.LowerCaseBox = new System.Windows.Forms.CheckBox();
            this.UpperCaseBox = new System.Windows.Forms.CheckBox();
            this.NumbersBox = new System.Windows.Forms.CheckBox();
            this.SpecialCharsBox = new System.Windows.Forms.CheckBox();
            this.AddNewAccount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MinLenBox = new System.Windows.Forms.TextBox();
            this.MaxLenBox = new System.Windows.Forms.TextBox();
            this.MinLen = new System.Windows.Forms.Label();
            this.MaxLen = new System.Windows.Forms.Label();
            this.Clarify = new System.Windows.Forms.Label();
            this.CenterPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.Clarify);
            this.CenterPanel.Controls.Add(this.MaxLen);
            this.CenterPanel.Controls.Add(this.MinLen);
            this.CenterPanel.Controls.Add(this.MaxLenBox);
            this.CenterPanel.Controls.Add(this.MinLenBox);
            this.CenterPanel.Controls.Add(this.label5);
            this.CenterPanel.Controls.Add(this.AddNewAccount);
            this.CenterPanel.Controls.Add(this.SpecialCharsBox);
            this.CenterPanel.Controls.Add(this.NumbersBox);
            this.CenterPanel.Controls.Add(this.UpperCaseBox);
            this.CenterPanel.Controls.Add(this.LowerCaseBox);
            this.CenterPanel.Controls.Add(this.DescBox);
            this.CenterPanel.Controls.Add(this.EmailBox);
            this.CenterPanel.Controls.Add(this.label4);
            this.CenterPanel.Controls.Add(this.label3);
            this.CenterPanel.Controls.Add(this.label2);
            this.CenterPanel.Controls.Add(this.label1);
            this.CenterPanel.Controls.Add(this.UserBox);
            this.CenterPanel.Controls.Add(this.PrinterList);
            this.CenterPanel.Location = new System.Drawing.Point(227, 31);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(649, 473);
            this.CenterPanel.TabIndex = 0;
            // 
            // PrinterList
            // 
            this.PrinterList.HideSelection = false;
            this.PrinterList.Location = new System.Drawing.Point(0, 0);
            this.PrinterList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrinterList.Name = "PrinterList";
            this.PrinterList.Size = new System.Drawing.Size(649, 473);
            this.PrinterList.TabIndex = 0;
            this.PrinterList.UseCompatibleStateImageBehavior = false;
            this.PrinterList.View = System.Windows.Forms.View.List;
            this.PrinterList.Visible = false;
            // 
            // PrintAccounts
            // 
            this.PrintAccounts.BackColor = System.Drawing.Color.Silver;
            this.PrintAccounts.FlatAppearance.BorderSize = 0;
            this.PrintAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintAccounts.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintAccounts.Location = new System.Drawing.Point(-3, 190);
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
            this.menuStrip1.Size = new System.Drawing.Size(876, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 26);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterPassowrdToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // masterPassowrdToolStripMenuItem
            // 
            this.masterPassowrdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetPassword});
            this.masterPassowrdToolStripMenuItem.Name = "masterPassowrdToolStripMenuItem";
            this.masterPassowrdToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.masterPassowrdToolStripMenuItem.Text = "Master passowrd";
            // 
            // ResetPassword
            // 
            this.ResetPassword.Name = "ResetPassword";
            this.ResetPassword.Size = new System.Drawing.Size(195, 26);
            this.ResetPassword.Text = "Reset password";
            this.ResetPassword.Click += new System.EventHandler(this.ResetPassword_Click);
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(86, 40);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(100, 22);
            this.UserBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "We create a secure password for you!\r\nCheck the preferences you want below:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(289, 40);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 22);
            this.EmailBox.TabIndex = 6;
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(504, 40);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(100, 22);
            this.DescBox.TabIndex = 8;
            // 
            // LowerCaseBox
            // 
            this.LowerCaseBox.AutoSize = true;
            this.LowerCaseBox.Location = new System.Drawing.Point(45, 137);
            this.LowerCaseBox.Name = "LowerCaseBox";
            this.LowerCaseBox.Size = new System.Drawing.Size(137, 20);
            this.LowerCaseBox.TabIndex = 9;
            this.LowerCaseBox.Text = "Lower case letters";
            this.LowerCaseBox.UseVisualStyleBackColor = true;
            // 
            // UpperCaseBox
            // 
            this.UpperCaseBox.AutoSize = true;
            this.UpperCaseBox.Location = new System.Drawing.Point(45, 163);
            this.UpperCaseBox.Name = "UpperCaseBox";
            this.UpperCaseBox.Size = new System.Drawing.Size(139, 20);
            this.UpperCaseBox.TabIndex = 10;
            this.UpperCaseBox.Text = "Upper case letters";
            this.UpperCaseBox.UseVisualStyleBackColor = true;
            // 
            // NumbersBox
            // 
            this.NumbersBox.AutoSize = true;
            this.NumbersBox.Location = new System.Drawing.Point(45, 189);
            this.NumbersBox.Name = "NumbersBox";
            this.NumbersBox.Size = new System.Drawing.Size(84, 20);
            this.NumbersBox.TabIndex = 11;
            this.NumbersBox.Text = "Numbers";
            this.NumbersBox.UseVisualStyleBackColor = true;
            // 
            // SpecialCharsBox
            // 
            this.SpecialCharsBox.AutoSize = true;
            this.SpecialCharsBox.Location = new System.Drawing.Point(45, 215);
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
            this.AddNewAccount.Location = new System.Drawing.Point(178, 312);
            this.AddNewAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddNewAccount.Name = "AddNewAccount";
            this.AddNewAccount.Size = new System.Drawing.Size(229, 38);
            this.AddNewAccount.TabIndex = 13;
            this.AddNewAccount.Text = "Add new account";
            this.AddNewAccount.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password length";
            // 
            // MinLenBox
            // 
            this.MinLenBox.Location = new System.Drawing.Point(289, 169);
            this.MinLenBox.Name = "MinLenBox";
            this.MinLenBox.Size = new System.Drawing.Size(100, 22);
            this.MinLenBox.TabIndex = 15;
            // 
            // MaxLenBox
            // 
            this.MaxLenBox.Location = new System.Drawing.Point(493, 169);
            this.MaxLenBox.Name = "MaxLenBox";
            this.MaxLenBox.Size = new System.Drawing.Size(100, 22);
            this.MaxLenBox.TabIndex = 16;
            // 
            // MinLen
            // 
            this.MinLen.AutoSize = true;
            this.MinLen.Location = new System.Drawing.Point(290, 150);
            this.MinLen.Name = "MinLen";
            this.MinLen.Size = new System.Drawing.Size(99, 16);
            this.MinLen.TabIndex = 17;
            this.MinLen.Text = "Minimum length";
            // 
            // MaxLen
            // 
            this.MaxLen.AutoSize = true;
            this.MaxLen.Location = new System.Drawing.Point(490, 150);
            this.MaxLen.Name = "MaxLen";
            this.MaxLen.Size = new System.Drawing.Size(103, 16);
            this.MaxLen.TabIndex = 18;
            this.MaxLen.Text = "Maximum length";
            // 
            // Clarify
            // 
            this.Clarify.AutoSize = true;
            this.Clarify.Location = new System.Drawing.Point(408, 172);
            this.Clarify.Name = "Clarify";
            this.Clarify.Size = new System.Drawing.Size(67, 16);
            this.Clarify.TabIndex = 19;
            this.Clarify.Text = "< Length <";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 502);
            this.Controls.Add(this.AddAccount);
            this.Controls.Add(this.PrintAccounts);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "SentinelKey - Home";
            this.Load += new System.EventHandler(this.Service_Load);
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Button PrintAccounts;
        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterPassowrdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetPassword;
        private System.Windows.Forms.ListView PrinterList;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.CheckBox NumbersBox;
        private System.Windows.Forms.CheckBox UpperCaseBox;
        private System.Windows.Forms.CheckBox LowerCaseBox;
        private System.Windows.Forms.Button AddNewAccount;
        private System.Windows.Forms.CheckBox SpecialCharsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Clarify;
        private System.Windows.Forms.Label MaxLen;
        private System.Windows.Forms.Label MinLen;
        private System.Windows.Forms.TextBox MaxLenBox;
        private System.Windows.Forms.TextBox MinLenBox;
    }
}