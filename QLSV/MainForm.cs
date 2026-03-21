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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Khi vừa mở máy, hiển thị mặc định trang Sinh viên
            ShowUserControl(new UC_SinhVien());
        }

        // Hàm dùng chung để chuyển trang
        public void ShowUserControl(UserControl uc)
        {
            // 1. Dọn dẹp bộ nhớ: Xóa các control cũ đang hiển thị trong panel
            pnl_MainContent.Controls.Clear();

            // 2. Thiết lập UC mới
            uc.Dock = DockStyle.Fill;

            // 3. Đưa UC vào panel chính
            pnl_MainContent.Controls.Add(uc);
        }

        // --- SỰ KIỆN CLICK MENU ---


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Đóng toàn bộ ứng dụng khi nhấn X
            }
        }

        private void QLSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_SinhVien());
        }

        private void QLLHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_LopHoc());
        }
    }
}
