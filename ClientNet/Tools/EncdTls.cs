using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNet.Tools
{
    public static class EncdTls
    {
        public static byte[] S2Byt(string data)
        {
            return Encoding.ASCII.GetBytes(data);
        }

        public static string B2Str(byte[] data)
        {
            return Encoding.ASCII.GetString(data);
        }

        public static List<byte> byArry2Lst(byte[] data)
        {
            List<byte> sLst = new List<byte>();
            for (int x = 0; x < data.Length; x++)
            {
                sLst.Add(data[x]);
            }

            return sLst;
        }

        public static byte[] Lst2bArry(List<byte> data)
        {
            return data.ToArray();
        }
    }
}
