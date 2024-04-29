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
            // LoginNow
            // 
            this.LoginNow.AutoSize = true;
            this.LoginNow.Font = new System.Drawing.Font("Verdana", 11F);
            this.LoginNow.Location = new System.Drawing.Point(43, 34);
            this.LoginNow.Name = "LoginNow";
            this.LoginNow.Size = new System.Drawing.Size(117, 23);
            this.LoginNow.TabIndex = 5;
            this.LoginNow.Text = "Login now!";
            // 
            // LogToReg
            // 
            this.LogToReg.AutoSize = true;
            this.LogToReg.Location = new System.Drawing.Point(108, 193);
            this.LogToReg.Name = "LogToReg";
            this.LogToReg.Size = new System.Drawing.Size(251, 16);
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
            this.LoginBut.Location = new System.Drawing.Point(432, 114);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(137, 59);
            this.LoginBut.TabIndex = 7;
            this.LoginBut.Text = "Login";
            this.LoginBut.UseVisualStyleBackColor = false;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginBut);
            this.Controls.Add(this.LogToReg);
            this.Controls.Add(this.LoginNow);
            this.Controls.Add(this.PassMasterAccount);
            this.Controls.Add(this.NameMasterAccount);
            this.Name = "Login";
            this.Text = "Login";
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