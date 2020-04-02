using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Management;
using Microsoft.Win32;

namespace ClientNet.Tools
{
    public class DevInf
    {
        public string GetName()
        {
            return Environment.MachineName;
        }

        public string GetExternal()
        {
            return WebFinder();
        }

        public string GetC_Count()
        {
            int usable = Environment.ProcessorCount * Thread.CurrentThread.ManagedThreadId;
            
            return $"{usable}:{Environment.ProcessorCount}";
        }

        public string GetC_Data()
        {
            var key = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0\");
            return key?.GetValue("ProcessorNameString").ToString() ?? "Not Found";
        }

        public string GetC_Type()
        {
            NativeProc proc = new NativeProc();
            return proc.GetProcessorArchitecture().ToString();
        }

        public string OsCompatibleCheck()
        {
            OperatingSystem op = Environment.OSVersion;
            return op.VersionString;
        }

        private string WebFinder()
        {
            return new WebClient().DownloadString("http://api.ipify.org/");
        }
    }
}
