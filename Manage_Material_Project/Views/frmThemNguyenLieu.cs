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
    public partial class frmThemNguyenLieu : Form
    {
        public frmThemNguyenLieu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmThemNguyenLieu_Load(object sender, EventArgs e)
        {
            txtmanguyenlieu.Text = NguyenlieuBUS.Instance._Getmanguyenlieumoinhat().ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txttennguyenlieu.Text = "";
            txtdonvitinh.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txttennguyenlieu.Text == "" || txtdonvitinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo!");
            }
            else
            {
                if (NguyenlieuBUS.Instance._Themnguyenlieu(Convert.ToInt32(txtmanguyenlieu.Text), txttennguyenlieu.Text.ToString(), txtdonvitinh.Text.ToString()) > 0)
                    MessageBox.Show("Thêm nguyên liệu thành công", "Thông báo!");
            }
            
        }

        private void frmThemNguyenLieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
