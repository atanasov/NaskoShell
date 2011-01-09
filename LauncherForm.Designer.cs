namespace NaskoShell
{
    partial class LauncherForm
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
            this.AppText = new System.Windows.Forms.TextBox();
            this.AppList = new System.Windows.Forms.ListBox();
            this.searchResultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AppText
            // 
            this.AppText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AppText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppText.Location = new System.Drawing.Point(12, 13);
            this.AppText.Name = "AppText";
            this.AppText.Size = new System.Drawing.Size(307, 19);
            this.AppText.TabIndex = 0;
            this.AppText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AppText.TextChanged += new System.EventHandler(this.AppText_TextChanged);
            // 
            // AppList
            // 
            this.AppList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppList.FormattingEnabled = true;
            this.AppList.ItemHeight = 20;
            this.AppList.Location = new System.Drawing.Point(12, 49);
            this.AppList.Name = "AppList";
            this.AppList.Size = new System.Drawing.Size(307, 82);
            this.AppList.TabIndex = 2;
            this.AppList.SelectedIndexChanged += new System.EventHandler(this.AppList_SelectedIndexChanged);
            // 
            // searchResultBindingSource1
            // 
            this.searchResultBindingSource1.DataSource = typeof(NaskoShell.SearchResult);
            // 
            // searchResultBindingSource
            // 
            this.searchResultBindingSource.DataSource = typeof(NaskoShell.SearchResult);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(330, 141);
            this.Controls.Add(this.AppList);
            this.Controls.Add(this.AppText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LauncherForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LauncherForm";
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LauncherForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LauncherForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LauncherForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AppText;
        private System.Windows.Forms.ListBox AppList;
        private System.Windows.Forms.BindingSource searchResultBindingSource1;
        private System.Windows.Forms.BindingSource searchResultBindingSource;
    }
}