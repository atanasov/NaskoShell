using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using Microsoft.Win32;
using System.Collections;

namespace NaskoShell
{
    public partial class MainForm : Form
    {
        string AppPath = System.Windows.Forms.Application.StartupPath;
        ArrayList ToDoList = new ArrayList();
        string[] ListImages;
        SQLiteDatabase db;
        public MainForm()
        {
            InitializeComponent();
            db = new SQLiteDatabase(AppPath + "\\data.s3db");
        }

        private void loadToDo()
        {
            string s = "";
            try
            {
                DataTable tasks;
                String query = "select task \"task\"";
                query += "from todo where done='false';";
                tasks = db.GetDataTable(query);
                if (tasks.Rows.Count != 0)
                {
                    s = tasks.Rows[0]["task"].ToString();
                }
                else s = "All done! Click to add new";
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
                this.Close();
            }
            
            ToDoButton.Text = s;
            ToDoButton.Left = (this.Width - ToDoButton.Width) / 2;
            ToDoButton.Top = (this.Height - ToDoButton.Height) / 2;
            ToDoButton.Show();    
        }

        private void doneToDo()
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("done", "true");
            try
            {
                db.Update("todo", data, String.Format("todo.task = '{0}'", ToDoButton.Text));
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
            }

        }

        private void getImages(string folder)
        {
            ListImages = System.IO.Directory.GetFiles(@folder, "*.jpg", System.IO.SearchOption.AllDirectories);
                    
        }


        private void makeDefaultShell(bool active)
        {
            if (active==true)
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\WinLogon", true);
                key.SetValue("Shell", AppPath+"\\NaskoShell.exe");
                key.Flush();
                key.Close();
            }
            else{
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\WinLogon", true);
                key.SetValue("Shell", "explorer.exe");
                key.Flush();
                 //   key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\WinLogon", false);
               // MessageBox.Show((string)(key.GetValue("Shell")));
                key.Close();
            }
        }

        private void LoadApps()
        {
            try
            {
                DataTable app;
                String query = "select path \"path\", attrib \"attrib\"";
                query += "from startup;";
                app = db.GetDataTable(query);
                // The results can be directly applied to a DataGridView control
                //recipeDataGrid.DataSource = recipe;
                
                // Or looped through for some other reason
                foreach (DataRow r in app.Rows)
                {
                    //MessageBox.Show(r["path"].ToString());
                    if (System.IO.File.Exists(r["path"].ToString()))
                    {
                        if (@r["attrib"].ToString()=="") System.Diagnostics.Process.Start(@r["path"].ToString());
                        else System.Diagnostics.Process.Start(@r["path"].ToString(), r["attrib"].ToString());
                    }
                }
	
                
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
                this.Close();
            }
        }

        private void CreateStartList()
        {

            string temp = "";
            string argum = "";
            string aStr = "";
            Int32 i1 = 0;
            Int32 len = 0;

            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("caption", "");
            data.Add("attrib", "");
            data.Add("path", "");
            data.Add("active", "");

            ManagementClass mangnmt = new ManagementClass("Win32_StartupCommand");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            foreach (ManagementObject strt in mcol)
            {
                if (strt["Location"].ToString() == "Startup")
                {
                    data["path"]=Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + strt["Command"].ToString();
                    data["attrib"] = "";
                    data["caption"] = strt["Command"].ToString();
                    data["active"] = "true";
                }
                else
                if (strt["Location"].ToString() != "Sidebar")
                {
                    aStr = strt["Command"].ToString();
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

                    data["path"] = temp.Replace("'", "''");//.Replace("%ProgramFiles%", System.Environment.GetEnvironmentVariable("%ProgramFiles%"));
                    data["attrib"] = argum.Replace("'", "''");// fileWriter.WriteLine(temp + "|" + argum);
                    data["caption"] = strt["Caption"].ToString();
                    data["active"] = "true";
                }
                //string[] lv = new String[4];
                //lv[0] = strt["Caption"].ToString();
                //lv[1] = strt["Location"].ToString();
                //lv[2] = strt["Command"].ToString();
                //lv[3] = strt["Description"].ToString();
                //listView1.Items.Add(new ListViewItem(lv, 0));

                try
                {
                    db.Insert("startup", data);
                }
                catch (Exception crap)
                {
                    MessageBox.Show(crap.Message);
                }

            }
            MessageBox.Show("List saved");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CreateStartList();
            //LoadApps();
            loadToDo();
            getImages("d:\\wallpapers");

            System.Random RandNum = new System.Random();
            this.BackgroundImage = new Bitmap(@ListImages[RandNum.Next(ListImages.Length - 1)]);
            this.BackgroundImageLayout = ImageLayout.Stretch;


            // makeDefaultShell(false);

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            PowerMenu.Show(SystemLink.Left,SystemLink.Top+20);
        }

        private void PowerDown(string s)
        {
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = false;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.Arguments = s;
            p.StartInfo.FileName = "shutdown.exe";
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            //string output = p.StandardOutput.ReadToEnd();
            //p.WaitForExit();
        }


        private void hibernateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hibernate
            PowerDown("/h"); 
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Restart
            PowerDown("/r"); 
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Shutdown
            PowerDown("/s"); 
        }

        private void ToDoButton_Click(object sender, EventArgs e)
        {
            ToDoButton.Hide();
            doneToDo();
            loadToDo();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToDoMenu.Show(TodoLink.Left, TodoLink.Top + 20);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //String inputMessage = System.Windows.Forms.InputDialogBox.Show("Enter Text:");
            
           AddToDoForm testDialog = new AddToDoForm();

           // Show testDialog as a modal dialog and determine if DialogResult = OK.
           if (testDialog.ShowDialog(this) == DialogResult.OK)
           {
              // Read the contents of testDialog's TextBox.
             // MessageBox.Show();
              Dictionary<String, String> data = new Dictionary<String, String>();
              data.Add("task", testDialog.ToDoText);
              data.Add("dueto", testDialog.ToDoDate.ToShortDateString());
              try
              {
                  db.Insert("todo", data);
              }
              catch (Exception crap)
              {
                  MessageBox.Show(crap.Message);
              }
           }
           else
           {
             // MessageBox.Show("Cancelled");
           }
           testDialog.Dispose();
        }

        private void setShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set naskoshell.exe as dafault shell and logout
            makeDefaultShell(true);
            PowerDown("/l"); 
        }

        private void resetWindowsShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set default explorer.exe shell
            makeDefaultShell(false);
            PowerDown("/l"); 
        }

        private void quitNaskoShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
