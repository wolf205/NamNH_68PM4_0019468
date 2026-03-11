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
        public Form_QLSV()
        {
            InitializeComponent();
        }

        private void llb_QLLH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QLLH f_qlLH = new Form_QLLH();
            f_qlLH.Show();
            this.Close();
        }
    }
}
