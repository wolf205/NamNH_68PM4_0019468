namespace QLSV
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QLSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLLHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_MainContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLSVToolStripMenuItem,
            this.QLLHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QLSVToolStripMenuItem
            // 
            this.QLSVToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.QLSVToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.QLSVToolStripMenuItem.Name = "QLSVToolStripMenuItem";
            this.QLSVToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.QLSVToolStripMenuItem.Text = "QLSV";
            this.QLSVToolStripMenuItem.Click += new System.EventHandler(this.QLSVToolStripMenuItem_Click);
            // 
            // QLLHToolStripMenuItem
            // 
            this.QLLHToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.QLLHToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.QLLHToolStripMenuItem.Name = "QLLHToolStripMenuItem";
            this.QLLHToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.QLLHToolStripMenuItem.Text = "QLLH";
            this.QLLHToolStripMenuItem.Click += new System.EventHandler(this.QLLHToolStripMenuItem_Click);
            // 
            // pnl_MainContent
            // 
            this.pnl_MainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_MainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MainContent.Location = new System.Drawing.Point(0, 42);
            this.pnl_MainContent.Name = "pnl_MainContent";
            this.pnl_MainContent.Size = new System.Drawing.Size(1200, 758);
            this.pnl_MainContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnl_MainContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnl_MainContent;
        private System.Windows.Forms.ToolStripMenuItem QLSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLLHToolStripMenuItem;
    }
}