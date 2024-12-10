using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCommandLinux
{
    internal class FileManager
    {
        private readonly HashSet<string> validExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            ".mp3", ".flac", ".wma", ".ape", ".wav",
            ".m4a", ".shn", ".opus", ".ogg", ".avi",
            ".chm", ".pdf", ".mov", ".ts", ".mkv",
            ".mp4", ".wmv", ".flv", ".mobi", ".epub",
            ".m4b", ".zip"
        };

        public List<string> GetFileList(string directory)
        {
            var fileList = new List<string>();

            try
            {
                var files = Directory.GetFiles(directory, "*.*");

                
                foreach (var file in files)
                {
                    var extension = Path.GetExtension(file);
                    if (validExtensions.Contains(extension))
                    {
                        fileList.Add(file);
                    }
                }
                
                fileList = SortFileList(fileList);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e);
            }

            return fileList;
        }

        public int GetLongestLine(List<string> list)
        {
            int len = 0;

            foreach (string line in list)
            {
                int fileNameLength = Path.GetFileName(line).Length;
                if (fileNameLength > len)
                {
                    len = fileNameLength;
                }
            }

            return len;
        }

        internal List<string> SortFileList(List<string> list)
        {
            List<string> newList = new List<string>();

            foreach (string line in list)
            {
                string name = Path.GetFileName(line);
                newList.Add(name);
            }

            newList.Sort();

            return newList;
        }
    }    
}