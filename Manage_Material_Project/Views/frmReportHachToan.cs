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
using System.Data.SqlClient;


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
           
        }

        private void ShowResult()
        {
            reportViewerHachToan.Reset();

            DataTable dt = GetData(configMonth(textBoxThang.Text), textBoxNam.Text);
            ReportDataSource rds = new ReportDataSource("hachtoan", dt);

            this.reportViewerHachToan.LocalReport.DataSources.Add(rds);

            this.reportViewerHachToan.LocalReport.ReportPath = "E:/Ketoan/Manage_Material_Project/Manage_Material_Project/Reports/HachToan.rdlc";

            ReportParameter[] rp_param = new ReportParameter[2];

            rp_param[0] = new ReportParameter("Month", textBoxThang.Text);
            rp_param[1] = new ReportParameter("Year", textBoxNam.Text);

            try { 
            this.reportViewerHachToan.LocalReport.SetParameters(rp_param);
                }
            catch (Exception e) { 
                Console.WriteLine(e.ToString()); 
            }
            this.reportViewerHachToan.RefreshReport();

        }

        private void buttonHachToan_Click(object sender, EventArgs e)
        {
            ShowResult();
        }

        private DataTable GetData(String month, String year)
        {
            
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlCommand cmd = new SqlCommand("hachtoan",con);
                cmd.CommandText = "hachtoan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            return dt;

        }

        private String configMonth(String month)
        {
            if (month.Length == 1)
            {
                return month = "0" + month;
            }

            return month;
        }
    }
}   
