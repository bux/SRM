using System.Diagnostics;

namespace SRM.Logic.Helpers
{
    public static class ProcessHelper
    {
        public static void ExecuteProcess(string command)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c \"" + command + "\"");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = true;

            // *** Redirect the output ***
           // processInfo.RedirectStandardError = true;
           // processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            //var output = process.StandardOutput.ReadToEnd();
            //var error = process.StandardError.ReadToEnd();

            //exitCode = process.ExitCode;

            //Console.WriteLine(Directory.GetCurrentDirectory());
            //Console.WriteLine("output>>" + (string.IsNullOrEmpty(output) ? "(none)" : output));
            //Console.WriteLine("error>>" + (string.IsNullOrEmpty(error) ? "(none)" : error));
            //Console.WriteLine("ExitCode: " + exitCode, "ExecuteCommand");
            process.Close();
        }
    }
}
