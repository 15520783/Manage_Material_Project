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
    public partial class frmChonNguyenLieu : Form
    {
        public frmChonNguyenLieu()
        {
            InitializeComponent();
        }
        //Các hàm được thực hiện khi chuyển form
        public void LoadDgvNguyenLieu()
        {
            dgvnguyenlieu.DataSource = DanhmucnguyenlieuBUS.Instance._Hienthitatcanguyenlieu();
            Removebindingtextbox();
            Bindingtextbox();
        }
        //
        private void frmChonNguyenLieu_Load(object sender, EventArgs e)
        {
            Setupdatagridview();
            dgvnguyenlieu.DataSource = DanhmucnguyenlieuBUS.Instance._Hienthitatcanguyenlieu();
            Bindingtextbox();
        }

        private void Setupdatagridview()
        {
            dgvnguyenlieu.AutoGenerateColumns = false;
            if (dgvnguyenlieu.ColumnCount == 0)
            {
                dgvnguyenlieu.ColumnCount = 2;
                dgvnguyenlieu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                dgvnguyenlieu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

                dgvnguyenlieu.Columns[0].Name = "manl";
                dgvnguyenlieu.Columns[0].HeaderText = "Mã nguyên liệu";
                dgvnguyenlieu.Columns[0].Width = 100;
                dgvnguyenlieu.Columns[0].DataPropertyName = "manl";

                dgvnguyenlieu.Columns[1].Name = "tennguyenlieu";
                dgvnguyenlieu.Columns[1].HeaderText = "Tên nguyên liệu";
                dgvnguyenlieu.Columns[1].Width = 200;
                dgvnguyenlieu.Columns[1].DataPropertyName = "tennguyenlieu";

            }
        }

        private void Bindingtextbox()
        {
            txtmanguyenlieu.DataBindings.Add(new Binding("Text", dgvnguyenlieu.DataSource, "manl"));
            txttennguyenlieu.DataBindings.Add(new Binding("Text", dgvnguyenlieu.DataSource, "tennguyenlieu"));
            txtdonvitinh.DataBindings.Add(new Binding("Text", dgvnguyenlieu.DataSource, "donvitinh"));
            
        }
        private void Removebindingtextbox()
        {
            txtmanguyenlieu.DataBindings.Clear();
            txttennguyenlieu.DataBindings.Clear();
            txtdonvitinh.DataBindings.Clear();
          

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                dgvnguyenlieu.DataSource = DanhmucnguyenlieuBUS.Instance._Hienthitatcanguyenlieu();
                Removebindingtextbox();
                Bindingtextbox();
            }
            else
            {
                dgvnguyenlieu.DataSource = DanhmucnguyenlieuBUS.Instance._Timkiemnguyenlieu(txttimkiem.Text);
                Removebindingtextbox();
                Bindingtextbox();

            }
        }

        private void btnThemkhachhang_Click(object sender, EventArgs e)
        {
            frmThemNguyenLieu frm = new frmThemNguyenLieu();
            DialogResult result = frm.ShowDialog(this);
        }

        private void btnchonnguyenlieu_Click(object sender, EventArgs e)
        {
           
            if (frmTrangChu.loaiphieu == 2)
                ((frmHoaDonBanNguyenLieu)this.Owner).Chonmanguyenlieu(txtmanguyenlieu.Text);
            else if(frmTrangChu.loaiphieu == 1)
               ((frmLapPhieuNhapNguyenLieu)this.Owner).Chonmanguyenlieu(txtmanguyenlieu.Text);
            else
                ((frmLapPhieuXuatNguyenLieu)this.Owner).Chonmanguyenlieu(txtmanguyenlieu.Text);

            this.Close();

        }
    }
}
