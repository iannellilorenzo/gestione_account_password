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
            this.LoginNow = new System.Windows.Forms.Label();
            this.LogToReg = new System.Windows.Forms.LinkLabel();
            this.LoginBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PassMasterAccount
            // 
            this.PassMasterAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassMasterAccount.Location = new System.Drawing.Point(68, 123);
            this.PassMasterAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PassMasterAccount.Name = "PassMasterAccount";
            this.PassMasterAccount.Size = new System.Drawing.Size(221, 20);
            this.PassMasterAccount.TabIndex = 4;
            this.PassMasterAccount.Enter += new System.EventHandler(this.PassMasterAccount_Enter);
            this.PassMasterAccount.Leave += new System.EventHandler(this.PassMasterAccount_Leave);
            // 
            // NameMasterAccount
            // 
            this.NameMasterAccount.Location = new System.Drawing.Point(68, 93);
            this.NameMasterAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameMasterAccount.Name = "NameMasterAccount";
            this.NameMasterAccount.Size = new System.Drawing.Size(221, 20);
            this.NameMasterAccount.TabIndex = 3;
            this.NameMasterAccount.Enter += new System.EventHandler(this.NameMasterAccount_Enter);
            this.NameMasterAccount.Leave += new System.EventHandler(this.NameMasterAccount_Leave);
            // 
            // LoginNow
            // 
            this.LoginNow.AutoSize = true;
            this.LoginNow.Font = new System.Drawing.Font("Verdana", 11F);
            this.LoginNow.Location = new System.Drawing.Point(32, 28);
            this.LoginNow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginNow.Name = "LoginNow";
            this.LoginNow.Size = new System.Drawing.Size(90, 18);
            this.LoginNow.TabIndex = 5;
            this.LoginNow.Text = "Login now!";
            // 
            // LogToReg
            // 
            this.LogToReg.AutoSize = true;
            this.LogToReg.Location = new System.Drawing.Point(80, 150);
            this.LogToReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogToReg.Name = "LogToReg";
            this.LogToReg.Size = new System.Drawing.Size(207, 13);
            this.LogToReg.TabIndex = 6;
            this.LogToReg.TabStop = true;
            this.LogToReg.Text = "Don\'t have an account yet? Register now!";
            this.LogToReg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogToReg_MouseClick);
            // 
            // LoginBut
            // 
            this.LoginBut.BackColor = System.Drawing.Color.Silver;
            this.LoginBut.FlatAppearance.BorderSize = 0;
            this.LoginBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBut.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBut.Location = new System.Drawing.Point(324, 93);
            this.LoginBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(103, 48);
            this.LoginBut.TabIndex = 7;
            this.LoginBut.Text = "Login";
            this.LoginBut.UseVisualStyleBackColor = false;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.LoginBut);
            this.Controls.Add(this.LogToReg);
            this.Controls.Add(this.LoginNow);
            this.Controls.Add(this.PassMasterAccount);
            this.Controls.Add(this.NameMasterAccount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "SentinelKey - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassMasterAccount;
        private System.Windows.Forms.TextBox NameMasterAccount;
        private System.Windows.Forms.Label LoginNow;
        private System.Windows.Forms.LinkLabel LogToReg;
        private System.Windows.Forms.Button LoginBut;
    }
}