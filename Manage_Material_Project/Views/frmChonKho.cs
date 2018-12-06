using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Material_Project.BLL;

namespace Manage_Material_Project.Views
{
    public partial class frmChonKho : Form
    {
        public static string makho = "";
        public frmChonKho()
        {
            InitializeComponent();
        }

        private void frmChonKho_Load(object sender, EventArgs e)
        {
            Setupdatagridview();
            dgvkho.DataSource = KhoBUS.Instance._Hienthitatcakho();
            Bindingtextbox();

        }

        private void Setupdatagridview()
        {
            dgvkho.AutoGenerateColumns = false;
            if (dgvkho.ColumnCount == 0)
            {
                dgvkho.ColumnCount = 2;
                dgvkho.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                dgvkho.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

                dgvkho.Columns[0].Name = "makho";
                dgvkho.Columns[0].HeaderText = "Mã kho";
                dgvkho.Columns[0].Width = 100;
                dgvkho.Columns[0].DataPropertyName = "makho";

                dgvkho.Columns[1].Name = "tenkho";
                dgvkho.Columns[1].HeaderText = "Tên kho";
                dgvkho.Columns[1].Width = 200;
                dgvkho.Columns[1].DataPropertyName = "tenkho";

            }
        }

        private void Bindingtextbox()
        {
            txtmakho.DataBindings.Add(new Binding("Text", dgvkho.DataSource, "makho"));
            txttenkho.DataBindings.Add(new Binding("Text", dgvkho.DataSource, "tenkho"));
            txtdiachi.DataBindings.Add(new Binding("Text", dgvkho.DataSource, "diachi"));
            txtsdt.DataBindings.Add(new Binding("Text", dgvkho.DataSource, "sdt"));         
        }

        private void btnchonkho_Click(object sender, EventArgs e)
        {
            if (frmTrangChu.loaiphieu == 1)
            {
                frmLapPhieuNhapNguyenLieu frmlapphieunhap = new frmLapPhieuNhapNguyenLieu(txtmakho.Text, txttenkho.Text);
                frmlapphieunhap.Show();
                ((frmTrangChu)this.Owner).Hide();
            }
            else if (frmTrangChu.loaiphieu == 2)
            {
                frmHoaDonBanNguyenLieu frmhoadonban = new frmHoaDonBanNguyenLieu(txtmakho.Text, txttenkho.Text);
                frmhoadonban.Show();
                ((frmTrangChu)this.Owner).Hide();

            }
            else
            {
                frmLapPhieuXuatNguyenLieu frmphieuxuat = new frmLapPhieuXuatNguyenLieu(txtmakho.Text, txttenkho.Text);
                frmphieuxuat.Show();
                ((frmTrangChu)this.Owner).Hide();

            }
            this.Close();
        }
    }
}
