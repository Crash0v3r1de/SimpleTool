using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ClientNet.Encryption
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
