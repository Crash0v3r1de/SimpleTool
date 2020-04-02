using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using ClientNet.Config;
using ClientNet.Network;

namespace ClientNet.ThreadWorkers
{
    public static class ConManager
    {
        public static void StartNMonitor()
        {
            NClient me = new NClient();
            me.AssignSetupDetails();
            me.StartDomain();
            int authLoops = 0;
            while (me.Active & ClientSettings.KeepAlive)
            {
                Console.WriteLine($"We're up and running!! | Domain: {ClientSettings.domainName}");
                Console.WriteLine("Sending auth step 0!");
                me.AuthDomain();
                me.WaitForDad();


                Thread.Sleep(700);
            }
        }
    }
}
