using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTool.Enums;

namespace SimpleTool.Lists
{
    public class Work
    {
        public string ClientID { get; set; }
        public WorkType WorkType { get; set; }
        public bool Sent { get; set; }
        public string AssemblyBytes { get; set; }
        public string AssemblyArguments { get; set; }
        public DateTime TimeSent { get; set; }
        public string ClassName { set; get; }
        public string FunctionName { get; set; }
        public string NameSpace { get; set; }
        public bool ExecutedRemotely { get; set; }
        public List<string> CompletedClients = new List<string>();
        public DateTime TimeSubmitted { get; set; }
    }
}
