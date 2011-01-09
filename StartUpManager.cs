using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;

namespace NaskoShell
{
    class StartUpManager
    {
  /*      STARTUP ORDER FOR WINDOWS NT4/2000/XP

BootExecute
HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\BootExecute
Services
User enters a password and logon to the system
UserInit
HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\UserInit
Shell
HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\Shell
All Users-RunOnce
HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\RunOnce
All Users-Run
HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run
All Users-RunOnceEx
HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\RunOnceEx
All Users-RunEx
HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\RunEx
Current User-RunOnce
HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce
Current User-Run
HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run
Current User-RunOnceEx
HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnceEx
Current User-RunEx
HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunEx
Common Startup Folder
Startup Folder
        Wow6432Node
   * 
   * HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\RunServicesOnce 

HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\RunServices 

<Logon Prompt> 

HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\RunOnce 

HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run 

HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run 

StartUp Folder 

HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce
   */
        private static SQLiteDatabase db;
        public StartUpManager(SQLiteDatabase database)
        {
            db = database;
        }

        public delegate void AppStarted(object myObject);

        public event AppStarted onReady;
        

        
                                             
        public void GetAllApps()
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("name", "");
            data.Add("attrib", "");
            data.Add("path", "");
            data.Add("active", "");

            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", false);
            //MessageBox.Show(key.ValueCount.ToString());
            foreach (string appName in key.GetValueNames()) 
                {
                        try
                        {
         
              //              MessageBox.Show((string)key.GetValue(appName));
                            ParsePath(appName, (string)key.GetValue(appName),ref data);
                            db.Insert("startup", data);
                        }
                    catch (Exception ex) 
                        {
                    
                        }
                
                }
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", false);
            //MessageBox.Show(key.ValueCount.ToString());
            foreach (string appName in key.GetValueNames())
            {
                try
                {

                //    MessageBox.Show((string)key.GetValue(appName));
                    ParsePath(appName, (string)key.GetValue(appName), ref data);
                    db.Insert("startup", data);
                }
                catch (Exception ex)
                {

                }

            }
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", false);
            //MessageBox.Show(key.ValueCount.ToString());
            foreach (string appName in key.GetValueNames())
            {
                try
                {

              //       MessageBox.Show((string)key.GetValue(appName));
                    ParsePath(appName, (string)key.GetValue(appName), ref data);
                    db.Insert("startup", data);
                }
                catch (Exception ex)
                {

                }

            }
            
            DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
            FileInfo[] links = di.GetFiles("*.lnk");
            foreach (FileInfo fi in links)
            {
                data["path"] = fi.FullName;// temp.Replace("'", "''");//Environment.ExpandEnvironmentVariables("%ProgramFiles%") Replace("%ProgramFiles%", System.Environment.GetEnvironmentVariable("%ProgramFiles%"));
                data["name"] = fi.Name;//name;
                data["attrib"] = "";// argum.Replace("'", "''");// fileWriter.WriteLine(temp + "|" + argum);
                data["active"] = "true";
                db.Insert("startup", data);
            }
            //key.Flush();
            //   key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\WinLogon", false);
            // MessageBox.Show((string)(key.GetValue("Shell")));
            
             
             key.Close();

        }


        public void StartApps()
        {
            try
            {
                DataTable AppList;
                String query = "select path \"path\", attrib \"attrib\"";
                query += "from startup where active='true';";
                AppList = db.GetDataTable(query);
                // The results can be directly applied to a DataGridView control
                //recipeDataGrid.DataSource = recipe;

                // Or looped through for some other reason
                foreach (DataRow r in AppList.Rows)
                {
                    //MessageBox.Show(r["path"].ToString());
                    if (System.IO.File.Exists(r["path"].ToString()))
                    {
                        if (@r["attrib"].ToString() == "") System.Diagnostics.Process.Start(@r["path"].ToString());
                        else System.Diagnostics.Process.Start(@r["path"].ToString(), r["attrib"].ToString());
                    }
                }
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
            }
            onReady(this);
        }

        private void Enable(string name)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("active", "true");
            try
            {
                db.Update("startup", data, String.Format("startup.name = '{0}'", name));
                //return true;
            }
            catch (Exception crap)
            {
                //return false;
            }
        }

        private void Disable(string name)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("active", "false");
            try
            {
                db.Update("startup", data, String.Format("startup.name = '{0}'", name));
                //return true;
            }
            catch (Exception crap)
            {
                //return false;
            }
        }
        
        private void ParsePath(string name, string aStr, ref Dictionary<String, String> data)
        {
            string temp = "";
            string argum = "";
            Int32 i1 = 0;
            Int32 len = 0;

               if (aStr.StartsWith("\""))
            {

                i1 = aStr.IndexOf("\"", 2);
                len = aStr.Length;
                if (i1 + 1 < len)
                {
                    temp = aStr.Substring(1, i1 - 1);

                    argum = aStr.Substring(i1 + 1, len - i1 - 1);
                }
                else
                {
                    temp = aStr.Substring(1, i1 - 1);
                    argum = "";
                }

            }
            else
            {
                i1 = aStr.IndexOf(".exe");
                len = aStr.Length;
                if (i1 + 4 == len)
                {
                    temp = aStr;
                    argum = "";
                }
                else
                {
                    temp = aStr.Substring(0, i1 + 4);
                    argum = aStr.Substring(i1 + 5, len - i1 - 5);
                }
            }

            if (temp.StartsWith("%"))
            {
                temp = System.Environment.ExpandEnvironmentVariables(temp);
            }
            //MessageBox.Show(aStr+" = " + temp+ " + " + argum);
            data["path"] = temp.Replace("'", "''");//Environment.ExpandEnvironmentVariables("%ProgramFiles%") Replace("%ProgramFiles%", System.Environment.GetEnvironmentVariable("%ProgramFiles%"));
            data["name"] = name;
            data["attrib"] = argum.Replace("'", "''");// fileWriter.WriteLine(temp + "|" + argum);
            data["active"] = "true";

        }

    }
}
