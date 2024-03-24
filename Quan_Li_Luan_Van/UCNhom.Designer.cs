namespace Quan_Li_Luan_Van
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
            this.lbChuyenNganh = new System.Windows.Forms.Label();
            this.lbTenLV = new System.Windows.Forms.Label();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.pictureBoxNen = new System.Windows.Forms.PictureBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChuyenNganh
            // 
            this.lbChuyenNganh.AutoSize = true;
            this.lbChuyenNganh.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenNganh.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbChuyenNganh.Location = new System.Drawing.Point(103, 61);
            this.lbChuyenNganh.Name = "lbChuyenNganh";
            this.lbChuyenNganh.Size = new System.Drawing.Size(186, 23);
            this.lbChuyenNganh.TabIndex = 18;
            this.lbChuyenNganh.Text = "Công nghệ phần mềm";
            this.lbChuyenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTenLV
            // 
            this.lbTenLV.AutoSize = true;
            this.lbTenLV.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTenLV.Location = new System.Drawing.Point(101, 19);
            this.lbTenLV.Name = "lbTenLV";
            this.lbTenLV.Size = new System.Drawing.Size(191, 27);
            this.lbTenLV.TabIndex = 17;
            this.lbTenLV.Text = "Quản lí khách sạn";
            this.lbTenLV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNV.Location = new System.Drawing.Point(920, 48);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(126, 42);
            this.btnThemNV.TabIndex = 21;
            this.btnThemNV.Text = "Thêm NV";
            this.btnThemNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
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
            // 
            // UCNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.lbChuyenNganh);
            this.Controls.Add(this.lbTenLV);
            this.Controls.Add(this.pictureBoxNen);
            this.Name = "UCNhom";
            this.Size = new System.Drawing.Size(1058, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChuyenNganh;
        private System.Windows.Forms.Label lbTenLV;
        private System.Windows.Forms.PictureBox pictureBoxNen;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnChiTiet;
    }
}
