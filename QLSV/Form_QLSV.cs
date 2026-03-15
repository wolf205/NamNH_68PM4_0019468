using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form_QLSV : Form
    {
        // Khởi tạo DataContext (Đảm bảo bạn đã kéo bảng vào file .dbml)
        QLSVDataContext db = new QLSVDataContext();

        public Form_QLSV()
        {
            InitializeComponent();
            LoadData();
            // Gán sự kiện click vào bảng bằng code (nếu trong Designer chưa gán)
            dt_sinhvien.CellClick += dt_sinhvien_CellClick;
        }

        // Hàm tải dữ liệu lên bảng
        void LoadData()
        {
            var ds = from sv in db.tbl_SinhViens
                     select new
                     {
                         sv.mssv,
                         sv.hoten,
                         sv.gioitinh,
                         sv.ngaysinh,
                         sv.malop
                     };
            dt_sinhvien.DataSource = ds.ToList();
        }

        private void llb_QLLH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QLLH f_qlLH = new Form_QLLH();
            f_qlLH.Show();
            this.Hide();
        }

        // --- 1. SỰ KIỆN CELLCLICK: Hiển thị thông tin từ bảng lên các ô bên trái ---
        private void dt_sinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng dữ liệu hay không (tránh click vào tiêu đề)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dt_sinhvien.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                txt_mssv.Text = row.Cells["MSSV"].Value?.ToString();
                txt_hoten.Text = row.Cells["HoTen"].Value?.ToString();
                txt_gioitinh.Text = row.Cells["gioitinh"].Value?.ToString();
                txt_lop.Text = row.Cells["malop"].Value?.ToString();

                // Đổ dữ liệu vào DateTimePicker
                if (row.Cells["ngaysinh"].Value != null)
                {
                    dtp_ngaysinh.Value = Convert.ToDateTime(row.Cells["ngaysinh"].Value);
                }
            }
        }

        // --- 2. NÚT LÀM MỚI: Xóa sạch input và reset ngày về hôm nay ---
        private void btn_refesh_Click(object sender, EventArgs e)
        {
            txt_mssv.Clear();
            txt_hoten.Clear();
            txt_gioitinh.Clear();
            txt_lop.Clear();
            txt_search.Clear();

            // Reset ngày sinh về ngày hiện tại
            dtp_ngaysinh.Value = DateTime.Now;

            // Load lại dữ liệu bảng cho chắc chắn
            LoadData();
        }

        // --- CHỨC NĂNG THÊM (LINQ) ---
        private void btn_addSV_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(txt_mssv.Text))
            {
                MessageBox.Show("Vui lòng nhập MSSV!");
                return;
            }

            // 2. Kiểm tra trùng khóa chính
            var check = db.tbl_SinhViens.Where(p => p.mssv == txt_mssv.Text).FirstOrDefault();
            if (check != null)
            {
                MessageBox.Show("Mã số sinh viên này đã tồn tại!");
                return;
            }

            try
            {
                tbl_SinhVien sv = new tbl_SinhVien();
                sv.mssv = txt_mssv.Text;
                sv.hoten = txt_hoten.Text;
                sv.gioitinh = txt_gioitinh.Text;
                sv.ngaysinh = dtp_ngaysinh.Value;
                sv.malop = txt_lop.Text;

                db.tbl_SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();

                MessageBox.Show("Thêm sinh viên thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        // --- CHỨC NĂNG SỬA (LINQ) ---
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                var sv = db.tbl_SinhViens.SingleOrDefault(p => p.mssv == txt_mssv.Text);
                if (sv != null)
                {
                    sv.hoten = txt_hoten.Text;
                    sv.gioitinh = txt_gioitinh.Text;
                    sv.ngaysinh = dtp_ngaysinh.Value;
                    sv.malop = txt_lop.Text;

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        // --- CHỨC NĂNG XÓA (LINQ) ---
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var sv = db.tbl_SinhViens.SingleOrDefault(p => p.mssv == txt_mssv.Text);
                if (sv != null)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        db.tbl_SinhViens.DeleteOnSubmit(sv);
                        db.SubmitChanges();
                        LoadData();
                        btn_refesh_Click(null, null); // Xóa sạch ô nhập sau khi xóa dưới DB
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String keyword = txt_search.Text.Trim();

            if (keyword == null || keyword.Length == 0)
            {
                LoadData();

            }
            else
            {
                var ds = from sv in db.tbl_SinhViens
                         where sv.mssv.Contains(keyword) || sv.hoten.Contains(keyword) || sv.malop.Contains(keyword) || sv.gioitinh.Contains(keyword)
                         select new
                         {
                             sv.mssv,
                             sv.hoten,
                             sv.gioitinh,
                             sv.ngaysinh,
                             sv.malop
                         };
                dt_sinhvien.DataSource = ds.ToList();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Đóng toàn bộ ứng dụng khi nhấn X
            }
        }
    }
}