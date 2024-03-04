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
    public partial class FDangNhap : Form
    {
        private Panel panel1;
        private RadioButton radioButtonSV;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private RadioButton radioButtonGV;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Button btnDangNhap;
        private LinkLabel linkLabel1;
        private Label lbDangNhap;

        public FDangNhap()
        {
            InitializeComponent();
        }

        private void Quen_mat_khau(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FQuenMatKhau quenMatKhau = new FQuenMatKhau();
            quenMatKhau.Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonSV = new System.Windows.Forms.RadioButton();
            this.radioButtonGV = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbDangNhap);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 501);
            this.panel1.TabIndex = 0;
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lbDangNhap.Font = new System.Drawing.Font("Sitka Small", 40.2F, System.Drawing.FontStyle.Bold);
            this.lbDangNhap.ForeColor = System.Drawing.Color.Red;
            this.lbDangNhap.Location = new System.Drawing.Point(144, 1);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(423, 99);
            this.lbDangNhap.TabIndex = 0;
            this.lbDangNhap.Text = "Đăng nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.radioButtonGV);
            this.panel2.Controls.Add(this.radioButtonSV);
            this.panel2.Location = new System.Drawing.Point(245, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 337);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.btnDangNhap);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.kryptonTextBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.kryptonTextBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(245, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 284);
            this.panel3.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(200, 54);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(200, 122);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.PasswordChar = '*';
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
            this.kryptonTextBox2.Text = "Nhập vào Mật khẩu";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
            this.linkLabel1.Location = new System.Drawing.Point(19, 194);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 28);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(200, 216);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(161, 47);
            this.btnDangNhap.TabIndex = 13;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // FDangNhap
            // 
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.panel1);
            this.Name = "FDangNhap";
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
