namespace GordoLagTool
{
    class PatchInfo
    {
        public string GameVersion { get; set; }
        public  string[] Offsets { get; set; }
        public string MainPointer { get; set; }
        public override string ToString()
        {
            return GameVersion;
        }
    }
}
