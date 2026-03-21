namespace QLSV
{
    partial class Form_Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.lb_AppTitle = new System.Windows.Forms.Label();
            this.lb_AppSubtitle = new System.Windows.Forms.Label();
            this.lb_Divider = new System.Windows.Forms.Label();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.lb_LoginTitle = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cb_remember = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.lb_Version = new System.Windows.Forms.Label();
            this.pnl_Left.SuspendLayout();
            this.pnl_Right.SuspendLayout();
            this.SuspendLayout();

            // ──────────────────────────────────────────────
            // pnl_Left  (Navy panel – branding side)
            // ──────────────────────────────────────────────
            this.pnl_Left.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);   // #34495E
            this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Left.Size = new System.Drawing.Size(340, 500);
            this.pnl_Left.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lb_AppTitle, this.lb_Divider, this.lb_AppSubtitle, this.lb_Version });

            // App title
            this.lb_AppTitle.AutoSize = false;
            this.lb_AppTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lb_AppTitle.ForeColor = System.Drawing.Color.White;
            this.lb_AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_AppTitle.Size = new System.Drawing.Size(340, 70);
            this.lb_AppTitle.Location = new System.Drawing.Point(0, 140);
            this.lb_AppTitle.Text = "QLSV";

            // Divider bar
            this.lb_Divider.AutoSize = false;
            this.lb_Divider.BackColor = System.Drawing.Color.FromArgb(26, 188, 156);  // #1ABC9C teal accent
            this.lb_Divider.Size = new System.Drawing.Size(60, 4);
            this.lb_Divider.Location = new System.Drawing.Point(140, 215);
            this.lb_Divider.Text = "";

            // App subtitle
            this.lb_AppSubtitle.AutoSize = false;
            this.lb_AppSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_AppSubtitle.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199);  // #BDC3C7
            this.lb_AppSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_AppSubtitle.Size = new System.Drawing.Size(340, 40);
            this.lb_AppSubtitle.Location = new System.Drawing.Point(0, 228);
            this.lb_AppSubtitle.Text = "Quản Lý Sinh Viên";

            // Version label
            this.lb_Version.AutoSize = false;
            this.lb_Version.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lb_Version.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lb_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Version.Size = new System.Drawing.Size(340, 25);
            this.lb_Version.Location = new System.Drawing.Point(0, 450);
            this.lb_Version.Text = "v1.0.0";

            // ──────────────────────────────────────────────
            // pnl_Right  (Light panel – form side)
            // ──────────────────────────────────────────────
            this.pnl_Right.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);  // #ECF0F1
            this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Right.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lb_LoginTitle,
                this.lb_username, this.txt_username,
                this.lb_password, this.txt_password,
                this.cb_remember,
                this.btn_login, this.btn_register });

            // Login title
            this.lb_LoginTitle.AutoSize = false;
            this.lb_LoginTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lb_LoginTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lb_LoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_LoginTitle.Size = new System.Drawing.Size(340, 55);
            this.lb_LoginTitle.Location = new System.Drawing.Point(40, 70);
            this.lb_LoginTitle.Text = "Đăng nhập";

            // Label Username
            this.lb_username.AutoSize = false;
            this.lb_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_username.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lb_username.Size = new System.Drawing.Size(340, 24);
            this.lb_username.Location = new System.Drawing.Point(40, 148);
            this.lb_username.Text = "Tên đăng nhập";

            // TextBox Username
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.txt_username.Size = new System.Drawing.Size(340, 34);
            this.txt_username.Location = new System.Drawing.Point(40, 176);
            this.txt_username.Text = "namnh";

            // Label Password
            this.lb_password.AutoSize = false;
            this.lb_password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_password.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lb_password.Size = new System.Drawing.Size(340, 24);
            this.lb_password.Location = new System.Drawing.Point(40, 228);
            this.lb_password.Text = "Mật khẩu";

            // TextBox Password
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(340, 34);
            this.txt_password.Location = new System.Drawing.Point(40, 256);
            this.txt_password.Text = "0019468";

            // CheckBox Remember
            this.cb_remember.AutoSize = false;
            this.cb_remember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_remember.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.cb_remember.BackColor = System.Drawing.Color.Transparent;
            this.cb_remember.Size = new System.Drawing.Size(200, 28);
            this.cb_remember.Location = new System.Drawing.Point(40, 308);
            this.cb_remember.Text = "Nhớ mật khẩu";

            // Button Login  (Teal accent)
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(26, 188, 156);  // #1ABC9C
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Size = new System.Drawing.Size(160, 44);
            this.btn_login.Location = new System.Drawing.Point(40, 360);
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);

            // Button Register  (Outlined navy)
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.FlatAppearance.BorderSize = 2;
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.Size = new System.Drawing.Size(160, 44);
            this.btn_register.Location = new System.Drawing.Point(220, 360);
            this.btn_register.Text = "Đăng ký";

            // ──────────────────────────────────────────────
            // Form_Login
            // ──────────────────────────────────────────────
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.pnl_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên – Đăng nhập";
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);

            this.pnl_Left.ResumeLayout(false);
            this.pnl_Right.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Label lb_AppTitle;
        private System.Windows.Forms.Label lb_AppSubtitle;
        private System.Windows.Forms.Label lb_Divider;
        private System.Windows.Forms.Label lb_Version;
        private System.Windows.Forms.Label lb_LoginTitle;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.CheckBox cb_remember;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
    }
}