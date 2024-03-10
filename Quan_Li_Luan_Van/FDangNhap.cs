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
        private Panel panelAnh;
        private PictureBox pictureBoxUTE;
        private Label lblText;
        private RadioButton rbntSV;
        private RadioButton rbtnGV;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTK;
        private ContextMenuStrip contextMenuStrip1;
        private IContainer components;
        private Label lblTenDangNhap;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDangNhap;
        private Label label1;
        private RadioButton radioButtonGV;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMatKhau;
        private Panel panelDangNhap;

        public FDangNhap()
        {
            InitializeComponent();
        }
  
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDangNhap));
            this.panelAnh = new System.Windows.Forms.Panel();
            this.pictureBoxUTE = new System.Windows.Forms.PictureBox();
            this.panelDangNhap = new System.Windows.Forms.Panel();
            this.txtMatKhau = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnDangNhap = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTK = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rbtnGV = new System.Windows.Forms.RadioButton();
            this.rbntSV = new System.Windows.Forms.RadioButton();
            this.lblText = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUTE)).BeginInit();
            this.panelDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAnh
            // 
            this.panelAnh.Controls.Add(this.pictureBoxUTE);
            this.panelAnh.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAnh.Location = new System.Drawing.Point(0, 0);
            this.panelAnh.Name = "panelAnh";
            this.panelAnh.Size = new System.Drawing.Size(821, 642);
            this.panelAnh.TabIndex = 0;
            // 
            // pictureBoxUTE
            // 
            this.pictureBoxUTE.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxUTE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxUTE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUTE.Image")));
            this.pictureBoxUTE.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUTE.Name = "pictureBoxUTE";
            this.pictureBoxUTE.Size = new System.Drawing.Size(821, 642);
            this.pictureBoxUTE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUTE.TabIndex = 0;
            this.pictureBoxUTE.TabStop = false;
            // 
            // panelDangNhap
            // 
            this.panelDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panelDangNhap.Controls.Add(this.txtMatKhau);
            this.panelDangNhap.Controls.Add(this.btnDangNhap);
            this.panelDangNhap.Controls.Add(this.label1);
            this.panelDangNhap.Controls.Add(this.lblTenDangNhap);
            this.panelDangNhap.Controls.Add(this.txtTK);
            this.panelDangNhap.Controls.Add(this.rbtnGV);
            this.panelDangNhap.Controls.Add(this.rbntSV);
            this.panelDangNhap.Controls.Add(this.lblText);
            this.panelDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDangNhap.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.panelDangNhap.Location = new System.Drawing.Point(821, 0);
            this.panelDangNhap.Name = "panelDangNhap";
            this.panelDangNhap.Size = new System.Drawing.Size(412, 642);
            this.panelDangNhap.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(86, 397);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.Size = new System.Drawing.Size(259, 42);
            this.txtMatKhau.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtMatKhau.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMatKhau.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMatKhau.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMatKhau.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtMatKhau.StateCommon.Border.Rounding = 30;
            this.txtMatKhau.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtMatKhau.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtMatKhau.TabIndex = 8;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(138, 463);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(144, 40);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Values.Text = "Đăng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(91, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lblTenDangNhap.Location = new System.Drawing.Point(91, 285);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(148, 28);
            this.lblTenDangNhap.TabIndex = 4;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(86, 316);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(259, 42);
            this.txtTK.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTK.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTK.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTK.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTK.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTK.StateCommon.Border.Rounding = 30;
            this.txtTK.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtTK.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtTK.TabIndex = 3;
            // 
            // rbtnGV
            // 
            this.rbtnGV.AutoSize = true;
            this.rbtnGV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtnGV.ForeColor = System.Drawing.Color.Black;
            this.rbtnGV.Location = new System.Drawing.Point(225, 235);
            this.rbtnGV.Name = "rbtnGV";
            this.rbtnGV.Size = new System.Drawing.Size(110, 25);
            this.rbtnGV.TabIndex = 2;
            this.rbtnGV.TabStop = true;
            this.rbtnGV.Text = "Giảng Viên";
            this.rbtnGV.UseVisualStyleBackColor = true;
            // 
            // rbntSV
            // 
            this.rbntSV.AutoSize = true;
            this.rbntSV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbntSV.ForeColor = System.Drawing.Color.Black;
            this.rbntSV.Location = new System.Drawing.Point(94, 235);
            this.rbntSV.Name = "rbntSV";
            this.rbntSV.Size = new System.Drawing.Size(99, 25);
            this.rbntSV.TabIndex = 1;
            this.rbntSV.TabStop = true;
            this.rbntSV.Text = "Sinh Viên";
            this.rbntSV.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI Semibold", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lblText.Location = new System.Drawing.Point(87, 158);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(285, 51);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Đăng Nhập Với";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(86, 397);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(259, 42);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox1.StateCommon.Border.Rounding = 30;
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FDangNhap
            // 
            this.ClientSize = new System.Drawing.Size(1233, 642);
            this.Controls.Add(this.panelDangNhap);
            this.Controls.Add(this.panelAnh);
            this.Name = "FDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FDangNhap_Load);
            this.panelAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUTE)).EndInit();
            this.panelDangNhap.ResumeLayout(false);
            this.panelDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }

    }
}
