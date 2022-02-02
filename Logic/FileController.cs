using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System;

namespace GordoLagTool
{
    static class FileController
    {
        public static string fileExpName;
        public static string gameFilesFolderName;
        //public static string applicationDir;

        /// <summary>
        /// Return file names inside directory
        /// </summary>
        public static string[] GetFileEntries()
        {
            var configDirectory = Path.Combine(Application.StartupPath, gameFilesFolderName);
            if (!Directory.Exists(configDirectory))
            {
                Directory.CreateDirectory(configDirectory);
                return null;
            }

            return Directory.GetFileSystemEntries(configDirectory, fileExpName);
        }
        /// <summary>
        /// Remove Path From Path array and return only the file names.
        /// </summary>
        public static string[] RemovePathFromString(string[] path)
        {
            var result = new string[path.Length];
            int x = 0;
            foreach (var item in path)
            {
                result[x] = Path.GetFileName(path[x]);
                x++;
            }
            return result;
        }

        public static GameInfo ReadGameInfoFromFile(string fileName)
        {
            var gameFilesFolder = Path.Combine(Application.StartupPath, gameFilesFolderName);
            var test1 = Path.Combine(gameFilesFolder, fileName);
            var test2 = File.ReadAllText(test1);
            return JsonSerializer.Deserialize<GameInfo>(test2);
        }
    }
}
