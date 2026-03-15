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
    public partial class Form_QLLH : Form
    {
        QLSVDataContext db = new QLSVDataContext();
        public Form_QLLH()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var ds = from lh in db.tbl_LopHocs
                     select new
                     {
                         lh.malop,
                         lh.tenlop,
                         lh.khoa,
                         lh.nienkhoa,
                         lh.siso
                     };
            dt_lophoc.DataSource = ds.ToList();
        }


        private void dt_lophoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng dữ liệu hay không (tránh click vào tiêu đề)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dt_lophoc.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                txt_mslh.Text = row.Cells["MSLH"].Value?.ToString();
                txt_tenlop.Text = row.Cells["TenLop"].Value?.ToString();
                txt_khoa.Text = row.Cells["khoa"].Value?.ToString();
                txt_nienkhoa.Text = row.Cells["nienkhoa"].Value?.ToString();
                txt_siso.Text = row.Cells["siso"].Value?.ToString();
            }
        }

   

        private void llb_QLLH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QLSV f_qlsv = new Form_QLSV();
            f_qlsv.Show();
            this.Hide();
        }

        private void btn_addSV_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(txt_mslh.Text))
            {
                MessageBox.Show("Vui lòng nhập MSLH!");
                return;
            }

            // 2. Kiểm tra trùng khóa chính
            var check = db.tbl_LopHocs.Where(p => p.malop == txt_mslh.Text).FirstOrDefault();
            if (check != null)
            {
                MessageBox.Show("Mã số lớp học này đã tồn tại!");
                return;
            }

            try
            {
                tbl_LopHoc lh = new tbl_LopHoc();
                lh.malop = txt_mslh.Text;
                lh.tenlop = txt_tenlop.Text;
                lh.khoa = txt_khoa.Text;
                lh.nienkhoa = txt_nienkhoa.Text;
                lh.siso = short.Parse(txt_siso.Text);

                db.tbl_LopHocs.InsertOnSubmit(lh);
                db.SubmitChanges();

                MessageBox.Show("Thêm lớp học thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                var lh = db.tbl_LopHocs.SingleOrDefault(p => p.malop == txt_mslh.Text);
                if (lh != null)
                {
                    lh.tenlop = txt_tenlop.Text;
                    lh.khoa = txt_khoa.Text;
                    lh.nienkhoa = txt_nienkhoa.Text;
                    lh.siso = short.Parse(txt_siso.Text);

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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var lh = db.tbl_LopHocs.SingleOrDefault(p => p.malop == txt_mslh.Text);
                if (lh != null)
                {
                    DialogResult dr = MessageBox.Show("Xóa lớp sẽ ảnh hưởng dữ liệu sinh viên. Tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        db.tbl_LopHocs.DeleteOnSubmit(lh);
                        db.SubmitChanges();
                        LoadData();
                        btn_refesh_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message + "\nLưu ý: Không thể xóa lớp đang có sinh viên học!");
            }
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            txt_mslh.Clear();
            txt_tenlop.Clear();
            txt_khoa.Clear();
            txt_nienkhoa.Clear();
            txt_siso.Clear();
            txt_search.Clear();

            LoadData();
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
                var ds = from lh in db.tbl_LopHocs
                         where lh.malop.Contains(keyword) || lh.tenlop.Contains(keyword) || lh.khoa.Contains(keyword)
                         select new
                         {
                             lh.malop,
                             lh.tenlop,
                             lh.khoa,
                             lh.nienkhoa,
                             lh.siso
                         };
                dt_lophoc.DataSource = ds.ToList();
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
