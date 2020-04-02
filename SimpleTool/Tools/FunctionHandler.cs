using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTool.Tools
{
    public class FunctionHandler
    {
        public Image LoadImage(string imgString)
        {
            //data:image/gif;base64,

            byte[] bytes = Convert.FromBase64String(imgString);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }
    }
}
