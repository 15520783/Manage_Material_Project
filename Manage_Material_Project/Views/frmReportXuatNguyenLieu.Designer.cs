﻿namespace Manage_Material_Project.Views
{
    partial class frmReportXuatNguyenLieu
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
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbDataset = new Manage_Material_Project.dbDataset();
            this.vIEWNHATKYXUATNGUYENLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_NHATKYXUATNGUYENLIEUTableAdapter = new Manage_Material_Project.dbDatasetTableAdapters.VIEW_NHATKYXUATNGUYENLIEUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWNHATKYXUATNGUYENLIEUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(111, 13);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFromDate.TabIndex = 1;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(381, 13);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpToDate.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(619, 10);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 26);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "NhatKiXuatNguyenLieu";
            reportDataSource1.Value = this.vIEWNHATKYXUATNGUYENLIEUBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Manage_Material_Project.Reports.NhatKyXuatNguyenLieu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(793, 431);
            this.reportViewer1.TabIndex = 3;
            // 
            // dbDataset
            // 
            this.dbDataset.DataSetName = "dbDataset";
            this.dbDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIEWNHATKYXUATNGUYENLIEUBindingSource
            // 
            this.vIEWNHATKYXUATNGUYENLIEUBindingSource.DataMember = "VIEW_NHATKYXUATNGUYENLIEU";
            this.vIEWNHATKYXUATNGUYENLIEUBindingSource.DataSource = this.dbDataset;
            // 
            // vIEW_NHATKYXUATNGUYENLIEUTableAdapter
            // 
            this.vIEW_NHATKYXUATNGUYENLIEUTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportXuatNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 469);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Name = "frmReportXuatNguyenLieu";
            this.Text = "frmReportXuatNguyenLieu";
            this.Load += new System.EventHandler(this.frmReportXuatNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWNHATKYXUATNGUYENLIEUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnThongKe;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dbDataset dbDataset;
        private System.Windows.Forms.BindingSource vIEWNHATKYXUATNGUYENLIEUBindingSource;
        private dbDatasetTableAdapters.VIEW_NHATKYXUATNGUYENLIEUTableAdapter vIEW_NHATKYXUATNGUYENLIEUTableAdapter;
    }
}