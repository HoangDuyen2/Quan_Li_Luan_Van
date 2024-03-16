namespace Quan_Li_Luan_Van
{
    partial class FTraCuu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboxLoaiTraCuu = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonThongTinMonHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPhanCach = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxLoaiTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelPhanCach);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbTrangThai);
            this.panel2.Controls.Add(this.comboxLoaiTraCuu);
            this.panel2.Controls.Add(this.buttonTimKiem);
            this.panel2.Controls.Add(this.kryptonThongTinMonHoc);
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 661);
            this.panel2.TabIndex = 5;
            // 
            // comboxLoaiTraCuu
            // 
            this.comboxLoaiTraCuu.DropDownWidth = 261;
            this.comboxLoaiTraCuu.Items.AddRange(new object[] {
            "Chưa nhận",
            "Đang tiến hành",
            "Đã hoàn thành"});
            this.comboxLoaiTraCuu.Location = new System.Drawing.Point(184, 29);
            this.comboxLoaiTraCuu.Name = "comboxLoaiTraCuu";
            this.comboxLoaiTraCuu.Size = new System.Drawing.Size(262, 40);
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Blue;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Rounding = 20;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Width = 1;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.comboxLoaiTraCuu.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxLoaiTraCuu.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxLoaiTraCuu.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxLoaiTraCuu.StateNormal.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxLoaiTraCuu.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxLoaiTraCuu.TabIndex = 11;
            this.comboxLoaiTraCuu.Text = "Trạng thái luận văn";
            // 
            // kryptonThongTinMonHoc
            // 
            this.kryptonThongTinMonHoc.Location = new System.Drawing.Point(555, 33);
            this.kryptonThongTinMonHoc.MaxLength = 327670;
            this.kryptonThongTinMonHoc.Name = "kryptonThongTinMonHoc";
            this.kryptonThongTinMonHoc.Size = new System.Drawing.Size(283, 36);
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
            this.kryptonThongTinMonHoc.Text = "Mã luận văn";
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.labelTieuDe.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTieuDe.Location = new System.Drawing.Point(11, 9);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(154, 35);
            this.labelTieuDe.TabIndex = 12;
            this.labelTieuDe.Text = "TRA CỨU";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonTimKiem.Image = global::Quan_Li_Luan_Van.Properties.Resources.find;
            this.buttonTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimKiem.Location = new System.Drawing.Point(879, 27);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(158, 42);
            this.buttonTimKiem.TabIndex = 6;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTrangThai.Location = new System.Drawing.Point(60, 37);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(105, 25);
            this.lbTrangThai.TabIndex = 12;
            this.lbTrangThai.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(491, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã";
            // 
            // panelPhanCach
            // 
            this.panelPhanCach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPhanCach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPhanCach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelPhanCach.Location = new System.Drawing.Point(1, 83);
            this.panelPhanCach.Name = "panelPhanCach";
            this.panelPhanCach.Size = new System.Drawing.Size(1071, 527);
            this.panelPhanCach.TabIndex = 14;
            // 
            // FTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 713);
            this.Controls.Add(this.labelTieuDe);
            this.Controls.Add(this.panel2);
            this.Name = "FTraCuu";
            this.Text = "TraCuu";
            this.Load += new System.EventHandler(this.TraCuu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxLoaiTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonThongTinMonHoc;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboxLoaiTraCuu;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPhanCach;
    }
}