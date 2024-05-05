namespace Quan_Li_Luan_Van
{
    partial class UCDuyet
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
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.lbChuyenNganh = new System.Windows.Forms.Label();
            this.lbTenLV = new System.Windows.Forms.Label();
            this.pictureBoxNen = new System.Windows.Forms.PictureBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNen)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChiTiet
            // 
            this.buttonChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.buttonChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChiTiet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonChiTiet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChiTiet.Location = new System.Drawing.Point(932, 51);
            this.buttonChiTiet.Name = "buttonChiTiet";
            this.buttonChiTiet.Size = new System.Drawing.Size(114, 42);
            this.buttonChiTiet.TabIndex = 20;
            this.buttonChiTiet.Text = "Chi tiết";
            this.buttonChiTiet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonChiTiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChiTiet.UseVisualStyleBackColor = false;
            this.buttonChiTiet.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // lbChuyenNganh
            // 
            this.lbChuyenNganh.AutoSize = true;
            this.lbChuyenNganh.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenNganh.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbChuyenNganh.Location = new System.Drawing.Point(103, 61);
            this.lbChuyenNganh.Name = "lbChuyenNganh";
            this.lbChuyenNganh.Size = new System.Drawing.Size(183, 23);
            this.lbChuyenNganh.TabIndex = 18;
            this.lbChuyenNganh.Text = "Công nghệ phần mềm";
            this.lbChuyenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTenLV
            // 
            this.lbTenLV.AutoSize = true;
            this.lbTenLV.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTenLV.Location = new System.Drawing.Point(101, 13);
            this.lbTenLV.Name = "lbTenLV";
            this.lbTenLV.Size = new System.Drawing.Size(203, 31);
            this.lbTenLV.TabIndex = 17;
            this.lbTenLV.Text = "Quản lí khách sạn";
            this.lbTenLV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxNen
            // 
            this.pictureBoxNen.Image = global::Quan_Li_Luan_Van.Properties.Resources.anhSubject;
            this.pictureBoxNen.Location = new System.Drawing.Point(19, 14);
            this.pictureBoxNen.Name = "pictureBoxNen";
            this.pictureBoxNen.Size = new System.Drawing.Size(78, 76);
            this.pictureBoxNen.TabIndex = 16;
            this.pictureBoxNen.TabStop = false;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbTrangThai.Location = new System.Drawing.Point(918, 14);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(128, 23);
            this.lbTrangThai.TabIndex = 24;
            this.lbTrangThai.Text = "Đang chờ duyệt";
            this.lbTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.buttonChiTiet);
            this.Controls.Add(this.lbChuyenNganh);
            this.Controls.Add(this.lbTenLV);
            this.Controls.Add(this.pictureBoxNen);
            this.Name = "UCDuyet";
            this.Size = new System.Drawing.Size(1058, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.Label lbChuyenNganh;
        private System.Windows.Forms.Label lbTenLV;
        private System.Windows.Forms.PictureBox pictureBoxNen;
        private System.Windows.Forms.Label lbTrangThai;
    }
}
