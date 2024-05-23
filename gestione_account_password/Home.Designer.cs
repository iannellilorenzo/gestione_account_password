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
            this.Print = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterPassowrdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.PrinterList = new System.Windows.Forms.ListView();
            this.CenterPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.PrinterList);
            this.CenterPanel.Location = new System.Drawing.Point(170, 25);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(487, 384);
            this.CenterPanel.TabIndex = 0;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.Silver;
            this.Print.FlatAppearance.BorderSize = 0;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(-2, 154);
            this.Print.Margin = new System.Windows.Forms.Padding(2);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(172, 31);
            this.Print.TabIndex = 10;
            this.Print.Text = "Print accounts";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-2, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add new account";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
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
            // PrinterList
            // 
            this.PrinterList.HideSelection = false;
            this.PrinterList.Location = new System.Drawing.Point(0, 0);
            this.PrinterList.Name = "PrinterList";
            this.PrinterList.Size = new System.Drawing.Size(487, 384);
            this.PrinterList.TabIndex = 0;
            this.PrinterList.UseCompatibleStateImageBehavior = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "SentinelKey - Home";
            this.Load += new System.EventHandler(this.Service_Load);
            this.CenterPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterPassowrdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetPassword;
        private System.Windows.Forms.ListView PrinterList;
    }
}