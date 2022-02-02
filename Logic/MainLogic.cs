using System.Windows.Forms;
using System;

namespace GordoLagTool
{
    static class MainLogic
    {
        //=-=-=-=-=-
        //Setup, Start and Stop Lag Functions
        //=-=-=-=-=-

        public static bool lagging = false;
        public static float MIN_FPS = 2;
        public static float MAX_FPS = 60;
        public static int MAIN_BUTTON = 0xA0;

        public static void Setup()
        {
            lagging = false;
            Application.EnableVisualStyles();
            Application.Run(new StartScreen());
        }

        public static void StartLag()
        {
            Console.WriteLine("StartLag");
            lagging = true;
            GameMemory.ins.WriteFPS(MIN_FPS);
        }

        public static void StopLag()
        {

            GameMemory.ins.WriteFPS(MAX_FPS);
            lagging = false;
        }
    }
}
