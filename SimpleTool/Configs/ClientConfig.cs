using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTool.Lists;

namespace SimpleTool.Configs
{
    public static class ClientConfig
    {
        // If you update this update ClientConfigDeSerial
        public static int Port { get; set; }
        public static string connectionKey { get; set; }
        public static List<EncryptionKeys> EncryptionKeys = new List<EncryptionKeys>();
        public static bool AntiVM { get; set; }
        public static bool Debug { get; set; }
        public static bool AssignNewKeys { get; set; }
    }
}
