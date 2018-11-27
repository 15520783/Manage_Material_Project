namespace Manage_Material_Project.Views
{
    partial class frmThongKeBaoBieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeBaoBieu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoPhieuMua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xem nhật kí xuất nguyên liệu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTaoPhieuMua
            // 
            this.btnTaoPhieuMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnTaoPhieuMua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaoPhieuMua.BackgroundImage")));
            this.btnTaoPhieuMua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTaoPhieuMua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieuMua.Location = new System.Drawing.Point(82, 78);
            this.btnTaoPhieuMua.Name = "btnTaoPhieuMua";
            this.btnTaoPhieuMua.Size = new System.Drawing.Size(185, 185);
            this.btnTaoPhieuMua.TabIndex = 8;
            this.btnTaoPhieuMua.UseVisualStyleBackColor = false;
            this.btnTaoPhieuMua.Click += new System.EventHandler(this.btnTaoPhieuMua_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 44);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmThongKeBaoBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaoPhieuMua);
            this.Name = "frmThongKeBaoBieu";
            this.Text = "frmThongKeBaoBieu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoPhieuMua;
        private System.Windows.Forms.Button button1;
    }
}