using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTool.Configs;
using SimpleTool.Tools;

namespace SimpleTool.Network.Auth
{
    class ClientAuth
    {
        public bool CheckAuth(string data,int step)
        {
            switch (step)
            {
                case 0:
                    return ClientIDCheck(data);
                case 1:
                    return ClientKeyValid(data);
                case 2:
                    return PassSaltValid(data);
                default:
                    Debug.WriteLine("CheckAuth Switch UNHANDLED!");
                    break;
            }

            Debug.WriteLine("CheckAuth switch statement exited without returning checks!");
            return false;
        }

        public string GetIP(string data)
        {
            byte[] splitBytes = Convert.FromBase64String(data);
            string[] splitStrings = Encoding.ASCII.GetString(splitBytes).Split(':');
            if (splitStrings[0] != null & splitStrings[1] != null)
            {
                return splitStrings[1];
            }
            else
            {
                return null;
            }
        }

        // Check if we can send the usable keys
        public bool SendUpdatedKeys(string data)
        {
            string decData = DecryptString(data);
            string[] split = decData.Split(':');
            if (split[1].Contains("true") || data.Contains("true"))
            {
                // VM reported
                if (ClientConfig.AntiVM)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }





        private string DecryptString(string encryptedData)
        {
            string decrypted;
            CryptoTool Crypto = new CryptoTool();
            decrypted = Crypto.DefaultDecrypt(encryptedData);
            return decrypted;
        }

        private bool ClientIDCheck(string base64String)
        {
            byte[] splitBytes = Convert.FromBase64String(base64String);
            string[] splitStrings = Encoding.ASCII.GetString(splitBytes).Split(':');
            if (splitStrings[0] != null & splitStrings[1] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ClientKeyValid(string key)
        {
            if (key == ClientConfig.connectionKey)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool PassSaltValid(string data)
        {
            // This should be sent as pass:salt
            string pass = data.Split(':')[0];
            string salt = data.Split(':')[1];
            if (pass.Contains(StaticKeys.SHAPass) && salt.Contains(StaticKeys.SHASalt))
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
