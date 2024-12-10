using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCommandLinux
{
    internal class CommandWriter
    {
        public void WriteCmd(List<string> list, int lineLength)
        {
            using (var outStream = File.Create(@"alan.sh"))
            using (var sw = new StreamWriter(outStream))
            {
                string str = "#!/bin/bash";
                sw.WriteLine(str);

                foreach (string file in list)
                {
                    string fileName = Path.GetFileName(file);
                    string space = new string(' ', lineLength - fileName.Length);
                    str = $"mv \"{fileName}\"{space} \"{fileName}\"";
                    sw.WriteLine(str);
                }

                sw.Close();
            }

            ChangePermissions();

            Console.WriteLine("Finished...");
        }

        internal void ChangePermissions()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            string script = $"{currentDirectory}/alan.sh";

            File.SetUnixFileMode(script, UnixFileMode.UserRead | UnixFileMode.UserWrite | UnixFileMode.UserExecute | UnixFileMode.GroupRead | UnixFileMode.GroupExecute | UnixFileMode.OtherRead | UnixFileMode.OtherExecute);            
        }

    }
}