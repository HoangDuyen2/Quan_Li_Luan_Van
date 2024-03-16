using System.Drawing;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    partial class FSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSinhVien));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnLuanVan = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.labelChucNang = new System.Windows.Forms.Label();
            this.panelTTSinhVien = new System.Windows.Forms.Panel();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelChucVu = new System.Windows.Forms.Label();
            this.labelMSSV = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTenTruong = new System.Windows.Forms.Panel();
            this.labelTenTruong = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.panelTTSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTenTruong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnLuanVan);
            this.panelMenu.Controls.Add(this.btnDangKy);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.panelChucNang);
            this.panelMenu.Controls.Add(this.panelTTSinhVien);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(256, 793);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = global::Quan_Li_Luan_Van.Properties.Resources.dang_xuat;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 519);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(252, 63);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "  Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnLuanVan
            // 
            this.btnLuanVan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuanVan.FlatAppearance.BorderSize = 0;
            this.btnLuanVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuanVan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuanVan.ForeColor = System.Drawing.Color.White;
            this.btnLuanVan.Image = global::Quan_Li_Luan_Van.Properties.Resources.find;
            this.btnLuanVan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuanVan.Location = new System.Drawing.Point(0, 456);
            this.btnLuanVan.Name = "btnLuanVan";
            this.btnLuanVan.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLuanVan.Size = new System.Drawing.Size(252, 63);
            this.btnLuanVan.TabIndex = 7;
            this.btnLuanVan.Text = " Luận văn của tôi";
            this.btnLuanVan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuanVan.UseVisualStyleBackColor = true;
            this.btnLuanVan.Click += new System.EventHandler(this.btnLuanVan_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Image = global::Quan_Li_Luan_Van.Properties.Resources.add;
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.Location = new System.Drawing.Point(0, 393);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDangKy.Size = new System.Drawing.Size(252, 63);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "  Đăng ký đề tài";
            this.btnDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = global::Quan_Li_Luan_Van.Properties.Resources.home;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 330);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(252, 63);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.Text = "  Trang chủ";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.labelChucNang);
            this.panelChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChucNang.Location = new System.Drawing.Point(0, 269);
            this.panelChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(252, 61);
            this.panelChucNang.TabIndex = 2;
            // 
            // labelChucNang
            // 
            this.labelChucNang.AutoSize = true;
            this.labelChucNang.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChucNang.ForeColor = System.Drawing.Color.White;
            this.labelChucNang.Location = new System.Drawing.Point(10, 13);
            this.labelChucNang.Name = "labelChucNang";
            this.labelChucNang.Size = new System.Drawing.Size(149, 31);
            this.labelChucNang.TabIndex = 2;
            this.labelChucNang.Text = "CHỨC NĂNG";
            // 
            // panelTTSinhVien
            // 
            this.panelTTSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTTSinhVien.Controls.Add(this.pictureBoxUser);
            this.panelTTSinhVien.Controls.Add(this.labelChucVu);
            this.panelTTSinhVien.Controls.Add(this.labelMSSV);
            this.panelTTSinhVien.Controls.Add(this.labelTen);
            this.panelTTSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTTSinhVien.Location = new System.Drawing.Point(0, 155);
            this.panelTTSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTTSinhVien.Name = "panelTTSinhVien";
            this.panelTTSinhVien.Size = new System.Drawing.Size(252, 114);
            this.panelTTSinhVien.TabIndex = 1;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::Quan_Li_Luan_Van.Properties.Resources.user;
            this.pictureBoxUser.Location = new System.Drawing.Point(26, 37);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            // 
            // labelChucVu
            // 
            this.labelChucVu.AutoSize = true;
            this.labelChucVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(171)))));
            this.labelChucVu.Location = new System.Drawing.Point(122, 70);
            this.labelChucVu.Name = "labelChucVu";
            this.labelChucVu.Size = new System.Drawing.Size(70, 20);
            this.labelChucVu.TabIndex = 4;
            this.labelChucVu.Text = "Sinh Viên";
            this.labelChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMSSV
            // 
            this.labelMSSV.AutoSize = true;
            this.labelMSSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelMSSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(171)))));
            this.labelMSSV.Location = new System.Drawing.Point(121, 47);
            this.labelMSSV.Name = "labelMSSV";
            this.labelMSSV.Size = new System.Drawing.Size(73, 20);
            this.labelMSSV.TabIndex = 3;
            this.labelMSSV.Text = "22110271";
            this.labelMSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelTen.Location = new System.Drawing.Point(87, 24);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(140, 20);
            this.labelTen.TabIndex = 2;
            this.labelTen.Text = "Lê Đức Minh Vương";
            this.labelTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogo
            // 
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(252, 155);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(63, 20);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(122, 115);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelTenTruong
            // 
            this.panelTenTruong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.panelTenTruong.Controls.Add(this.pictureBox1);
            this.panelTenTruong.Controls.Add(this.labelTenTruong);
            this.panelTenTruong.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTenTruong.Location = new System.Drawing.Point(256, 0);
            this.panelTenTruong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTenTruong.Name = "panelTenTruong";
            this.panelTenTruong.Size = new System.Drawing.Size(1068, 87);
            this.panelTenTruong.TabIndex = 1;
            // 
            // labelTenTruong
            // 
            this.labelTenTruong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTenTruong.AutoSize = true;
            this.labelTenTruong.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelTenTruong.ForeColor = System.Drawing.Color.Snow;
            this.labelTenTruong.Location = new System.Drawing.Point(23, 24);
            this.labelTenTruong.Name = "labelTenTruong";
            this.labelTenTruong.Size = new System.Drawing.Size(655, 38);
            this.labelTenTruong.TabIndex = 3;
            this.labelTenTruong.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT TP.HCM";
            this.labelTenTruong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.ForeColor = System.Drawing.Color.Snow;
            this.panelDesktopPane.Location = new System.Drawing.Point(256, 87);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1068, 706);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quan_Li_Luan_Van.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(982, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1324, 793);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTenTruong);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSinhVien";
            this.Load += new System.EventHandler(this.FSinhVien_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelChucNang.ResumeLayout(false);
            this.panelChucNang.PerformLayout();
            this.panelTTSinhVien.ResumeLayout(false);
            this.panelTTSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTenTruong.ResumeLayout(false);
            this.panelTenTruong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelTTSinhVien;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxUser;
        private Label labelChucVu;
        private Label labelTen;
        private Label labelMSSV;
        private Panel panelTenTruong;
        private Label labelTenTruong;
        private Panel panelChucNang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label labelChucNang;
        private Panel panelDesktopPane;
        private Button buttonHome;
        private Button btnDangXuat;
        private Button btnLuanVan;
        private Button btnDangKy;
        private PictureBox pictureBox1;
    }
}