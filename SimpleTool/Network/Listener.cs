using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SimpleTool.Configs;
using SimpleTool.Enums;
using SimpleTool.Lists;
using SimpleTool.Network.Auth;
using SimpleTool.Tools;
using SimpleTool.Workers;
using AuthSteps = SimpleTool.Tools.AuthSteps;

namespace SimpleTool.Network
{
    public class Listener
    {
        TcpClient clientConnection;
        string clNo;
        private Random rng = new Random();

        public void startClient(TcpClient inClientSocket, string clientName)
        {
            // This is ran once a client connects! Auth should be handled from here/inside the doChat function

            this.clientConnection = inClientSocket;
            this.clNo = clientName;


            Thread ctThread = new Thread(StartSlave); // Creates the thread for current new connection
            ctThread.Start(); // Start thread
        }


        // Creates a new thread per connection from this function
        // This function is the actual communication with the specific connection
        private void StartSlave()
        {
            CryptoTool crypto = new CryptoTool();
            //---Slave master list creation and assignment---\\
            Slave client = new Slave();
            client.AssignedKeys = false;
            client.ConnectionKey = ClientConfig.connectionKey;
            if (clientConnection.Connected)
            {
                client.OnlineStatus = OnlineInfo.Online; // Assign online
            }
            else
            {
                client.OnlineStatus = OnlineInfo.Offline; // Assign offline
            }
            client.Authorized = false;

            //---Local variable creation---\\
            bool Authing = true;
            bool Authed = false;
            bool KeepAlive = true;
            int AuthStep = 1;
            int clientListNumber = 0; // make it 0 so we can handle things better
            int bytesRead = 0; // Byte count from stream read
            string dataReceived; // string of byte data recieved
            byte[] dataSent; // Byte data to send to client - probly wont be used
            NetworkStream nwStream = clientConnection.GetStream(); // Start connection stream
            byte[] buffer = new byte[clientConnection.ReceiveBufferSize];
            // SslStream slStream = new SslStream(nwStream); // Iniate stream for future use

            // Mess with secure encrypted stream stuff later
            // SslStream sStream = new SslStream(nwStream);

            try
            {
                while (KeepAlive) // keep looping while we tell it to
                {

                    if (!Authed & Authing)
                    {
                      

                        //---read incoming stream---\\
                        bytesRead = nwStream.Read(buffer, 0, clientConnection.ReceiveBufferSize);
                        //---convert the data received into a string---\\
                        dataReceived = crypto.DefaultDecrypt(Encoding.ASCII.GetString(buffer, 0, bytesRead)); // Decrypt data to string
                        WorkQueue.AddBytes(buffer.Length);
                        if (ClientConfig.Debug) Logger.SaveDebug("==================START OF NEW CLIENT VERIFICATION================");
                        if (ClientConfig.Debug) Logger.SaveDebug($"NEW CLIENT! | ID: {dataReceived} - AUTH SEQUENCE STARTED!");
                        Debug.WriteLine("Step 0 - Received : " + dataReceived);
                        client.ClientID = dataReceived;
                        ClientHandler.AddClient(client);
                        client.SlaveListAssignment = ClientHandler.AssignClientListCount(client.ClientID);
                        clientListNumber = client.SlaveListAssignment;
                        if (clientListNumber == 0)
                        {
                            // Issue handling the list number assignment code
                            //TODO: What/how do we handle this?
                        }
                        //---Sending acknowledge---\\
                        dataSent = null;
                        dataSent = Encoding.ASCII.GetBytes(crypto.DefaultEncrypt("VALID")); // encrypt to send
                        WorkQueue.AddBytes(dataSent.Length);
                        nwStream.Write(dataSent, 0, dataSent.Length);
                        Debug.WriteLine("Telling client step 0 valid...");
                        dataSent = null;
                        bytesRead = 0;


                        //---Auth sequence loop handling until pass or failure---\\
                        while (Authing & AuthStep != 0)
                        {
                            ClientAuth auth = new ClientAuth();
                            if (String.IsNullOrWhiteSpace(ClientHandler.Slaves[clientListNumber].IP))
                            {
                                ClientHandler.Slaves[clientListNumber].IP = auth.GetIP(dataReceived);
                            }

                            //using (AuthSteps step = new AuthSteps())
                            //{

                                switch (AuthStep)
                                {
                                    case 1:
                                        // Read response
                                        bytesRead = nwStream.Read(buffer, 0, clientConnection.ReceiveBufferSize);
                                        WorkQueue.AddBytes(buffer.Length);
                                        dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                                        Debug.WriteLine("Step 1 - Received : " + dataReceived);
                                        if (ClientConfig.Debug) Logger.SaveDebug($"Step 1 started for client {ClientHandler.Slaves[clientListNumber].ClientID}");
                                        if (auth.CheckAuth(crypto.DefaultDecrypt(dataReceived), 1))
                                        {
                                            AuthStep = 2;
                                            //---sending back valid step 1---\\
                                            dataSent = null;
                                            dataSent = Encoding.ASCII.GetBytes(crypto.DefaultEncrypt("VALID"));
                                            nwStream.Write(dataSent, 0, dataSent.Length);
                                            WorkQueue.AddBytes(dataSent.Length);
                                            Debug.WriteLine("Telling client step 1 valid...");
                                            dataSent = null;
                                            ClientHandler.Slaves[clientListNumber].AuthStatus.Step1Done = true;
                                            if (ClientConfig.Debug) Logger.SaveDebug($"Step 1 verified | client {ClientHandler.Slaves[clientListNumber].ClientID}");
                                        }
                                        else
                                        {
                                            Logger.SaveDebug($"Step 1 FAILED! for client {ClientHandler.Slaves[clientListNumber].ClientID}");
                                            AuthStep = 0; // Deny
                                            Authing = false;
                                            Authed = false;
                                            clientConnection.Close();
                                            if (ClientConfig.Debug) Logger.SaveDebug($"Client disconnected and slave list updated for client!");
                                            ClientHandler.Slaves[clientListNumber].Authorized = false;
                                            ClientHandler.Slaves[clientListNumber].OnlineStatus = OnlineInfo.BadLogin;
                                        }
                                        break;
                                    case 2:
                                        // Read response
                                        bytesRead = nwStream.Read(buffer, 0, clientConnection.ReceiveBufferSize);
                                        dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                                        WorkQueue.AddBytes(buffer.Length);
                                        Debug.WriteLine("Step 2 - Received : " + dataReceived);
                                        if (ClientConfig.Debug) Logger.SaveDebug($"Step 2 started for client {ClientHandler.Slaves[clientListNumber].ClientID}");

                                        // Process response
                                        if (auth.CheckAuth(crypto.DefaultDecrypt(dataReceived), 2))
                                        {
                                            dataSent = null;
                                            AuthStep = 3;
                                            dataSent = Encoding.ASCII.GetBytes(crypto.DefaultEncrypt("VALID"));
                                            nwStream.Write(dataSent, 0, dataSent.Length);
                                            WorkQueue.AddBytes(dataSent.Length);
                                            Debug.WriteLine("Telling client step 2 valid...");
                                            dataSent = null;
                                            ClientHandler.Slaves[clientListNumber].AuthStatus.Step2Done = true;
                                            if (ClientConfig.Debug) Logger.SaveDebug($"Step 2 VALID for client {ClientHandler.Slaves[clientListNumber].ClientID}");
                                        }
                                        else
                                        {
                                            AuthStep = 0; // Deny
                                            Authing = false;
                                            Authed = false;
                                            clientConnection.Close();
                                            ClientHandler.Slaves[clientListNumber].Authorized = false;
                                            ClientHandler.Slaves[clientListNumber].OnlineStatus = OnlineInfo.BadLogin;
                                            if (ClientConfig.Debug) Logger.SaveDebug($"Step 2 FAILED | closed connection and updated slave list.");
                                        }
                                        break;
                                    case 3:
                                        // Read response
                                        //bytesRead = nwStream.Read(buffer, 0, clientConnection.ReceiveBufferSize);
                                        //dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                                        //Debug.WriteLine("Step 3 - Received : " + dataReceived);

                                        if (ClientConfig.Debug) Logger.SaveDebug($"Step 3 started for client {ClientHandler.Slaves[clientListNumber].ClientID}");

                                        // Process response
                                        if (ClientConfig.AssignNewKeys)
                                        {
                                            dataSent = null;
                                            EncryptionKeys newKeys = ClientConfig.EncryptionKeys[Rando.GetNumber(ClientConfig.EncryptionKeys.Count)];
                                            ClientHandler.Slaves[clientListNumber].key = newKeys;
                                            dataSent = Encoding.ASCII.GetBytes(crypto.DefaultEncrypt($"KEYS:{newKeys.Password}:{newKeys.Salt}:{newKeys.XorKey}:{newKeys.VlKey}"));
                                            nwStream.Write(dataSent, 0, dataSent.Length);
                                            WorkQueue.AddBytes(dataSent.Length);
                                            ClientHandler.Slaves[clientListNumber].AuthStatus.Step3Done = true;
                                            ClientHandler.Slaves[clientListNumber].Authorized = true;
                                            if (ClientConfig.Debug) Logger.SaveDebug($"Step 3 COMPLETED for client {ClientHandler.Slaves[clientListNumber].ClientID}");
                                            bytesRead = nwStream.Read(buffer, 0, clientConnection.ReceiveBufferSize);
                                            dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                                            WorkQueue.AddBytes(buffer.Length);
                                            if (dataReceived.Contains("UPDATED"))
                                            {
                                                Authed = true;
                                                Authing = false;
                                            }
                                            else
                                            {
                                                // Bad sequence sent, close connection
                                                AuthStep = 0; // Deny
                                                Authing = false;
                                                Authed = false;
                                                clientConnection.Close();
                                                ClientHandler.Slaves[clientListNumber].Authorized = false;
                                                ClientHandler.Slaves[clientListNumber].OnlineStatus = OnlineInfo.Unknown;
                                                if (ClientConfig.Debug) Logger.SaveDebug($"Step 3 FAILED | Connection closed and list updated | ERROR UPDATING KEYS!");
                                            }
                                        }
                                        else
                                        {
                                            // Bad sequence sent, close connection
                                            AuthStep = 0; // Deny
                                            Authing = false;
                                            Authed = false;
                                            clientConnection.Close();
                                            ClientHandler.Slaves[clientListNumber].Authorized = false;
                                            ClientHandler.Slaves[clientListNumber].OnlineStatus = OnlineInfo.VMDenied;
                                            if (ClientConfig.Debug) Logger.SaveDebug($"Step 3 FAILED | Connection closed and list updated");
                                        }
                                        break;
                                    default:
                                        // Bad sequence sent, close connection
                                        AuthStep = 0; // Deny
                                        Authing = false;
                                        Authed = false;
                                        clientConnection.Close();
                                        ClientHandler.Slaves[clientListNumber].Authorized = false;
                                        ClientHandler.Slaves[clientListNumber].OnlineStatus = OnlineInfo.Error;
                                        if (ClientConfig.Debug) Logger.SaveDebug($"Default auth switch hit, ERROR occured!");
                                        break;
                                }

                            //}

                            
                        } // Authing loop

                        Debug.WriteLine($"Auth Status processed: {Authed} | Auth sequence processing is complete");
                    }
                    else if (Authed & !Authing) // Process this after client has been authorized
                    {
                        // read response
                        //bytesRead = nwStream.Read(buffer, 0, clientConnection.ReceiveBufferSize);
                        //dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        // Send response
                        //dataSent = null;
                        //dataSent = Encoding.ASCII.GetBytes(crypto.DefaultEncrypt("VALID"));
                        //nwStream.Write(dataSent, 0, dataSent.Length);
                        for (var x = 0; x < WorkQueue.JobQueue.Count; x++)
                        {
                            if (WorkQueue.JobQueue[x] != null) // Validate we haven't grabbed a junk list item
                            {
                                if (WorkQueue.JobQueue[x].ClientID == ClientHandler.Slaves[clientListNumber].ClientID & !WorkQueue.JobQueue[x].Sent) // Client has work in queue that isn't sent yet
                                { // Pending work, let's send it

                                    switch (WorkQueue.JobQueue[x].WorkType)
                                    {
                                        case WorkType.Kill:
                                        default:
                                            if(ClientConfig.Debug)Logger.SaveDebug($"JobQueue item {x} could not be handled for client {WorkQueue.JobQueue[x].ClientID}({ClientHandler.Slaves[clientListNumber].ClientID})");
                                            Debug.WriteLine($"JobQueue item {x} could not be handled for client {WorkQueue.JobQueue[x].ClientID}({ClientHandler.Slaves[clientListNumber].ClientID})");
                                            break;
                                    }

                                }
                            }
                        }

                    }
                    else
                    {
                        // Unknown not authed or not failed to auth either
                        KeepAlive = false;
                    }

                }// end of keepalive loop

                ClientHandler.Slaves[clientListNumber].OnlineStatus = OnlineInfo.Offline;
                Debug.WriteLine("KEEP ALIVE OFF AND SLAVE THREAD ENDING!");
                Logger.SaveDebug("KEEP ALIVE OFF AND SLAVE THREAD ENDING!");

            }
            catch (Exception ex)
            {
                ClientHandler.Slaves[clientListNumber].OnlineStatus = OnlineInfo.Offline;
                Debug.WriteLine("ERROR! >> " + ex);
            }
            
        }

        private string GetSendingFormat(int clientNumber,WorkType type,Work work)
        {
            // Correct data sent is in this format
            // function_enum:arguments_if-needed:string_data_of_something
            // custom handling AKA plugin handling
            // custom:byte_data:class_name:method_name(aka function name)
            StringBuilder sb = new StringBuilder();
            switch (type)
            {
                case WorkType.Kill:
                    sb.Append(type);
                    sb.Append(":");
                    sb.Append("NONE");
                    sb.Append(":");
                    sb.Append("NONE");
                    return sb.ToString();
                    break;
                case WorkType.CompRestart:
                    sb.Append(type);
                    sb.Append(":");
                    sb.Append("NONE");
                    sb.Append(":");
                    sb.Append("NONE");
                    break;
                case WorkType.Lock:
                    sb.Append(type);
                    sb.Append(":");
                    sb.Append("NONE");
                    sb.Append(":");
                    sb.Append("NONE");
                    break;
                case WorkType.Restart:
                    sb.Append(type);
                    sb.Append(":");
                    sb.Append("NONE");
                    sb.Append(":");
                    sb.Append("NONE");
                    break;
                case WorkType.Stop:
                    sb.Append(type);
                    sb.Append(":");
                    sb.Append("NONE");
                    sb.Append(":");
                    sb.Append("NONE");
                    break;
                default:
                    break;
            }


            return null;
        }

    }
}
