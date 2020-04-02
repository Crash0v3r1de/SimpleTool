using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTool.Lists
{
    public class EncryptionKeys
    {
        public string Password { get; set; }
        public string Salt { get; set; }
        public string VlKey { get; set; }
        public string XorKey { get; set; }
    }
}
