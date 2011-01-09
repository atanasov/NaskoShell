using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NaskoShell
{
    public partial class TimeControl : UserControl
    {
        public TimeControl()
        {
            InitializeComponent();
        }

        private void TimeControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            labelTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
