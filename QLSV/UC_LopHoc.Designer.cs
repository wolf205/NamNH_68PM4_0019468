namespace QLSV
{
    partial class UC_LopHoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lb_mslh = new System.Windows.Forms.Label();
            this.txt_mslh = new System.Windows.Forms.TextBox();
            this.lb_tenlop = new System.Windows.Forms.Label();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.lb_khoa = new System.Windows.Forms.Label();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.lb_nienkhoa = new System.Windows.Forms.Label();
            this.txt_nienkhoa = new System.Windows.Forms.TextBox();
            this.lb_siso = new System.Windows.Forms.Label();
            this.txt_siso = new System.Windows.Forms.TextBox();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_danhsach = new System.Windows.Forms.Button();
            this.btn_addSV = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refesh = new System.Windows.Forms.Button();
            this.pnl_right_header = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dt_lophoc = new System.Windows.Forms.DataGridView();
            this.MSLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nienkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_right_footer = new System.Windows.Forms.Panel();
            this.lbl_footer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.pnl_right_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lophoc)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lb_mslh);
            this.splitContainer1.Panel1.Controls.Add(this.txt_mslh);
            this.splitContainer1.Panel1.Controls.Add(this.lb_tenlop);
            this.splitContainer1.Panel1.Controls.Add(this.txt_tenlop);
            this.splitContainer1.Panel1.Controls.Add(this.lb_khoa);
            this.splitContainer1.Panel1.Controls.Add(this.txt_khoa);
            this.splitContainer1.Panel1.Controls.Add(this.lb_nienkhoa);
            this.splitContainer1.Panel1.Controls.Add(this.txt_nienkhoa);
            this.splitContainer1.Panel1.Controls.Add(this.lb_siso);
            this.splitContainer1.Panel1.Controls.Add(this.txt_siso);
            this.splitContainer1.Panel1.Controls.Add(this.pnl_buttons);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.pnl_right_header);
            this.splitContainer1.Panel2.Controls.Add(this.dt_lophoc);
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
            this.lbl_title.Text = "QUẢN LÝ LỚP HỌC";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_mslh
            // 
            this.lb_mslh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_mslh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lb_mslh.Location = new System.Drawing.Point(30, 85);
            this.lb_mslh.Name = "lb_mslh";
            this.lb_mslh.Size = new System.Drawing.Size(320, 22);
            this.lb_mslh.TabIndex = 1;
            this.lb_mslh.Text = "MÃ SỐ LỚP HỌC";
            // 
            // txt_mslh
            // 
            this.txt_mslh.BackColor = System.Drawing.Color.White;
            this.txt_mslh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mslh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_mslh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_mslh.Location = new System.Drawing.Point(30, 110);
            this.txt_mslh.Name = "txt_mslh";
            this.txt_mslh.Size = new System.Drawing.Size(320, 37);
            this.txt_mslh.TabIndex = 1;
            // 
            // lb_tenlop
            // 
            this.lb_tenlop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_tenlop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lb_tenlop.Location = new System.Drawing.Point(30, 162);
            this.lb_tenlop.Name = "lb_tenlop";
            this.lb_tenlop.Size = new System.Drawing.Size(320, 22);
            this.lb_tenlop.TabIndex = 2;
            this.lb_tenlop.Text = "TÊN LỚP";
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.BackColor = System.Drawing.Color.White;
            this.txt_tenlop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenlop.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_tenlop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_tenlop.Location = new System.Drawing.Point(30, 187);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(320, 37);
            this.txt_tenlop.TabIndex = 2;
            // 
            // lb_khoa
            // 
            this.lb_khoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_khoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lb_khoa.Location = new System.Drawing.Point(30, 239);
            this.lb_khoa.Name = "lb_khoa";
            this.lb_khoa.Size = new System.Drawing.Size(320, 22);
            this.lb_khoa.TabIndex = 3;
            this.lb_khoa.Text = "KHOA";
            // 
            // txt_khoa
            // 
            this.txt_khoa.BackColor = System.Drawing.Color.White;
            this.txt_khoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_khoa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_khoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_khoa.Location = new System.Drawing.Point(30, 264);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.Size = new System.Drawing.Size(320, 37);
            this.txt_khoa.TabIndex = 3;
            // 
            // lb_nienkhoa
            // 
            this.lb_nienkhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_nienkhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lb_nienkhoa.Location = new System.Drawing.Point(30, 316);
            this.lb_nienkhoa.Name = "lb_nienkhoa";
            this.lb_nienkhoa.Size = new System.Drawing.Size(320, 22);
            this.lb_nienkhoa.TabIndex = 4;
            this.lb_nienkhoa.Text = "NIÊN KHOÁ";
            // 
            // txt_nienkhoa
            // 
            this.txt_nienkhoa.BackColor = System.Drawing.Color.White;
            this.txt_nienkhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nienkhoa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_nienkhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_nienkhoa.Location = new System.Drawing.Point(30, 341);
            this.txt_nienkhoa.Name = "txt_nienkhoa";
            this.txt_nienkhoa.Size = new System.Drawing.Size(320, 37);
            this.txt_nienkhoa.TabIndex = 4;
            // 
            // lb_siso
            // 
            this.lb_siso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_siso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lb_siso.Location = new System.Drawing.Point(30, 393);
            this.lb_siso.Name = "lb_siso";
            this.lb_siso.Size = new System.Drawing.Size(320, 22);
            this.lb_siso.TabIndex = 5;
            this.lb_siso.Text = "SĨ SỐ";
            // 
            // txt_siso
            // 
            this.txt_siso.BackColor = System.Drawing.Color.White;
            this.txt_siso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_siso.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_siso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_siso.Location = new System.Drawing.Point(30, 418);
            this.txt_siso.Name = "txt_siso";
            this.txt_siso.Size = new System.Drawing.Size(320, 37);
            this.txt_siso.TabIndex = 5;
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.BackColor = System.Drawing.Color.Transparent;
            this.pnl_buttons.Controls.Add(this.btn_addSV);
            this.pnl_buttons.Controls.Add(this.btn_update);
            this.pnl_buttons.Controls.Add(this.btn_delete);
            this.pnl_buttons.Controls.Add(this.btn_refesh);
            this.pnl_buttons.Controls.Add(this.btn_danhsach);
            this.pnl_buttons.Location = new System.Drawing.Point(20, 480);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(340, 160);
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
            // btn_danhsach
            // 
            this.btn_danhsach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_danhsach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_danhsach.FlatAppearance.BorderSize = 0;
            this.btn_danhsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_danhsach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_danhsach.ForeColor = System.Drawing.Color.White;
            this.btn_danhsach.Location = new System.Drawing.Point(0, 110);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(340, 44);
            this.btn_danhsach.TabIndex = 10;
            this.btn_danhsach.Text = "Danh sách";
            this.btn_danhsach.UseVisualStyleBackColor = false;
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
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
            // dt_lophoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dt_lophoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_lophoc.BackgroundColor = System.Drawing.Color.White;
            this.dt_lophoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_lophoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_lophoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_lophoc.ColumnHeadersHeight = 45;
            this.dt_lophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dt_lophoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSLH,
            this.TenLop,
            this.khoa,
            this.nienkhoa,
            this.siso});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_lophoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dt_lophoc.EnableHeadersVisualStyles = false;
            this.dt_lophoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dt_lophoc.Location = new System.Drawing.Point(20, 85);
            this.dt_lophoc.Name = "dt_lophoc";
            this.dt_lophoc.RowHeadersVisible = false;
            this.dt_lophoc.RowHeadersWidth = 62;
            this.dt_lophoc.RowTemplate.Height = 40;
            this.dt_lophoc.Size = new System.Drawing.Size(778, 615);
            this.dt_lophoc.TabIndex = 0;
            this.dt_lophoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_lophoc_CellContentClick);
            // 
            // MSLH
            // 
            this.MSLH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MSLH.DataPropertyName = "malop";
            this.MSLH.HeaderText = "MSLH";
            this.MSLH.MinimumWidth = 100;
            this.MSLH.Name = "MSLH";
            // 
            // TenLop
            // 
            this.TenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLop.DataPropertyName = "tenlop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.MinimumWidth = 150;
            this.TenLop.Name = "TenLop";
            // 
            // khoa
            // 
            this.khoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.khoa.DataPropertyName = "khoa";
            this.khoa.HeaderText = "Khoa";
            this.khoa.MinimumWidth = 90;
            this.khoa.Name = "khoa";
            this.khoa.Width = 93;
            // 
            // nienkhoa
            // 
            this.nienkhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nienkhoa.DataPropertyName = "nienkhoa";
            this.nienkhoa.HeaderText = "Niên Khoá";
            this.nienkhoa.MinimumWidth = 110;
            this.nienkhoa.Name = "nienkhoa";
            this.nienkhoa.Width = 139;
            // 
            // siso
            // 
            this.siso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.siso.DataPropertyName = "siso";
            this.siso.HeaderText = "Sĩ Số";
            this.siso.MinimumWidth = 90;
            this.siso.Name = "siso";
            this.siso.Width = 92;
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
            this.lbl_footer.Text = "Quản Lý Lớp Học";
            this.lbl_footer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UC_LopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "UC_LopHoc";
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
            ((System.ComponentModel.ISupportInitialize)(this.dt_lophoc)).EndInit();
            this.pnl_right_footer.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lb_mslh;
        private System.Windows.Forms.TextBox txt_mslh;
        private System.Windows.Forms.Label lb_tenlop;
        private System.Windows.Forms.TextBox txt_tenlop;
        private System.Windows.Forms.Label lb_khoa;
        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.Label lb_nienkhoa;
        private System.Windows.Forms.TextBox txt_nienkhoa;
        private System.Windows.Forms.Label lb_siso;
        private System.Windows.Forms.TextBox txt_siso;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_addSV;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refesh;
        private System.Windows.Forms.Button btn_danhsach;
        private System.Windows.Forms.Panel pnl_right_header;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dt_lophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nienkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn siso;
        private System.Windows.Forms.Panel pnl_right_footer;
        private System.Windows.Forms.Label lbl_footer;
    }
}