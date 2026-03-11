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
        public Form_QLLH()
        {
            InitializeComponent();
        }

        private void llb_qlsv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QLSV f_qlsv = new Form_QLSV();
            f_qlsv.Show();
            this.Close();
        }
    }
}
