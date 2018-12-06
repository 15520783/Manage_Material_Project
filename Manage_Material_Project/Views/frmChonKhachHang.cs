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
    public partial class frmChonKhachHang : Form
    {
        
        public frmChonKhachHang()
        {
            InitializeComponent();
        }

        private void frmChonKhachHang_Load(object sender, EventArgs e)
        {
            Setupdatagridview();
            if(frmTrangChu.loaiphieu == 3)
            {
                dgvkhachhang.DataSource = KhachhangBUS.Instance._Hienthitatcaphanxuong();

            }
            else
            {
                dgvkhachhang.DataSource = KhachhangBUS.Instance._Hienthitatcakhachhang();

            }
            Bindingtextbox();
        }

        private void Setupdatagridview()
        {
            dgvkhachhang.AutoGenerateColumns = false;
            if (dgvkhachhang.ColumnCount == 0)
            {
                dgvkhachhang.ColumnCount = 2;
                dgvkhachhang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                dgvkhachhang.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

                dgvkhachhang.Columns[0].Name = "makh";
                dgvkhachhang.Columns[0].HeaderText = "Mã khách hàng";
                dgvkhachhang.Columns[0].Width = 100;
                dgvkhachhang.Columns[0].DataPropertyName = "makh";

                dgvkhachhang.Columns[1].Name = "ten";
                dgvkhachhang.Columns[1].HeaderText = "Tên khách hàng";
                dgvkhachhang.Columns[1].Width = 350;
                dgvkhachhang.Columns[1].DataPropertyName = "ten";

            }
        }

        private void Bindingtextbox()
        {
            txtmakh.DataBindings.Add(new Binding("Text", dgvkhachhang.DataSource, "makh"));
            txtten.DataBindings.Add(new Binding("Text", dgvkhachhang.DataSource, "ten"));
            txtdiachi.DataBindings.Add(new Binding("Text", dgvkhachhang.DataSource, "diachi"));
            txtmaso.DataBindings.Add(new Binding("Text", dgvkhachhang.DataSource, "masothue"));
            txttaikhoan.DataBindings.Add(new Binding("Text", dgvkhachhang.DataSource, "sotaikhoan"));
        }

        private void Removebindingtextbox()
        {
            txtmakh.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            txtmaso.DataBindings.Clear();
            txttaikhoan.DataBindings.Clear();
            txtten.DataBindings.Clear();
            
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                if(frmTrangChu.loaiphieu == 3)
                {
                    dgvkhachhang.DataSource = KhachhangBUS.Instance._Hienthitatcaphanxuong();

                }
                else
                {
                    dgvkhachhang.DataSource = KhachhangBUS.Instance._Hienthitatcakhachhang();

                }
                Removebindingtextbox();
                Bindingtextbox();
            }
            else
            {
                if(frmTrangChu.loaiphieu!=3)
                {
                    dgvkhachhang.DataSource = KhachhangBUS.Instance._GetKhachHangByTen(txttimkiem.Text);
                }
                else
                {
                    dgvkhachhang.DataSource = KhachhangBUS.Instance._GetPhanXuongByTen(txttimkiem.Text);

                }
                Removebindingtextbox();
                Bindingtextbox();

            }
        }

        private void btnchonkhachhang_Click(object sender, EventArgs e)
        {
            if(frmTrangChu.loaiphieu == 2)
               ((frmHoaDonBanNguyenLieu)this.Owner).Loadkhachhang(txtmakh.Text, txtten.Text, txtdiachi.Text, txttaikhoan.Text, txtmaso.Text);
            else if(frmTrangChu.loaiphieu == 1)
                ((frmLapPhieuNhapNguyenLieu)this.Owner).Loadkhachhang(txtmakh.Text, txtten.Text, txtdiachi.Text, txttaikhoan.Text, txtmaso.Text);
            else
                ((frmLapPhieuXuatNguyenLieu)this.Owner).Loadkhachhang(txtmakh.Text, txtten.Text, txtdiachi.Text, txttaikhoan.Text, txtmaso.Text);

            this.Close();
            
        }
    }
}
