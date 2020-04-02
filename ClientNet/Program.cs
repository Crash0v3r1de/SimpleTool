using System;
using ClientNet.ThreadWorkers;

namespace ClientNet
{
    class Program
    {
        static void Main(string[] args)
        {
            ConManager.StartNMonitor();
        }
    }
}
