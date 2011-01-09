using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
namespace NaskoShell
{
    class SystemManager
    {
        private string AppPath="";
        public SystemManager(string path)
        {
            AppPath = path;
        }

        public void System(string s)
        {
            switch (s)
            {
                case "hibernate":
                    Application.SetSuspendState(PowerState.Hibernate, true, true);
                    break;
                case "standby":
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                    break;
                case "logoff":
                    WinApi.ExitWindowsEx(0, 0);
                    break;
                case "restart":
                    WinApi.ExitWindowsEx(2, 0);
                    break;
                case "shutdown":
                    WinApi.ExitWindowsEx(1, 0);
                    break;
            }
            // Start the child process.
            //Process p = new Process();
            // Redirect the output stream of the child process.
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.CreateNoWindow = false;
            //p.StartInfo.RedirectStandardOutput = false;
            //p.StartInfo.Arguments = s;
            //p.StartInfo.FileName = "shutdown.exe";
            //p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            //string output = p.StandardOutput.ReadToEnd();
            //p.WaitForExit();

        }

        public void SetDefaultShell(bool active)
        {
            if (active == true)
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\WinLogon", true);
                key.SetValue("Shell", AppPath + "\\NaskoShell.exe");
                key.Flush();
                key.Close();
            }
            else
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\WinLogon", true);
                key.SetValue("Shell", "explorer.exe");
                key.Flush();
                //   key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\WinLogon", false);
                // MessageBox.Show((string)(key.GetValue("Shell")));
                key.Close();
            }
        }

    }
}
 