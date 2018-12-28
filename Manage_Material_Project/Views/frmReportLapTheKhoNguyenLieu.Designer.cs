namespace Manage_Material_Project.Views
{
    partial class frmReportLapTheKhoNguyenLieu
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
            this.VIEW_LAPTHEKHONGUYENLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTheKhoNguyenLieu = new Manage_Material_Project.DSTheKhoNguyenLieu();
            this.vIEWLAPTHEKHONGUYENLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTheKhoNguyenLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNguyenLieu = new System.Windows.Forms.ComboBox();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLapthekho = new System.Windows.Forms.Button();
            this.vIEW_LAPTHEKHONGUYENLIEUTableAdapter = new Manage_Material_Project.DSTheKhoNguyenLieuTableAdapters.VIEW_LAPTHEKHONGUYENLIEUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VIEW_LAPTHEKHONGUYENLIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTheKhoNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWLAPTHEKHONGUYENLIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTheKhoNguyenLieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VIEW_LAPTHEKHONGUYENLIEUBindingSource
            // 
            this.VIEW_LAPTHEKHONGUYENLIEUBindingSource.DataMember = "VIEW_LAPTHEKHONGUYENLIEU";
            this.VIEW_LAPTHEKHONGUYENLIEUBindingSource.DataSource = this.dSTheKhoNguyenLieu;
            // 
            // dSTheKhoNguyenLieu
            // 
            this.dSTheKhoNguyenLieu.DataSetName = "DSTheKhoNguyenLieu";
            this.dSTheKhoNguyenLieu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIEWLAPTHEKHONGUYENLIEUBindingSource
            // 
            this.vIEWLAPTHEKHONGUYENLIEUBindingSource.DataMember = "VIEW_LAPTHEKHONGUYENLIEU";
            this.vIEWLAPTHEKHONGUYENLIEUBindingSource.DataSource = this.dSTheKhoNguyenLieuBindingSource;
            // 
            // dSTheKhoNguyenLieuBindingSource
            // 
            this.dSTheKhoNguyenLieuBindingSource.DataSource = this.dSTheKhoNguyenLieu;
            this.dSTheKhoNguyenLieuBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSTheKhoNguyenLieu";
            reportDataSource1.Value = this.VIEW_LAPTHEKHONGUYENLIEUBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Manage_Material_Project.Reports.TheKhoNguyenLieu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(930, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbKho
            // 
            this.cmbKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(137, 24);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(179, 25);
            this.cmbKho.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nguyên liệu";
            // 
            // cmbNguyenLieu
            // 
            this.cmbNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNguyenLieu.FormattingEnabled = true;
            this.cmbNguyenLieu.Location = new System.Drawing.Point(137, 72);
            this.cmbNguyenLieu.Name = "cmbNguyenLieu";
            this.cmbNguyenLieu.Size = new System.Drawing.Size(179, 25);
            this.cmbNguyenLieu.TabIndex = 3;
            // 
            // txtthang
            // 
            this.txtthang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthang.Location = new System.Drawing.Point(370, 29);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(100, 25);
            this.txtthang.TabIndex = 5;
            // 
            // txtnam
            // 
            this.txtnam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnam.Location = new System.Drawing.Point(370, 77);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 25);
            this.txtnam.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Năm";
            // 
            // btnLapthekho
            // 
            this.btnLapthekho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapthekho.Location = new System.Drawing.Point(567, 53);
            this.btnLapthekho.Name = "btnLapthekho";
            this.btnLapthekho.Size = new System.Drawing.Size(88, 37);
            this.btnLapthekho.TabIndex = 7;
            this.btnLapthekho.Text = "Lập thẻ kho";
            this.btnLapthekho.UseVisualStyleBackColor = true;
            this.btnLapthekho.Click += new System.EventHandler(this.btnLapthekho_Click);
            // 
            // vIEW_LAPTHEKHONGUYENLIEUTableAdapter
            // 
            this.vIEW_LAPTHEKHONGUYENLIEUTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportLapTheKhoNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 574);
            this.Controls.Add(this.btnLapthekho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNguyenLieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKho);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportLapTheKhoNguyenLieu";
            this.Text = "frmReportLapTheKhoNguyenLieu";
            this.Load += new System.EventHandler(this.frmReportLapTheKhoNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VIEW_LAPTHEKHONGUYENLIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTheKhoNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWLAPTHEKHONGUYENLIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTheKhoNguyenLieuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cmbKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNguyenLieu;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLapthekho;
        private System.Windows.Forms.BindingSource vIEWLAPTHEKHONGUYENLIEUBindingSource;
        private System.Windows.Forms.BindingSource dSTheKhoNguyenLieuBindingSource;
        private DSTheKhoNguyenLieu dSTheKhoNguyenLieu;
        private DSTheKhoNguyenLieuTableAdapters.VIEW_LAPTHEKHONGUYENLIEUTableAdapter vIEW_LAPTHEKHONGUYENLIEUTableAdapter;
        private System.Windows.Forms.BindingSource VIEW_LAPTHEKHONGUYENLIEUBindingSource;
    }
}