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
using Manage_Material_Project.Utilities;
using Manage_Material_Project.DAO;

namespace Manage_Material_Project.Views
{
    public partial class frmLapPhieuNhapNguyenLieu : Form
    {

        public frmLapPhieuNhapNguyenLieu()
        {
            InitializeComponent();
        }

        private static frmLapPhieuNhapNguyenLieu _instance;
        private static frmLapPhieuNhapNguyenLieu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmLapPhieuNhapNguyenLieu();
                return _instance;
            }
        }
        BindingSource NguyenlieuList = new BindingSource();
        double tongtienhang = 0;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLapPhieuNhapNguyenLieu_Load(object sender, EventArgs e)
        {
            Setupdatagridview();
            LoadNguyenLieu();
            Loadcmbmakhachhang(cmbmakhachhang);
            Loadcmbkho(cmbmakho);
            dgvnguyenlieu.DataSource = NguyenlieuList;
            Loadcmbhinhthucthanhtoan(cmbhinhthucthanhtoan);
            txttaikhoan.Text = "C331";
            txtsohoadon.Text = HoadongiaodichBUS.Instance._Getsohoadonmoinhat().ToString();
            Hienthighichu("331");
            //Hiển thị tài khoản đối ứng
            DataTable dt = TaikhoanketoanBUS.Instance._Laythongtintaikhoan("152");
            foreach (DataRow row in dt.Rows)
            {
                txttaikhoandu.Text = row["tentaikhoan"].ToString();
            }


        }

        private void LoadNguyenLieu()
        {
            NguyenlieuList.DataSource = NguyenlieuBUS.Instance._Hienthitatcanguyenlieu(); 
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

            dgvnhapnguyenlieu.AutoGenerateColumns = false;
            if(dgvnhapnguyenlieu.ColumnCount == 0)
            {
                dgvnhapnguyenlieu.ColumnCount = 5;
                dgvnhapnguyenlieu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                dgvnhapnguyenlieu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

                dgvnhapnguyenlieu.Columns[0].Name = "taikhoandu";
                dgvnhapnguyenlieu.Columns[0].HeaderText = "TKDU";
                dgvnhapnguyenlieu.Columns[0].Width = 70;
                dgvnhapnguyenlieu.Columns[0].DataPropertyName = "taikhoandu";

                dgvnhapnguyenlieu.Columns[1].Name = "manl";
                dgvnhapnguyenlieu.Columns[1].HeaderText = "Mã nguyên liệu";
                dgvnhapnguyenlieu.Columns[1].Width = 150;
                dgvnhapnguyenlieu.Columns[1].DataPropertyName = "manl";

                dgvnhapnguyenlieu.Columns[2].Name = "soluong";
                dgvnhapnguyenlieu.Columns[2].HeaderText = "Số lượng";
                dgvnhapnguyenlieu.Columns[2].Width = 150;
                dgvnhapnguyenlieu.Columns[2].DataPropertyName = "soluong";

                dgvnhapnguyenlieu.Columns[3].Name = "dongia";
                dgvnhapnguyenlieu.Columns[3].HeaderText = "Đơn giá";
                dgvnhapnguyenlieu.Columns[3].Width = 150;
                dgvnhapnguyenlieu.Columns[3].DataPropertyName = "dongia";

                dgvnhapnguyenlieu.Columns[4].Name = "thanhtien";
                dgvnhapnguyenlieu.Columns[4].HeaderText = "Thành tiền";
                dgvnhapnguyenlieu.Columns[4].Width = 150;
                dgvnhapnguyenlieu.Columns[4].DataPropertyName = "thanhtien";


            }
        }


        private void Loadcmbhinhthucthanhtoan(ComboBox temp)
        {
            ComboBoxItem item1 = new ComboBoxItem("Tiền mặt", "Tiền mặt");
            ComboBoxItem item2 = new ComboBoxItem("Chuyển khoản", "Chuyển khoản");
            temp.Items.Add(item1);
            temp.Items.Add(item2);
            temp.DisplayMember = "Text";
            temp.ValueMember = "Value";
        }

        private void Loadcmbkho(ComboBox temp)
        {
            DataTable dt = KhoBUS.Instance._Hienthitatcakho();
            foreach (DataRow row in dt.Rows)
            {
                ComboBoxItem item = new ComboBoxItem(row["tenkho"].ToString(), row["makho"].ToString());
                temp.Items.Add(item);
            }
            temp.DisplayMember = "Text";
            temp.ValueMember = "Value";
        }
        private void Loadcmbmakhachhang(ComboBox temp)
        {
            DataTable dt = KhachhangBUS.Instance._Hienthitatcakhachhang();
            foreach (DataRow row in dt.Rows)
            {
                ComboBoxItem item = new ComboBoxItem(row["makh"].ToString(), row["makh"].ToString());
                temp.Items.Add(item);
            }
            temp.DisplayMember = "Text";
            temp.ValueMember = "Value";

        }

        private void cmbmakho_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttenkho.Text = (cmbmakho.SelectedItem as ComboBoxItem).Value.ToString();
        }

        private void cmbmakhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int makhachhang = Convert.ToInt32((cmbmakhachhang.SelectedItem as ComboBoxItem).Value);
            DataTable dt = KhachhangBUS.Instance._GetthongtinKHbyMaKH(makhachhang);
            foreach (DataRow row in dt.Rows)
            {
                txtdonvi.Text = row["ten"].ToString();
                txtdiachi.Text = row["diachi"].ToString();
                txttaikhoankhach.Text = row["sotaikhoan"].ToString();
                txtmaso.Text = row["masothue"].ToString();
            }
        }

        private void Hienthighichu(string mataikhoan)
        {
            DataTable dt = TaikhoanketoanBUS.Instance._Laythongtintaikhoan(mataikhoan);
            foreach (DataRow row in dt.Rows)
            {
                txtghichu.Text = row["tentaikhoan"].ToString();
            }
        }

        private void btnThemnguyenlieu_Click(object sender, EventArgs e)
        {
            frmThemNguyenLieu frmthemnguyenlieu = new frmThemNguyenLieu();
            frmthemnguyenlieu.ShowDialog();
            LoadNguyenLieu();
            dgvnguyenlieu.DataSource = NguyenlieuList;

        }

        private void btnThemvaods_Click(object sender, EventArgs e)
        {
            int manguyenlieu = 0;           

            foreach (DataGridViewRow row in dgvnguyenlieu.SelectedRows)
            {
                manguyenlieu = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            if (manguyenlieu == 0 || txtdongiamua.Text == "" || txtsoluongmua.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            int soluongmua = Convert.ToInt32(txtsoluongmua.Text);
            double dongiamua = Convert.ToDouble(txtdongiamua.Text);
            double thanhtien = soluongmua * dongiamua;
            tongtienhang += thanhtien;
            this.dgvnhapnguyenlieu.Rows.Add("N1521", manguyenlieu, soluongmua, dongiamua, thanhtien);
            txttongtienhang.Text = tongtienhang.ToString();
            


        }

        private void txtthuesuat_TextChanged(object sender, EventArgs e)
        {
            if(txttongtienhang.Text != "")
            {
                txtthueGTGT.Text = (Convert.ToDouble(txtthuesuat.Text) / 100 * Convert.ToDouble(txttongtienhang.Text)).ToString();
                txttongcong.Text = (Convert.ToDouble(txtthueGTGT.Text) + Convert.ToDouble(txttongtienhang.Text)).ToString();
                txttienbangchu.Text = ModuleChuyenTienSangChu.So_chu(Convert.ToDouble(txttongcong.Text));
            }
        }
    }
}
