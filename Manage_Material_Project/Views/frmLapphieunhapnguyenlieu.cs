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
using Manage_Material_Project.DTO;

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
        //Các biến global
        BindingSource NguyenlieuList = new BindingSource();
        private double tongtienhang = 0;
        private List<Chitietgiaodich> listChitietgiaodich = new List<Chitietgiaodich>();

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
            Loadcmbquyen(cmbquyen);
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

        private void Loadcmbquyen(ComboBox temp)
        {
            DataTable dt = QuyenBUS.Instance._Laytatcamaquyen();
            foreach(DataRow row in dt.Rows)
            {
                ComboBoxItem item = new ComboBoxItem(row["quyen"].ToString(), row["quyen"].ToString());
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

        void ClearTextboxes(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                ClearTextboxes(ctrl.Controls);
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
            // Lấy thông tin nguyên liệu được thêm vào
            foreach (DataGridViewRow row in dgvnguyenlieu.SelectedRows)
            {
                manguyenlieu = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            if (manguyenlieu == 0 || txtdongiamua.Text == "" || txtsoluongmua.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            //Khai báo các biến lưu trữ dữ liệu
            int soluongmua = Convert.ToInt32(txtsoluongmua.Text);
            double dongiamua = Convert.ToDouble(txtdongiamua.Text);
            double thanhtien = soluongmua * dongiamua;
            tongtienhang += thanhtien;
            int flag = 0;
            //Thêm vào list chi tiết giao dịch, kiểm tra trùng mã nguyên liệu
            for(int i = 0; i < listChitietgiaodich.Count; i++)
            {
                if(listChitietgiaodich[i].manl == manguyenlieu)
                {
                    listChitietgiaodich[i].soluong += soluongmua;
                    listChitietgiaodich[i].thanhtien += thanhtien;
                    flag = -1;
                }
            }
            if(flag == 0)
            {
                Chitietgiaodich chitietgiaodich = new Chitietgiaodich(Convert.ToInt32(txtsohoadon.Text), manguyenlieu, soluongmua, dongiamua, thanhtien, "N1521");
                listChitietgiaodich.Add(chitietgiaodich);
            }

            //Thay đổi dgv nguyên liệu thêm vào
            dgvnhapnguyenlieu.Rows.Clear();
            for(int i =0; i<listChitietgiaodich.Count; i++)
            {
                dgvnhapnguyenlieu.Rows.Add(listChitietgiaodich[i].taikhoandu, listChitietgiaodich[i].manl, listChitietgiaodich[i].soluong, listChitietgiaodich[i].dongia, listChitietgiaodich[i].thanhtien);

            }
            //Thay đổi text box thành tiền
            txttongtienhang.Text = tongtienhang.ToString();
            if (txtthuesuat.Text != "")
            {
                txtthueGTGT.Text = (Convert.ToDouble(txtthuesuat.Text) / 100 * Convert.ToDouble(txttongtienhang.Text)).ToString();
                txttongcong.Text = (Convert.ToDouble(txtthueGTGT.Text) + Convert.ToDouble(txttongtienhang.Text)).ToString();
                txttienbangchu.Text = ModuleChuyenTienSangChu.So_chu(Convert.ToDouble(txttongcong.Text));
            }
            else
            {
                txttongcong.Text = (txttongtienhang.Text).ToString();
                txttienbangchu.Text = ModuleChuyenTienSangChu.So_chu(Convert.ToDouble(txttongcong.Text));
            }
            //Clear textbox soluong và dongia
            txtdongiamua.Clear();
            txtsoluongmua.Clear();


        }

        private void txtthuesuat_TextChanged(object sender, EventArgs e)
        {
            if(txttongtienhang.Text != "")
            {
                if(txtthuesuat.Text!="")
                {
                    txtthueGTGT.Text = (Convert.ToDouble(txtthuesuat.Text) / 100 * Convert.ToDouble(txttongtienhang.Text)).ToString();
                    txttongcong.Text = (Convert.ToDouble(txtthueGTGT.Text) + Convert.ToDouble(txttongtienhang.Text)).ToString();
                    txttienbangchu.Text = ModuleChuyenTienSangChu.So_chu(Convert.ToDouble(txttongcong.Text));
                }
                else
                {
                    txttongcong.Text = (txttongtienhang.Text).ToString();
                    txttienbangchu.Text = ModuleChuyenTienSangChu.So_chu(Convert.ToDouble(txttongcong.Text));
                    txtthueGTGT.Text = "0";
                }
                
            }
        }

        private void txtsoluongmua_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtdongiamua_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtnguyenlieu.Text != "")
            {
                DataTable dt = NguyenlieuBUS.Instance._Timkiemnguyenlieu(txtnguyenlieu.Text);
                dgvnguyenlieu.DataSource = dt;
            }
            else
                dgvnguyenlieu.DataSource = NguyenlieuList;
            
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
            txttaikhoan.Text = "C331";
            cmbquyen.Text = "1";
            txtsohoadon.Text = HoadongiaodichBUS.Instance._Getsohoadonmoinhat().ToString();
            Hienthighichu("331");
            //Clear datagridview
            dgvnhapnguyenlieu.Rows.Clear();
            //Clear lischitietgiaodich
            listChitietgiaodich.Clear();
            //Hiển thị tài khoản đối ứng
            DataTable dt = TaikhoanketoanBUS.Instance._Laythongtintaikhoan("152");
            foreach (DataRow row in dt.Rows)
            {
                txttaikhoandu.Text = row["tentaikhoan"].ToString();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra điều kiện rỗng của các trường
            if (txttenkho.Text == "" || cmbmakhachhang.Text == "" || txttongtienhang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Thông báo");
                return;
            }
            //Khởi tạo các biến tạm lưu trữ thông tin
            int sohoadon = Convert.ToInt32(txtsohoadon.Text);
            var ngayphathanh = Convert.ToDateTime(dtmngayphathanh.Value);
            var ngaythanhtoan = Convert.ToDateTime(dtmngaythanhtoan.Value);
            string lydo = txtlydo.Text;
            string hinhthucthanhtoan = "";
            if(cmbhinhthucthanhtoan.Text != "")
            {
                hinhthucthanhtoan = (cmbhinhthucthanhtoan.SelectedItem as ComboBoxItem).Value.ToString();
            }
               
            
            int thuesuat = 0;
            if (txtthuesuat.Text!="")
            {
                thuesuat = Convert.ToInt32(txtthuesuat.Text);
            }
           
            double tongtien = Convert.ToDouble(txttongtienhang.Text);
            string taikhoanchinh = txttaikhoan.Text;
            string taikhoandu = txttaikhoandu.Text;
            int makho = Convert.ToInt32((cmbmakho.SelectedItem as ComboBoxItem).Text.ToString());
            string quyen = cmbquyen.Text;
            int makh = Convert.ToInt32((cmbmakhachhang.SelectedItem as ComboBoxItem).Text.ToString());
            var ngayban = Convert.ToDateTime(dtmngayban.Value);
            double tongthueGTGT = Convert.ToDouble(txtthueGTGT.Text);
            
            //Thêm hóa đơn và chi tiết hóa đơn
            Hoadongiaodich hoadongiaodich = new Hoadongiaodich(sohoadon, ngayphathanh, ngaythanhtoan, hinhthucthanhtoan, lydo, thuesuat, tongtien, taikhoanchinh, taikhoandu, makho, quyen, makh, ngayban, tongthueGTGT,1);
            int flag = 0;
            //Thêm chi tiết giao dịch
            //Thêm hóa đơn giao dịch
            if (HoadongiaodichBUS.Instance._Themhoadongiaodich(hoadongiaodich) > 0)
            {
                for (int i = 0; i < listChitietgiaodich.Count; i++)
                {
                    if (ChitietgiaodichBUS.Instance._Themchitietgiaodich(listChitietgiaodich[i]) <= 0)
                        flag = -1;

                 }
                if(flag == 0)
                {
                    MessageBox.Show("Thêm thành công. Bạn có muốn in hóa đơn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
                else MessageBox.Show("Thêm thành công", "Thông báo!");

            }

            else MessageBox.Show("Thêm thành công", "Thông báo!");

        }

        private void txtthuesuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
