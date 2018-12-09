namespace Manage_Material_Project.Views
{
    partial class frmReportMuaNguyenLieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbDataset = new Manage_Material_Project.dbDataset();
            this.vIEWNHATKYMUANGUYENLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_NHATKYMUANGUYENLIEUTableAdapter = new Manage_Material_Project.dbDatasetTableAdapters.VIEW_NHATKYMUANGUYENLIEUTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWNHATKYMUANGUYENLIEUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 694);
            this.panel1.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(520, 9);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(186, 26);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(282, 12);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpToDate.TabIndex = 3;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(12, 12);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFromDate.TabIndex = 4;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "NHATKYMUANGUYENLIEU";
            reportDataSource1.Value = this.vIEWNHATKYMUANGUYENLIEUBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Manage_Material_Project.Reports.NhatKyMuaNguyenLieu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1355, 694);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbDataset
            // 
            this.dbDataset.DataSetName = "dbDataset";
            this.dbDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIEWNHATKYMUANGUYENLIEUBindingSource
            // 
            this.vIEWNHATKYMUANGUYENLIEUBindingSource.DataMember = "VIEW_NHATKYMUANGUYENLIEU";
            this.vIEWNHATKYMUANGUYENLIEUBindingSource.DataSource = this.dbDataset;
            // 
            // vIEW_NHATKYMUANGUYENLIEUTableAdapter
            // 
            this.vIEW_NHATKYMUANGUYENLIEUTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportMuaNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 749);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportMuaNguyenLieu";
            this.Text = "frmReportMuaNguyenLieu";
            this.Load += new System.EventHandler(this.frmReportMuaNguyenLieu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWNHATKYMUANGUYENLIEUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dbDataset dbDataset;
        private System.Windows.Forms.BindingSource vIEWNHATKYMUANGUYENLIEUBindingSource;
        private dbDatasetTableAdapters.VIEW_NHATKYMUANGUYENLIEUTableAdapter vIEW_NHATKYMUANGUYENLIEUTableAdapter;
    }
}