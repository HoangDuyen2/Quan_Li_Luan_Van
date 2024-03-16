namespace Quan_Li_Luan_Van
{
    partial class UCLV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbChuyenNganh = new System.Windows.Forms.Label();
            this.lblnguoidung = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSlot = new System.Windows.Forms.Label();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChuyenNganh
            // 
            this.lbChuyenNganh.AutoSize = true;
            this.lbChuyenNganh.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenNganh.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbChuyenNganh.Location = new System.Drawing.Point(137, 60);
            this.lbChuyenNganh.Name = "lbChuyenNganh";
            this.lbChuyenNganh.Size = new System.Drawing.Size(186, 23);
            this.lbChuyenNganh.TabIndex = 9;
            this.lbChuyenNganh.Text = "Công nghệ phần mềm";
            // 
            // lblnguoidung
            // 
            this.lblnguoidung.AutoSize = true;
            this.lblnguoidung.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnguoidung.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblnguoidung.Location = new System.Drawing.Point(130, 20);
            this.lblnguoidung.Name = "lblnguoidung";
            this.lblnguoidung.Size = new System.Drawing.Size(221, 31);
            this.lblnguoidung.TabIndex = 8;
            this.lblnguoidung.Text = "Quản lí khách sạn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbSlot
            // 
            this.lbSlot.AutoSize = true;
            this.lbSlot.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlot.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbSlot.Location = new System.Drawing.Point(689, 28);
            this.lbSlot.Name = "lbSlot";
            this.lbSlot.Size = new System.Drawing.Size(113, 23);
            this.lbSlot.TabIndex = 10;
            this.lbSlot.Text = "Chưa đăng kí";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimKiem.Location = new System.Drawing.Point(915, 81);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(97, 42);
            this.buttonTimKiem.TabIndex = 11;
            this.buttonTimKiem.Text = "Chi tiết";
            this.buttonTimKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // UCLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.lbSlot);
            this.Controls.Add(this.lbChuyenNganh);
            this.Controls.Add(this.lblnguoidung);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCLV";
            this.Size = new System.Drawing.Size(1015, 126);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChuyenNganh;
        private System.Windows.Forms.Label lblnguoidung;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSlot;
        private System.Windows.Forms.Button buttonTimKiem;
    }
}
