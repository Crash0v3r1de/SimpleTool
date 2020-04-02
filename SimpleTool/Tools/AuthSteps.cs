using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SimpleTool.Workers;

namespace SimpleTool.Tools
{
    public class AuthSteps : IDisposable
    {
        private bool Step1Done = false;
        private bool Step2Done = false;
        private bool Step3Done = false;
        private bool Step4Done = false;
        private int bytesRead = 0;

        //public bool Step1Valid(int bytes, NetworkStream nwStream, string dataRecieved, byte[] buffer)
        //{
        //    // Read response
        //    bytesRead = nwStream.Read(buffer, 0, clientConnection.ReceiveBufferSize);
        //    WorkQueue.AddBytes(buffer.Length);
        //    dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
        //    Debug.WriteLine("Step 1 - Received : " + dataReceived);
        //}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
            }
            // free native resources if there are any.
        }

    }
}
