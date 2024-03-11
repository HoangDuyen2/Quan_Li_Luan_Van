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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenLuanVan;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMaLuanVan;
        private Label lbTrangThai;
        private Label lbGioKT;
        private Label lbMoTaChiTiet;
        private Label lbNgayKT;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMoTaChiTiet;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Button buttonAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtNgayBD;
        private Label lbID;
        private Label lbTenLuanVan;
        private Label lbLGioBD;
        private Label lblNgayKT;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DtNgayKT;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtGioBD;
        private Label lbNgayBD;
        private Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtGioKT;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboxTrangThai;
        private Label label2;
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
            this.lbNgayKT = new System.Windows.Forms.Label();
            this.txtMoTaChiTiet = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtTenLuanVan = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMaLuanVan = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dtNgayBD = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.DtNgayKT = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtGioBD = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtGioKT = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.comboxTrangThai = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNgayBD = new System.Windows.Forms.Label();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.lbLGioBD = new System.Windows.Forms.Label();
            this.lbTenLuanVan = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbGioKT = new System.Windows.Forms.Label();
            this.lbMoTaChiTiet = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxTrangThai)).BeginInit();
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboxTrangThai);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtGioKT);
            this.panel2.Controls.Add(this.dtGioBD);
            this.panel2.Controls.Add(this.lbNgayBD);
            this.panel2.Controls.Add(this.DtNgayKT);
            this.panel2.Controls.Add(this.lblNgayKT);
            this.panel2.Controls.Add(this.lbLGioBD);
            this.panel2.Controls.Add(this.lbTenLuanVan);
            this.panel2.Controls.Add(this.lbID);
            this.panel2.Controls.Add(this.dtNgayBD);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.kryptonDataGridView1);
            this.panel2.Controls.Add(this.lbNgayKT);
            this.panel2.Controls.Add(this.txtMoTaChiTiet);
            this.panel2.Controls.Add(this.txtTenLuanVan);
            this.panel2.Controls.Add(this.txtMaLuanVan);
            this.panel2.Controls.Add(this.lbTrangThai);
            this.panel2.Controls.Add(this.lbGioKT);
            this.panel2.Controls.Add(this.lbMoTaChiTiet);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 575);
            this.panel2.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(417, 524);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 39);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(116, 366);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(713, 144);
            this.kryptonDataGridView1.TabIndex = 33;
            // 
            // lbNgayKT
            // 
            this.lbNgayKT.AutoSize = true;
            this.lbNgayKT.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayKT.Location = new System.Drawing.Point(1, 379);
            this.lbNgayKT.Name = "lbNgayKT";
            this.lbNgayKT.Size = new System.Drawing.Size(40, 27);
            this.lbNgayKT.TabIndex = 29;
            this.lbNgayKT.Text = "  ";
            // 
            // txtMoTaChiTiet
            // 
            this.txtMoTaChiTiet.Location = new System.Drawing.Point(85, 92);
            this.txtMoTaChiTiet.Name = "txtMoTaChiTiet";
            this.txtMoTaChiTiet.Size = new System.Drawing.Size(798, 36);
            this.txtMoTaChiTiet.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtMoTaChiTiet.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtMoTaChiTiet.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMoTaChiTiet.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMoTaChiTiet.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtMoTaChiTiet.StateCommon.Border.Rounding = 16;
            this.txtMoTaChiTiet.StateCommon.Border.Width = 1;
            this.txtMoTaChiTiet.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtMoTaChiTiet.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTaChiTiet.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtMoTaChiTiet.TabIndex = 28;
            this.txtMoTaChiTiet.Text = "Phần mềm giúp quản lí luận văn dễ dàng hơn";
            // 
            // txtTenLuanVan
            // 
            this.txtTenLuanVan.Location = new System.Drawing.Point(521, 30);
            this.txtTenLuanVan.Name = "txtTenLuanVan";
            this.txtTenLuanVan.Size = new System.Drawing.Size(362, 36);
            this.txtTenLuanVan.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTenLuanVan.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtTenLuanVan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTenLuanVan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenLuanVan.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTenLuanVan.StateCommon.Border.Rounding = 16;
            this.txtTenLuanVan.StateCommon.Border.Width = 1;
            this.txtTenLuanVan.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtTenLuanVan.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLuanVan.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtTenLuanVan.StateDisabled.Border.Color1 = System.Drawing.Color.Blue;
            this.txtTenLuanVan.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTenLuanVan.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenLuanVan.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTenLuanVan.StateDisabled.Border.Rounding = 16;
            this.txtTenLuanVan.StateDisabled.Border.Width = 1;
            this.txtTenLuanVan.TabIndex = 23;
            this.txtTenLuanVan.Text = "Quản lí luận văn";
            // 
            // txtMaLuanVan
            // 
            this.txtMaLuanVan.Location = new System.Drawing.Point(83, 30);
            this.txtMaLuanVan.Name = "txtMaLuanVan";
            this.txtMaLuanVan.Size = new System.Drawing.Size(333, 36);
            this.txtMaLuanVan.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtMaLuanVan.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtMaLuanVan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMaLuanVan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaLuanVan.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtMaLuanVan.StateCommon.Border.Rounding = 16;
            this.txtMaLuanVan.StateCommon.Border.Width = 1;
            this.txtMaLuanVan.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtMaLuanVan.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLuanVan.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtMaLuanVan.TabIndex = 22;
            this.txtMaLuanVan.Text = "LV001";
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.Location = new System.Drawing.Point(149, 161);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(267, 38);
            this.dtNgayBD.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.dtNgayBD.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.dtNgayBD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtNgayBD.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dtNgayBD.StateCommon.Border.Rounding = 16;
            this.dtNgayBD.StateCommon.Border.Width = 1;
            this.dtNgayBD.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.dtNgayBD.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBD.TabIndex = 34;
            this.dtNgayBD.ValueNullable = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            // 
            // DtNgayKT
            // 
            this.DtNgayKT.Location = new System.Drawing.Point(149, 229);
            this.DtNgayKT.Name = "DtNgayKT";
            this.DtNgayKT.Size = new System.Drawing.Size(271, 38);
            this.DtNgayKT.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.DtNgayKT.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.DtNgayKT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DtNgayKT.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DtNgayKT.StateCommon.Border.Rounding = 16;
            this.DtNgayKT.StateCommon.Border.Width = 1;
            this.DtNgayKT.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.DtNgayKT.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtNgayKT.TabIndex = 41;
            this.DtNgayKT.ValueNullable = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            // 
            // dtGioBD
            // 
            this.dtGioBD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtGioBD.Location = new System.Drawing.Point(595, 161);
            this.dtGioBD.Name = "dtGioBD";
            this.dtGioBD.Size = new System.Drawing.Size(288, 38);
            this.dtGioBD.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.dtGioBD.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.dtGioBD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtGioBD.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dtGioBD.StateCommon.Border.Rounding = 16;
            this.dtGioBD.StateCommon.Border.Width = 1;
            this.dtGioBD.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.dtGioBD.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGioBD.TabIndex = 43;
            this.dtGioBD.ValueNullable = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            // 
            // dtGioKT
            // 
            this.dtGioKT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtGioKT.Location = new System.Drawing.Point(595, 229);
            this.dtGioKT.Name = "dtGioKT";
            this.dtGioKT.Size = new System.Drawing.Size(288, 38);
            this.dtGioKT.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.dtGioKT.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.dtGioKT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtGioKT.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dtGioKT.StateCommon.Border.Rounding = 16;
            this.dtGioKT.StateCommon.Border.Width = 1;
            this.dtGioKT.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.dtGioKT.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGioKT.TabIndex = 44;
            this.dtGioKT.ValueNullable = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            // 
            // comboxTrangThai
            // 
            this.comboxTrangThai.DropDownWidth = 267;
            this.comboxTrangThai.Location = new System.Drawing.Point(149, 315);
            this.comboxTrangThai.Name = "comboxTrangThai";
            this.comboxTrangThai.Size = new System.Drawing.Size(267, 28);
            this.comboxTrangThai.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.comboxTrangThai.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.comboxTrangThai.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxTrangThai.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.comboxTrangThai.StateCommon.ComboBox.Border.Rounding = 0;
            this.comboxTrangThai.StateCommon.ComboBox.Border.Width = 1;
            this.comboxTrangThai.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxTrangThai.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxTrangThai.StateNormal.ComboBox.Border.Rounding = 16;
            this.comboxTrangThai.TabIndex = 46;
            this.comboxTrangThai.Text = " ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::Quan_Li_Luan_Van.Properties.Resources.status;
            this.label2.Location = new System.Drawing.Point(12, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 63);
            this.label2.TabIndex = 47;
            this.label2.Text = "  ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Quan_Li_Luan_Van.Properties.Resources.progress;
            this.label1.Location = new System.Drawing.Point(447, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 62);
            this.label1.TabIndex = 45;
            this.label1.Text = "  ";
            // 
            // lbNgayBD
            // 
            this.lbNgayBD.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayBD.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbNgayBD.Image = global::Quan_Li_Luan_Van.Properties.Resources.date;
            this.lbNgayBD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNgayBD.Location = new System.Drawing.Point(10, 152);
            this.lbNgayBD.Name = "lbNgayBD";
            this.lbNgayBD.Size = new System.Drawing.Size(133, 60);
            this.lbNgayBD.TabIndex = 42;
            this.lbNgayBD.Text = "start";
            this.lbNgayBD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKT.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNgayKT.Image = global::Quan_Li_Luan_Van.Properties.Resources.date;
            this.lblNgayKT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNgayKT.Location = new System.Drawing.Point(10, 222);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(110, 60);
            this.lblNgayKT.TabIndex = 40;
            this.lblNgayKT.Text = "end";
            this.lblNgayKT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLGioBD
            // 
            this.lbLGioBD.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLGioBD.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbLGioBD.Image = global::Quan_Li_Luan_Van.Properties.Resources.start;
            this.lbLGioBD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLGioBD.Location = new System.Drawing.Point(459, 152);
            this.lbLGioBD.Name = "lbLGioBD";
            this.lbLGioBD.Size = new System.Drawing.Size(130, 60);
            this.lbLGioBD.TabIndex = 38;
            this.lbLGioBD.Text = "start";
            this.lbLGioBD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTenLuanVan
            // 
            this.lbTenLuanVan.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLuanVan.Image = global::Quan_Li_Luan_Van.Properties.Resources.card;
            this.lbTenLuanVan.Location = new System.Drawing.Point(444, 18);
            this.lbTenLuanVan.Name = "lbTenLuanVan";
            this.lbTenLuanVan.Size = new System.Drawing.Size(68, 54);
            this.lbTenLuanVan.TabIndex = 37;
            this.lbTenLuanVan.Text = "  ";
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Image = global::Quan_Li_Luan_Van.Properties.Resources.id1;
            this.lbID.Location = new System.Drawing.Point(12, 12);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(65, 60);
            this.lbID.TabIndex = 36;
            this.lbID.Text = "  ";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Image = global::Quan_Li_Luan_Van.Properties.Resources.major;
            this.lbTrangThai.Location = new System.Drawing.Point(12, 393);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(67, 63);
            this.lbTrangThai.TabIndex = 19;
            this.lbTrangThai.Text = "  ";
            // 
            // lbGioKT
            // 
            this.lbGioKT.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioKT.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbGioKT.Image = global::Quan_Li_Luan_Van.Properties.Resources.start;
            this.lbGioKT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbGioKT.Location = new System.Drawing.Point(459, 222);
            this.lbGioKT.Name = "lbGioKT";
            this.lbGioKT.Size = new System.Drawing.Size(110, 60);
            this.lbGioKT.TabIndex = 17;
            this.lbGioKT.Text = "end";
            this.lbGioKT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMoTaChiTiet
            // 
            this.lbMoTaChiTiet.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoTaChiTiet.Image = global::Quan_Li_Luan_Van.Properties.Resources.decribe;
            this.lbMoTaChiTiet.Location = new System.Drawing.Point(12, 82);
            this.lbMoTaChiTiet.Name = "lbMoTaChiTiet";
            this.lbMoTaChiTiet.Size = new System.Drawing.Size(67, 50);
            this.lbMoTaChiTiet.TabIndex = 16;
            this.lbMoTaChiTiet.Text = "  ";
            // 
            // FThemLuanVan
            // 
            this.ClientSize = new System.Drawing.Size(919, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelTieuDe);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThemLuanVan";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxTrangThai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
