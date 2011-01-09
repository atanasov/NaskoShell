using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace NaskoShell
{
    class BackgroundSwitcher
    {
        private string[] ListImages;
        private Form myform;
        
        public BackgroundSwitcher(Form form1)
        {
            myform = form1;
        }

        public void LoadImages(string folder)
        {
            ListImages = System.IO.Directory.GetFiles(@folder, "*.jpg", System.IO.SearchOption.AllDirectories);
        }

        public void Change()
        {
            System.Random RandNum = new System.Random();
            myform.BackgroundImage = new Bitmap(@ListImages[RandNum.Next(ListImages.Length - 1)]);
            myform.BackgroundImageLayout = ImageLayout.Stretch;
        }


    }
}
