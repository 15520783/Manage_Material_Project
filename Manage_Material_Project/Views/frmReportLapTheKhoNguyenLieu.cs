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
    public partial class frmReportLapTheKhoNguyenLieu : Form
    {
        public frmReportLapTheKhoNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmReportLapTheKhoNguyenLieu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
