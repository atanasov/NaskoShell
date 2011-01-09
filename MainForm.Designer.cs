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
            this.TaskPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LauncherLink = new System.Windows.Forms.LinkLabel();
            this.AppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeControl1 = new NaskoShell.TimeControl();
            this.PowerMenu.SuspendLayout();
            this.ToDoMenu.SuspendLayout();
            this.AppMenu.SuspendLayout();
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
            this.ToDoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDoButton.Location = new System.Drawing.Point(88, 168);
            this.ToDoButton.Margin = new System.Windows.Forms.Padding(1);
            this.ToDoButton.Name = "ToDoButton";
            this.ToDoButton.Size = new System.Drawing.Size(363, 83);
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
            this.SystemLink.Location = new System.Drawing.Point(336, 2);
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
            this.PowerMenu.BackColor = System.Drawing.Color.White;
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
            this.PowerMenu.Size = new System.Drawing.Size(149, 136);
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
            this.TodoLink.Location = new System.Drawing.Point(283, 2);
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
            this.ToDoMenu.BackColor = System.Drawing.Color.White;
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
            // TaskPanel
            // 
            this.TaskPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TaskPanel.AutoSize = true;
            this.TaskPanel.Location = new System.Drawing.Point(184, 374);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(114, 33);
            this.TaskPanel.TabIndex = 7;
            this.TaskPanel.Visible = false;
            // 
            // LauncherLink
            // 
            this.LauncherLink.ActiveLinkColor = System.Drawing.Color.White;
            this.LauncherLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LauncherLink.BackColor = System.Drawing.Color.Transparent;
            this.LauncherLink.ContextMenuStrip = this.PowerMenu;
            this.LauncherLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LauncherLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LauncherLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LauncherLink.LinkColor = System.Drawing.Color.Black;
            this.LauncherLink.Location = new System.Drawing.Point(195, 2);
            this.LauncherLink.Name = "LauncherLink";
            this.LauncherLink.Size = new System.Drawing.Size(82, 17);
            this.LauncherLink.TabIndex = 8;
            this.LauncherLink.TabStop = true;
            this.LauncherLink.Text = "&Launcher";
            this.LauncherLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.LauncherLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LauncherLink_LinkClicked);
            // 
            // AppMenu
            // 
            this.AppMenu.BackColor = System.Drawing.Color.White;
            this.AppMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AppMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.AppMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.AppMenu.Name = "contextMenuStrip1";
            this.AppMenu.ShowImageMargin = false;
            this.AppMenu.Size = new System.Drawing.Size(95, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem2.Text = "new Task";
            // 
            // timeControl1
            // 
            this.timeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeControl1.AutoSize = true;
            this.timeControl1.BackColor = System.Drawing.Color.Transparent;
            this.timeControl1.Location = new System.Drawing.Point(414, 2);
            this.timeControl1.Name = "timeControl1";
            this.timeControl1.Size = new System.Drawing.Size(114, 58);
            this.timeControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 408);
            this.Controls.Add(this.timeControl1);
            this.Controls.Add(this.ToDoButton);
            this.Controls.Add(this.TodoLink);
            this.Controls.Add(this.LauncherLink);
            this.Controls.Add(this.SystemLink);
            this.Controls.Add(this.TaskPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NaskoShell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.PowerMenu.ResumeLayout(false);
            this.ToDoMenu.ResumeLayout(false);
            this.AppMenu.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel TaskPanel;
        private System.Windows.Forms.LinkLabel LauncherLink;
        private System.Windows.Forms.ContextMenuStrip AppMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

