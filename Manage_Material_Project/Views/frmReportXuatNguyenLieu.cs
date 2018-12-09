using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Material_Project.Views
{
    public partial class frmReportXuatNguyenLieu : Form
    {
        public frmReportXuatNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmReportXuatNguyenLieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataset.VIEW_NHATKYXUATNGUYENLIEU' table. You can move, or remove it, as needed.
            this.vIEW_NHATKYXUATNGUYENLIEUTableAdapter.Fill(this.dbDataset.VIEW_NHATKYXUATNGUYENLIEU);
            // TODO: This line of code loads data into the 'dbDataSet.VIEW_NHATKYXUATNGUYENLIEU' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
            this.SetParameters(dtpFromDate.Value, dtpToDate.Value);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public void SetParameters(DateTime fromDate, DateTime toDate)
        {
            ReportParameter[] rp_param = new ReportParameter[2];
            rp_param[0] = new ReportParameter("FromDate");
            rp_param[1] = new ReportParameter("ToDate");

            rp_param[0].Values.Add(fromDate.ToShortDateString());
            rp_param[1].Values.Add(toDate.ToShortDateString());

            reportViewer1.LocalReport.SetParameters(rp_param);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.SetParameters(dtpFromDate.Value, dtpToDate.Value);
            reportViewer1.RefreshReport();
        }
    }
}
