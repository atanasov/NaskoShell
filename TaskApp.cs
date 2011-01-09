using System;
using System.Collections.Generic;
using System.Text;

namespace NaskoShell
{
    class TaskApp
    {
        private string name;
        private string command;
        private string handle;
   //     private System.Windows.Media.ImageSource icon;

        /// <summary>Gets the display nome of the search result</summary>
        public string Name { get { return name; } }
        /// <summary>Gets the search result's actual command</summary>
        public string Command { get { return command; } }
        /// <summary>Gets the filename of the shortcut on disk this result was read from</summary>
        public string Handle { get { return handle; } }

        /// <summary>Gets a WPF TmageSource for the icon to display for the search result</summary>
     /*   public System.Drawing.Icon icon
        {
            get
            {
                Icon icon_temp = null;
                if (icon == null && System.IO.File.Exists(Command))
                {
                  //  using (System.Drawing.Icon sysicon = )
                    //{
                        // This new call in WPF finally allows us to read/display 32bit Windows file icons!
                    icon_temp = System.Drawing.Icon.ExtractAssociatedIcon(Command);
                        //  icon = icon_temp;
                //    }
                }

                return icon_temp;
            }
        }
     */
        public TaskApp(string name, string command, string handle)
        {
            this.name = name;
            this.command = command;
            this.handle = handle;
        }

        public TaskApp()
            : this("","","")
        {
        }
    }
}
