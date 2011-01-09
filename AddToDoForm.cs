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
    public partial class AddToDoForm : Form
    {
        public AddToDoForm()
        {
            InitializeComponent();
        }

        public string ToDoText
        {
            get
            {
                return todoTextBox.Text;
            }
        }

        public DateTime ToDoDate
        {
            get
            {
                return todoDate.Value.Date;
            }
        }

        public int ToDoPriority
        {
            get
            {
                return priorityBar.Value;
            }
        }
        
        
        private void AddToDoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (e.KeyChar == (char)System.Windows.Forms.Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void AddToDoForm_Load(object sender, EventArgs e)
        {
            todoDate.Value = DateTime.Now;
        }

        private void AddToDoForm_Paint(object sender, PaintEventArgs e)
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
            graphics.DrawPath(pen,gfxPath);
            this.Region = new Region(gfxPath);
        }
    }
}
