namespace Quan_Li_Luan_Van
{
    partial class UCThongBao
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
            this.lblGV = new System.Windows.Forms.Label();
            this.lbNoiDungTB = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGV
            // 
            this.lblGV.AutoSize = true;
            this.lblGV.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblGV.Location = new System.Drawing.Point(112, 21);
            this.lblGV.Name = "lblGV";
            this.lblGV.Size = new System.Drawing.Size(157, 24);
            this.lblGV.TabIndex = 3;
            this.lblGV.Text = "Nguyễn Thủy An";
            // 
            // lbNoiDungTB
            // 
            this.lbNoiDungTB.AutoSize = true;
            this.lbNoiDungTB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDungTB.ForeColor = System.Drawing.Color.Black;
            this.lbNoiDungTB.Location = new System.Drawing.Point(114, 61);
            this.lbNoiDungTB.Name = "lbNoiDungTB";
            this.lbNoiDungTB.Size = new System.Drawing.Size(123, 20);
            this.lbNoiDungTB.TabIndex = 4;
            this.lbNoiDungTB.Text = "Thông báo nghỉ";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(941, 49);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(89, 42);
            this.btnXem.TabIndex = 12;
            this.btnXem.Text = "Xem";
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.buttonThongBao_Click);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.Black;
            this.lblThoiGian.Location = new System.Drawing.Point(782, 8);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(159, 20);
            this.lblThoiGian.TabIndex = 13;
            this.lblThoiGian.Text = "17/03/2024 10:41:22";
            // 
            // picBoxUser
            // 
            this.picBoxUser.Image = global::Quan_Li_Luan_Van.Properties.Resources.user1;
            this.picBoxUser.Location = new System.Drawing.Point(19, 11);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(81, 80);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 0;
            this.picBoxUser.TabStop = false;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.Black;
            this.lblTrangThai.Location = new System.Drawing.Point(967, 8);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(63, 20);
            this.lblTrangThai.TabIndex = 14;
            this.lblTrangThai.Text = "Đã xem";
            // 
            // UCThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.lbNoiDungTB);
            this.Controls.Add(this.lblGV);
            this.Controls.Add(this.picBoxUser);
            this.Name = "UCThongBao";
            this.Size = new System.Drawing.Size(1050, 100);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Label lblGV;
        private System.Windows.Forms.Label lbNoiDungTB;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblTrangThai;
    }
}
