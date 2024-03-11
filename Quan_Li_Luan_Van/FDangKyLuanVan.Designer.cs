namespace Quan_Li_Luan_Van
{
    partial class FDangKyLuanVan
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
            this.groupBoxTraCuuLuanVan = new System.Windows.Forms.GroupBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.panelTile = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
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
            this.groupBoxTraCuuLuanVan.Location = new System.Drawing.Point(-3, 1);
            this.groupBoxTraCuuLuanVan.Name = "groupBoxTraCuuLuanVan";
            this.groupBoxTraCuuLuanVan.Size = new System.Drawing.Size(871, 143);
            this.groupBoxTraCuuLuanVan.TabIndex = 2;
            this.groupBoxTraCuuLuanVan.TabStop = false;
            this.groupBoxTraCuuLuanVan.Text = "Tra cứu luận văn";
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
            this.btnDangKy.Location = new System.Drawing.Point(643, 448);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(146, 35);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng kí đề tài mới";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // DangKyLuanVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 509);
            this.Controls.Add(this.groupBoxTraCuuLuanVan);
            this.Controls.Add(this.btnDangKy);
            this.Name = "DangKyLuanVan";
            this.Text = "DangKyLuanVan";
            this.groupBoxTraCuuLuanVan.ResumeLayout(false);
            this.panelTile.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTraCuuLuanVan;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Panel panelTile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangKy;
    }
}