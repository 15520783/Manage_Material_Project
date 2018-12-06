namespace Manage_Material_Project.Views
{
    partial class frmChonKho
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
            this.dgvkho = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmakho = new System.Windows.Forms.TextBox();
            this.txttenkho = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.RichTextBox();
            this.btnchonkho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvkho
            // 
            this.dgvkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkho.Location = new System.Drawing.Point(12, 29);
            this.dgvkho.Name = "dgvkho";
            this.dgvkho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvkho.Size = new System.Drawing.Size(346, 128);
            this.dgvkho.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH KHO";
            // 
            // txtmakho
            // 
            this.txtmakho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtmakho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakho.Location = new System.Drawing.Point(24, 191);
            this.txtmakho.Name = "txtmakho";
            this.txtmakho.ReadOnly = true;
            this.txtmakho.Size = new System.Drawing.Size(155, 25);
            this.txtmakho.TabIndex = 2;
            // 
            // txttenkho
            // 
            this.txttenkho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttenkho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkho.Location = new System.Drawing.Point(210, 191);
            this.txttenkho.Name = "txttenkho";
            this.txttenkho.ReadOnly = true;
            this.txttenkho.Size = new System.Drawing.Size(148, 25);
            this.txttenkho.TabIndex = 2;
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsdt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(210, 250);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.ReadOnly = true;
            this.txtsdt.Size = new System.Drawing.Size(148, 25);
            this.txtsdt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdiachi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(24, 250);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.ReadOnly = true;
            this.txtdiachi.Size = new System.Drawing.Size(155, 45);
            this.txtdiachi.TabIndex = 5;
            this.txtdiachi.Text = "";
            // 
            // btnchonkho
            // 
            this.btnchonkho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchonkho.Location = new System.Drawing.Point(149, 301);
            this.btnchonkho.Name = "btnchonkho";
            this.btnchonkho.Size = new System.Drawing.Size(86, 30);
            this.btnchonkho.TabIndex = 3;
            this.btnchonkho.Text = "CHỌN KHO";
            this.btnchonkho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnchonkho.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnchonkho.UseVisualStyleBackColor = true;
            this.btnchonkho.Click += new System.EventHandler(this.btnchonkho_Click);
            // 
            // frmChonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 343);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnchonkho);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txttenkho);
            this.Controls.Add(this.txtmakho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvkho);
            this.Name = "frmChonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn kho cần thao tác";
            this.Load += new System.EventHandler(this.frmChonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvkho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmakho;
        private System.Windows.Forms.TextBox txttenkho;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Button btnchonkho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtdiachi;
    }
}