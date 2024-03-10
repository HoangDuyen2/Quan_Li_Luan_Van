using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLuanVan
{
    public partial class FSinhVien : Form
    {
        public FSinhVien()
        {
            InitializeComponent();
        }

        private Button currentButton;
        private Panel panel2;
        private Button buttonThong_Tin_Chung;
        private Label labelTenTruong;
        private Panel panel1;
        private Panel panel3;
        private Button button1;
        private Button buttonTraCuu;
        private Button buttonAdd;
        private Button buttonHome;
        private Label labelChucNang;
        private Panel panelTTSV;
        private Label labelChucVu;
        private Label labelMSSV;
        private Label labelTen;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxLogo;

        /*private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                }
            }
        }
        /*private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }*/
        /*private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }*/
        private void FSinhVien_Load(object sender, EventArgs e)
        {

        }

        /*private void buttonDangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKy(), sender);
        }

        private void buttonQuanLi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {

        }*/

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonThong_Tin_Chung = new System.Windows.Forms.Button();
            this.labelTenTruong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTraCuu = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelChucNang = new System.Windows.Forms.Label();
            this.panelTTSV = new System.Windows.Forms.Panel();
            this.labelChucVu = new System.Windows.Forms.Label();
            this.labelMSSV = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.panel2.Controls.Add(this.buttonThong_Tin_Chung);
            this.panel2.Controls.Add(this.labelTenTruong);
            this.panel2.Location = new System.Drawing.Point(266, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 75);
            this.panel2.TabIndex = 5;
            // 
            // buttonThong_Tin_Chung
            // 
            this.buttonThong_Tin_Chung.BackgroundImage = global::Quan_Li_Luan_Van.Properties.Resources.user;
            this.buttonThong_Tin_Chung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonThong_Tin_Chung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThong_Tin_Chung.Location = new System.Drawing.Point(814, 18);
            this.buttonThong_Tin_Chung.Name = "buttonThong_Tin_Chung";
            this.buttonThong_Tin_Chung.Size = new System.Drawing.Size(46, 40);
            this.buttonThong_Tin_Chung.TabIndex = 12;
            this.buttonThong_Tin_Chung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThong_Tin_Chung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonThong_Tin_Chung.UseVisualStyleBackColor = true;
            // 
            // labelTenTruong
            // 
            this.labelTenTruong.AutoSize = true;
            this.labelTenTruong.BackColor = System.Drawing.Color.Transparent;
            this.labelTenTruong.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelTenTruong.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTenTruong.Location = new System.Drawing.Point(57, 18);
            this.labelTenTruong.Name = "labelTenTruong";
            this.labelTenTruong.Size = new System.Drawing.Size(646, 38);
            this.labelTenTruong.TabIndex = 11;
            this.labelTenTruong.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KĨ THUẬT ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelTTSV);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 657);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.buttonTraCuu);
            this.panel3.Controls.Add(this.buttonAdd);
            this.panel3.Controls.Add(this.buttonHome);
            this.panel3.Controls.Add(this.labelChucNang);
            this.panel3.Location = new System.Drawing.Point(1, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 382);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Quan_Li_Luan_Van.Properties.Resources.dang_xuat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, 236);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(269, 63);
            this.button1.TabIndex = 16;
            this.button1.Text = " Đăng xuất";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonTraCuu
            // 
            this.buttonTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTraCuu.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTraCuu.ForeColor = System.Drawing.Color.White;
            this.buttonTraCuu.Image = global::Quan_Li_Luan_Van.Properties.Resources.find;
            this.buttonTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTraCuu.Location = new System.Drawing.Point(-3, 176);
            this.buttonTraCuu.Name = "buttonTraCuu";
            this.buttonTraCuu.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonTraCuu.Size = new System.Drawing.Size(269, 63);
            this.buttonTraCuu.TabIndex = 0;
            this.buttonTraCuu.Text = " Luận văn của tôi";
            this.buttonTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTraCuu.UseVisualStyleBackColor = true;
            this.buttonTraCuu.Click += new System.EventHandler(this.buttonTraCuu_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Image = global::Quan_Li_Luan_Van.Properties.Resources.add;
            this.buttonAdd.Location = new System.Drawing.Point(-4, 116);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAdd.Size = new System.Drawing.Size(269, 63);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = " Đăng kí đề tài";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = global::Quan_Li_Luan_Van.Properties.Resources.home;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(-3, 53);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(269, 63);
            this.buttonHome.TabIndex = 4;
            this.buttonHome.Text = "  Trang chủ";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // labelChucNang
            // 
            this.labelChucNang.AutoSize = true;
            this.labelChucNang.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelChucNang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelChucNang.Location = new System.Drawing.Point(3, 17);
            this.labelChucNang.Name = "labelChucNang";
            this.labelChucNang.Size = new System.Drawing.Size(154, 28);
            this.labelChucNang.TabIndex = 4;
            this.labelChucNang.Text = "CHỨC NĂNG";
            // 
            // panelTTSV
            // 
            this.panelTTSV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTTSV.Controls.Add(this.labelChucVu);
            this.panelTTSV.Controls.Add(this.labelMSSV);
            this.panelTTSV.Controls.Add(this.labelTen);
            this.panelTTSV.Controls.Add(this.pictureBox1);
            this.panelTTSV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTTSV.Location = new System.Drawing.Point(1, 164);
            this.panelTTSV.Name = "panelTTSV";
            this.panelTTSV.Size = new System.Drawing.Size(266, 108);
            this.panelTTSV.TabIndex = 4;
            // 
            // labelChucVu
            // 
            this.labelChucVu.AutoSize = true;
            this.labelChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(171)))));
            this.labelChucVu.Location = new System.Drawing.Point(110, 64);
            this.labelChucVu.Name = "labelChucVu";
            this.labelChucVu.Size = new System.Drawing.Size(73, 16);
            this.labelChucVu.TabIndex = 22;
            this.labelChucVu.Text = "Giảng Viên";
            this.labelChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMSSV
            // 
            this.labelMSSV.AutoSize = true;
            this.labelMSSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(171)))));
            this.labelMSSV.Location = new System.Drawing.Point(118, 44);
            this.labelMSSV.Name = "labelMSSV";
            this.labelMSSV.Size = new System.Drawing.Size(63, 16);
            this.labelMSSV.TabIndex = 21;
            this.labelMSSV.Text = "22110271";
            this.labelMSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelTen.Location = new System.Drawing.Point(89, 24);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(121, 16);
            this.labelTen.TabIndex = 20;
            this.labelTen.Text = "Lê Đức Minh Vương";
            this.labelTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Quan_Li_Luan_Van.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(10, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Quan_Li_Luan_Van.Properties.Resources.Logo_HCMUTE_Corel_white_background_preview_rev_1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(69, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(122, 138);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FSinhVien
            // 
            this.ClientSize = new System.Drawing.Size(1135, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FSinhVien";
            this.Load += new System.EventHandler(this.FSinhVien_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTTSV.ResumeLayout(false);
            this.panelTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private void FSinhVien_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonTraCuu_Click(object sender, EventArgs e)
        {

        }
    }
}
