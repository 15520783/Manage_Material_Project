using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Manage_Material_Project.Views
{
    public partial class frmReportHachToan : Form
    {
        public frmReportHachToan()
        {
            InitializeComponent();
        }

        private void frmReportHachToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataset.VIEW_HACHTOAN_NHAPHANG' table. You can move, or remove it, as needed.
            this.vIEW_HACHTOAN_NHAPHANGTableAdapter.Fill(this.dbDataset.VIEW_HACHTOAN_NHAPHANG);
            // TODO: This line of code loads data into the 'dbDataset.VIEW_HACHTOAN' table. You can move, or remove it, as needed.
            this.vIEW_HACHTOANTableAdapter.Fill(this.dbDataset.VIEW_HACHTOAN);

        }

        public void SetParameters(String month, String year)
        {
            ReportParameter[] rp_param = new ReportParameter[2];
            rp_param[0] = new ReportParameter("Month");
            rp_param[1] = new ReportParameter("Year");


            rp_param[0].Values.Add(month.ToString());
            rp_param[1].Values.Add(year.ToString());

            reportViewerHachToan.LocalReport.SetParameters(rp_param);
        }

        private void buttonHachToan_Click(object sender, EventArgs e)
        {
            SetParameters(textBoxThang.Text, textBoxNam.Text);
            reportViewerHachToan.RefreshReport();
        }

    }
}
