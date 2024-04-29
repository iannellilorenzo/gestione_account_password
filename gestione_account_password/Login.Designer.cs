namespace gestione_account_password
{
    partial class Login
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
            this.PassMasterAccount = new System.Windows.Forms.TextBox();
            this.NameMasterAccount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PassMasterAccount
            // 
            this.PassMasterAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassMasterAccount.Location = new System.Drawing.Point(90, 151);
            this.PassMasterAccount.Name = "PassMasterAccount";
            this.PassMasterAccount.Size = new System.Drawing.Size(293, 22);
            this.PassMasterAccount.TabIndex = 4;
            this.PassMasterAccount.MouseEnter += new System.EventHandler(this.PassMasterAccount_MouseEnter);
            this.PassMasterAccount.MouseLeave += new System.EventHandler(this.PassMasterAccount_MouseLeave);
            // 
            // NameMasterAccount
            // 
            this.NameMasterAccount.Location = new System.Drawing.Point(90, 114);
            this.NameMasterAccount.Name = "NameMasterAccount";
            this.NameMasterAccount.Size = new System.Drawing.Size(293, 22);
            this.NameMasterAccount.TabIndex = 3;
            this.NameMasterAccount.MouseEnter += new System.EventHandler(this.NameMasterAccount_MouseEnter);
            this.NameMasterAccount.MouseLeave += new System.EventHandler(this.NameMasterAccount_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PassMasterAccount);
            this.Controls.Add(this.NameMasterAccount);
            this.Name = "Login";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassMasterAccount;
        private System.Windows.Forms.TextBox NameMasterAccount;
    }
}