using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void dMHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHang dmhang = new frmDMHang();
            dmhang.Show();
        }
    }
}
