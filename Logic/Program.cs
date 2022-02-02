using System.Windows.Forms;

namespace GordoLagTool
{
    class Program
    {
        //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // === PROGRAM / MAIN START ===
        //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        public bool lagging = false;
        public float MIN_FPS = 2;
        public float MAX_FPS = 60;
        public int MAIN_BUTTON = 0xA0;

        static void Main(string[] args)
        {
            FileController.gameFilesFolderName = "GameFiles";
            FileController.fileExpName = "*.game";
            FileController.GetFileEntries();
            MainLogic.Setup();
            
        }
    }


}
