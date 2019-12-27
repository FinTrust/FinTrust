namespace FinTrustApp.PresentationLayer
{
    partial class FinTrust_Clerk_HomePage
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
            this.menuStripClerk = new System.Windows.Forms.MenuStrip();
            this.accountOpenCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grievanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripClerk.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripClerk
            // 
            this.menuStripClerk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStripClerk.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStripClerk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountOpenCloseToolStripMenuItem,
            this.grievanceToolStripMenuItem});
            this.menuStripClerk.Location = new System.Drawing.Point(0, 0);
            this.menuStripClerk.Name = "menuStripClerk";
            this.menuStripClerk.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripClerk.Size = new System.Drawing.Size(984, 24);
            this.menuStripClerk.TabIndex = 0;
            this.menuStripClerk.Text = "menuStrip1";
            // 
            // accountOpenCloseToolStripMenuItem
            // 
            this.accountOpenCloseToolStripMenuItem.Name = "accountOpenCloseToolStripMenuItem";
            this.accountOpenCloseToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.accountOpenCloseToolStripMenuItem.Text = "Account Open/Close";
            this.accountOpenCloseToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // grievanceToolStripMenuItem
            // 
            this.grievanceToolStripMenuItem.Name = "grievanceToolStripMenuItem";
            this.grievanceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.grievanceToolStripMenuItem.Text = "Grievance";
            // 
            // FinTrust_Clerk_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.menuStripClerk);
            this.Name = "FinTrust_Clerk_HomePage";
            this.Text = "Clerk";
            this.menuStripClerk.ResumeLayout(false);
            this.menuStripClerk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripClerk;
        private System.Windows.Forms.ToolStripMenuItem accountOpenCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grievanceToolStripMenuItem;
    }
}