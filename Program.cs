using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NaskoShell
{
    class Program
    {

        public static Cache cache;
        public static List<TaskApp> AppsList;
        public static int num = 444;
      //  public static Cache GlobalCache { get { return cache; } }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         //   Application.EnableVisualStyles();
            cache = new Cache();
            AppsList = new List<TaskApp>();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
