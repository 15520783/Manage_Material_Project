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
        public static int loaiphieu = 0;

        private static frmTrangChu _instance;
        public static frmTrangChu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmTrangChu();
                }
                return _instance;
            }
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoPhieuMua_Click(object sender, EventArgs e)
        {
            loaiphieu = 1;

            // frmLapPhieuNhapNguyenLieu frmlapphieunhap = new frmLapPhieuNhapNguyenLieu();
            //frmlapphieunhap.ShowDialog();
            frmChonKho frm = new frmChonKho();
            DialogResult result = frm.ShowDialog(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaiphieu = 3;
            //this.Hide();
            frmChonKho frm = new frmChonKho();
            DialogResult result = frm.ShowDialog(this);
            //this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loaiphieu = 2;
            //this.Hide();
            frmChonKho frm = new frmChonKho();
            DialogResult result = frm.ShowDialog(this);
            //this.Show();
        }

        private void frmTrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmThongKeBaoBieu frmthongkebaobieu = new frmThongKeBaoBieu();
            frmthongkebaobieu.Show();
            this.Hide();
        }
    }
}
