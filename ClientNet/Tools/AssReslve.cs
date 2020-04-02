using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClientNet.Tools
{
    public class AssReslve
    {
        private Assembly _ass;
        private Type _typ;


        public bool LoadPlugin(byte[] libData)
        {
            try
            {
                _ass = Assembly.Load(libData);
                if (_ass != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR LOADING PLUGIN - "+ex.Message);
                return false;
            }
        }
        public bool LoadClass(string libName,string className)
        {
            try
            {
                _typ =_ass.GetType($"{libName}.{className}");
                if (_typ != null)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR LOADING CLASS - "+ex.Message);
                return false;
            }

            return false;
        }
        public bool FireFunctions(string functionName,string args)
        {
            var methodInfo = _typ.GetMethod(functionName, new Type[] { typeof(int), typeof(string) });
            // Load the new function
            if (methodInfo == null)
            {
                Console.WriteLine("ERROR LOADING FUNCTION TO RUN!");
            }
            else
            {
                object[] constructorParameters = new object[1];
                constructorParameters[0] = args; // First parameter.

                // Create instance of class with parameters
                var o = Activator.CreateInstance(_typ, constructorParameters);

                // Config parameters for the method to invoke: 'void functionName(string args)'
                object[] parameters = new object[2];
                parameters[0] = 124;            // 'args' parameter

                // Invoke method 'void functionName(string args)'
                var r = methodInfo.Invoke(o, parameters);
                Console.WriteLine("Function Output - "+r);
            }

            return false;
        }
    }
}
