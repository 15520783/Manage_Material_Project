namespace Manage_Material_Project.Views
{
    partial class frmReportHachToan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerHachToan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBoxThang = new System.Windows.Forms.TextBox();
            this.labelThang = new System.Windows.Forms.Label();
            this.labelNam = new System.Windows.Forms.Label();
            this.textBoxNam = new System.Windows.Forms.TextBox();
            this.buttonHachToan = new System.Windows.Forms.Button();
            this.dbDataset = new Manage_Material_Project.dbDataset();
            this.vIEWHACHTOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_HACHTOANTableAdapter = new Manage_Material_Project.dbDatasetTableAdapters.VIEW_HACHTOANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWHACHTOANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerHachToan
            // 
            this.reportViewerHachToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerHachToan.DocumentMapCollapsed = true;
            reportDataSource2.Name = "Hachtoan";
            reportDataSource2.Value = this.vIEWHACHTOANBindingSource;
            this.reportViewerHachToan.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerHachToan.LocalReport.ReportEmbeddedResource = "Manage_Material_Project.Reports.HachToan.rdlc";
            this.reportViewerHachToan.Location = new System.Drawing.Point(-1, 53);
            this.reportViewerHachToan.Name = "reportViewerHachToan";
            this.reportViewerHachToan.Size = new System.Drawing.Size(1236, 526);
            this.reportViewerHachToan.TabIndex = 0;
            // 
            // textBoxThang
            // 
            this.textBoxThang.Location = new System.Drawing.Point(56, 16);
            this.textBoxThang.Name = "textBoxThang";
            this.textBoxThang.Size = new System.Drawing.Size(100, 20);
            this.textBoxThang.TabIndex = 1;
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Location = new System.Drawing.Point(12, 20);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(38, 13);
            this.labelThang.TabIndex = 2;
            this.labelThang.Text = "Tháng";
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Location = new System.Drawing.Point(178, 20);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(29, 13);
            this.labelNam.TabIndex = 3;
            this.labelNam.Text = "Năm";
            // 
            // textBoxNam
            // 
            this.textBoxNam.Location = new System.Drawing.Point(213, 16);
            this.textBoxNam.Name = "textBoxNam";
            this.textBoxNam.Size = new System.Drawing.Size(100, 20);
            this.textBoxNam.TabIndex = 4;
            // 
            // buttonHachToan
            // 
            this.buttonHachToan.Location = new System.Drawing.Point(358, 16);
            this.buttonHachToan.Name = "buttonHachToan";
            this.buttonHachToan.Size = new System.Drawing.Size(90, 20);
            this.buttonHachToan.TabIndex = 5;
            this.buttonHachToan.Text = "Hạch toán";
            this.buttonHachToan.UseVisualStyleBackColor = true;
            this.buttonHachToan.Click += new System.EventHandler(this.buttonHachToan_Click);
            // 
            // dbDataset
            // 
            this.dbDataset.DataSetName = "dbDataset";
            this.dbDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIEWHACHTOANBindingSource
            // 
            this.vIEWHACHTOANBindingSource.DataMember = "VIEW_HACHTOAN";
            this.vIEWHACHTOANBindingSource.DataSource = this.dbDataset;
            // 
            // vIEW_HACHTOANTableAdapter
            // 
            this.vIEW_HACHTOANTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportHachToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 570);
            this.Controls.Add(this.buttonHachToan);
            this.Controls.Add(this.textBoxNam);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.labelThang);
            this.Controls.Add(this.textBoxThang);
            this.Controls.Add(this.reportViewerHachToan);
            this.Name = "frmReportHachToan";
            this.Text = "Hạch toán";
            this.Load += new System.EventHandler(this.frmReportHachToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWHACHTOANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerHachToan;
        private System.Windows.Forms.TextBox textBoxThang;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.TextBox textBoxNam;
        private System.Windows.Forms.Button buttonHachToan;
        private dbDataset dbDataset;
        private System.Windows.Forms.BindingSource vIEWHACHTOANBindingSource;
        private dbDatasetTableAdapters.VIEW_HACHTOANTableAdapter vIEW_HACHTOANTableAdapter;
    }
}