﻿namespace WorldSmith.Panels
{
    partial class StartPageForm 
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
            this.components = new System.ComponentModel.Container();
            this.lblRecentAddons = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblNewAddon = new System.Windows.Forms.Label();
            this.lblLoadAddon = new System.Windows.Forms.Label();
            this.recentAddonsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecentAddons
            // 
            this.lblRecentAddons.AutoSize = true;
            this.lblRecentAddons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentAddons.Location = new System.Drawing.Point(4, 111);
            this.lblRecentAddons.Name = "lblRecentAddons";
            this.lblRecentAddons.Size = new System.Drawing.Size(109, 18);
            this.lblRecentAddons.TabIndex = 1;
            this.lblRecentAddons.Text = "Recent Addons";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(6, 4);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(39, 18);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Start";
            // 
            // lblNewAddon
            // 
            this.lblNewAddon.AutoSize = true;
            this.lblNewAddon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNewAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAddon.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNewAddon.Location = new System.Drawing.Point(9, 26);
            this.lblNewAddon.Name = "lblNewAddon";
            this.lblNewAddon.Size = new System.Drawing.Size(79, 15);
            this.lblNewAddon.TabIndex = 4;
            this.lblNewAddon.Text = "New Addon...";
            this.lblNewAddon.Click += new System.EventHandler(this.lblNewAddon_Click);
            // 
            // lblLoadAddon
            // 
            this.lblLoadAddon.AutoSize = true;
            this.lblLoadAddon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoadAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadAddon.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblLoadAddon.Location = new System.Drawing.Point(9, 41);
            this.lblLoadAddon.Name = "lblLoadAddon";
            this.lblLoadAddon.Size = new System.Drawing.Size(82, 15);
            this.lblLoadAddon.TabIndex = 5;
            this.lblLoadAddon.Text = "Load Addon...";
            this.lblLoadAddon.Click += new System.EventHandler(this.lblLoadAddon_Click);
            // 
            // recentAddonsFlowPanel
            // 
            this.recentAddonsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.recentAddonsFlowPanel.Location = new System.Drawing.Point(7, 133);
            this.recentAddonsFlowPanel.Name = "recentAddonsFlowPanel";
            this.recentAddonsFlowPanel.Size = new System.Drawing.Size(148, 100);
            this.recentAddonsFlowPanel.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // StartPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 286);
            this.Controls.Add(this.recentAddonsFlowPanel);
            this.Controls.Add(this.lblLoadAddon);
            this.Controls.Add(this.lblNewAddon);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblRecentAddons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StartPageForm";
            this.TabPageContextMenuStrip = this.contextMenuStrip1;
            this.TabText = "Start Page";
            this.Text = "Start Page";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecentAddons;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblNewAddon;
        private System.Windows.Forms.Label lblLoadAddon;
        private System.Windows.Forms.FlowLayoutPanel recentAddonsFlowPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}