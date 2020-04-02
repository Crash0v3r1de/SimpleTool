using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTool.Lists;
using SimpleTool.Workers;

namespace SimpleTool.ToolWindows
{
    public partial class GlobalWorkUI : Form
    {
        private bool continueUpdate = true;
        public GlobalWorkUI()
        {
            InitializeComponent();
        }

        private void GlobalWorkUI_Load(object sender, EventArgs e)
        {
            Task.Run(() => { ListUpdate();});
        }

        private void ListUpdate()
        {
            while (continueUpdate)
            {
                for (int x = 0; x < WorkQueue.JobQueue.Count; x++)
                {
                    if (WorkQueue.JobQueue[x].ClientID.Contains("ALL"))
                    {
                        AddActiveItem(WorkQueue.JobQueue[x]);
                    }
                    else if(!WorkQueue.JobQueue[x].ClientID.Contains("ALL"))
                    {
                        AddOtherItem(WorkQueue.JobQueue[x]);
                    }
                }
                Thread.Sleep(900);
            }
            Debug.WriteLine("Queue refresh refresh STOPPED!");
        }

        private void AddActiveItem(Work work)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Work>(AddActiveItem), work);
                return;
            }

            if (lstActive.Items.Count == 0 & work.TimeSubmitted.Year > 2018)
            {
                lstActive.Items.Add($"All Clients | {work.WorkType} | {work.NameSpace} - {work.ClassName} - {work.FunctionName} | TimeStarted {work.TimeSubmitted.ToString()}");
            }
            else
            {
                for (int x = 0; x < lstActive.Items.Count; x++)
                {
                    var chk = (string)lstActive.Items[x];
                    if (!chk.Contains(work.TimeSubmitted.ToString()))
                    {
                        lstActive.Items.Add($"All Clients | {work.WorkType} | {work.NameSpace} - {work.ClassName} - {work.FunctionName} | TimeStarted {work.TimeSubmitted.ToString()}");
                    }
                }
            }

        }
        private void AddOtherItem(Work work)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Work>(AddOtherItem), work);
                return;
            }

            if (lstOther.Items.Count == 0 & work.TimeSubmitted.Year > 2018)
            {
                lstOther.Items.Add($"{work.ClientID} | {work.WorkType} | Sent? {work.Sent} - {work.TimeSent}");
            }
            else
            {
                for (int x = 0; x < lstOther.Items.Count; x++)
                {
                    var chk = (string)lstOther.Items[x];
                    if (!chk.Contains(work.TimeSubmitted.ToString()) & !chk.Contains(work.ClientID))
                    {
                        lstOther.Items.Add($"{work.ClientID} | {work.WorkType} | Sent? {work.Sent} - {work.TimeSent}");
                    }
                }
            }

            if (!lstOther.Items.Contains(work.TimeSubmitted))
            {
                lstOther.Items.Add($"{work.ClientID} | {work.WorkType} | Sent? {work.Sent} - {work.TimeSent}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            continueUpdate = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            continueUpdate = true;
            Task.Run(() => { ListUpdate(); });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (AllClientWorkUI wkUI = new AllClientWorkUI())
            {
                wkUI.ShowDialog();
            }
        }
    }
}
