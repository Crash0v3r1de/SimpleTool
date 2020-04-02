using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTool.Encryption
{
    public class RSAHandler
    {
        public string EncryptString(string data)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            byte[] encBytes = RSA.Encrypt(Encoding.ASCII.GetBytes(data), false);
            return Encoding.ASCII.GetString(encBytes);
        }
        public string DecryptString(string data)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            byte[] encBytes = RSA.Decrypt(Encoding.ASCII.GetBytes(data), false);
            return Encoding.ASCII.GetString(encBytes);
        }
    }
}
