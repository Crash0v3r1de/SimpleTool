using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SimpleTool.Lists;
using SimpleTool.Network;

namespace SimpleTool.Workers
{
    public static class WorkQueue
    {
        public static List<Work> JobQueue = new List<Work>();
        public static int TotalBytesProcessed = 0;

        public static void AddBytes(int byteAmount)
        {
            TotalBytesProcessed = TotalBytesProcessed + byteAmount;
        }
        public static bool WorkAssigned(string ID)
        {
            for (int x = 0; x < JobQueue.Count; x++)
            {
                if (JobQueue[x].ClientID == ID)
                {
                    if (!JobQueue[x].Sent)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static void SubmitJob(Work job)
        {
            if (!JobQueue.Contains(job))
            {
                JobQueue.Add(job);
            }
            else
            {
                Debug.WriteLine("ERROR ADDING JOB! | Work already in queue...");
            }
        }
        public static void StartQueueCleanup(bool wipeCompleted)
        {
            while (wipeCompleted)
            {
                for (int x = 0; x < JobQueue.Count; x++)
                {
                    if (JobQueue[x].ExecutedRemotely)
                    {
                        JobQueue.RemoveAt(x);
                    }
                }
                Thread.Sleep(900);
            }
        }
    }
}
