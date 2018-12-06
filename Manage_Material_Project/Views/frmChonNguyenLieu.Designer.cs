namespace Manage_Material_Project.Views
{
    partial class frmChonNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonNguyenLieu));
            this.label1 = new System.Windows.Forms.Label();
            this.txtmanguyenlieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttennguyenlieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdonvitinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvnguyenlieu = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnchonnguyenlieu = new System.Windows.Forms.Button();
            this.btnthemnguyenlieu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguyenlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã nguyên liệu";
            // 
            // txtmanguyenlieu
            // 
            this.txtmanguyenlieu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtmanguyenlieu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanguyenlieu.Location = new System.Drawing.Point(18, 58);
            this.txtmanguyenlieu.Name = "txtmanguyenlieu";
            this.txtmanguyenlieu.ReadOnly = true;
            this.txtmanguyenlieu.Size = new System.Drawing.Size(193, 25);
            this.txtmanguyenlieu.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên nguyên liệu";
            // 
            // txttennguyenlieu
            // 
            this.txttennguyenlieu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttennguyenlieu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennguyenlieu.Location = new System.Drawing.Point(14, 124);
            this.txttennguyenlieu.Name = "txttennguyenlieu";
            this.txttennguyenlieu.ReadOnly = true;
            this.txttennguyenlieu.Size = new System.Drawing.Size(196, 25);
            this.txttennguyenlieu.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Đơn vị tính";
            // 
            // txtdonvitinh
            // 
            this.txtdonvitinh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdonvitinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonvitinh.Location = new System.Drawing.Point(216, 100);
            this.txtdonvitinh.Name = "txtdonvitinh";
            this.txtdonvitinh.ReadOnly = true;
            this.txtdonvitinh.Size = new System.Drawing.Size(132, 25);
            this.txtdonvitinh.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "DANH MỤC NGUYÊN LIỆU";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtmanguyenlieu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txttennguyenlieu);
            this.panel1.Controls.Add(this.txtdonvitinh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(315, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 166);
            this.panel1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "THÔNG TIN NGUYÊN LIỆU";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvnguyenlieu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 434);
            this.panel2.TabIndex = 26;
            // 
            // dgvnguyenlieu
            // 
            this.dgvnguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnguyenlieu.Location = new System.Drawing.Point(3, 36);
            this.dgvnguyenlieu.Name = "dgvnguyenlieu";
            this.dgvnguyenlieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnguyenlieu.Size = new System.Drawing.Size(301, 393);
            this.dgvnguyenlieu.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nhập nguyên liệu cần tìm:";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(315, 116);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(309, 25);
            this.txttimkiem.TabIndex = 22;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // btnchonnguyenlieu
            // 
            this.btnchonnguyenlieu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchonnguyenlieu.Location = new System.Drawing.Point(411, 382);
            this.btnchonnguyenlieu.Name = "btnchonnguyenlieu";
            this.btnchonnguyenlieu.Size = new System.Drawing.Size(120, 40);
            this.btnchonnguyenlieu.TabIndex = 27;
            this.btnchonnguyenlieu.Text = "Chọn nguyên liệu";
            this.btnchonnguyenlieu.UseVisualStyleBackColor = true;
            this.btnchonnguyenlieu.Click += new System.EventHandler(this.btnchonnguyenlieu_Click);
            // 
            // btnthemnguyenlieu
            // 
            this.btnthemnguyenlieu.Image = ((System.Drawing.Image)(resources.GetObject("btnthemnguyenlieu.Image")));
            this.btnthemnguyenlieu.Location = new System.Drawing.Point(630, 116);
            this.btnthemnguyenlieu.Name = "btnthemnguyenlieu";
            this.btnthemnguyenlieu.Size = new System.Drawing.Size(21, 25);
            this.btnthemnguyenlieu.TabIndex = 31;
            this.btnthemnguyenlieu.UseVisualStyleBackColor = true;
            this.btnthemnguyenlieu.Click += new System.EventHandler(this.btnThemkhachhang_Click);
            // 
            // frmChonNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.btnthemnguyenlieu);
            this.Controls.Add(this.btnchonnguyenlieu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "frmChonNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn nguyên liệu";
            this.Load += new System.EventHandler(this.frmChonNguyenLieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguyenlieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmanguyenlieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttennguyenlieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdonvitinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvnguyenlieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnchonnguyenlieu;
        private System.Windows.Forms.Button btnthemnguyenlieu;
    }
}