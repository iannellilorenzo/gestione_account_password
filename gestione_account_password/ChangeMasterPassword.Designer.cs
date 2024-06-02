namespace gestione_account_password
{
    partial class ChangeMasterPassword
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
            this.OldPassLabel = new System.Windows.Forms.Label();
            this.OldPassBox = new System.Windows.Forms.TextBox();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.NewPassLabel = new System.Windows.Forms.Label();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldPassLabel
            // 
            this.OldPassLabel.AutoSize = true;
            this.OldPassLabel.Location = new System.Drawing.Point(167, 46);
            this.OldPassLabel.Name = "OldPassLabel";
            this.OldPassLabel.Size = new System.Drawing.Size(134, 16);
            this.OldPassLabel.TabIndex = 0;
            this.OldPassLabel.Text = "Old master password";
            // 
            // OldPassBox
            // 
            this.OldPassBox.Location = new System.Drawing.Point(180, 65);
            this.OldPassBox.Name = "OldPassBox";
            this.OldPassBox.Size = new System.Drawing.Size(100, 22);
            this.OldPassBox.TabIndex = 1;
            // 
            // NewPassBox
            // 
            this.NewPassBox.Location = new System.Drawing.Point(180, 136);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(100, 22);
            this.NewPassBox.TabIndex = 3;
            // 
            // NewPassLabel
            // 
            this.NewPassLabel.AutoSize = true;
            this.NewPassLabel.Location = new System.Drawing.Point(161, 117);
            this.NewPassLabel.Name = "NewPassLabel";
            this.NewPassLabel.Size = new System.Drawing.Size(140, 16);
            this.NewPassLabel.TabIndex = 2;
            this.NewPassLabel.Text = "New master password";
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackColor = System.Drawing.Color.Silver;
            this.ChangePassword.FlatAppearance.BorderSize = 0;
            this.ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassword.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassword.Location = new System.Drawing.Point(113, 207);
            this.ChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(229, 67);
            this.ChangePassword.TabIndex = 38;
            this.ChangePassword.Text = "Change master password";
            this.ChangePassword.UseVisualStyleBackColor = false;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // ChangeMasterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 328);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.NewPassBox);
            this.Controls.Add(this.NewPassLabel);
            this.Controls.Add(this.OldPassBox);
            this.Controls.Add(this.OldPassLabel);
            this.MaximizeBox = false;
            this.Name = "ChangeMasterPassword";
            this.Text = "Change master password";
            this.Load += new System.EventHandler(this.ChangeMasterPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OldPassLabel;
        private System.Windows.Forms.TextBox OldPassBox;
        private System.Windows.Forms.TextBox NewPassBox;
        private System.Windows.Forms.Label NewPassLabel;
        private System.Windows.Forms.Button ChangePassword;
    }
}