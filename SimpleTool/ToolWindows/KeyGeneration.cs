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
    public partial class KeyGeneration : Form
    {
        private CryptoTool crypt = new CryptoTool();
        public KeyGeneration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (var x = 0;x<numKeysToMake.Value;x++)
            {
                EncryptionKeys key = new EncryptionKeys();
                key.Password = crypt.CreatePassSalt(256);
                key.Salt = crypt.CreatePassSalt(15);
                key.XorKey = crypt.CreateXOR_Pass(Rando.GetNumber(256).ToString()); // instead of a username we'll just use int for XOR key
                key.VlKey = crypt.Create15VIPassword(15);
                ClientConfig.EncryptionKeys.Add(key); // Add to client key list
            }
            MessageBox.Show($"{ClientConfig.EncryptionKeys.Count} custom keys now stored!");
            this.Close();
        }
    }
}
