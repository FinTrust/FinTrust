namespace FinTrustApp.PresentationLayer
{
    partial class FinTrust_Login
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
            this.lblTrust = new System.Windows.Forms.Label();
            this.lblnTrust = new System.Windows.Forms.Label();
            this.lbli = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelLoginHead = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelLoginHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrust
            // 
            this.lblTrust.AutoSize = true;
            this.lblTrust.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrust.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTrust.Location = new System.Drawing.Point(1080, 95);
            this.lblTrust.Name = "lblTrust";
            this.lblTrust.Size = new System.Drawing.Size(104, 16);
            this.lblTrust.TabIndex = 14;
            this.lblTrust.Text = "Tradition of Trust";
            // 
            // lblnTrust
            // 
            this.lblnTrust.AutoSize = true;
            this.lblnTrust.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnTrust.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblnTrust.Location = new System.Drawing.Point(1072, 21);
            this.lblnTrust.Margin = new System.Windows.Forms.Padding(0);
            this.lblnTrust.Name = "lblnTrust";
            this.lblnTrust.Size = new System.Drawing.Size(171, 56);
            this.lblnTrust.TabIndex = 11;
            this.lblnTrust.Text = "nTrust";
            // 
            // lbli
            // 
            this.lbli.AutoSize = true;
            this.lbli.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbli.ForeColor = System.Drawing.Color.Red;
            this.lbli.Location = new System.Drawing.Point(1049, 21);
            this.lbli.Name = "lbli";
            this.lbli.Size = new System.Drawing.Size(37, 56);
            this.lbli.TabIndex = 13;
            this.lbli.Text = "i";
            this.lbli.Click += new System.EventHandler(this.lbli_Click);
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblF.Location = new System.Drawing.Point(1014, 21);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(53, 56);
            this.lblF.TabIndex = 12;
            this.lblF.Text = "F";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.panelLoginHead);
            this.panelLogin.Location = new System.Drawing.Point(1025, 146);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(404, 354);
            this.panelLogin.TabIndex = 0;
            // 
            // panelLoginHead
            // 
            this.panelLoginHead.Controls.Add(this.lblLogin);
            this.panelLoginHead.Location = new System.Drawing.Point(3, 3);
            this.panelLoginHead.Name = "panelLoginHead";
            this.panelLoginHead.Size = new System.Drawing.Size(398, 38);
            this.panelLoginHead.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(159, 11);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // FinTrust_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 648);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.lblTrust);
            this.Controls.Add(this.lblnTrust);
            this.Controls.Add(this.lbli);
            this.Controls.Add(this.lblF);
            this.Name = "FinTrust_Login";
            this.Text = "FinTrust_Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLoginHead.ResumeLayout(false);
            this.panelLoginHead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrust;
        private System.Windows.Forms.Label lblnTrust;
        private System.Windows.Forms.Label lbli;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelLoginHead;
        private System.Windows.Forms.Label lblLogin;
    }
}