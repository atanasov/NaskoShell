using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;

namespace NaskoShell
{
    public partial class MainForm : Form
    {
        struct WindowData
        {
            public IntPtr hwnd;
            public string title;
        }

        string AppPath = System.Windows.Forms.Application.StartupPath;
        private static SQLiteDatabase db;
        private ToDoManager todo;
        private BackgroundSwitcher bkg;
        private StartUpManager startup;
        private SystemManager pc;
        private ProcessManager apps;

        private int uMsgNotify;

            
        public delegate void InvokeDelegate();

        public MainForm()
        {
            InitializeComponent();
            SetMinimizedMetrics();

            WinApi.SetTaskmanWindow(this.Handle);
            WinApi.RegisterShellHookWindow(this.Handle);
            uMsgNotify = WinApi.RegisterWindowMessage("SHELLHOOK");
           
         
           
            db = new SQLiteDatabase(AppPath + "\\data.s3db");
            todo = new ToDoManager(db);
            startup = new StartUpManager(db);
            startup.onReady += new StartUpManager.AppStarted(AppsReady);
            bkg = new BackgroundSwitcher(this);
            pc = new SystemManager(AppPath);
            apps = new ProcessManager();
        }

        ~MainForm()
        {
            WinApi.DeregisterShellHookWindow(this.Handle);
        }

       

        private void SetMinimizedMetrics()
        {
            WinApi.MinimizedMetrics mm = new WinApi.MinimizedMetrics
            {
                cbSize = (uint)Marshal.SizeOf(typeof(WinApi.MinimizedMetrics))
            };

            IntPtr mmPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(WinApi.MinimizedMetrics)));

            try
            {
                Marshal.StructureToPtr(mm, mmPtr, true);
                WinApi.SystemParametersInfo(WinApi.SPI.SPI_GETMINIMIZEDMETRICS, mm.cbSize, mmPtr, WinApi.SPIF.None);

                mm.iArrange |= WinApi.MinimizedMetricsArrangement.Hide;
                Marshal.StructureToPtr(mm, mmPtr, true);
                WinApi.SystemParametersInfo(WinApi.SPI.SPI_SETMINIMIZEDMETRICS, mm.cbSize, mmPtr, WinApi.SPIF.None);
            }
            finally
            {
                Marshal.DestroyStructure(mmPtr, typeof(WinApi.MinimizedMetrics));
                Marshal.FreeHGlobal(mmPtr);
            }
        }
        
        protected override void WndProc(ref System.Windows.Forms.Message m)
     
        {
            IntPtr handle;
            if (m.Msg == uMsgNotify)
            {
                switch (m.WParam.ToInt32())
                {
                    case WinApi.HSHELL_WINDOWCREATED:
                        handle = m.LParam;
                        string windowName = GetWindowName(handle);
                        IntPtr hWnd = WinApi.FindWindow(null,windowName);
                     //   MessageBox.Show(hWnd.ToString());
                      //  WinApi.ShowWindow(hWnd, WinApi.SW_SHOWMAXIMIZED);
                     //   WinApi.ToggleTitleBar(handle, false);
                      //  WinApi.ShowWindow(handle, WinApi.SW_SHOWMINIMIZED);
                        AddNewButton(windowName, handle);
                     
                     //   MessageBox.Show(windowName);//+" "+handle.ToString());
                        break;
                    case WinApi.HSHELL_WINDOWACTIVATED:
                        handle = m.LParam;
                    //    WinApi.ToggleTitleBar(handle, false);
                        break;
                    case WinApi.HSHELL_WINDOWDESTROYED:
                        handle = m.LParam;
                      //  MessageBox.Show(handle.ToString());
                        DeleteButton(handle);
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private static string GetWindowName(IntPtr hWnd)
        {
            // Allocate correct string length first
            int length = WinApi.GetWindowTextLength(hWnd);
            StringBuilder sb = new StringBuilder(length + 1);
            WinApi.GetWindowText(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }


        private void AppsReady(object sender)
        {

            Process[] process = Process.GetProcesses();
            IntPtr child = IntPtr.Zero;
            foreach (Process p in process)
            {

                if (p.MainWindowHandle != IntPtr.Zero && p.MainWindowTitle.Length > 0)
                {
                  //  Icon ico = Icon.ExtractAssociatedIcon(p.MainModule.FileName);
                    Button btn = new Button();
                    btn.Text = p.MainWindowTitle;
                    btn.Name = p.ProcessName;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Tag =p.MainWindowHandle;
                  //  MessageBox.Show(p.MainWindowHandle.ToString());                   
                   // WinApi.ShowWindow(p.MainWindowHandle, WinApi.SW_SHOWMAXIMIZED);
                    //WinApi.ToggleTitleBar(p.MainWindowHandle, false);
                    // btn.Height = 120;
                    // btn.Width = 100;
                    // btn.Image = Grayscale(ico.ToBitmap());
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.Click += new EventHandler(btn_click);
                    TaskPanel.Controls.Add(btn);
                }
                // else MessageBox.Show(p.ProcessName);
                // p.MainModule.FileName
                //Icon ico = Icon.ExtractAssociatedIcon(theProcess.MainModule.FileName);
                //path file of process
            }
            TaskPanel.Left = (this.Width - TaskPanel.Width) / 2;
            //  TaskPanel.Top = (this.Height - TaskPanel.Height) / 2;
            TaskPanel.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //startup.GetAllApps();
            startup.StartApps();
            ToDoButton.Text = todo.LoadTodo();
            ToDoButton.Left = (this.Width - ToDoButton.Width) / 2;
            ToDoButton.Top = (this.Height - ToDoButton.Height) / 2;
            ToDoButton.Show();
            
            //bkg.LoadImages("d:\\wallpapers");
            //bkg.Change();

        }

        private void btn_click(object sender, EventArgs e)
        {
            //WinApi.SetForegroundWindow((IntPtr)(sender as Button).Tag);
            WinApi.SwitchToThisWindow((IntPtr)(sender as Button).Tag,true);
          // string name = 
            IntPtr p = (IntPtr)(sender as Button).Tag;
          //  WinApi.ToggleTitleBar(p, false);
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            PowerMenu.Show(SystemLink.Left,SystemLink.Top+20);
        }

        private void hibernateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pc.System("hibernate");
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pc.System("restart");
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pc.System("shutdown");
        }

        /// <summary>
        /// Convert an Image to a Grayscale Image.
        /// </summary>
        /// <param name="Bitmap">The Bitmap to Convert to Grayscale.</param>
        /// <returns>A Grayscale Image.</returns>
        public static Bitmap Grayscale(Bitmap bitmap)
        {
            //Declare myBitmap as a new Bitmap with the same Width & Height
            Bitmap myBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int x = 0; x < bitmap.Height; x++)
                {
                    //Get the Pixel
                    Color BitmapColor = bitmap.GetPixel(i, x);

                    //Declare grayScale as the Grayscale Pixel
                    int grayScale = (int)((BitmapColor.R * 0.3) + (BitmapColor.G * 0.59) + (BitmapColor.B * 0.11));

                    //Declare myColor as a Grayscale Color
                    Color myColor = Color.FromArgb(grayScale, grayScale, grayScale);

                    //Set the Grayscale Pixel
                    myBitmap.SetPixel(i, x, myColor);
                }
            }
            return myBitmap;
        }

        private void ToDoButton_Click(object sender, EventArgs e)
        {
            ToDoButton.Hide();
            todo.DoIt(ToDoButton.Text);
            ToDoButton.Text = todo.LoadTodo();
            ToDoButton.Left = (this.Width - ToDoButton.Width) / 2;
            ToDoButton.Top = (this.Height - ToDoButton.Height) / 2;
            ToDoButton.Show();
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
           AddToDoForm testDialog = new AddToDoForm();
            
           if (testDialog.ShowDialog(this) == DialogResult.OK)
           {
               todo.AddTodo(testDialog.ToDoText, testDialog.ToDoDate, testDialog.ToDoPriority);
               todo.LoadTodo();
           }
           else
           {
             // MessageBox.Show("Cancelled");
           }
           testDialog.Dispose();
           ToDoButton.Hide();
           ToDoButton.Text = todo.LoadTodo();
           ToDoButton.Left = (this.Width - ToDoButton.Width) / 2;
           ToDoButton.Top = (this.Height - ToDoButton.Height) / 2;
           ToDoButton.Show();
        }

        private void setShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set naskoshell.exe as dafault shell and logout
            pc.SetDefaultShell(true);
            pc.System("logoff"); 
        }

        private void resetWindowsShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set default explorer.exe shell
            pc.SetDefaultShell(false);
            pc.System("logoff"); 
        }

        private void quitNaskoShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewButton(string name, IntPtr id)
        {
            Button btn = new Button();
            btn.Text = name;//p.MainWindowTitle;
            btn.Name = name + "Button";//p.ProcessName;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Tag = id;//p.MainWindowHandle;
            // btn.Height = 120;
            // btn.Width = 100;
            // btn.Image = Grayscale(ico.ToBitmap());
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.ImageAlign = ContentAlignment.MiddleCenter;
            btn.Click += new EventHandler(btn_click);
            
            //this.Controls.Add(btn);
                
            TaskPanel.Controls.Add(btn);
            TaskPanel.Left = (this.Width - TaskPanel.Width) / 2;
            //  TaskPanel.Top = (this.Height - TaskPanel.Height) / 2;
            TaskPanel.Show();
        }

        private void DeleteButton(IntPtr id)
        {
            for (int i=0; i<TaskPanel.Controls.Count; i++)
            { 
                if ((IntPtr)(TaskPanel.Controls[i] as Button).Tag==id) TaskPanel.Controls.RemoveAt(i);
            }
            TaskPanel.Left = (this.Width - TaskPanel.Width) / 2;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void toDoControl1_Click(object sender, EventArgs e)
        {

        }

        private void LauncherLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LauncherForm testDialog = new LauncherForm();

            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
              //  todo.AddTodo(testDialog.ToDoText, testDialog.ToDoDate, testDialog.ToDoPriority);
              //  todo.LoadTodo();
            }
            else
            {
                // MessageBox.Show("Cancelled");
            }
            testDialog.Dispose();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }



    }
}
