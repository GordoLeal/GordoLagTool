using System.Collections.Generic;

namespace GordoLagTool
{
    class GameInfo
    {
        public string GameName { get; set; }
        public string MainWindowName { get; set; }
        public string ProcessName { get; set; }
        public List<PatchInfo> PatchInfos { get; set; }
        public override string ToString()
        {
            return GameName;
        }
    }
}
