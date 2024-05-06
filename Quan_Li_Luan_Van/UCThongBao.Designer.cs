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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lbNoiDungTB = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe.Location = new System.Drawing.Point(101, 24);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(135, 28);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Họp Meeting";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNoiDungTB
            // 
            this.lbNoiDungTB.AutoSize = true;
            this.lbNoiDungTB.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDungTB.ForeColor = System.Drawing.Color.Black;
            this.lbNoiDungTB.Location = new System.Drawing.Point(103, 50);
            this.lbNoiDungTB.Name = "lbNoiDungTB";
            this.lbNoiDungTB.Size = new System.Drawing.Size(128, 23);
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
            this.btnXem.Location = new System.Drawing.Point(957, 49);
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
            this.lblThoiGian.Location = new System.Drawing.Point(866, 8);
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
            // UCThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.lbNoiDungTB);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.picBoxUser);
            this.Name = "UCThongBao";
            this.Size = new System.Drawing.Size(1060, 100);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lbNoiDungTB;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lblThoiGian;
    }
}
