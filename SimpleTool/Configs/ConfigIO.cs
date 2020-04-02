using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SimpleTool.ToolWindows;

namespace SimpleTool.Configs
{
    public class ConfigIO
    {
        private static string configFolder = Directory.GetCurrentDirectory() + "\\Config";
        private string backupFolder = configFolder + "\\Backup";
        private string configFullPath = configFolder + "\\client.json";
        private ClientConfigDeSerial toSerialize = new ClientConfigDeSerial();

        public void SaveConfig()
        {
            VerifyFolders();
            InitializeConfig4Save();
            var jsonString = JsonConvert.SerializeObject(toSerialize,Formatting.Indented);
            BackupOldConfig();
            using (StreamWriter sw = File.AppendText(configFullPath))
            {
                sw.WriteLine(jsonString);
            }
        }

        public void LoadConfig()
        {
            if (File.Exists(configFullPath))
            {
                toSerialize = JsonConvert.DeserializeObject<ClientConfigDeSerial>(File.ReadAllText(configFullPath));
            }
            else
            {
                InitialSetup setupUI = new InitialSetup();
                setupUI.ShowDialog();
                setupUI.Dispose();
                SaveConfig();
            }
            LoadConfigToMemory(); // Used to load deserialized config into ClientConfig
        }

        private void VerifyFolders()
        {
            if (!Directory.Exists(configFolder))
            {
                Directory.CreateDirectory(configFolder);
            }
            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }
        }
        private void InitializeConfig4Save()
        {
            toSerialize.EncryptionKeys = ClientConfig.EncryptionKeys;
            toSerialize.AntiVM = ClientConfig.AntiVM;
            toSerialize.Debug = ClientConfig.Debug;
            toSerialize.Port = ClientConfig.Port;
            toSerialize.connectionKey = ClientConfig.connectionKey;
        }
        private void LoadConfigToMemory()
        {
            ClientConfig.EncryptionKeys = toSerialize.EncryptionKeys;
            ClientConfig.AntiVM = toSerialize.AntiVM;
            ClientConfig.Debug = toSerialize.Debug;
            ClientConfig.Port = toSerialize.Port;            ClientConfig.connectionKey = toSerialize.connectionKey;
        }
        private void BackupOldConfig()
        {
            if(File.Exists(configFullPath))
            File.Move(configFullPath,backupFolder+$"\\client_{DateTime.Now.ToString("mm-dd-yyyy_hh-mm")}.json");
        }


        bool disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose managed resources
                }
            }
            //dispose unmanaged resources
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
