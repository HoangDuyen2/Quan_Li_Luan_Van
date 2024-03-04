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
    public partial class FTrangChu : Form
    {
        private Label labelTieuDe;
        private Panel panel1;

        public FTrangChu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.labelTieuDe);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 53);
            this.panel1.TabIndex = 4;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.labelTieuDe.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTieuDe.Location = new System.Drawing.Point(1, 9);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(206, 35);
            this.labelTieuDe.TabIndex = 5;
            this.labelTieuDe.Text = "TRANG CHỦ";
            // 
            // FTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTrangChu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
