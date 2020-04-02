using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SimpleTool.Configs;

namespace SimpleTool.Tools
{
    public static class ConfigHandler
    {
        private static string configFolderLocation = Directory.GetCurrentDirectory() + "\\Configs";
        private static string configFileLocation = configFolderLocation + "\\config.json";

        public static bool ConfigFound()
        {
            if (File.Exists(configFileLocation))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidConfig()
        {
            if (ConfigFound())
            {
                try {
                    var config = JsonConvert.DeserializeObject<ClientConfigDeSerial>(configFileLocation);
                    if (config != null) { return true; }
                }
                catch { return false; }
                return false;
            }
            else
            {
                return false;
            }
        }
        public static bool LoadConfig()
        {
            if (ConfigFound()&ValidConfig())
            {
                try
                {
                }
                catch
                {
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
