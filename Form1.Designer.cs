namespace NaskoShell
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToDoButton = new System.Windows.Forms.Button();
            this.SystemLink = new System.Windows.Forms.LinkLabel();
            this.PowerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hibernateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWindowsShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitNaskoShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TodoLink = new System.Windows.Forms.LinkLabel();
            this.ToDoMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeControl1 = new NaskoShell.TimeControl();
            this.PowerMenu.SuspendLayout();
            this.ToDoMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToDoButton
            // 
            this.ToDoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToDoButton.AutoSize = true;
            this.ToDoButton.BackColor = System.Drawing.Color.Transparent;
            this.ToDoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ToDoButton.FlatAppearance.BorderSize = 0;
            this.ToDoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ToDoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ToDoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDoButton.Location = new System.Drawing.Point(116, 175);
            this.ToDoButton.Margin = new System.Windows.Forms.Padding(1);
            this.ToDoButton.Name = "ToDoButton";
            this.ToDoButton.Size = new System.Drawing.Size(280, 29);
            this.ToDoButton.TabIndex = 3;
            this.ToDoButton.Text = "tasks to do";
            this.ToDoButton.UseVisualStyleBackColor = false;
            this.ToDoButton.Visible = false;
            this.ToDoButton.Click += new System.EventHandler(this.ToDoButton_Click);
            // 
            // SystemLink
            // 
            this.SystemLink.ActiveLinkColor = System.Drawing.Color.White;
            this.SystemLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemLink.AutoSize = true;
            this.SystemLink.BackColor = System.Drawing.Color.Transparent;
            this.SystemLink.ContextMenuStrip = this.PowerMenu;
            this.SystemLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SystemLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SystemLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.SystemLink.LinkColor = System.Drawing.Color.Black;
            this.SystemLink.Location = new System.Drawing.Point(273, 2);
            this.SystemLink.Name = "SystemLink";
            this.SystemLink.Size = new System.Drawing.Size(60, 17);
            this.SystemLink.TabIndex = 4;
            this.SystemLink.TabStop = true;
            this.SystemLink.Text = "&System";
            this.SystemLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.SystemLink.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // PowerMenu
            // 
            this.PowerMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PowerMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PowerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hibernateToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            this.setShellToolStripMenuItem,
            this.resetWindowsShellToolStripMenuItem,
            this.quitNaskoShellToolStripMenuItem});
            this.PowerMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.PowerMenu.Name = "contextMenuStrip1";
            this.PowerMenu.ShowImageMargin = false;
            this.PowerMenu.Size = new System.Drawing.Size(149, 158);
            // 
            // hibernateToolStripMenuItem
            // 
            this.hibernateToolStripMenuItem.Name = "hibernateToolStripMenuItem";
            this.hibernateToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.hibernateToolStripMenuItem.Text = "Hibernate";
            this.hibernateToolStripMenuItem.Click += new System.EventHandler(this.hibernateToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // setShellToolStripMenuItem
            // 
            this.setShellToolStripMenuItem.Name = "setShellToolStripMenuItem";
            this.setShellToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.setShellToolStripMenuItem.Text = "Set Windows Shell";
            this.setShellToolStripMenuItem.Click += new System.EventHandler(this.setShellToolStripMenuItem_Click);
            // 
            // resetWindowsShellToolStripMenuItem
            // 
            this.resetWindowsShellToolStripMenuItem.Name = "resetWindowsShellToolStripMenuItem";
            this.resetWindowsShellToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.resetWindowsShellToolStripMenuItem.Text = "Reset Windows Shell";
            this.resetWindowsShellToolStripMenuItem.Click += new System.EventHandler(this.resetWindowsShellToolStripMenuItem_Click);
            // 
            // quitNaskoShellToolStripMenuItem
            // 
            this.quitNaskoShellToolStripMenuItem.Name = "quitNaskoShellToolStripMenuItem";
            this.quitNaskoShellToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.quitNaskoShellToolStripMenuItem.Text = "Quit NaskoShell";
            this.quitNaskoShellToolStripMenuItem.Click += new System.EventHandler(this.quitNaskoShellToolStripMenuItem_Click);
            // 
            // TodoLink
            // 
            this.TodoLink.ActiveLinkColor = System.Drawing.Color.White;
            this.TodoLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TodoLink.AutoSize = true;
            this.TodoLink.BackColor = System.Drawing.Color.Transparent;
            this.TodoLink.ContextMenuStrip = this.PowerMenu;
            this.TodoLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TodoLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TodoLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.TodoLink.LinkColor = System.Drawing.Color.Black;
            this.TodoLink.Location = new System.Drawing.Point(220, 2);
            this.TodoLink.Name = "TodoLink";
            this.TodoLink.Size = new System.Drawing.Size(47, 17);
            this.TodoLink.TabIndex = 5;
            this.TodoLink.TabStop = true;
            this.TodoLink.Text = "&ToDo";
            this.TodoLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.TodoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ToDoMenu
            // 
            this.ToDoMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToDoMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ToDoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.ToDoMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ToDoMenu.Name = "contextMenuStrip1";
            this.ToDoMenu.ShowImageMargin = false;
            this.ToDoMenu.Size = new System.Drawing.Size(95, 26);
            this.ToDoMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem1.Text = "new Task";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // timeControl1
            // 
            this.timeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeControl1.AutoSize = true;
            this.timeControl1.BackColor = System.Drawing.Color.Transparent;
            this.timeControl1.Location = new System.Drawing.Point(351, 2);
            this.timeControl1.Name = "timeControl1";
            this.timeControl1.Size = new System.Drawing.Size(177, 20);
            this.timeControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 408);
            this.Controls.Add(this.ToDoButton);
            this.Controls.Add(this.timeControl1);
            this.Controls.Add(this.TodoLink);
            this.Controls.Add(this.SystemLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PowerMenu.ResumeLayout(false);
            this.ToDoMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TimeControl timeControl1;
        private System.Windows.Forms.Button ToDoButton;
        private System.Windows.Forms.LinkLabel SystemLink;
        private System.Windows.Forms.ContextMenuStrip PowerMenu;
        private System.Windows.Forms.ToolStripMenuItem hibernateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.LinkLabel TodoLink;
        private System.Windows.Forms.ContextMenuStrip ToDoMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetWindowsShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitNaskoShellToolStripMenuItem;
    }
}

