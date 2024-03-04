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
    public partial class FDangKy : Form
    {
        private GroupBox groupBoxTraCuuLuanVan;
        private Panel panelTile;
        private Button buttonTimKiem;
        private Label label1;
        private Button btnDangKy;
        private Panel panel2;

        public FDangKy()
        {
            InitializeComponent();
        }

        private void labelDangKy_Click(object sender, EventArgs e)
        {

        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.groupBoxTraCuuLuanVan = new System.Windows.Forms.GroupBox();
            this.panelTile = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.groupBoxTraCuuLuanVan.SuspendLayout();
            this.panelTile.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTraCuuLuanVan
            // 
            this.groupBoxTraCuuLuanVan.Controls.Add(this.buttonTimKiem);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.panelTile);
            this.groupBoxTraCuuLuanVan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxTraCuuLuanVan.Location = new System.Drawing.Point(0, 1);
            this.groupBoxTraCuuLuanVan.Name = "groupBoxTraCuuLuanVan";
            this.groupBoxTraCuuLuanVan.Size = new System.Drawing.Size(853, 176);
            this.groupBoxTraCuuLuanVan.TabIndex = 0;
            this.groupBoxTraCuuLuanVan.TabStop = false;
            this.groupBoxTraCuuLuanVan.Text = "Tra cứu luận văn";
            // 
            // panelTile
            // 
            this.panelTile.Controls.Add(this.panel2);
            this.panelTile.Location = new System.Drawing.Point(0, 64);
            this.panelTile.Name = "panelTile";
            this.panelTile.Size = new System.Drawing.Size(853, 53);
            this.panelTile.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 53);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG KÝ LUẬN VĂN";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKy.Location = new System.Drawing.Point(669, 481);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(146, 35);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng kí đề tài mới";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTimKiem.Location = new System.Drawing.Point(701, 26);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(146, 35);
            this.buttonTimKiem.TabIndex = 2;
            this.buttonTimKiem.Text = "         Tìm kiếm";
            this.buttonTimKiem.UseMnemonic = false;
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // FDangKy
            // 
            this.ClientSize = new System.Drawing.Size(855, 560);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.groupBoxTraCuuLuanVan);
            this.Name = "FDangKy";
            this.Text = "FDangKy";
            this.groupBoxTraCuuLuanVan.ResumeLayout(false);
            this.panelTile.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
