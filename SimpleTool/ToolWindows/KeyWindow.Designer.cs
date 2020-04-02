namespace SimpleTool.ToolWindows
{
    partial class KeyWindow
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
            this.lstKeys = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKeys
            // 
            this.lstKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKeys.FormattingEnabled = true;
            this.lstKeys.Location = new System.Drawing.Point(0, 28);
            this.lstKeys.Name = "lstKeys";
            this.lstKeys.Size = new System.Drawing.Size(907, 238);
            this.lstKeys.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeWindowToolStripMenuItem,
            this.removeSelectedKeyToolStripMenuItem,
            this.refreshListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.closeWindowToolStripMenuItem.Text = "Close Window";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // removeSelectedKeyToolStripMenuItem
            // 
            this.removeSelectedKeyToolStripMenuItem.Name = "removeSelectedKeyToolStripMenuItem";
            this.removeSelectedKeyToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.removeSelectedKeyToolStripMenuItem.Text = "Remove Selected Key";
            this.removeSelectedKeyToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedKeyToolStripMenuItem_Click);
            // 
            // refreshListToolStripMenuItem
            // 
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.refreshListToolStripMenuItem.Text = "Refresh List";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.refreshListToolStripMenuItem_Click);
            // 
            // KeyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 268);
            this.Controls.Add(this.lstKeys);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KeyWindow";
            this.Text = "KeyWindow";
            this.Load += new System.EventHandler(this.KeyWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKeys;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
    }
}