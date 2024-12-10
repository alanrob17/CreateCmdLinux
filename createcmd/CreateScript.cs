using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace CreateCommandLinux
{
    public class CreateScript
    {
        public static int Main(string[] args)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var fileManager = new FileManager();
            var commandWriter = new CommandWriter();

            var fileList = fileManager.GetFileList(currentDirectory);
                        
            var longestLineLength = fileManager.GetLongestLine(fileList);

            commandWriter.WriteCmd(fileList, longestLineLength);

            return 0;
        }
    }
}