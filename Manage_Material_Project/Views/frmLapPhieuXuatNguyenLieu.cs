using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Material_Project.Utilities;
using Manage_Material_Project.BLL;
using Manage_Material_Project.DTO;

namespace Manage_Material_Project.Views
{
    public partial class frmLapPhieuXuatNguyenLieu : Form
    {
        //Các biến global
        BindingSource NguyenlieuList = new BindingSource();
        private double tongtienhang = 0;
        private List<Chitietgiaodich> listChitietgiaodich = new List<Chitietgiaodich>();

        public frmLapPhieuXuatNguyenLieu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_STT_Click(object sender, EventArgs e)
        {

        }

        private void frmLapPhieuXuatNguyenLieu_Load(object sender, EventArgs e)
        {
            Setupdatagridview();
            LoadNguyenLieu();
            dgvnguyenlieu.DataSource = NguyenlieuList;
            txttaikhoan.Text = "N621";
            txtsohoadon.Text = HoadongiaodichBUS.Instance._Getsohoadonmoinhat().ToString();
            Hienthighichu("621");
            Loadcmbhinhthucthanhtoan(cmbhinhthucthanhtoan);
            Loadcmbkho(cmbmakho);
            Loadcmbquyen(cmbquyen);
            Loadcmbmakhachhang(cmbmakhachhang);
            //Hiển thị tài khoản đối ứng
            DataTable dt = TaikhoanketoanBUS.Instance._Laythongtintaikhoan("152");
            foreach (DataRow row in dt.Rows)
            {
                txttentaikhoandu.Text = row["tentaikhoan"].ToString();
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
            if (dgvnhapnguyenlieu.ColumnCount == 0)
            {
                dgvnhapnguyenlieu.ColumnCount = 6;
                dgvnhapnguyenlieu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                dgvnhapnguyenlieu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

                dgvnhapnguyenlieu.Columns[0].Name = "taikhoandu";
                dgvnhapnguyenlieu.Columns[0].HeaderText = "TKDU";
                dgvnhapnguyenlieu.Columns[0].Width = 70;
                dgvnhapnguyenlieu.Columns[0].DataPropertyName = "taikhoandu";

                dgvnhapnguyenlieu.Columns[1].Name = "manl";
                dgvnhapnguyenlieu.Columns[1].HeaderText = "Mã nguyên liệu";
                dgvnhapnguyenlieu.Columns[1].Width = 120;
                dgvnhapnguyenlieu.Columns[1].DataPropertyName = "manl";

                dgvnhapnguyenlieu.Columns[2].Name = "soluong";
                dgvnhapnguyenlieu.Columns[2].HeaderText = "Số lượng";
                dgvnhapnguyenlieu.Columns[2].Width = 120;
                dgvnhapnguyenlieu.Columns[2].DataPropertyName = "soluong";

                dgvnhapnguyenlieu.Columns[3].Name = "dongia";
                dgvnhapnguyenlieu.Columns[3].HeaderText = "Đơn giá";
                dgvnhapnguyenlieu.Columns[3].Width = 120;
                dgvnhapnguyenlieu.Columns[3].DataPropertyName = "dongia";

                dgvnhapnguyenlieu.Columns[4].Name = "thanhtien";
                dgvnhapnguyenlieu.Columns[4].HeaderText = "Thành tiền";
                dgvnhapnguyenlieu.Columns[4].Width = 120;
                dgvnhapnguyenlieu.Columns[4].DataPropertyName = "thanhtien";

                dgvnhapnguyenlieu.Columns[5].Name = "tienchuack";
                dgvnhapnguyenlieu.Columns[5].HeaderText = "Tiền chưa CK";
                dgvnhapnguyenlieu.Columns[5].Width = 120;
                dgvnhapnguyenlieu.Columns[5].DataPropertyName = "tienchuack";

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
        private void Loadcmbquyen(ComboBox temp)
        {
            DataTable dt = QuyenBUS.Instance._Laytatcamaquyen();
            foreach (DataRow row in dt.Rows)
            {
                ComboBoxItem item = new ComboBoxItem(row["quyen"].ToString(), row["quyen"].ToString());
                temp.Items.Add(item);
            }
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

        private void Hienthighichu(string mataikhoan)
        {
            DataTable dt = TaikhoanketoanBUS.Instance._Laythongtintaikhoan(mataikhoan);
            foreach (DataRow row in dt.Rows)
            {
                txtghichu.Text = row["tentaikhoan"].ToString();
            }
        }

        void ClearTextboxes(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                ClearTextboxes(ctrl.Controls);
            }
        }

        private void Hienthithongtinquyen(string maquyen)
        {
            DataTable dt = QuyenBUS.Instance._GetThongTinByMaquyen(maquyen);
            foreach (DataRow row in dt.Rows)
            {
                txtmauso.Text = row["mauso"].ToString();
                txtkyhieu.Text = row["kyhieu"].ToString();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txtnguyenlieu.Text != "")
            {
                DataTable dt = NguyenlieuBUS.Instance._Timkiemnguyenlieu(txtnguyenlieu.Text);
                dgvnguyenlieu.DataSource = dt;
            }
            else
                dgvnguyenlieu.DataSource = NguyenlieuList;

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

        private void cmbmakho_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttenkho.Text = (cmbmakho.SelectedItem as ComboBoxItem).Value.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoanlai_Click(object sender, EventArgs e)
        {
            //frmLapPhieuNhapNguyenLieu_Load(null, EventArgs.Empty);
            //this.ResetText();
            ClearTextboxes(this.Controls);
            //Khởi tạo các biến default
            txttaikhoan.Text = "N621";
            cmbquyen.Text = "2";
            txtsohoadon.Text = HoadongiaodichBUS.Instance._Getsohoadonmoinhat().ToString();
            Hienthithongtinquyen(cmbquyen.Text);
            Hienthighichu("621");
            //Clear datagridview
            dgvnhapnguyenlieu.Rows.Clear();
            //Clear lischitietgiaodich
            listChitietgiaodich.Clear();
            //Hiển thị tài khoản đối ứng
            DataTable dt = TaikhoanketoanBUS.Instance._Laythongtintaikhoan("152");
            foreach (DataRow row in dt.Rows)
            {
                txttentaikhoandu.Text = row["tentaikhoan"].ToString();
            }
        }

        private void cmbquyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maquyen = Convert.ToString((cmbquyen.SelectedItem as ComboBoxItem).Value);
            DataTable dt = QuyenBUS.Instance._GetThongTinByMaquyen(maquyen);
            foreach (DataRow row in dt.Rows)
            {
                txtkyhieu.Text = row["kyhieu"].ToString();
                txtmauso.Text = row["mauso"].ToString();
            }
        }
    }
}
