using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLuanVan
{
    public partial class FQuenMatKhau : Form
    {
        private Panel panel3;
        private Button btnDangNhap;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Label labelEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label labelTenDangNhap;
        private Panel panel2;
        private RadioButton radioButtonGV;
        private RadioButton radioButtonSV;
        private Label lbDangNhap;
        private Panel panel1;

        public FQuenMatKhau()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonGV = new System.Windows.Forms.RadioButton();
            this.radioButtonSV = new System.Windows.Forms.RadioButton();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.btnDangNhap);
            this.panel3.Controls.Add(this.kryptonTextBox2);
            this.panel3.Controls.Add(this.labelEmail);
            this.panel3.Controls.Add(this.kryptonTextBox1);
            this.panel3.Controls.Add(this.labelTenDangNhap);
            this.panel3.Location = new System.Drawing.Point(257, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 284);
            this.panel3.TabIndex = 0;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(112, 212);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(305, 47);
            this.btnDangNhap.TabIndex = 13;
            this.btnDangNhap.Text = "Gửi email lấy lại mật khẩu";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(200, 129);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(251, 36);
            this.kryptonTextBox2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox2.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.kryptonTextBox2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonTextBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox2.StateCommon.Border.Rounding = 16;
            this.kryptonTextBox2.StateCommon.Border.Width = 1;
            this.kryptonTextBox2.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox2.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox2.TabIndex = 11;
            this.kryptonTextBox2.Text = "Nhập vào Email";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Italic);
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(3, 135);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 30);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(200, 61);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(251, 36);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox1.StateCommon.Border.Rounding = 16;
            this.kryptonTextBox1.StateCommon.Border.Width = 1;
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox1.TabIndex = 9;
            this.kryptonTextBox1.Text = "Nhập vào Tên đăng nhập";
            // 
            // labelTenDangNhap
            // 
            this.labelTenDangNhap.AutoSize = true;
            this.labelTenDangNhap.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Italic);
            this.labelTenDangNhap.ForeColor = System.Drawing.Color.White;
            this.labelTenDangNhap.Location = new System.Drawing.Point(3, 61);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(181, 30);
            this.labelTenDangNhap.TabIndex = 0;
            this.labelTenDangNhap.Text = "Tên đăng nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.radioButtonGV);
            this.panel2.Controls.Add(this.radioButtonSV);
            this.panel2.Location = new System.Drawing.Point(257, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 337);
            this.panel2.TabIndex = 1;
            // 
            // radioButtonGV
            // 
            this.radioButtonGV.AutoSize = true;
            this.radioButtonGV.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic);
            this.radioButtonGV.ForeColor = System.Drawing.Color.White;
            this.radioButtonGV.Location = new System.Drawing.Point(230, 9);
            this.radioButtonGV.Name = "radioButtonGV";
            this.radioButtonGV.Size = new System.Drawing.Size(167, 38);
            this.radioButtonGV.TabIndex = 2;
            this.radioButtonGV.TabStop = true;
            this.radioButtonGV.Text = "Giảng viên";
            this.radioButtonGV.UseVisualStyleBackColor = true;
            // 
            // radioButtonSV
            // 
            this.radioButtonSV.AutoSize = true;
            this.radioButtonSV.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic);
            this.radioButtonSV.ForeColor = System.Drawing.Color.White;
            this.radioButtonSV.Location = new System.Drawing.Point(22, 9);
            this.radioButtonSV.Name = "radioButtonSV";
            this.radioButtonSV.Size = new System.Drawing.Size(150, 38);
            this.radioButtonSV.TabIndex = 0;
            this.radioButtonSV.TabStop = true;
            this.radioButtonSV.Text = "Sinh viên";
            this.radioButtonSV.UseVisualStyleBackColor = true;
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lbDangNhap.Font = new System.Drawing.Font("Sitka Small", 40.2F, System.Drawing.FontStyle.Bold);
            this.lbDangNhap.ForeColor = System.Drawing.Color.Red;
            this.lbDangNhap.Location = new System.Drawing.Point(58, 0);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(638, 99);
            this.lbDangNhap.TabIndex = 0;
            this.lbDangNhap.Text = "Lấy lại mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbDangNhap);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 501);
            this.panel1.TabIndex = 1;
            // 
            // FQuenMatKhau
            // 
            this.ClientSize = new System.Drawing.Size(753, 501);
            this.Controls.Add(this.panel1);
            this.Name = "FQuenMatKhau";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
