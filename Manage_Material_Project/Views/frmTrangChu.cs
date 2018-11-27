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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoPhieuMua_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLapPhieuNhapNguyenLieu frmlapphieunhap = new frmLapPhieuNhapNguyenLieu();
            frmlapphieunhap.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLapPhieuXuatNguyenLieu frmlapphieuxuat = new frmLapPhieuXuatNguyenLieu();
            frmlapphieuxuat.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDonBanNguyenLieu frmlaphoadon = new frmHoaDonBanNguyenLieu();
            frmlaphoadon.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKeBaoBieu frmthongkebaobieu = new frmThongKeBaoBieu();
            frmthongkebaobieu.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
