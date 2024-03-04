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
    public partial class FTraCuu : Form
    {
        private Label labelTieuDe;
        private Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Label labelLoaiTraCuu;
        private Label labelThongTinMonHoc;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonThongTinMonHoc;
        private Button buttonTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewTraCuu;
        private Panel panel2;

        public FTraCuu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelThongTinMonHoc = new System.Windows.Forms.Label();
            this.labelLoaiTraCuu = new System.Windows.Forms.Label();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonThongTinMonHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDataGridViewTraCuu = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.labelTieuDe.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTieuDe.Location = new System.Drawing.Point(0, 9);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(154, 35);
            this.labelTieuDe.TabIndex = 2;
            this.labelTieuDe.Text = "TRA CỨU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 53);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonTimKiem);
            this.panel2.Controls.Add(this.kryptonDataGridViewTraCuu);
            this.panel2.Controls.Add(this.kryptonThongTinMonHoc);
            this.panel2.Controls.Add(this.kryptonComboBox1);
            this.panel2.Controls.Add(this.labelLoaiTraCuu);
            this.panel2.Controls.Add(this.labelThongTinMonHoc);
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 399);
            this.panel2.TabIndex = 3;
            // 
            // labelThongTinMonHoc
            // 
            this.labelThongTinMonHoc.AutoSize = true;
            this.labelThongTinMonHoc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelThongTinMonHoc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelThongTinMonHoc.Location = new System.Drawing.Point(286, 13);
            this.labelThongTinMonHoc.Name = "labelThongTinMonHoc";
            this.labelThongTinMonHoc.Size = new System.Drawing.Size(188, 28);
            this.labelThongTinMonHoc.TabIndex = 5;
            this.labelThongTinMonHoc.Text = "Thông tin môn học";
            // 
            // labelLoaiTraCuu
            // 
            this.labelLoaiTraCuu.AutoSize = true;
            this.labelLoaiTraCuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelLoaiTraCuu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelLoaiTraCuu.Location = new System.Drawing.Point(0, 13);
            this.labelLoaiTraCuu.Name = "labelLoaiTraCuu";
            this.labelLoaiTraCuu.Size = new System.Drawing.Size(118, 28);
            this.labelLoaiTraCuu.TabIndex = 6;
            this.labelLoaiTraCuu.Text = "Loại tra cứu";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 141;
            this.kryptonComboBox1.Location = new System.Drawing.Point(124, 16);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(141, 25);
            this.kryptonComboBox1.TabIndex = 7;
            // 
            // kryptonThongTinMonHoc
            // 
            this.kryptonThongTinMonHoc.Location = new System.Drawing.Point(478, 13);
            this.kryptonThongTinMonHoc.Name = "kryptonThongTinMonHoc";
            this.kryptonThongTinMonHoc.Size = new System.Drawing.Size(204, 36);
            this.kryptonThongTinMonHoc.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonThongTinMonHoc.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.kryptonThongTinMonHoc.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonThongTinMonHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonThongTinMonHoc.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonThongTinMonHoc.StateCommon.Border.Rounding = 16;
            this.kryptonThongTinMonHoc.StateCommon.Border.Width = 1;
            this.kryptonThongTinMonHoc.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonThongTinMonHoc.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonThongTinMonHoc.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonThongTinMonHoc.TabIndex = 9;
            this.kryptonThongTinMonHoc.Text = "Nhập Thông tin môn học";
            // 
            // kryptonDataGridViewTraCuu
            // 
            this.kryptonDataGridViewTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewTraCuu.Location = new System.Drawing.Point(0, 65);
            this.kryptonDataGridViewTraCuu.Name = "kryptonDataGridViewTraCuu";
            this.kryptonDataGridViewTraCuu.RowHeadersWidth = 51;
            this.kryptonDataGridViewTraCuu.RowTemplate.Height = 24;
            this.kryptonDataGridViewTraCuu.Size = new System.Drawing.Size(830, 334);
            this.kryptonDataGridViewTraCuu.TabIndex = 10;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonTimKiem.Image = global::Quan_Li_Luan_Van.Properties.Resources.find;
            this.buttonTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimKiem.Location = new System.Drawing.Point(690, 7);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(137, 42);
            this.buttonTimKiem.TabIndex = 6;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // FTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelTieuDe);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FTraCuu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
