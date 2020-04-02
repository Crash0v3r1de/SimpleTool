using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTool.Configs;

namespace SimpleTool.ToolWindows
{
    public partial class KeyWindow : Form
    {
        public KeyWindow()
        {
            InitializeComponent();
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeSelectedKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstKeys);
            selectedItems = lstKeys.SelectedItems;

            if (lstKeys.SelectedIndex != -1)
            {
                for (int i = 0;i<selectedItems.Count;i++)
                {
                    lstKeys.Items.Remove(selectedItems[i]);
                    ClientConfig.EncryptionKeys.RemoveAt(i);
                }
            }
            else
                MessageBox.Show("No key selected!");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void KeyWindow_Load(object sender, EventArgs e)
        {
            if (ClientConfig.EncryptionKeys.Count != 0)
            {
                for (var x = 0; x < ClientConfig.EncryptionKeys.Count; x++)
                {
                    lstKeys.Items.Add($"Pass - {ClientConfig.EncryptionKeys[x].Password} | Salt - {ClientConfig.EncryptionKeys[x].Salt} | XOR Key - {ClientConfig.EncryptionKeys[x].XorKey}");
                }
            }
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstKeys.Items.Clear();
            for (var x = 0; x < ClientConfig.EncryptionKeys.Count; x++)
            {
                lstKeys.Items.Add($"Pass - {ClientConfig.EncryptionKeys[x].Password} | Salt - {ClientConfig.EncryptionKeys[x].Salt} | XOR Key - {ClientConfig.EncryptionKeys[x].XorKey}");
            }
        }
    }
}
