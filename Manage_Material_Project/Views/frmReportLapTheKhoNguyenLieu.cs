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
using Microsoft.Reporting.WinForms;

namespace Manage_Material_Project.Views
{
    public partial class frmReportLapTheKhoNguyenLieu : Form
    {
        public frmReportLapTheKhoNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmReportLapTheKhoNguyenLieu_Load(object sender, EventArgs e)
        {
            Loadcmbkho(cmbKho);
            Loadcmbnguyenlieu(cmbNguyenLieu);
            //this.SetParameters((cmbNguyenLieu.SelectedItem as ComboBoxItem).Value.ToString(), (cmbNguyenLieu.SelectedItem as ComboBoxItem).Text.ToString(), (cmbKho.SelectedItem as ComboBoxItem).Value.ToString(), (cmbKho.SelectedItem as ComboBoxItem).Text.ToString(), txtthang.Text, txtnam.Text);
            // TODO: This line of code loads data into the 'dSTheKhoNguyenLieu.VIEW_LAPTHEKHONGUYENLIEU' table. You can move, or remove it, as needed.
            //this.vIEW_LAPTHEKHONGUYENLIEUTableAdapter.Fill(this.dSTheKhoNguyenLieu.VIEW_LAPTHEKHONGUYENLIEU,2, 100000001,12,2018);

            this.reportViewer1.RefreshReport();
        }
        private void Loadcmbnguyenlieu(ComboBox temp)
        {
            DataTable dt = DanhmucnguyenlieuBUS.Instance._Hienthitatcanguyenlieu();
            foreach (DataRow row in dt.Rows)
            {
                ComboBoxItem item = new ComboBoxItem(row["manl"].ToString(), row["tennguyenlieu"].ToString());
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
                ComboBoxItem item = new ComboBoxItem(row["makho"].ToString(), row["tenkho"].ToString());
                temp.Items.Add(item);
            }
            temp.DisplayMember = "Text";
            temp.ValueMember = "Value";
        }

        public void SetParameters(String manl, String tennguyenlieu, String makho, String tenkho, String thang, String nam)
        {
            ReportParameter[] rp_param = new ReportParameter[6];
            rp_param[0] = new ReportParameter("manl");
            rp_param[1] = new ReportParameter("tennguyenlieu");
            rp_param[2] = new ReportParameter("thang");
            rp_param[3] = new ReportParameter("nam");
            rp_param[4] = new ReportParameter("makho");
            rp_param[5] = new ReportParameter("tenkho");

            rp_param[0].Values.Add(manl);
            rp_param[1].Values.Add(tennguyenlieu);
            rp_param[2].Values.Add(thang.ToString());
            rp_param[3].Values.Add(nam.ToString());
            rp_param[4].Values.Add(makho.ToString());
            rp_param[5].Values.Add(tenkho);



            reportViewer1.LocalReport.SetParameters(rp_param);
        }

        private void btnLapthekho_Click(object sender, EventArgs e)
        {
            this.vIEW_LAPTHEKHONGUYENLIEUTableAdapter.Fill(this.dSTheKhoNguyenLieu.VIEW_LAPTHEKHONGUYENLIEU,Convert.ToInt32( (cmbKho.SelectedItem as ComboBoxItem).Value),Convert.ToInt32((cmbNguyenLieu.SelectedItem as ComboBoxItem).Value.ToString()),Convert.ToInt32(txtthang.Text), Convert.ToInt32(txtnam.Text));
            this.SetParameters((cmbNguyenLieu.SelectedItem as ComboBoxItem).Value.ToString(), (cmbNguyenLieu.SelectedItem as ComboBoxItem).Text.ToString(),(cmbKho.SelectedItem as ComboBoxItem).Value.ToString(), (cmbKho.SelectedItem as ComboBoxItem).Text.ToString(),txtthang.Text,txtnam.Text);
            reportViewer1.RefreshReport();
        }
    }
}
