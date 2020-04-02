using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SimpleTool.Enums;

namespace SimpleTool.Tools
{
    public static class Logger
    {
        private static string logFolder = Directory.GetCurrentDirectory() + "\\Logs";
        private static string errorLog = logFolder + "\\errors.txt";
        private static string debugLog = logFolder + "\\debug.txt";
        private static string infoLog = logFolder + "\\client_log.txt";

        private static void SaveEntry(string msg, LogType type,Exception ex = null)
        {
            if (!Directory.Exists(logFolder))
            {
                Directory.CreateDirectory(logFolder);
            }

            switch (type)
            {
                case LogType.Debug:
                    using (StreamWriter log = File.AppendText(debugLog))
                    {
                        log.WriteLine($"{DateTime.Now.ToString("M/d/yy-hh:mm")} | {msg}");
                    }
                    break;
                case LogType.Info:
                    using (StreamWriter log = File.AppendText(infoLog))
                    {
                        log.WriteLine($"{DateTime.Now.ToString("M/d/yy-hh:mm")} | {msg}");
                    }
                    break;
                case LogType.Error:
                    using (StreamWriter log = File.AppendText(errorLog))
                    {
                        log.WriteLine($"{DateTime.Now.ToString("M/d/yy-hh:mm")} | {msg}");
                    }
                    break;
                case LogType.Critical:
                    using (StreamWriter log = File.AppendText(errorLog))
                    {
                        log.WriteLine($"{DateTime.Now.ToString("M/d/yy-hh:mm")} | {msg}");
                        log.WriteLine(ex.StackTrace);
                        log.WriteLine("============================================================");
                    }
                    break;
                default:
                    Debug.WriteLine("Default Logger SaveEntry hit!!");
                    break;
            }
        }

        public static void SaveInfo(string info)
        {
            SaveEntry(info,LogType.Info);
        }
        public static void SaveDebug(string debug)
        {
            SaveEntry(debug, LogType.Debug);
        }
        public static void SaveError(string error)
        {
            SaveEntry(error, LogType.Error);
        }
        public static void SaveCritical(string critical)
        {
            SaveEntry(critical, LogType.Critical);
        }
    }
}
