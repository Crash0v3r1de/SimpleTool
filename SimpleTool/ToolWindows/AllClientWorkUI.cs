using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTool.Enums;
using SimpleTool.Workers;

namespace SimpleTool.ToolWindows
{
    public partial class AllClientWorkUI : Form
    {
        public AllClientWorkUI()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Title = "Select plugin or exe to execute";
                fd.Filter = "Executables|*.exe|Plugins|*.dll";
                fd.CheckFileExists = true;
                fd.ShowDialog();
                txtFilePath.Text = fd.FileName;
            }

            if (!String.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                ExecutionHandler();
            }
        }

        private void ExecutionHandler()
        {
            FileInfo fI = new FileInfo(txtFilePath.Text);
            DataSize size = DataSize.Bytes;
            decimal conv = 0;
            if (fI.Length >= 1024 & fI.Length < 1000024)
            {
                size = DataSize.KB;
                conv = fI.Length / 1024; // KB
            }
            if (fI.Length >= 1000024 & fI.Length < 1073741824)
            {
                size = DataSize.MB;
                conv = fI.Length / 1000024; // MB
            }
            if (fI.Length >= 1073741824 & fI.Length < 1073741824)
            {
                size = DataSize.GB;
                conv = fI.Length / 1073741824; // GB
            }
            lblSize.Text = $"{conv.ToString("F")} {size}";

            if (txtFilePath.Text.Contains(".dll"))
            {
                lblType.Text = "Plugin";
                using (PluginUI pUI = new PluginUI())
                {
                    pUI.ExternalPluginHandle(txtFilePath.Text);
                    pUI.ShowDialog();
                    if (pUI.GlobalWorkAssigned)
                    {
                        grpPlugin.Visible = true;
                        lblNamespace.Text = pUI.PluginWork.NameSpace;
                        lblClass.Text = pUI.PluginWork.ClassName;
                        lblFunction.Text = pUI.PluginWork.FunctionName;
                        //this.Close();
                    }
                }
            }

            if (txtFilePath.Text.Contains(".exe"))
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
