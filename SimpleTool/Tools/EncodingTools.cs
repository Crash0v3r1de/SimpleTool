using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTool.Tools
{
    public static class EncodingTools
    {
        public static byte[] String2ByteArray(string data)
        {
            return Encoding.ASCII.GetBytes(data);
        }

        public static string ByteArray2String(byte[] data)
        {
            return Encoding.ASCII.GetString(data);
        }

        public static List<byte> ByteArray2List(byte[] data)
        {
            List<byte> sLst = new List<byte>();
            for (int x = 0; x < data.Length; x++)
            {
                sLst.Add(data[x]);
            }

            return sLst;
        }

        public static byte[] List2ByteArray(List<byte> data)
        {
            return data.ToArray();
        }
    }
}
