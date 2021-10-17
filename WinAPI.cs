using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace GordoLagTool
{
    class WinAPI
    {
        // Windows API - Memoria e detectar Inputs
        //Memory Control functions

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);


        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        public static IntPtr GetWindowHandlerByName(string winName)
        {

            IntPtr hWnd = IntPtr.Zero;
            foreach (var pList in Process.GetProcesses())
            {
                if (pList.MainWindowTitle.Contains(winName))
                {
                    hWnd = pList.MainWindowHandle;
                }
            }
            return hWnd;
        }

        //Inputs 



    }
}
