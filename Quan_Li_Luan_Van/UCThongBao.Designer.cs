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
            this.lbGV = new System.Windows.Forms.Label();
            this.lbNoiDungTB = new System.Windows.Forms.Label();
            this.buttonThongBao = new System.Windows.Forms.Button();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGV
            // 
            this.lbGV.AutoSize = true;
            this.lbGV.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbGV.Location = new System.Drawing.Point(115, 33);
            this.lbGV.Name = "lbGV";
            this.lbGV.Size = new System.Drawing.Size(180, 27);
            this.lbGV.TabIndex = 3;
            this.lbGV.Text = "Nguyễn Thủy An";
            // 
            // lbNoiDungTB
            // 
            this.lbNoiDungTB.AutoSize = true;
            this.lbNoiDungTB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDungTB.ForeColor = System.Drawing.Color.Black;
            this.lbNoiDungTB.Location = new System.Drawing.Point(116, 69);
            this.lbNoiDungTB.Name = "lbNoiDungTB";
            this.lbNoiDungTB.Size = new System.Drawing.Size(138, 23);
            this.lbNoiDungTB.TabIndex = 4;
            this.lbNoiDungTB.Text = "Thông báo nghỉ";
            // 
            // buttonThongBao
            // 
            this.buttonThongBao.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThongBao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonThongBao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonThongBao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThongBao.Location = new System.Drawing.Point(945, 59);
            this.buttonThongBao.Name = "buttonThongBao";
            this.buttonThongBao.Size = new System.Drawing.Size(100, 42);
            this.buttonThongBao.TabIndex = 12;
            this.buttonThongBao.Text = "Xem";
            this.buttonThongBao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonThongBao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThongBao.UseVisualStyleBackColor = false;
            // 
            // picBoxUser
            // 
            this.picBoxUser.Image = global::Quan_Li_Luan_Van.Properties.Resources.user1;
            this.picBoxUser.Location = new System.Drawing.Point(13, 21);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(96, 92);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 0;
            this.picBoxUser.TabStop = false;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.Black;
            this.lblThoiGian.Location = new System.Drawing.Point(829, 9);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(216, 27);
            this.lblThoiGian.TabIndex = 13;
            this.lblThoiGian.Text = "17/03/2024 10:41:22";
            // 
            // UCThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.buttonThongBao);
            this.Controls.Add(this.lbNoiDungTB);
            this.Controls.Add(this.lbGV);
            this.Controls.Add(this.picBoxUser);
            this.Name = "UCThongBao";
            this.Size = new System.Drawing.Size(1060, 124);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Label lbGV;
        private System.Windows.Forms.Label lbNoiDungTB;
        private System.Windows.Forms.Button buttonThongBao;
        private System.Windows.Forms.Label lblThoiGian;
    }
}
