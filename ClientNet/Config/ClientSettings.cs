using System;
using System.Collections.Generic;
using System.Text;
using ClientNet.Lists;
using ClientNet.Lists.Auth;

namespace ClientNet.Config
{
    public static class ClientSettings
    {
        public static int pNum = 991;
        public static int pFresh = 15; // Probly not needed
        public static string domainName = "127.0.0.1";
        public static bool KeepAlive = true;
        public static string ConnectionKey = "thisIsa_simpleTest-key";
        public static EncryptionKeys key { get; set; }
        public static bool AssignedKeys { get; set; }
        public static AuthSteps AuthStatus = new AuthSteps();
    }
}
