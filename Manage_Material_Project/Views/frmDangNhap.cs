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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void lblmessage_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (!TaikhoanBUS.Instance._Kiemtrataikhoan(txttaikhoan.Text, txtmatkhau.Text))
            {
                lblmessage.Text = "Tài khoản và mật khẩu không đúng";
                txtmatkhau.Clear();
                txttaikhoan.Clear();
                txttaikhoan.Focus();
            }
            else
            {
                this.Hide();
                frmTrangChu frmtrangchu = new frmTrangChu();
                frmtrangchu.ShowDialog();
                this.Show();
                lblmessage.Text = "";
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
