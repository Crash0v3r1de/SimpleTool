using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTool.Lists;

namespace SimpleTool.Tools
{
    public class ClientTools
    {
        public string HostNameFromID(Slave client)
        {
            byte[] rawByte = Convert.FromBase64String(client.ClientID);
            string raw = Encoding.UTF8.GetString(rawByte);
            try
            {
                // Hostname:IP
                //     0   : 1
                return raw.Split(':')[0];
            }
            catch
            {
                return "BAD";
            }
        }
        public string IPFromID(Slave client)
        {
            byte[] rawByte = Convert.FromBase64String(client.ClientID);
            string raw = Encoding.UTF8.GetString(rawByte);
            try
            {
                // Hostname:IP
                //     0   : 1
                return raw.Split(':')[1];
            }
            catch
            {
                return "BAD";
            }
        }
    }
}
