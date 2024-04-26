namespace gestione_account_password
{
    partial class Register
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
            this.RegNow = new System.Windows.Forms.Label();
            this.NameAccount = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegNow
            // 
            this.RegNow.AutoSize = true;
            this.RegNow.Font = new System.Drawing.Font("Verdana", 11F);
            this.RegNow.Location = new System.Drawing.Point(39, 45);
            this.RegNow.Name = "RegNow";
            this.RegNow.Size = new System.Drawing.Size(142, 23);
            this.RegNow.TabIndex = 0;
            this.RegNow.Text = "Register now!";
            // 
            // NameAccount
            // 
            this.NameAccount.Location = new System.Drawing.Point(81, 145);
            this.NameAccount.Name = "NameAccount";
            this.NameAccount.Size = new System.Drawing.Size(100, 22);
            this.NameAccount.TabIndex = 1;
            // 
            // Pass
            // 
            this.Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass.Location = new System.Drawing.Point(81, 182);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(100, 22);
            this.Pass.TabIndex = 2;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.NameAccount);
            this.Controls.Add(this.RegNow);
            this.Name = "Register";
            this.Text = "Registeformr";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegNow;
        private System.Windows.Forms.TextBox NameAccount;
        private System.Windows.Forms.TextBox Pass;
    }
}