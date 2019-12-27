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
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panelLogin.Controls.Add(this.button1);
            this.panelLogin.Controls.Add(this.textBox1);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.lblUser);
            this.panelLogin.Controls.Add(this.cmbUser);
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
            this.lblLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(167, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(63, 22);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // cmbUser
            // 
            this.cmbUser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Items.AddRange(new object[] {
            "Branch Manager",
            "probationary Officer",
            "Cashier",
            "Clerk"});
            this.cmbUser.Location = new System.Drawing.Point(165, 83);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(224, 28);
            this.cmbUser.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(53, 91);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 18);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(55, 195);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 18);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 184);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 29);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.panelLogin.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
    }
}