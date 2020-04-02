using System.Windows.Forms;

namespace SimpleTool
{
    partial class mainFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllStealersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDumbyBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSlaveToListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markSlaveOfflineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateMoreKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareCurrentAndSaveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableAssigningKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalWorkAssignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botView = new System.Windows.Forms.DataGridView();
            this.previewColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.osColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpuRamColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.serverStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.memUsageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNetworkStats = new System.Windows.Forms.ToolStripStatusLabel();
            this.botMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killUntilRestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botRefresh = new System.Windows.Forms.Timer(this.components);
            this.testGlobalWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.botMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testingToolStripMenuItem,
            this.keyManagementToolStripMenuItem,
            this.configManagementToolStripMenuItem,
            this.globalWorkAssignmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAllStealersToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportAllStealersToolStripMenuItem
            // 
            this.exportAllStealersToolStripMenuItem.Name = "exportAllStealersToolStripMenuItem";
            this.exportAllStealersToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exportAllStealersToolStripMenuItem.Text = "Export All Stealers";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDumbyBotToolStripMenuItem,
            this.addSlaveToListToolStripMenuItem,
            this.markSlaveOfflineToolStripMenuItem,
            this.testPluginToolStripMenuItem,
            this.testGlobalWorkToolStripMenuItem});
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.testingToolStripMenuItem.Text = "Testing";
            // 
            // addDumbyBotToolStripMenuItem
            // 
            this.addDumbyBotToolStripMenuItem.Name = "addDumbyBotToolStripMenuItem";
            this.addDumbyBotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addDumbyBotToolStripMenuItem.Text = "Add Dumby Bot";
            this.addDumbyBotToolStripMenuItem.Click += new System.EventHandler(this.addDumbyBotToolStripMenuItem_Click);
            // 
            // addSlaveToListToolStripMenuItem
            // 
            this.addSlaveToListToolStripMenuItem.Name = "addSlaveToListToolStripMenuItem";
            this.addSlaveToListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addSlaveToListToolStripMenuItem.Text = "Add Slave to List";
            this.addSlaveToListToolStripMenuItem.Click += new System.EventHandler(this.addSlaveToListToolStripMenuItem_Click);
            // 
            // markSlaveOfflineToolStripMenuItem
            // 
            this.markSlaveOfflineToolStripMenuItem.Name = "markSlaveOfflineToolStripMenuItem";
            this.markSlaveOfflineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.markSlaveOfflineToolStripMenuItem.Text = "Mark Slave Offline";
            this.markSlaveOfflineToolStripMenuItem.Click += new System.EventHandler(this.markSlaveOfflineToolStripMenuItem_Click);
            // 
            // testPluginToolStripMenuItem
            // 
            this.testPluginToolStripMenuItem.Name = "testPluginToolStripMenuItem";
            this.testPluginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testPluginToolStripMenuItem.Text = "Test Plugin";
            this.testPluginToolStripMenuItem.Click += new System.EventHandler(this.testPluginToolStripMenuItem_Click);
            // 
            // keyManagementToolStripMenuItem
            // 
            this.keyManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateMoreKeysToolStripMenuItem,
            this.listKeysToolStripMenuItem,
            this.clearKeysToolStripMenuItem});
            this.keyManagementToolStripMenuItem.Name = "keyManagementToolStripMenuItem";
            this.keyManagementToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.keyManagementToolStripMenuItem.Text = "Key Management";
            // 
            // generateMoreKeysToolStripMenuItem
            // 
            this.generateMoreKeysToolStripMenuItem.Name = "generateMoreKeysToolStripMenuItem";
            this.generateMoreKeysToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.generateMoreKeysToolStripMenuItem.Text = "Generate More Keys";
            this.generateMoreKeysToolStripMenuItem.Click += new System.EventHandler(this.generateMoreKeysToolStripMenuItem_Click);
            // 
            // listKeysToolStripMenuItem
            // 
            this.listKeysToolStripMenuItem.Name = "listKeysToolStripMenuItem";
            this.listKeysToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listKeysToolStripMenuItem.Text = "Manage Keys";
            this.listKeysToolStripMenuItem.Click += new System.EventHandler(this.listKeysToolStripMenuItem_Click);
            // 
            // clearKeysToolStripMenuItem
            // 
            this.clearKeysToolStripMenuItem.Name = "clearKeysToolStripMenuItem";
            this.clearKeysToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.clearKeysToolStripMenuItem.Text = "Clear Keys";
            // 
            // configManagementToolStripMenuItem
            // 
            this.configManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadConfigToolStripMenuItem,
            this.saveConfigToolStripMenuItem,
            this.compareCurrentAndSaveConfigToolStripMenuItem,
            this.enableAssigningKeysToolStripMenuItem});
            this.configManagementToolStripMenuItem.Name = "configManagementToolStripMenuItem";
            this.configManagementToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.configManagementToolStripMenuItem.Text = "Config Management";
            // 
            // reloadConfigToolStripMenuItem
            // 
            this.reloadConfigToolStripMenuItem.Name = "reloadConfigToolStripMenuItem";
            this.reloadConfigToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.reloadConfigToolStripMenuItem.Text = "Reload Config";
            this.reloadConfigToolStripMenuItem.Click += new System.EventHandler(this.reloadConfigToolStripMenuItem_Click);
            // 
            // saveConfigToolStripMenuItem
            // 
            this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.saveConfigToolStripMenuItem.Text = "Save Config";
            this.saveConfigToolStripMenuItem.Click += new System.EventHandler(this.saveConfigToolStripMenuItem_Click);
            // 
            // compareCurrentAndSaveConfigToolStripMenuItem
            // 
            this.compareCurrentAndSaveConfigToolStripMenuItem.Name = "compareCurrentAndSaveConfigToolStripMenuItem";
            this.compareCurrentAndSaveConfigToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.compareCurrentAndSaveConfigToolStripMenuItem.Text = "Compare Current and Save Config";
            // 
            // enableAssigningKeysToolStripMenuItem
            // 
            this.enableAssigningKeysToolStripMenuItem.CheckOnClick = true;
            this.enableAssigningKeysToolStripMenuItem.Name = "enableAssigningKeysToolStripMenuItem";
            this.enableAssigningKeysToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.enableAssigningKeysToolStripMenuItem.Text = "Enable Assigning Keys";
            this.enableAssigningKeysToolStripMenuItem.Click += new System.EventHandler(this.enableAssigningKeysToolStripMenuItem_Click);
            // 
            // globalWorkAssignmentToolStripMenuItem
            // 
            this.globalWorkAssignmentToolStripMenuItem.Name = "globalWorkAssignmentToolStripMenuItem";
            this.globalWorkAssignmentToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.globalWorkAssignmentToolStripMenuItem.Text = "Global Work Assignment";
            this.globalWorkAssignmentToolStripMenuItem.Click += new System.EventHandler(this.globalWorkAssignmentToolStripMenuItem_Click);
            // 
            // botView
            // 
            this.botView.AllowUserToAddRows = false;
            this.botView.AllowUserToDeleteRows = false;
            this.botView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.botView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.botView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.botView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.botView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.previewColumn,
            this.osColumn,
            this.ipColumn,
            this.cpuRamColumn,
            this.IDColumn,
            this.avColumn});
            this.botView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botView.Location = new System.Drawing.Point(0, 24);
            this.botView.MultiSelect = false;
            this.botView.Name = "botView";
            this.botView.RowHeadersVisible = false;
            this.botView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.botView.ShowCellToolTips = false;
            this.botView.ShowEditingIcon = false;
            this.botView.Size = new System.Drawing.Size(942, 458);
            this.botView.TabIndex = 2;
            // 
            // previewColumn
            // 
            this.previewColumn.HeaderText = "Display";
            this.previewColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.previewColumn.MinimumWidth = 50;
            this.previewColumn.Name = "previewColumn";
            // 
            // osColumn
            // 
            this.osColumn.HeaderText = "Operating System";
            this.osColumn.Name = "osColumn";
            // 
            // ipColumn
            // 
            this.ipColumn.HeaderText = "Client IP";
            this.ipColumn.Name = "ipColumn";
            // 
            // cpuRamColumn
            // 
            this.cpuRamColumn.HeaderText = "CPU Core Count | RAM";
            this.cpuRamColumn.MinimumWidth = 100;
            this.cpuRamColumn.Name = "cpuRamColumn";
            this.cpuRamColumn.Width = 150;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Client ID";
            this.IDColumn.MinimumWidth = 120;
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Width = 180;
            // 
            // avColumn
            // 
            this.avColumn.HeaderText = "Detected AV\'s";
            this.avColumn.MinimumWidth = 120;
            this.avColumn.Name = "avColumn";
            this.avColumn.Width = 180;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverStatus,
            this.memUsageLabel,
            this.lblNetworkStats});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(942, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // serverStatus
            // 
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(77, 17);
            this.serverStatus.Text = "Server Status:";
            // 
            // memUsageLabel
            // 
            this.memUsageLabel.Name = "memUsageLabel";
            this.memUsageLabel.Size = new System.Drawing.Size(79, 17);
            this.memUsageLabel.Text = "Mem Usage...";
            // 
            // lblNetworkStats
            // 
            this.lblNetworkStats.Name = "lblNetworkStats";
            this.lblNetworkStats.Size = new System.Drawing.Size(70, 17);
            this.lblNetworkStats.Text = "Net Usage...";
            // 
            // botMenu
            // 
            this.botMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPluginToolStripMenuItem,
            this.powerOptionsToolStripMenuItem,
            this.clientOptionsToolStripMenuItem});
            this.botMenu.Name = "botMenu";
            this.botMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // loadPluginToolStripMenuItem
            // 
            this.loadPluginToolStripMenuItem.Image = global::SimpleTool.Properties.Resources.plugin_icon_26;
            this.loadPluginToolStripMenuItem.Name = "loadPluginToolStripMenuItem";
            this.loadPluginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadPluginToolStripMenuItem.Text = "Load Plugin";
            this.loadPluginToolStripMenuItem.Click += new System.EventHandler(this.loadPluginToolStripMenuItem_Click);
            // 
            // powerOptionsToolStripMenuItem
            // 
            this.powerOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.powerOffToolStripMenuItem});
            this.powerOptionsToolStripMenuItem.Image = global::SimpleTool.Properties.Resources.Power;
            this.powerOptionsToolStripMenuItem.Name = "powerOptionsToolStripMenuItem";
            this.powerOptionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.powerOptionsToolStripMenuItem.Text = "Power Options";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // powerOffToolStripMenuItem
            // 
            this.powerOffToolStripMenuItem.Name = "powerOffToolStripMenuItem";
            this.powerOffToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.powerOffToolStripMenuItem.Text = "Power Off";
            // 
            // clientOptionsToolStripMenuItem
            // 
            this.clientOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killUntilRestartToolStripMenuItem,
            this.removeFromComputerToolStripMenuItem,
            this.restartProcessToolStripMenuItem});
            this.clientOptionsToolStripMenuItem.Image = global::SimpleTool.Properties.Resources.monitor;
            this.clientOptionsToolStripMenuItem.Name = "clientOptionsToolStripMenuItem";
            this.clientOptionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientOptionsToolStripMenuItem.Text = "Client Options";
            // 
            // killUntilRestartToolStripMenuItem
            // 
            this.killUntilRestartToolStripMenuItem.Name = "killUntilRestartToolStripMenuItem";
            this.killUntilRestartToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.killUntilRestartToolStripMenuItem.Text = "Kill until restart";
            // 
            // removeFromComputerToolStripMenuItem
            // 
            this.removeFromComputerToolStripMenuItem.Name = "removeFromComputerToolStripMenuItem";
            this.removeFromComputerToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.removeFromComputerToolStripMenuItem.Text = "Remove from computer";
            // 
            // restartProcessToolStripMenuItem
            // 
            this.restartProcessToolStripMenuItem.Name = "restartProcessToolStripMenuItem";
            this.restartProcessToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.restartProcessToolStripMenuItem.Text = "Restart process";
            // 
            // botRefresh
            // 
            this.botRefresh.Enabled = true;
            this.botRefresh.Interval = 600;
            this.botRefresh.Tick += new System.EventHandler(this.botRefresh_Tick);
            // 
            // testGlobalWorkToolStripMenuItem
            // 
            this.testGlobalWorkToolStripMenuItem.Name = "testGlobalWorkToolStripMenuItem";
            this.testGlobalWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testGlobalWorkToolStripMenuItem.Text = "Test Global Work";
            this.testGlobalWorkToolStripMenuItem.Click += new System.EventHandler(this.testGlobalWorkToolStripMenuItem_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 482);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.botView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainFrm";
            this.Text = "SimpleTool | RAT Tool for simple shit | 991z3r0";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.botMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllStealersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDumbyBotToolStripMenuItem;
        private System.Windows.Forms.DataGridView botView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel serverStatus;
        private System.Windows.Forms.ToolStripStatusLabel memUsageLabel;
        private System.Windows.Forms.ToolStripMenuItem keyManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateMoreKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareCurrentAndSaveConfigToolStripMenuItem;
        private ContextMenuStrip botMenu;
        private ToolStripMenuItem loadPluginToolStripMenuItem;
        private ToolStripMenuItem powerOptionsToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem powerOffToolStripMenuItem;
        private ToolStripMenuItem clientOptionsToolStripMenuItem;
        private ToolStripMenuItem killUntilRestartToolStripMenuItem;
        private ToolStripMenuItem removeFromComputerToolStripMenuItem;
        private ToolStripMenuItem restartProcessToolStripMenuItem;
        private Timer botRefresh;
        private ToolStripMenuItem addSlaveToListToolStripMenuItem;
        private ToolStripMenuItem markSlaveOfflineToolStripMenuItem;
        private ToolStripMenuItem enableAssigningKeysToolStripMenuItem;
        private ToolStripMenuItem testPluginToolStripMenuItem;
        private DataGridViewImageColumn previewColumn;
        private DataGridViewTextBoxColumn osColumn;
        private DataGridViewTextBoxColumn ipColumn;
        private DataGridViewTextBoxColumn cpuRamColumn;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn avColumn;
        private ToolStripStatusLabel lblNetworkStats;
        private ToolStripMenuItem globalWorkAssignmentToolStripMenuItem;
        private ToolStripMenuItem testGlobalWorkToolStripMenuItem;
    }
}

