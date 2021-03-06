﻿namespace FinTrustApp.PresentationLayer
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
            this.panelClerk = new System.Windows.Forms.Panel();
            this.labelSearchID = new System.Windows.Forms.Label();
            this.labelSearchTransactionID = new System.Windows.Forms.Label();
            this.labelSearchAccuntNo = new System.Windows.Forms.Label();
            this.textBoxSearchClerkID = new System.Windows.Forms.TextBox();
            this.textBoxSearchTransactionID = new System.Windows.Forms.TextBox();
            this.textBoxSearchAccountNo = new System.Windows.Forms.TextBox();
            this.accountHandlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grievanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripClerk.SuspendLayout();
            this.panelClerk.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripClerk
            // 
            this.menuStripClerk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStripClerk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountHandlingToolStripMenuItem,
            this.grievanceToolStripMenuItem});
            this.menuStripClerk.Location = new System.Drawing.Point(0, 0);
            this.menuStripClerk.Name = "menuStripClerk";
            this.menuStripClerk.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripClerk.Size = new System.Drawing.Size(984, 24);
            this.menuStripClerk.TabIndex = 0;
            this.menuStripClerk.Text = "menuStrip1";
            // 
            // panelClerk
            // 
            this.panelClerk.Controls.Add(this.textBoxSearchAccountNo);
            this.panelClerk.Controls.Add(this.textBoxSearchTransactionID);
            this.panelClerk.Controls.Add(this.textBoxSearchClerkID);
            this.panelClerk.Controls.Add(this.labelSearchAccuntNo);
            this.panelClerk.Controls.Add(this.labelSearchTransactionID);
            this.panelClerk.Controls.Add(this.labelSearchID);
            this.panelClerk.Location = new System.Drawing.Point(104, 78);
            this.panelClerk.Name = "panelClerk";
            this.panelClerk.Size = new System.Drawing.Size(740, 445);
            this.panelClerk.TabIndex = 1;
            // 
            // labelSearchID
            // 
            this.labelSearchID.AutoSize = true;
            this.labelSearchID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchID.Location = new System.Drawing.Point(122, 101);
            this.labelSearchID.Name = "labelSearchID";
            this.labelSearchID.Size = new System.Drawing.Size(94, 18);
            this.labelSearchID.TabIndex = 0;
            this.labelSearchID.Text = "Serach by ID";
            // 
            // labelSearchTransactionID
            // 
            this.labelSearchTransactionID.AutoSize = true;
            this.labelSearchTransactionID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchTransactionID.Location = new System.Drawing.Point(122, 175);
            this.labelSearchTransactionID.Name = "labelSearchTransactionID";
            this.labelSearchTransactionID.Size = new System.Drawing.Size(176, 18);
            this.labelSearchTransactionID.TabIndex = 1;
            this.labelSearchTransactionID.Text = "Search by Transaction ID";
            // 
            // labelSearchAccuntNo
            // 
            this.labelSearchAccuntNo.AutoSize = true;
            this.labelSearchAccuntNo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchAccuntNo.Location = new System.Drawing.Point(122, 249);
            this.labelSearchAccuntNo.Name = "labelSearchAccuntNo";
            this.labelSearchAccuntNo.Size = new System.Drawing.Size(150, 18);
            this.labelSearchAccuntNo.TabIndex = 2;
            this.labelSearchAccuntNo.Text = "Search by Account No";
            // 
            // textBoxSearchClerkID
            // 
            this.textBoxSearchClerkID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchClerkID.Location = new System.Drawing.Point(414, 99);
            this.textBoxSearchClerkID.Name = "textBoxSearchClerkID";
            this.textBoxSearchClerkID.Size = new System.Drawing.Size(239, 25);
            this.textBoxSearchClerkID.TabIndex = 3;
            // 
            // textBoxSearchTransactionID
            // 
            this.textBoxSearchTransactionID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchTransactionID.Location = new System.Drawing.Point(414, 173);
            this.textBoxSearchTransactionID.Name = "textBoxSearchTransactionID";
            this.textBoxSearchTransactionID.Size = new System.Drawing.Size(239, 25);
            this.textBoxSearchTransactionID.TabIndex = 4;
            // 
            // textBoxSearchAccountNo
            // 
            this.textBoxSearchAccountNo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchAccountNo.Location = new System.Drawing.Point(414, 250);
            this.textBoxSearchAccountNo.Name = "textBoxSearchAccountNo";
            this.textBoxSearchAccountNo.Size = new System.Drawing.Size(239, 25);
            this.textBoxSearchAccountNo.TabIndex = 5;
            // 
            // accountHandlingToolStripMenuItem
            // 
            this.accountHandlingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountOpenToolStripMenuItem,
            this.accountCloseToolStripMenuItem});
            this.accountHandlingToolStripMenuItem.Name = "accountHandlingToolStripMenuItem";
            this.accountHandlingToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.accountHandlingToolStripMenuItem.Text = "Account Handling";
            // 
            // accountOpenToolStripMenuItem
            // 
            this.accountOpenToolStripMenuItem.Name = "accountOpenToolStripMenuItem";
            this.accountOpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accountOpenToolStripMenuItem.Text = "Account Open";
            this.accountOpenToolStripMenuItem.Click += new System.EventHandler(this.accountOpenToolStripMenuItem_Click);
            // 
            // accountCloseToolStripMenuItem
            // 
            this.accountCloseToolStripMenuItem.Name = "accountCloseToolStripMenuItem";
            this.accountCloseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accountCloseToolStripMenuItem.Text = "Account Close";
            this.accountCloseToolStripMenuItem.Click += new System.EventHandler(this.accountCloseToolStripMenuItem_Click);
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
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panelClerk);
            this.Controls.Add(this.menuStripClerk);
            this.Name = "FinTrust_Clerk_HomePage";
            this.Text = "Clerk";
            this.menuStripClerk.ResumeLayout(false);
            this.menuStripClerk.PerformLayout();
            this.panelClerk.ResumeLayout(false);
            this.panelClerk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripClerk;
        private System.Windows.Forms.Panel panelClerk;
        private System.Windows.Forms.TextBox textBoxSearchAccountNo;
        private System.Windows.Forms.TextBox textBoxSearchTransactionID;
        private System.Windows.Forms.TextBox textBoxSearchClerkID;
        private System.Windows.Forms.Label labelSearchAccuntNo;
        private System.Windows.Forms.Label labelSearchTransactionID;
        private System.Windows.Forms.Label labelSearchID;
        private System.Windows.Forms.ToolStripMenuItem accountHandlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grievanceToolStripMenuItem;
    }
}