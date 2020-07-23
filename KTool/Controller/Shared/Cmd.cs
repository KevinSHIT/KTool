using System.Collections.Generic;
using System.Diagnostics;

namespace KTool.Controller.Shared
{
    class Cmd
    {
        public static List<string> GetOutput(string app, string arg)
        {
            var l = new List<string>();
            using (var process = new Process())
            {
                process.StartInfo.FileName = app;
                process.StartInfo.Arguments = arg;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;

                process.Start();

                string output = process.StandardOutput.ReadToEnd();

                if (string.IsNullOrWhiteSpace(output) == false)
                    l.Add(output.Trim());

                process.WaitForExit();
                process.Close();
            }
            return l;
        }
    }
}
