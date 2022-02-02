using System;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace GordoLagTool
{
    class WinKeyboardAPI

    {

        //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // === WINDOWS READ/HOOK KEYBOARD API ===
        //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_UP = 0x0101;
        private static IntPtr HookID = IntPtr.Zero;
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static LowLevelKeyboardProc LowLevelProc = HookCallback;
        /*
        [DllImport("user32")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk); */

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        //[DllImport("user32")]
        //private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [StructLayout(LayoutKind.Sequential)]
        public class KBDLLHOOKSTRUCT
        {
            public int vkCode;
            public int scanCode;
            public KBDLLHOOKSTRUCTFlags flags;
            public uint time;
            public UIntPtr dwExtraInfo;
        }

        [Flags]
        public enum KBDLLHOOKSTRUCTFlags : uint
        {
            LLKHF_EXTENDED = 0x01,
            LLKHF_INJECTED = 0x10,
            LLKHF_ALTDOWN = 0x20,
            LLKHF_UP = 0x80,
        }

        public static void SetupInputHook() // start hook to keyboard inputs
        {
            HookID = SetHook(LowLevelProc);
        }

        public static void RemoveInputHook() //Make sure to remove the keyboard hook or will can have memory leaks and other problems.
        {
            UnhookWindowsHookEx(HookID);
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) //call back to every single keyboard event and filter with code
        {
            
            if (nCode >= 0)
            {
                Console.WriteLine("Reading keyboard");
                KBDLLHOOKSTRUCT kbd = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));
                if (kbd.vkCode == MainLogic.MAIN_BUTTON && wParam == (IntPtr)WM_KEYDOWN && !MainLogic.lagging)
                {
                    MainLogic.StartLag();
                }else if(kbd.vkCode == MainLogic.MAIN_BUTTON && wParam == (IntPtr)WM_UP && MainLogic.lagging)
                {
                    MainLogic.StopLag();
                }
            }
            return CallNextHookEx(HookID, nCode, wParam, lParam);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

    }
}
