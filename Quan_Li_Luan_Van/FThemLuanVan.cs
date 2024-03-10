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
    public partial class FThemLuanVan : Form
    {
        private Panel panel1;
        private Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label lbTrangThai;
        private Label lbChuyenNganh;
        private Label lbNgayBD;
        private Label lbMoTaChiTiet;
        private Label lbTenLuanVan;
        private Label lbMaLuanVan;
        private Label lbNgayKT;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox7;
        private Label lbGioKT;
        private Label lbGioBD;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Label lbTienDo;
        private Button buttonAdd;
        private Label labelTieuDe;

        public FThemLuanVan()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lbTienDo = new System.Windows.Forms.Label();
            this.lbGioKT = new System.Windows.Forms.Label();
            this.lbGioBD = new System.Windows.Forms.Label();
            this.lbNgayKT = new System.Windows.Forms.Label();
            this.kryptonTextBox7 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbChuyenNganh = new System.Windows.Forms.Label();
            this.lbNgayBD = new System.Windows.Forms.Label();
            this.lbMoTaChiTiet = new System.Windows.Forms.Label();
            this.lbTenLuanVan = new System.Windows.Forms.Label();
            this.lbMaLuanVan = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 53);
            this.panel1.TabIndex = 1;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.labelTieuDe.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTieuDe.Location = new System.Drawing.Point(0, 9);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(281, 35);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "THÊM LUẬN VĂN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.kryptonDataGridView1);
            this.panel2.Controls.Add(this.lbTienDo);
            this.panel2.Controls.Add(this.lbGioKT);
            this.panel2.Controls.Add(this.lbGioBD);
            this.panel2.Controls.Add(this.lbNgayKT);
            this.panel2.Controls.Add(this.kryptonTextBox7);
            this.panel2.Controls.Add(this.kryptonTextBox2);
            this.panel2.Controls.Add(this.kryptonTextBox1);
            this.panel2.Controls.Add(this.lbTrangThai);
            this.panel2.Controls.Add(this.lbChuyenNganh);
            this.panel2.Controls.Add(this.lbNgayBD);
            this.panel2.Controls.Add(this.lbMoTaChiTiet);
            this.panel2.Controls.Add(this.lbTenLuanVan);
            this.panel2.Controls.Add(this.lbMaLuanVan);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 538);
            this.panel2.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(464, 495);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 39);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(196, 320);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(620, 168);
            this.kryptonDataGridView1.TabIndex = 33;
            // 
            // lbTienDo
            // 
            this.lbTienDo.AutoSize = true;
            this.lbTienDo.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienDo.Location = new System.Drawing.Point(459, 270);
            this.lbTienDo.Name = "lbTienDo";
            this.lbTienDo.Size = new System.Drawing.Size(110, 27);
            this.lbTienDo.TabIndex = 32;
            this.lbTienDo.Text = "Tiến độ";
            // 
            // lbGioKT
            // 
            this.lbGioKT.AutoSize = true;
            this.lbGioKT.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioKT.Location = new System.Drawing.Point(459, 210);
            this.lbGioKT.Name = "lbGioKT";
            this.lbGioKT.Size = new System.Drawing.Size(180, 27);
            this.lbGioKT.TabIndex = 31;
            this.lbGioKT.Text = "Giờ kết thúc";
            // 
            // lbGioBD
            // 
            this.lbGioBD.AutoSize = true;
            this.lbGioBD.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioBD.Location = new System.Drawing.Point(459, 150);
            this.lbGioBD.Name = "lbGioBD";
            this.lbGioBD.Size = new System.Drawing.Size(166, 27);
            this.lbGioBD.TabIndex = 30;
            this.lbGioBD.Text = "Giờ bắt đầu";
            // 
            // lbNgayKT
            // 
            this.lbNgayKT.AutoSize = true;
            this.lbNgayKT.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayKT.Location = new System.Drawing.Point(10, 210);
            this.lbNgayKT.Name = "lbNgayKT";
            this.lbNgayKT.Size = new System.Drawing.Size(194, 27);
            this.lbNgayKT.TabIndex = 29;
            this.lbNgayKT.Text = "Ngày kết thúc";
            // 
            // kryptonTextBox7
            // 
            this.kryptonTextBox7.Location = new System.Drawing.Point(235, 83);
            this.kryptonTextBox7.Name = "kryptonTextBox7";
            this.kryptonTextBox7.Size = new System.Drawing.Size(681, 35);
            this.kryptonTextBox7.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox7.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.kryptonTextBox7.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonTextBox7.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox7.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox7.StateCommon.Border.Rounding = 16;
            this.kryptonTextBox7.StateCommon.Border.Width = 1;
            this.kryptonTextBox7.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox7.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox7.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox7.TabIndex = 28;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(631, 22);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(276, 36);
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
            this.kryptonTextBox2.StateDisabled.Border.Color1 = System.Drawing.Color.Blue;
            this.kryptonTextBox2.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonTextBox2.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox2.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox2.StateDisabled.Border.Rounding = 16;
            this.kryptonTextBox2.StateDisabled.Border.Width = 1;
            this.kryptonTextBox2.TabIndex = 23;
            this.kryptonTextBox2.Text = "Nhập Tên luận văn";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(196, 22);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(227, 36);
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
            this.kryptonTextBox1.TabIndex = 22;
            this.kryptonTextBox1.Text = "Nhập Mã luận văn";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Location = new System.Drawing.Point(10, 270);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(152, 27);
            this.lbTrangThai.TabIndex = 19;
            this.lbTrangThai.Text = "Trạng thái";
            // 
            // lbChuyenNganh
            // 
            this.lbChuyenNganh.AutoSize = true;
            this.lbChuyenNganh.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenNganh.Location = new System.Drawing.Point(10, 330);
            this.lbChuyenNganh.Name = "lbChuyenNganh";
            this.lbChuyenNganh.Size = new System.Drawing.Size(180, 27);
            this.lbChuyenNganh.TabIndex = 18;
            this.lbChuyenNganh.Text = "Chuyên ngành";
            // 
            // lbNgayBD
            // 
            this.lbNgayBD.AutoSize = true;
            this.lbNgayBD.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayBD.Location = new System.Drawing.Point(10, 150);
            this.lbNgayBD.Name = "lbNgayBD";
            this.lbNgayBD.Size = new System.Drawing.Size(180, 27);
            this.lbNgayBD.TabIndex = 17;
            this.lbNgayBD.Text = "Ngày bắt đầu";
            // 
            // lbMoTaChiTiet
            // 
            this.lbMoTaChiTiet.AutoSize = true;
            this.lbMoTaChiTiet.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoTaChiTiet.Location = new System.Drawing.Point(10, 90);
            this.lbMoTaChiTiet.Name = "lbMoTaChiTiet";
            this.lbMoTaChiTiet.Size = new System.Drawing.Size(208, 27);
            this.lbMoTaChiTiet.TabIndex = 16;
            this.lbMoTaChiTiet.Text = "Mô tả chi tiết";
            // 
            // lbTenLuanVan
            // 
            this.lbTenLuanVan.AutoSize = true;
            this.lbTenLuanVan.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLuanVan.Location = new System.Drawing.Point(445, 30);
            this.lbTenLuanVan.Name = "lbTenLuanVan";
            this.lbTenLuanVan.Size = new System.Drawing.Size(180, 27);
            this.lbTenLuanVan.TabIndex = 15;
            this.lbTenLuanVan.Text = "Tên luận văn";
            // 
            // lbMaLuanVan
            // 
            this.lbMaLuanVan.AutoSize = true;
            this.lbMaLuanVan.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLuanVan.Location = new System.Drawing.Point(10, 30);
            this.lbMaLuanVan.Name = "lbMaLuanVan";
            this.lbMaLuanVan.Size = new System.Drawing.Size(166, 27);
            this.lbMaLuanVan.TabIndex = 14;
            this.lbMaLuanVan.Text = "Mã luận văn";
            // 
            // FThemLuanVan
            // 
            this.ClientSize = new System.Drawing.Size(919, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelTieuDe);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThemLuanVan";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
