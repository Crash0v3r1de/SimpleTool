using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTool.Configs;
using SimpleTool.Enums;
using SimpleTool.Lists;
using SimpleTool.Tools;
using SimpleTool.Workers;

namespace SimpleTool.ToolWindows
{
    public partial class PluginUI : Form
    {
        public Work PluginWork = new Work();
        public bool UserCanceled = false;
        public bool GlobalWorkAssigned = false;
        public string ClientID = null;
        private bool GlobalPlugin = false;


        public PluginUI()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Select a plugin to load...";
            fd.Filter = "DLL Plugin |*.dll";
            fd.CheckFileExists = true;
            fd.ShowDialog();
            if (File.Exists(fd.FileName))
            {
                if (ClientConfig.Debug) Logger.SaveDebug($"{ClientID} | Loading plugin...({fd.FileName})");
                lblFileName.Text = fd.SafeFileName;
                txtLocation.Text = fd.FileName;
                Assembly ass = Assembly.LoadFrom(fd.FileName);
                if (ClientConfig.Debug) Logger.SaveDebug($"{ClientID} | Plugin loaded, getting functions...");
                GetNameSpaces(ass);
                GetClassNames(ass);
                GetFunctions(ass);
            }
            else
            {
                if (ClientConfig.Debug) Logger.SaveDebug($"{ClientID} | Plugin file MISSING!");
                MessageBox.Show("ERROR! | Plugin file is missing from provided path!");
            }
        }

        private void GetNameSpaces(Assembly ass)
        {
            var typs = ass.GetTypes();
            foreach (var item in typs)
            {
                if (item.Namespace != null)
                {
                    lstNamespaces.Items.Add(item.Namespace);
                }
            }

            lstNamespaces.SetSelected(0,true);
            typs = null;
            if (ClientConfig.Debug) Logger.SaveDebug($"{ClientID} | Loaded {lstNamespaces.Items.Count} namespaces...");
        }

        private void GetClassNames(Assembly ass)
        {
            var typs = ass.GetTypes();
            foreach (var item in typs)
            {
                lstClasses.Items.Add(item.Name);
            }
            lstClasses.SetSelected(0, true);
            typs = null;
            if (ClientConfig.Debug) Logger.SaveDebug($"{ClientID} | Loaded {lstClasses.Items.Count} classes...");
        }

        private void GetFunctions(Assembly ass)
        {
            var typs = ass.GetTypes();
            foreach (var item in typs)
            {
                var methods = item.GetMethods();
                foreach (var method in methods)
                {
                    lstFunctions.Items.Add(method.Name);
                }

                methods = null;
            }
            lstFunctions.SetSelected(0, true);
            typs = null;
            if (ClientConfig.Debug) Logger.SaveDebug($"{ClientID} | Loaded {lstFunctions.Items.Count} functions/methods...");
        }

        private void btnSendPluginData_Click(object sender, EventArgs e)
        {
            Work work = new Work();
            var rawBytes = File.ReadAllBytes(txtLocation.Text);
            work.ClassName = (string) lstClasses.SelectedItem;
            work.FunctionName = (string)lstFunctions.SelectedItem;
            work.NameSpace = (string)lstNamespaces.SelectedItem;
            work.ClientID = "ALL";
            work.TimeSubmitted = DateTime.Now;
            work.AssemblyBytes = Convert.ToBase64String(rawBytes); // Byte Array To Base64 String - PRE ENCRYPTION
            work.WorkType = WorkType.Custom;
            PluginWork = work;
            Debug.WriteLine($"Plugin Details:\nNamespace: {(string)lstNamespaces.SelectedItem}\nClass: {(string)lstClasses.SelectedItem}\nFunction {(string)lstFunctions.SelectedItem}");
            work = null;
            if (GlobalPlugin)
            {
                WorkQueue.JobQueue.Add(PluginWork);
                GlobalWorkAssigned = true;
            }
            if (ClientConfig.Debug) Logger.SaveDebug($"{ClientID} | Plugin work assigned and sent....closing window!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserCanceled = true;
            this.Close();
            if (ClientConfig.Debug) Logger.SaveDebug($"{ClientID} | User canceled plugin loading...");
        }

        private void PluginUI_Load(object sender, EventArgs e)
        {
            if (ClientConfig.Debug) Logger.SaveDebug($"{ClientID} | Plugin UI loaded...");
        }

        public void ExternalPluginHandle(string path)
        {
            GlobalPlugin = true;
            txtLocation.Text = path;
            Assembly ass = Assembly.LoadFrom(path);
            if (ClientConfig.Debug) Logger.SaveDebug($"{ClientID} | Plugin loaded, getting functions...");
            GetNameSpaces(ass);
            GetClassNames(ass);
            GetFunctions(ass);
        }
    }
}
