namespace Quan_Li_Luan_Van
{
    partial class FTrangChu
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
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.panelChucnang = new System.Windows.Forms.Panel();
            this.btnThemThongBao = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblChonngay = new System.Windows.Forms.Label();
            this.txtTimkiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.flpanelDSThongBao = new System.Windows.Forms.FlowLayoutPanel();
            this.dtNgayThang = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.panelTB = new System.Windows.Forms.Panel();
            this.panelChucnang.SuspendLayout();
            this.flpanelDSThongBao.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.labelTieuDe.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTieuDe.Location = new System.Drawing.Point(12, 9);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(234, 41);
            this.labelTieuDe.TabIndex = 3;
            this.labelTieuDe.Text = "TRANG CHỦ";
            this.labelTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChucnang
            // 
            this.panelChucnang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelChucnang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChucnang.Controls.Add(this.dtNgayThang);
            this.panelChucnang.Controls.Add(this.btnThemThongBao);
            this.panelChucnang.Controls.Add(this.buttonTimKiem);
            this.panelChucnang.Controls.Add(this.lblChonngay);
            this.panelChucnang.Controls.Add(this.txtTimkiem);
            this.panelChucnang.Controls.Add(this.lblThongbao);
            this.panelChucnang.Controls.Add(this.labelTieuDe);
            this.panelChucnang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChucnang.Location = new System.Drawing.Point(0, 0);
            this.panelChucnang.Name = "panelChucnang";
            this.panelChucnang.Size = new System.Drawing.Size(1073, 127);
            this.panelChucnang.TabIndex = 5;
            // 
            // btnThemThongBao
            // 
            this.btnThemThongBao.Location = new System.Drawing.Point(910, 75);
            this.btnThemThongBao.Name = "btnThemThongBao";
            this.btnThemThongBao.Size = new System.Drawing.Size(146, 43);
            this.btnThemThongBao.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThemThongBao.StateNormal.Border.Rounding = 10;
            this.btnThemThongBao.StateNormal.Border.Width = 1;
            this.btnThemThongBao.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThongBao.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThongBao.TabIndex = 19;
            this.btnThemThongBao.Values.Text = "Thêm thông báo";
            this.btnThemThongBao.Click += new System.EventHandler(this.btnThemThongBao_Click);
            // 
            // lblChonngay
            // 
            this.lblChonngay.AutoSize = true;
            this.lblChonngay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblChonngay.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblChonngay.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblChonngay.Location = new System.Drawing.Point(14, 87);
            this.lblChonngay.Name = "lblChonngay";
            this.lblChonngay.Size = new System.Drawing.Size(109, 25);
            this.lblChonngay.TabIndex = 16;
            this.lblChonngay.Text = "Chọn ngày";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(347, 78);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(497, 39);
            this.txtTimkiem.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTimkiem.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtTimkiem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTimkiem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTimkiem.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTimkiem.StateCommon.Border.Rounding = 16;
            this.txtTimkiem.StateCommon.Border.Width = 1;
            this.txtTimkiem.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtTimkiem.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtTimkiem.TabIndex = 15;
            this.txtTimkiem.Text = "Nhập để tìm kiếm";
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = true;
            this.lblThongbao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongbao.ForeColor = System.Drawing.Color.Black;
            this.lblThongbao.Location = new System.Drawing.Point(15, 50);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(155, 20);
            this.lblThongbao.TabIndex = 4;
            this.lblThongbao.Text = "Danh sách thông báo";
            // 
            // flpanelDSThongBao
            // 
            this.flpanelDSThongBao.Controls.Add(this.panelTB);
            this.flpanelDSThongBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpanelDSThongBao.Location = new System.Drawing.Point(0, 127);
            this.flpanelDSThongBao.Name = "flpanelDSThongBao";
            this.flpanelDSThongBao.Size = new System.Drawing.Size(1073, 532);
            this.flpanelDSThongBao.TabIndex = 6;
            // 
            // dtNgayThang
            // 
            this.dtNgayThang.CalendarTodayDate = new System.DateTime(2024, 3, 16, 0, 0, 0, 0);
            this.dtNgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayThang.Location = new System.Drawing.Point(136, 78);
            this.dtNgayThang.Name = "dtNgayThang";
            this.dtNgayThang.Size = new System.Drawing.Size(191, 39);
            this.dtNgayThang.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.dtNgayThang.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.dtNgayThang.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.dtNgayThang.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtNgayThang.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dtNgayThang.StateCommon.Border.Rounding = 16;
            this.dtNgayThang.StateCommon.Border.Width = 1;
            this.dtNgayThang.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.dtNgayThang.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThang.TabIndex = 20;
            this.dtNgayThang.ValueNullable = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.AutoSize = true;
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonTimKiem.Image = global::Quan_Li_Luan_Van.Properties.Resources.find;
            this.buttonTimKiem.Location = new System.Drawing.Point(856, 78);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(43, 36);
            this.buttonTimKiem.TabIndex = 18;
            this.buttonTimKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // panelTB
            // 
            this.panelTB.Location = new System.Drawing.Point(3, 3);
            this.panelTB.Name = "panelTB";
            this.panelTB.Size = new System.Drawing.Size(1070, 529);
            this.panelTB.TabIndex = 0;
            // 
            // FTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 659);
            this.Controls.Add(this.flpanelDSThongBao);
            this.Controls.Add(this.panelChucnang);
            this.Name = "FTrangChu";
            this.Text = "FTrangChu";
            this.Load += new System.EventHandler(this.FTrangChu_Load);
            this.panelChucnang.ResumeLayout(false);
            this.panelChucnang.PerformLayout();
            this.flpanelDSThongBao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Panel panelChucnang;
        private System.Windows.Forms.Label lblThongbao;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimkiem;
        private System.Windows.Forms.Label lblChonngay;
        private System.Windows.Forms.Button buttonTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThemThongBao;
        private System.Windows.Forms.FlowLayoutPanel flpanelDSThongBao;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtNgayThang;
        private System.Windows.Forms.Panel panelTB;
    }
}