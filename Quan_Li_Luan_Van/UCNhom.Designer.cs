﻿namespace Quan_Li_Luan_Van
{
    partial class UCNhom
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
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.lblTenLV = new System.Windows.Forms.Label();
            this.btnTienTrinh = new System.Windows.Forms.Button();
            this.pictureBoxNen = new System.Windows.Forms.PictureBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuyenNganh.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblChuyenNganh.Location = new System.Drawing.Point(103, 61);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(186, 23);
            this.lblChuyenNganh.TabIndex = 18;
            this.lblChuyenNganh.Text = "Công nghệ phần mềm";
            this.lblChuyenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenLV
            // 
            this.lblTenLV.AutoSize = true;
            this.lblTenLV.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTenLV.Location = new System.Drawing.Point(101, 19);
            this.lblTenLV.Name = "lblTenLV";
            this.lblTenLV.Size = new System.Drawing.Size(191, 27);
            this.lblTenLV.TabIndex = 17;
            this.lblTenLV.Text = "Quản lí khách sạn";
            this.lblTenLV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTienTrinh
            // 
            this.btnTienTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnTienTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienTrinh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnTienTrinh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTienTrinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTienTrinh.Location = new System.Drawing.Point(920, 48);
            this.btnTienTrinh.Name = "btnTienTrinh";
            this.btnTienTrinh.Size = new System.Drawing.Size(126, 42);
            this.btnTienTrinh.TabIndex = 21;
            this.btnTienTrinh.Text = "Tiến trình";
            this.btnTienTrinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTienTrinh.UseVisualStyleBackColor = false;
            this.btnTienTrinh.Click += new System.EventHandler(this.btnTienTrinh_Click);
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
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnChiTiet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnChiTiet.Image = global::Quan_Li_Luan_Van.Properties.Resources.decribe1;
            this.btnChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTiet.Location = new System.Drawing.Point(786, 48);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(128, 42);
            this.btnChiTiet.TabIndex = 29;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // UCNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnTienTrinh);
            this.Controls.Add(this.lblChuyenNganh);
            this.Controls.Add(this.lblTenLV);
            this.Controls.Add(this.pictureBoxNen);
            this.Name = "UCNhom";
            this.Size = new System.Drawing.Size(1058, 98);
            this.Load += new System.EventHandler(this.UCNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Label lblTenLV;
        private System.Windows.Forms.PictureBox pictureBoxNen;
        private System.Windows.Forms.Button btnTienTrinh;
        private System.Windows.Forms.Button btnChiTiet;
    }
}
