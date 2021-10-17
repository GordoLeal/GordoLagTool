using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace GordoLagTool
{
    class GameMemory
    {
        public static GameMemory ins;

        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;
        const string SPONGE_NAME = "SpongeBob";

        private RevisionList.GameRevision REV_INFO;
        
        IntPtr wPointer;
        int processId = 0;
        Process gameProccess;
        IntPtr openProcessHandler;
        ProcessModuleCollection allGameMemoryModules;
        ProcessModule gameMainModule;
        IntPtr baseAddress;
        IntPtr finalAddress;

        int[] offsets = {
                 0x10,
                0x378
            }; //0x03414EA0 rev 603899

        public GameMemory()
        {
            ins = this;
        }

        public bool SetGameRevision(int rev)
        {
            RevisionList rl = new RevisionList();
            foreach(RevisionList.GameRevision i in rl.ReturnRevisionList())
            {
                if (i.revision == rev)
                {
                    REV_INFO = i;
                    return true;
                }
            }
            return false;
        }

        public bool DoSetup() 
        {

            wPointer = WinAPI.GetWindowHandlerByName(SPONGE_NAME);
            if (!(wPointer != IntPtr.Zero))
            {
                StartScreen.mainScreen.AddInfoToList("[ERROR] could not find the game handler with SPONGE_NAME. is the game open?");
                StartScreen.mainScreen.AddInfoToList("[INFO] Please close the lag tool and try again.");
                return false;
            }

            WinAPI.GetWindowThreadProcessId(wPointer, out processId);

            if (processId <1)
            {
                StartScreen.mainScreen.AddInfoToList("[WARNING] processId is less then 1? but why? program may crash");
            }

            gameProccess = Process.GetProcessById(processId);
            openProcessHandler = WinAPI.OpenProcess((PROCESS_VM_READ | PROCESS_VM_OPERATION | PROCESS_VM_WRITE), false, processId);


            allGameMemoryModules = gameProccess.Modules;
            gameMainModule = null;

            foreach (ProcessModule i in allGameMemoryModules)
            {
                if (i.ModuleName == "Pineapple-Win64-Shipping.exe")
                {
                    gameMainModule = i;
                    StartScreen.mainScreen.AddInfoToList("[INFO] Game Is: open! reading memory address");
                    break;
                }
                else
                {
                    StartScreen.mainScreen.AddInfoToList("[ERROR]!!! could not find game memory. is the game open?");
                    return false;
                }
            }

            baseAddress = (gameMainModule.BaseAddress + REV_INFO.MainPointer);
            finalAddress = FindMyAdress(openProcessHandler, baseAddress, REV_INFO.offsets);

            return true;
        }

        public bool WriteFPS(float fps)
        {
            var writerBuffer = new byte[4];
            writerBuffer = BitConverter.GetBytes(fps);
            int bytesWritten = 0;
            return WinAPI.WriteProcessMemory(openProcessHandler, finalAddress, writerBuffer, writerBuffer.Length, ref bytesWritten);
        }

        public bool ReadMemoryAddress(out byte[] buffer)
        {
            buffer = new byte[4];
            bool error = WinAPI.ReadProcessMemory(openProcessHandler, finalAddress, buffer, buffer.Length, out var read);

            StartScreen.mainScreen.AddInfoToList("[Debug] Did he read the memory? " + error + "| Last Error: " + Marshal.GetLastWin32Error());
            StartScreen.mainScreen.AddInfoToList("[Debug] Value found on memory: "+ BitConverter.ToSingle(buffer, 0));
            return error;
        }

        public static IntPtr FindMyAdress(IntPtr hProc, IntPtr ptr, int[] offsets)
        {
            var buffer = new byte[IntPtr.Size];
            foreach (int i in offsets)
            {
                WinAPI.ReadProcessMemory(hProc, ptr, buffer, buffer.Length, out var read);

                ptr = (IntPtr.Size == 4)
                ? IntPtr.Add(new IntPtr(BitConverter.ToInt32(buffer, 0)), i)
                : ptr = IntPtr.Add(new IntPtr(BitConverter.ToInt64(buffer, 0)), i);
            }
            return ptr;

        }

    }
}
