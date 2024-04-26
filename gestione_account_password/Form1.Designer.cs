namespace gestione_account_password
{
    partial class Access
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Register = new System.Windows.Forms.Button();
            this.LogIn = new System.Windows.Forms.Button();
            this.RightsReserved = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Silver;
            this.Register.Font = new System.Drawing.Font("Verdana", 12F);
            this.Register.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Register.Location = new System.Drawing.Point(161, 106);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(162, 78);
            this.Register.TabIndex = 0;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.Silver;
            this.LogIn.Font = new System.Drawing.Font("Verdana", 12F);
            this.LogIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogIn.Location = new System.Drawing.Point(161, 202);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(162, 78);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "Log in";
            this.LogIn.UseVisualStyleBackColor = false;
            // 
            // RightsReserved
            // 
            this.RightsReserved.AutoSize = true;
            this.RightsReserved.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightsReserved.Location = new System.Drawing.Point(95, 387);
            this.RightsReserved.Name = "RightsReserved";
            this.RightsReserved.Size = new System.Drawing.Size(272, 16);
            this.RightsReserved.TabIndex = 3;
            this.RightsReserved.Text = "All rights reserved. ©2024 Iannelli Corp.";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(92, 42);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(316, 31);
            this.Welcome.TabIndex = 4;
            this.Welcome.Text = "Welcome to SentinelKey";
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 412);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.RightsReserved);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.Register);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Access";
            this.Text = "SentinelKey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label RightsReserved;
        private System.Windows.Forms.Label Welcome;
    }
}

