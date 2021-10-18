using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace GordoLagTool
{
    class Program
    {
        public static Program ins;
        public bool lagging = false;

        public float MIN_FPS = 2;
        public float MAX_FPS = 60;
        public int MAIN_BUTTON = 0xA0;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Setup();
        }

        public void Setup()
        {
            lagging = false;
            ins = this;
            Application.EnableVisualStyles();
            Application.Run(new StartScreen());
        }

        public void StartLag()
        {
            StartScreen.mainScreen.AddInfoToList($"[INFO] FPS set to {MIN_FPS} f");
            GameMemory.ins.WriteFPS(MIN_FPS);
            lagging = true;
        }

        public void StopLag()
        {

            StartScreen.mainScreen.AddInfoToList($"[INFO] FPS set to {MAX_FPS} f");
            GameMemory.ins.WriteFPS(MAX_FPS);
            lagging = false;
        }
    }


}
