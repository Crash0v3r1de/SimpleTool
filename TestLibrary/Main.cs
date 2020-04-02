using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLibrary
{
    public class Main
    {
        public void Console(string args)
        {
            System.Console.WriteLine("LIBRARY RAN! - "+args);
            MessageBox.Show("Yo?");
        }
    }
}
