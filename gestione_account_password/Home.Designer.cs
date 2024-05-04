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
            this.SuspendLayout();
            // 
            // CenterPanel
            // 
            this.CenterPanel.Location = new System.Drawing.Point(201, 158);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(806, 463);
            this.CenterPanel.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 633);
            this.Controls.Add(this.CenterPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "SentinelKey - Home";
            this.Load += new System.EventHandler(this.Service_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CenterPanel;
    }
}