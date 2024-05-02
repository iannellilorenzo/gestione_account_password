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
            this.NameMasterAccount = new System.Windows.Forms.TextBox();
            this.PassMasterAccount = new System.Windows.Forms.TextBox();
            this.RegToLog = new System.Windows.Forms.LinkLabel();
            this.RegBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegNow
            // 
            this.RegNow.AutoSize = true;
            this.RegNow.Font = new System.Drawing.Font("Verdana", 11F);
            this.RegNow.Location = new System.Drawing.Point(29, 37);
            this.RegNow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegNow.Name = "RegNow";
            this.RegNow.Size = new System.Drawing.Size(111, 18);
            this.RegNow.TabIndex = 0;
            this.RegNow.Text = "Register now!";
            // 
            // NameMasterAccount
            // 
            this.NameMasterAccount.Location = new System.Drawing.Point(61, 118);
            this.NameMasterAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameMasterAccount.Name = "NameMasterAccount";
            this.NameMasterAccount.Size = new System.Drawing.Size(221, 20);
            this.NameMasterAccount.TabIndex = 1;
            this.NameMasterAccount.Tag = "Insert master account name here";
            this.NameMasterAccount.Enter += new System.EventHandler(this.NameMasterAccount_Enter);
            this.NameMasterAccount.Leave += new System.EventHandler(this.NameMasterAccount_Leave);
            // 
            // PassMasterAccount
            // 
            this.PassMasterAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassMasterAccount.Location = new System.Drawing.Point(61, 148);
            this.PassMasterAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PassMasterAccount.Name = "PassMasterAccount";
            this.PassMasterAccount.Size = new System.Drawing.Size(221, 20);
            this.PassMasterAccount.TabIndex = 2;
            this.PassMasterAccount.Tag = "Insert master account password here";
            this.PassMasterAccount.Enter += new System.EventHandler(this.PassMasterAccount_Enter);
            this.PassMasterAccount.Leave += new System.EventHandler(this.PassMasterAccount_Leave);
            // 
            // RegToLog
            // 
            this.RegToLog.AutoSize = true;
            this.RegToLog.Location = new System.Drawing.Point(74, 176);
            this.RegToLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegToLog.Name = "RegToLog";
            this.RegToLog.Size = new System.Drawing.Size(204, 13);
            this.RegToLog.TabIndex = 8;
            this.RegToLog.TabStop = true;
            this.RegToLog.Text = "Already have an account yet? Login now!";
            this.RegToLog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RegToLog_MouseClick);
            // 
            // RegBut
            // 
            this.RegBut.BackColor = System.Drawing.Color.Silver;
            this.RegBut.FlatAppearance.BorderSize = 0;
            this.RegBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBut.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBut.Location = new System.Drawing.Point(302, 118);
            this.RegBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegBut.Name = "RegBut";
            this.RegBut.Size = new System.Drawing.Size(103, 48);
            this.RegBut.TabIndex = 9;
            this.RegBut.Text = "Register";
            this.RegBut.UseVisualStyleBackColor = false;
            this.RegBut.Click += new System.EventHandler(this.RegBut_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.RegBut);
            this.Controls.Add(this.RegToLog);
            this.Controls.Add(this.PassMasterAccount);
            this.Controls.Add(this.NameMasterAccount);
            this.Controls.Add(this.RegNow);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Register";
            this.Text = "SentinelKey - Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegNow;
        private System.Windows.Forms.TextBox NameMasterAccount;
        private System.Windows.Forms.TextBox PassMasterAccount;
        private System.Windows.Forms.LinkLabel RegToLog;
        private System.Windows.Forms.Button RegBut;
    }
}