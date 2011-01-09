namespace NaskoShell
{
    partial class AddToDoForm
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
            this.todoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.todoDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.priorityBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.priorityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // todoTextBox
            // 
            this.todoTextBox.Location = new System.Drawing.Point(11, 25);
            this.todoTextBox.Name = "todoTextBox";
            this.todoTextBox.Size = new System.Drawing.Size(283, 20);
            this.todoTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New To Do: ";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(240, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Due to: ";
            // 
            // todoDate
            // 
            this.todoDate.CustomFormat = "dd.M.yyyy";
            this.todoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.todoDate.Location = new System.Drawing.Point(11, 69);
            this.todoDate.Name = "todoDate";
            this.todoDate.Size = new System.Drawing.Size(92, 20);
            this.todoDate.TabIndex = 4;
            this.todoDate.Value = new System.DateTime(2010, 12, 15, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(191, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // priorityBar
            // 
            this.priorityBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityBar.Location = new System.Drawing.Point(300, 9);
            this.priorityBar.Maximum = 5;
            this.priorityBar.Minimum = 1;
            this.priorityBar.Name = "priorityBar";
            this.priorityBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.priorityBar.Size = new System.Drawing.Size(42, 84);
            this.priorityBar.TabIndex = 6;
            this.priorityBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.priorityBar.Value = 3;
            // 
            // AddToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(354, 100);
            this.ControlBox = false;
            this.Controls.Add(this.priorityBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.todoDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddToDoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New To do";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddToDoForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddToDoForm_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddToDoForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.priorityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox todoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker todoDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar priorityBar;
    }
}