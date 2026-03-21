namespace QLSV
{
    partial class UC_SinhVien
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lb_mssv = new System.Windows.Forms.Label();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.lb_hoten = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lb_lop = new System.Windows.Forms.Label();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_addSV = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refesh = new System.Windows.Forms.Button();
            this.pnl_right_header = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dt_sinhvien = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_right_footer = new System.Windows.Forms.Panel();
            this.lbl_footer = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.pnl_right_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_sinhvien)).BeginInit();
            this.pnl_right_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.splitContainer1.Panel1.Controls.Add(this.pnl_header);
            this.splitContainer1.Panel1.Controls.Add(this.lb_mssv);
            this.splitContainer1.Panel1.Controls.Add(this.txt_mssv);
            this.splitContainer1.Panel1.Controls.Add(this.lb_hoten);
            this.splitContainer1.Panel1.Controls.Add(this.txt_hoten);
            this.splitContainer1.Panel1.Controls.Add(this.lb_gioitinh);
            this.splitContainer1.Panel1.Controls.Add(this.txt_gioitinh);
            this.splitContainer1.Panel1.Controls.Add(this.lb_ngaysinh);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_ngaysinh);
            this.splitContainer1.Panel1.Controls.Add(this.lb_lop);
            this.splitContainer1.Panel1.Controls.Add(this.cb_lop);
            this.splitContainer1.Panel1.Controls.Add(this.pnl_buttons);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.pnl_right_header);
            this.splitContainer1.Panel2.Controls.Add(this.dt_sinhvien);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_right_footer);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 800);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnl_header.Controls.Add(this.lbl_title);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnl_header.Size = new System.Drawing.Size(380, 65);
            this.pnl_header.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(380, 62);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "QUẢN LÝ SINH VIÊN";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_mssv
            // 
            this.lb_mssv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_mssv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lb_mssv.Location = new System.Drawing.Point(30, 85);
            this.lb_mssv.Name = "lb_mssv";
            this.lb_mssv.Size = new System.Drawing.Size(320, 22);
            this.lb_mssv.TabIndex = 1;
            this.lb_mssv.Text = "MÃ SỐ SINH VIÊN";
            // 
            // txt_mssv
            // 
            this.txt_mssv.BackColor = System.Drawing.Color.White;
            this.txt_mssv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mssv.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_mssv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_mssv.Location = new System.Drawing.Point(30, 110);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(320, 37);
            this.txt_mssv.TabIndex = 1;
            // 
            // lb_hoten
            // 
            this.lb_hoten.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_hoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lb_hoten.Location = new System.Drawing.Point(30, 162);
            this.lb_hoten.Name = "lb_hoten";
            this.lb_hoten.Size = new System.Drawing.Size(320, 22);
            this.lb_hoten.TabIndex = 2;
            this.lb_hoten.Text = "HỌ VÀ TÊN";
            // 
            // txt_hoten
            // 
            this.txt_hoten.BackColor = System.Drawing.Color.White;
            this.txt_hoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hoten.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_hoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_hoten.Location = new System.Drawing.Point(30, 187);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(320, 37);
            this.txt_hoten.TabIndex = 2;
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_gioitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lb_gioitinh.Location = new System.Drawing.Point(30, 239);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(320, 22);
            this.lb_gioitinh.TabIndex = 3;
            this.lb_gioitinh.Text = "GIỚI TÍNH";
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.BackColor = System.Drawing.Color.White;
            this.txt_gioitinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gioitinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_gioitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_gioitinh.Location = new System.Drawing.Point(30, 264);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(320, 37);
            this.txt_gioitinh.TabIndex = 3;
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_ngaysinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lb_ngaysinh.Location = new System.Drawing.Point(30, 316);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(320, 22);
            this.lb_ngaysinh.TabIndex = 4;
            this.lb_ngaysinh.Text = "NGÀY SINH";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtp_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(30, 341);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(320, 37);
            this.dtp_ngaysinh.TabIndex = 4;
            // 
            // lb_lop
            // 
            this.lb_lop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_lop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lb_lop.Location = new System.Drawing.Point(30, 393);
            this.lb_lop.Name = "lb_lop";
            this.lb_lop.Size = new System.Drawing.Size(320, 22);
            this.lb_lop.TabIndex = 5;
            this.lb_lop.Text = "LỚP";
            // 
            // cb_lop
            // 
            this.cb_lop.BackColor = System.Drawing.Color.White;
            this.cb_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lop.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cb_lop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(30, 418);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(320, 38);
            this.cb_lop.TabIndex = 5;
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.BackColor = System.Drawing.Color.Transparent;
            this.pnl_buttons.Controls.Add(this.btn_addSV);
            this.pnl_buttons.Controls.Add(this.btn_update);
            this.pnl_buttons.Controls.Add(this.btn_delete);
            this.pnl_buttons.Controls.Add(this.btn_refesh);
            this.pnl_buttons.Location = new System.Drawing.Point(20, 480);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(340, 102);
            this.pnl_buttons.TabIndex = 6;
            // 
            // btn_addSV
            // 
            this.btn_addSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_addSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addSV.FlatAppearance.BorderSize = 0;
            this.btn_addSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_addSV.ForeColor = System.Drawing.Color.White;
            this.btn_addSV.Location = new System.Drawing.Point(0, 0);
            this.btn_addSV.Name = "btn_addSV";
            this.btn_addSV.Size = new System.Drawing.Size(155, 44);
            this.btn_addSV.TabIndex = 6;
            this.btn_addSV.Text = "Thêm";
            this.btn_addSV.UseVisualStyleBackColor = false;
            this.btn_addSV.Click += new System.EventHandler(this.btn_addSV_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_update.FlatAppearance.BorderSize = 2;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_update.Location = new System.Drawing.Point(185, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(155, 44);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(0, 55);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(155, 44);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_refesh
            // 
            this.btn_refesh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btn_refesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refesh.FlatAppearance.BorderSize = 0;
            this.btn_refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refesh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_refesh.ForeColor = System.Drawing.Color.White;
            this.btn_refesh.Location = new System.Drawing.Point(185, 55);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Size = new System.Drawing.Size(155, 44);
            this.btn_refesh.TabIndex = 9;
            this.btn_refesh.Text = "Làm mới";
            this.btn_refesh.UseVisualStyleBackColor = false;
            this.btn_refesh.Click += new System.EventHandler(this.btn_refesh_Click);
            // 
            // pnl_right_header
            // 
            this.pnl_right_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_right_header.Controls.Add(this.txt_search);
            this.pnl_right_header.Controls.Add(this.btn_search);
            this.pnl_right_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_right_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_right_header.Name = "pnl_right_header";
            this.pnl_right_header.Size = new System.Drawing.Size(818, 68);
            this.pnl_right_header.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.White;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_search.Location = new System.Drawing.Point(20, 18);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(560, 37);
            this.txt_search.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(592, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(130, 30);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dt_sinhvien
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dt_sinhvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dt_sinhvien.BackgroundColor = System.Drawing.Color.White;
            this.dt_sinhvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_sinhvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_sinhvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dt_sinhvien.ColumnHeadersHeight = 45;
            this.dt_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dt_sinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.gioitinh,
            this.ngaysinh,
            this.malop});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_sinhvien.DefaultCellStyle = dataGridViewCellStyle9;
            this.dt_sinhvien.EnableHeadersVisualStyles = false;
            this.dt_sinhvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dt_sinhvien.Location = new System.Drawing.Point(20, 85);
            this.dt_sinhvien.Name = "dt_sinhvien";
            this.dt_sinhvien.RowHeadersVisible = false;
            this.dt_sinhvien.RowHeadersWidth = 62;
            this.dt_sinhvien.RowTemplate.Height = 40;
            this.dt_sinhvien.Size = new System.Drawing.Size(778, 615);
            this.dt_sinhvien.TabIndex = 0;
            this.dt_sinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_sinhvien_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MSSV.DataPropertyName = "mssv";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 100;
            this.MSSV.Name = "MSSV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "hoten";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 180;
            this.HoTen.Name = "HoTen";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.MinimumWidth = 90;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 126;
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.MinimumWidth = 110;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 138;
            // 
            // malop
            // 
            this.malop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã Lớp";
            this.malop.MinimumWidth = 90;
            this.malop.Name = "malop";
            this.malop.Width = 114;
            // 
            // pnl_right_footer
            // 
            this.pnl_right_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnl_right_footer.Controls.Add(this.lbl_footer);
            this.pnl_right_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_right_footer.Location = new System.Drawing.Point(0, 768);
            this.pnl_right_footer.Name = "pnl_right_footer";
            this.pnl_right_footer.Size = new System.Drawing.Size(818, 32);
            this.pnl_right_footer.TabIndex = 1;
            // 
            // lbl_footer
            // 
            this.lbl_footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_footer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lbl_footer.Location = new System.Drawing.Point(0, 0);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lbl_footer.Size = new System.Drawing.Size(818, 32);
            this.lbl_footer.TabIndex = 0;
            this.lbl_footer.Text = "Quản Lý Sinh Viên";
            this.lbl_footer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UC_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "UC_SinhVien";
            this.Size = new System.Drawing.Size(1200, 800);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_right_header.ResumeLayout(false);
            this.pnl_right_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_sinhvien)).EndInit();
            this.pnl_right_footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lb_mssv;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.Label lb_hoten;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label lb_gioitinh;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label lb_lop;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_addSV;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refesh;
        private System.Windows.Forms.Panel pnl_right_header;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dt_sinhvien;
        private System.Windows.Forms.Panel pnl_right_footer;
        private System.Windows.Forms.Label lbl_footer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        #region Component Designer generated code

        #endregion
    }
}