using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GordoLagTool
{
    class GameMemory
    {
        public static GameMemory ins;

        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;

        public GameInfo gameInfo;
        public PatchInfo patchInfo;

        IntPtr wPointer;
        int processId = 0;
        IntPtr openProcessHandler;
        ProcessModuleCollection allGameMemoryModules;
        ProcessModule gameMainModule;
        IntPtr baseAddress;
        IntPtr finalAddress;

        public GameMemory()
        {
            ins = this;
        }

        /// <summary>
        /// Setup for reading/writing memory
        /// </summary>
        public bool DoSetup()
        {
            Console.WriteLine(gameInfo.MainWindowName);
            wPointer = WinProcessAPI.GetWindowHandlerByName(gameInfo.MainWindowName);
            if (!(wPointer != IntPtr.Zero))
            {
                MessageBox.Show($"Game with handler {gameInfo.MainWindowName} could not be found, Remember to write correctly, including Caps");
                return false;
            }

            WinProcessAPI.GetWindowThreadProcessId(wPointer, out processId);

            if (processId < 1)
            {
                MessageBox.Show("ProcessID is less than 1 for some reason, program may crash?");
            }

            openProcessHandler = WinProcessAPI.OpenProcess((PROCESS_VM_READ | PROCESS_VM_OPERATION | PROCESS_VM_WRITE), false, processId); //Read process with permission to modify memory values
            allGameMemoryModules = Process.GetProcessById(processId).Modules;
            gameMainModule = null;

            foreach (ProcessModule i in allGameMemoryModules)
            {
                if (i.ModuleName == gameInfo.ProcessName)
                {
                    gameMainModule = i;
                    break;
                }
                else
                {
                    MessageBox.Show("Could not find game Memory, is the game open?");
                    return false;
                }
            }

            var offsetsInint = new Int32[patchInfo.Offsets.Length];
            for (int i = 0; i < patchInfo.Offsets.Length; i++)
            {
                offsetsInint[i] = Convert.ToInt32(patchInfo.Offsets[i], 16);
            }
            baseAddress = (gameMainModule.BaseAddress + Convert.ToInt32(patchInfo.MainPointer, 16));
            finalAddress = FindFinalAddress(openProcessHandler, baseAddress, offsetsInint);

            return true;
        }

        /// <summary>
        /// Write FPS value to finalAddress pointer on process Handler 
        /// </summary>
        /// <param name="fps"></param>
        public bool WriteFPS(float fps)
        {
            Console.WriteLine("writeFPS");
            var writerBuffer = new byte[4];
            writerBuffer = BitConverter.GetBytes(fps);
            int bytesWritten = 0;
            return WinProcessAPI.WriteProcessMemory(openProcessHandler, finalAddress, writerBuffer, writerBuffer.Length, ref bytesWritten);
        }

        /// <summary>
        /// Read FPS Value on finalAddress
        /// </summary>
        public bool ReadMemoryAddress(out byte[] buffer)
        {
            buffer = new byte[4];
            bool error = WinProcessAPI.ReadProcessMemory(openProcessHandler, finalAddress, buffer, buffer.Length, out var read);
            return error;
        }

        /// <summary>
        /// find final Memory Address by getting the BaseAddres from game module and doing the sum of every offset.
        /// </summary>
        public static IntPtr FindFinalAddress(IntPtr hProc, IntPtr ptr, int[] offsets)
        {
            var buffer = new byte[IntPtr.Size];
            foreach (int i in offsets)
            {
                WinProcessAPI.ReadProcessMemory(hProc, ptr, buffer, buffer.Length, out var read);

                ptr = (IntPtr.Size == 4)
                ? IntPtr.Add(new IntPtr(BitConverter.ToInt32(buffer, 0)), i)
                : ptr = IntPtr.Add(new IntPtr(BitConverter.ToInt64(buffer, 0)), i);
            }
            return ptr;
        }
    }
}
