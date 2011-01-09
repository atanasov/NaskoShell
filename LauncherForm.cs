using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace NaskoShell
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();

            AppList.DisplayMember = "Name";
        }

        private void LauncherForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int CornerRadius = 10;
            Pen pen = new Pen(Color.Black, 2);
            pen.EndCap = pen.StartCap = LineCap.Round;
            System.Drawing.Drawing2D.GraphicsPath gfxPath = new System.Drawing.Drawing2D.GraphicsPath();
            gfxPath.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
            gfxPath.AddArc(0 + this.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
            gfxPath.AddArc(0 + this.Width - CornerRadius, 0 + this.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            gfxPath.AddArc(0, 0 + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            gfxPath.CloseAllFigures();
            graphics.DrawPath(pen, gfxPath);
            this.Region = new Region(gfxPath);
        }

        private void LauncherForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Program.num.ToString());
            AppText.Focus();
            AppText.SelectAll();
          //  SearchResult[] apps = Program.GlobalCache.Results;//{ new SearchResult("paint", "U.S.A.","") };


        }

        private void LauncherForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Down:
                  //  if (sender is TextBox) 
                        AppList.Focus();
                    break;
                case Keys.Back:
                    if (!(sender is TextBox))
                    {
                        int textlength = AppText.Text.Length;
                        if (textlength > 0)
                        {
                            // Delete character from textBox1
                            AppText.Text = AppText.Text.Substring(0, textlength - 1);
                        }
                        // Go back to textBox1
                        //AppText.Focus();
                        // Set cursor location at the end of the text
                        AppText.SelectionStart = AppText.Text.Length;
                        AppText.SelectionLength = 0;
                    }
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    SearchResult sr = AppList.SelectedItem as SearchResult;

                    if (sr != null)
                    {
                        if (sr.Shortcut != null)
                        {
                            System.Diagnostics.ProcessStartInfo myProc = new System.Diagnostics.ProcessStartInfo();
                            myProc.FileName = sr.Shortcut;
                            myProc.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
                            System.Diagnostics.Process.Start(myProc);
                           
                        }
                        // System.Diagnostics.Process.Start(sr.Shortcut);
                        else
                        {
                            System.Diagnostics.ProcessStartInfo myProc = new System.Diagnostics.ProcessStartInfo();
                            myProc.FileName = sr.Command;
                            myProc.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
                            System.Diagnostics.Process.Start(myProc);
                            // System.Diagnostics.Process.Start(sr.Command);
                        }
                    }

                    this.Close();
                    break;
            }
        }

        private void AppList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AppText.Text = (AppList.SelectedItem as SearchResult).Name;
        }

        private void AppText_TextChanged(object sender, EventArgs e)
        {
            //Program.cache.Hint = AppText.Text;
            AppList.DataSource = Program.cache.Result(AppText.Text); //GlobalCache.Results;// apps;
            AppList.Refresh();
        }

        private void LauncherForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                AppText.AppendText(e.KeyChar.ToString());
                //AppText. e.KeyChar;
                //AppText.
                e.Handled = true;
            }
        }
    }
}
