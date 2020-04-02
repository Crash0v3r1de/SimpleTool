using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTool.Lists;

namespace SimpleTool.Network
{
    public static class ClientHandler
    {
        public static List<Slave> Slaves = new List<Slave>();

        public static void AddClient(Slave client)
        {
            Slaves.Add(client);
            Debug.WriteLine($"Added {client.ClientID} to slave list!");
        }

        public static int AssignClientListCount(string clientID)
        {
            for (var x = 0; x < Slaves.Count; x++) // Look through all and find associated client from list
            {
                if (Slaves[x].ClientID == clientID)
                {
                    Slaves[x].SlaveListAssignment = x;
                    return x;
                }
            }

            return 0; // Error occured
        }

        public static string GetAVFormatted(Slave slave)
        {
            if (slave.DetectedAVs.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                var last = slave.DetectedAVs.Last();
                foreach (var found in slave.DetectedAVs)
                {
                    sb.Append(found);
                    if (found != last)
                    {
                        sb.Append(" | ");
                    }
                }

                return sb.ToString();
            }
            else
            {
                return "None Found! - Probly needs updated...";
            }
        }
    }
}
