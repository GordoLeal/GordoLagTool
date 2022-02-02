using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace GordoLagTool
{
    //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    // === WINDOWS READ/WRITE MEMORY API ===
    //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

    class WinProcessAPI
    {      
        /// <summary>
        /// Get application processID by using the application Window Thread.
        /// </summary>
        /// <param name="hWnd">Window Handler</param>
        /// <param name="lpdwProcessId">output: process ID</param>
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        /// <summary>
        /// with process and memory Adresses, get value in byte and apply to that address.
        /// </summary>
        /// <param name="hProcess">Process Handler ID</param>
        /// <param name="lpBaseAddress"> The memory address you want to modify </param>
        /// <param name="lpBuffer"> byte array of the value</param>
        /// <param name="dwSize"> byte array size</param>
        /// <param name="lpNumberOfBytesWritten">i honestly don't know what this do, just set to 0</param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);


        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        //[DllImport("kernel32.dll")]
        //public static extern uint GetLastError();

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
    }
}
