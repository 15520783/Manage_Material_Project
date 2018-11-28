using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Material_Project.Views
{
    public partial class frmThongKeBaoBieu : Form
    {
        public frmThongKeBaoBieu()
        {
            InitializeComponent();
        }

        private void btnTaoPhieuMua_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmReportXuatNguyenLieu frmreportXuatNguyenLieu = new frmReportXuatNguyenLieu();
            frmreportXuatNguyenLieu.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu frmtrangchu = new frmTrangChu();
            frmtrangchu.ShowDialog();
            this.Show();
        }

        private void btnXemNhatKyMua_Click(object sender, EventArgs e)
        {
            frmReportMuaNguyenLieu frmreportMuaNguyenLieu = new frmReportMuaNguyenLieu();
            frmreportMuaNguyenLieu.ShowDialog();
            this.Show();
        }
    }
}
