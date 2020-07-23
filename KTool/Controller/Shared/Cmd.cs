using System.Diagnostics;

namespace KTool.Controller.Shared
{
    class Cmd
    {
        public static string[] GetOutput(string app, string arg)
        {
            string s = string.Empty;
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
                    s = output.Trim();

                process.WaitForExit();
                process.Close();
            }
            return s.Split('\n');
        }
    }
}
