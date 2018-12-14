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
using Manage_Material_Project.DAO;


namespace Manage_Material_Project.Views
{
    public partial class frmLapPhieuXuatNguyenLieu : Form
    {
        //Các biến global
        private double tongtienhang = 0;
        private List<Nguyenlieu> listChitietgiaodich = new List<Nguyenlieu>();
        //Các hàm được thực hiện khi chuyển form
        public void Loadkhachhang(string makh, string donvi, string diachi, string taikhoan, string maso)
        {
            txtmakhachang.Text = makh;
            txtdonvi.Text = donvi;
            txtdiachi.Text = diachi;
            txttaikhoankhach.Text = taikhoan;
            txtmaso.Text = maso;
        }

        public void Chonmanguyenlieu(string manguyenlieu)
        {
            dgvnhapnguyenlieu.CurrentCell.Value = manguyenlieu;
            int indexrow = dgvnhapnguyenlieu.CurrentCell.RowIndex;
            dgvnhapnguyenlieu.Rows[indexrow].Cells["taikhoandu"].Value = "C1521";

        }
        //

        public frmLapPhieuXuatNguyenLieu(string makho, string tenkho)
        {
            InitializeComponent();
            txtmakho.Text = makho;
            txttenkho.Text = tenkho;
        }

       
        private void frmLapPhieuXuatNguyenLieu_Load(object sender, EventArgs e)
        {
            Setupdatagridview();            
            txttaikhoan.Text = "N621";
            Hienthighichu("621");
            txtsophieu.Text = PhieuBUS.Instance._Getsohoadonmoinhat(3).ToString() + "-" + dtmngayphathanh.Value.Month + "-" + dtmngayphathanh.Value.Year % 100;
            Loadcmbhinhthucthanhtoan(cmbhinhthucthanhtoan);
            Loadcmbquyen(cmbquyen);
            //Hiển thị tài khoản đối ứng
            DataTable dt = TaikhoanketoanBUS.Instance._Laythongtintaikhoan("152");
            foreach (DataRow row in dt.Rows)
            {
                txttentaikhoandu.Text = row["tentaikhoan"].ToString();
            }

        }
       
        private void Setupdatagridview()
        {
            
            dgvnhapnguyenlieu.AutoGenerateColumns = false;
            if (dgvnhapnguyenlieu.ColumnCount == 0)
            {
                dgvnhapnguyenlieu.ColumnCount = 6;
                dgvnhapnguyenlieu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                dgvnhapnguyenlieu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

                dgvnhapnguyenlieu.Columns[0].Name = "taikhoandu";
                dgvnhapnguyenlieu.Columns[0].HeaderText = "TKDU";
                dgvnhapnguyenlieu.Columns[0].Width = 100;
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
                dgvnhapnguyenlieu.Columns[3].ReadOnly = true;

                dgvnhapnguyenlieu.Columns[4].Name = "thanhtien";
                dgvnhapnguyenlieu.Columns[4].HeaderText = "Thành tiền";
                dgvnhapnguyenlieu.Columns[4].Width = 120;
                dgvnhapnguyenlieu.Columns[4].DataPropertyName = "thanhtien";
                dgvnhapnguyenlieu.Columns[4].ReadOnly = true;

                dgvnhapnguyenlieu.Columns[5].Name = "tienchuack";
                dgvnhapnguyenlieu.Columns[5].HeaderText = "Tiền chưa CK";
                dgvnhapnguyenlieu.Columns[5].Width = 120;
                dgvnhapnguyenlieu.Columns[5].DataPropertyName = "tienchuack";
                dgvnhapnguyenlieu.Columns[5].ReadOnly = true;

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
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTrangChu.Instance.Show();
        }

        private void btnHoanlai_Click(object sender, EventArgs e)
        {
            //frmLapPhieuNhapNguyenLieu_Load(null, EventArgs.Empty);
            //this.ResetText();
            ClearTextboxes(this.Controls);
            //Khởi tạo các biến default
            txttaikhoan.Text = "N621";
            txtsophieu.Text = PhieuBUS.Instance._Getsohoadonmoinhat(3).ToString() + "-" + dtmngayphathanh.Value.Month + "-" + dtmngayphathanh.Value.Year % 100;
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

        private void txtmakhachang_Enter(object sender, EventArgs e)
        {
            frmChonKhachHang frm = new frmChonKhachHang();
            DialogResult result = frm.ShowDialog(this);
            //frm.ShowDialog();
        }

        private void dgvnhapnguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow = dgvnhapnguyenlieu.CurrentCell.RowIndex;

            //cell nguyên liệu
            if (dgvnhapnguyenlieu.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                frmChonNguyenLieu frm = new frmChonNguyenLieu();
                DialogResult result = frm.ShowDialog(this);
            }
            //cell số lượng
            if (dgvnhapnguyenlieu.CurrentCell.ColumnIndex.Equals(2) || dgvnhapnguyenlieu.CurrentCell.ColumnIndex.Equals(3))
            {
                if (dgvnhapnguyenlieu.Rows[indexrow].Cells["manl"].Value == null)
                {
                    MessageBox.Show("Vui lòng nhập mã nguyên liệu trước!", "Thông báo!");

                }
            }
        }

        private void cmbquyen_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string maquyen = Convert.ToString((cmbquyen.SelectedItem as ComboBoxItem).Value);
            DataTable dt = QuyenBUS.Instance._GetThongTinByMaquyen(maquyen);
            foreach (DataRow row in dt.Rows)
            {
                txtkyhieu.Text = row["kyhieu"].ToString();
                txtmauso.Text = row["mauso"].ToString();
            }
        }

        private void frmLapPhieuXuatNguyenLieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTrangChu.Instance.Show();
        }

        private void dgvnhapnguyenlieu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvnhapnguyenlieu.CurrentCell != null)
            {
                int indexrow = dgvnhapnguyenlieu.CurrentCell.RowIndex;
                //cell đơn giá
                if (dgvnhapnguyenlieu.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
                {

                    if (dgvnhapnguyenlieu.Rows[indexrow].Cells["soluong"].Value.ToString() != "")
                    {
                        dgvnhapnguyenlieu.Rows[indexrow].Cells["thanhtien"].Value = Convert.ToUInt32(dgvnhapnguyenlieu.Rows[indexrow].Cells["soluong"].Value) * Convert.ToUInt32(dgvnhapnguyenlieu.Rows[indexrow].Cells["dongia"].Value);
                        dgvnhapnguyenlieu.Rows[indexrow].Cells["tienchuack"].Value = dgvnhapnguyenlieu.Rows[indexrow].Cells["thanhtien"].Value;
                    }

                    //Thay đổi các textbox tính tiền hàng
                    tongtienhang += Convert.ToDouble(dgvnhapnguyenlieu.Rows[indexrow].Cells["thanhtien"].Value);
                    txttongtienhang.Text = tongtienhang.ToString();
                    if (txtthuesuat.Text != "")
                    {
                        txtthueGTGT.Text = (tongtienhang * Convert.ToDouble(txtthuesuat.Text) * 0.01).ToString();
                    }
                    else txtthueGTGT.Text = "0";
                    txttongcong.Text = (tongtienhang + Convert.ToDouble(txtthueGTGT.Text)).ToString();
                    txttienbangchu.Text = ModuleChuyenTienSangChu.So_chu(Convert.ToDouble(txttongcong.Text));
                }
                //cell số lượng
                if (dgvnhapnguyenlieu.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
                {
                    if (Convert.ToInt32(dgvnhapnguyenlieu.Rows[indexrow].Cells["soluong"].Value) > TonkhoBUS.Instance._Laysoluongtonnguyenlieu(Convert.ToInt32(dgvnhapnguyenlieu.Rows[indexrow].Cells["manl"].Value), Convert.ToInt32(txtmakho.Text)))
                    {
                        dgvnhapnguyenlieu.Rows[indexrow].Cells["soluong"].Value = TonkhoBUS.Instance._Laysoluongtonnguyenlieu(Convert.ToInt32(dgvnhapnguyenlieu.Rows[indexrow].Cells["manl"].Value), Convert.ToInt32(txtmakho.Text));
                        MessageBox.Show("Số lượng tồn tối thiểu của nguyên liệu " + dgvnhapnguyenlieu.Rows[indexrow].Cells["manl"].Value.ToString() + " là: " + TonkhoBUS.Instance._Laysoluongtonnguyenlieu(Convert.ToInt32(dgvnhapnguyenlieu.Rows[indexrow].Cells["manl"].Value), Convert.ToInt32(txtmakho.Text)), "Thông báo");
                    }
                    if (dgvnhapnguyenlieu.Rows[indexrow].Cells["dongia"].Value != null)
                    {
                        dgvnhapnguyenlieu.Rows[indexrow].Cells["thanhtien"].Value = Convert.ToUInt32(dgvnhapnguyenlieu.Rows[indexrow].Cells["soluong"].Value) * Convert.ToUInt32(dgvnhapnguyenlieu.Rows[indexrow].Cells["dongia"].Value);
                        dgvnhapnguyenlieu.Rows[indexrow].Cells["tienchuack"].Value = dgvnhapnguyenlieu.Rows[indexrow].Cells["thanhtien"].Value;
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra điều kiện rỗng của các trường
            if (txtsohoadon.Text == "" || txtmakhachang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Thông báo");
                return;
            }
            //Tạo list các chi tiết giao dịch
            listChitietgiaodich.Clear();
            string taikhoandoiung = "";
            int manl = 0;
            int soluong = 0;
            double dongia = 0;
            double thanhtien = 0;
            for (int row = 0; row < dgvnhapnguyenlieu.RowCount - 1; row++)
            {
                if (dgvnhapnguyenlieu.Rows[row].Cells["taikhoandu"].Value != null)
                {
                    taikhoandoiung = dgvnhapnguyenlieu.Rows[row].Cells["taikhoandu"].Value.ToString();
                }
                if (dgvnhapnguyenlieu.Rows[row].Cells["manl"].Value != null)
                {
                    manl = Convert.ToInt32(dgvnhapnguyenlieu.Rows[row].Cells["manl"].Value.ToString());
                }
                if (dgvnhapnguyenlieu.Rows[row].Cells["soluong"].Value != null)
                {
                    soluong = Convert.ToInt32(dgvnhapnguyenlieu.Rows[row].Cells["soluong"].Value.ToString());
                }
               
                if ( dgvnhapnguyenlieu.Rows[row].Cells["soluong"].Value == null || dgvnhapnguyenlieu.Rows[row].Cells["manl"].Value == null)
                {
                    MessageBox.Show("Thông báo", "Vui lòng nhập nguyên liệu cần xuất");
                    return;
                }
                Nguyenlieu nguyenlieu = new Nguyenlieu(txtsophieu.Text, manl, soluong, dongia, thanhtien, taikhoandoiung);
                listChitietgiaodich.Add(nguyenlieu);


            }
            //Khởi tạo các biến tạm lưu trữ thông tin
            int sohoadon = Convert.ToInt32(txtsohoadon.Text);
            var ngayphathanh = Convert.ToDateTime(dtmngayphathanh.Value);
            var ngaythanhtoan = Convert.ToDateTime(dtmngaythanhtoan.Value);
            string lydo = txtlydo.Text;
            string hinhthucthanhtoan = "";
            if (cmbhinhthucthanhtoan.Text != "")
            {
                hinhthucthanhtoan = (cmbhinhthucthanhtoan.SelectedItem as ComboBoxItem).Value.ToString();
            }
            int thuesuat = 0;
            if (txtthuesuat.Text != "")
            {
                thuesuat = Convert.ToInt32(txtthuesuat.Text);
            }

            double tongtien = 0;
            string taikhoanchinh = txttaikhoan.Text;
            string taikhoandu = txttaikhoandu.Text;
            string quyen = cmbquyen.Text;
            int makh = Convert.ToInt32(txtmakhachang.Text);
            var ngayban = Convert.ToDateTime(dtmngayban.Value);
            double tongthueGTGT = 0;
            int makho = Convert.ToInt32(txtmakho.Text);
            //Thêm hóa đơn và chi tiết hóa đơn
            Phieu hoadongiaodich = new Phieu(txtsophieu.Text, sohoadon, ngayphathanh, ngaythanhtoan, hinhthucthanhtoan, lydo, thuesuat, tongtien, taikhoanchinh, taikhoandu, makho, quyen, makh, ngayban, tongthueGTGT, 3);
            int flag = 0;
            //Thêm chi tiết giao dịch
            //Thêm hóa đơn giao dịch
            if (PhieuBUS.Instance._Themhoadongiaodich(hoadongiaodich) > 0)
            {
                for (int i = 0; i < listChitietgiaodich.Count; i++)
                {
                    if (NguyenlieuBUS.Instance._Themchitietgiaodich(listChitietgiaodich[i]) > 0)
                    {
                        //Cập nhật số lượng tồn kho của nguyên liệu
                        DataTable dt = TonkhoBUS.Instance._Gettonkho(Convert.ToInt32(listChitietgiaodich[i].manl), Convert.ToInt32(txtmakho.Text));
                        int flagsoluong = listChitietgiaodich[i].soluong;
                        foreach (DataRow row in dt.Rows)
                        {
                            if (flagsoluong <= Convert.ToInt32(row["soluongton"]))
                            {
                                flagsoluong = Convert.ToInt32(row["soluongton"]) - flagsoluong;
                                TonkhoBUS.Instance._Updatetonkho(Convert.ToInt32(row["thang"]), Convert.ToInt32(row["nam"]), Convert.ToInt32(row["manl"]), Convert.ToInt32(row["makho"]), flagsoluong);
                                break;
                            }
                            else
                            {
                                flagsoluong = flagsoluong - Convert.ToInt32(row["soluongton"]);
                                TonkhoBUS.Instance._Updatetonkho(Convert.ToInt32(row["thang"]), Convert.ToInt32(row["nam"]), Convert.ToInt32(row["manl"]), Convert.ToInt32(row["makho"]), 0);

                            }
                        }

                    }
                    else
                    {
                        flag = -1;
                    }

                }
                if (flag == 0)
                {
                    MessageBox.Show("Thêm thành công. Bạn có muốn in hóa đơn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
                else
                {
                    NguyenlieuBUS.Instance._Xoachitietgiaodich(txtsophieu.Text);
                    PhieuBUS.Instance._Xoaphieubypso(txtsophieu.Text);
                    MessageBox.Show("Lỗi", "Thông báo!");
                }


            }

            else
            {
                NguyenlieuBUS.Instance._Xoachitietgiaodich(txtsophieu.Text);
                PhieuBUS.Instance._Xoaphieubypso(txtsophieu.Text);
                MessageBox.Show("Lỗi 1", "Thông báo!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NguyenlieuBUS.Instance._Xoachitietgiaodich(txtsophieu.Text) > 0)
            {
                PhieuBUS.Instance._Xoaphieubypso(txtsophieu.Text);
                MessageBox.Show("Xóa thành công phiếu số " + txtsophieu.Text, "Thông báo!");
            }
            else
                MessageBox.Show("Không tồn tại phiếu số " + txtsophieu.Text + "trong hệ thống.", "Thông báo!");
        }

        private void dtmngayphathanh_ValueChanged(object sender, EventArgs e)
        {
            txtsophieu.Text = PhieuBUS.Instance._Getsohoadonmoinhat(3).ToString() + "-" + dtmngayphathanh.Value.Month + "-" + dtmngayphathanh.Value.Year % 100;

        }
    }
}
