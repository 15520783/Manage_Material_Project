namespace Manage_Material_Project.Views
{
    partial class frmChonKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmaso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.RichTextBox();
            this.btnchonkhachhang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Location = new System.Drawing.Point(39, 70);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvkhachhang.Size = new System.Drawing.Size(497, 182);
            this.dgvkhachhang.TabIndex = 1;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(120, 39);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(416, 25);
            this.txttimkiem.TabIndex = 2;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm:";
            // 
            // txtmakh
            // 
            this.txtmakh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtmakh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Location = new System.Drawing.Point(22, 289);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.ReadOnly = true;
            this.txtmakh.Size = new System.Drawing.Size(176, 25);
            this.txtmakh.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã khách hàng";
            // 
            // txtten
            // 
            this.txtten.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(204, 290);
            this.txtten.Name = "txtten";
            this.txtten.ReadOnly = true;
            this.txtten.Size = new System.Drawing.Size(193, 25);
            this.txtten.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn vị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttaikhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaikhoan.Location = new System.Drawing.Point(204, 355);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.ReadOnly = true;
            this.txttaikhoan.Size = new System.Drawing.Size(193, 25);
            this.txttaikhoan.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tài khoản";
            // 
            // txtmaso
            // 
            this.txtmaso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtmaso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaso.Location = new System.Drawing.Point(22, 354);
            this.txtmaso.Name = "txtmaso";
            this.txtmaso.ReadOnly = true;
            this.txtmaso.Size = new System.Drawing.Size(176, 25);
            this.txtmaso.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã số thuế";
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdiachi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(413, 290);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.ReadOnly = true;
            this.txtdiachi.Size = new System.Drawing.Size(144, 96);
            this.txtdiachi.TabIndex = 6;
            this.txtdiachi.Text = "";
            // 
            // btnchonkhachhang
            // 
            this.btnchonkhachhang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchonkhachhang.Location = new System.Drawing.Point(204, 406);
            this.btnchonkhachhang.Name = "btnchonkhachhang";
            this.btnchonkhachhang.Size = new System.Drawing.Size(147, 32);
            this.btnchonkhachhang.TabIndex = 7;
            this.btnchonkhachhang.Text = "CHỌN KHÁCH HÀNG";
            this.btnchonkhachhang.UseVisualStyleBackColor = true;
            this.btnchonkhachhang.Click += new System.EventHandler(this.btnchonkhachhang_Click);
            // 
            // frmChonKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.btnchonkhachhang);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtmaso);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.dgvkhachhang);
            this.Controls.Add(this.label1);
            this.Name = "frmChonKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn khách hàng";
            this.Load += new System.EventHandler(this.frmChonKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmaso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtdiachi;
        private System.Windows.Forms.Button btnchonkhachhang;
    }
}