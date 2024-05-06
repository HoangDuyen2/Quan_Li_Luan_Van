namespace Quan_Li_Luan_Van
{
    partial class FDuyetLuanVan
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblDuyet = new System.Windows.Forms.Label();
            this.flPanelDSLV = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxTraCuuDuyet = new System.Windows.Forms.GroupBox();
            this.cbbLoaiTraCuu = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.groupBoxTraCuuDuyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblDuyet);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1064, 52);
            this.panelTitle.TabIndex = 24;
            // 
            // lblDuyet
            // 
            this.lblDuyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.lblDuyet.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.lblDuyet.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDuyet.Location = new System.Drawing.Point(6, 9);
            this.lblDuyet.Name = "lblDuyet";
            this.lblDuyet.Size = new System.Drawing.Size(318, 35);
            this.lblDuyet.TabIndex = 1;
            this.lblDuyet.Text = "DUYỆT LUẬN VĂN";
            // 
            // flPanelDSLV
            // 
            this.flPanelDSLV.AutoScroll = true;
            this.flPanelDSLV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flPanelDSLV.Location = new System.Drawing.Point(0, 141);
            this.flPanelDSLV.Name = "flPanelDSLV";
            this.flPanelDSLV.Size = new System.Drawing.Size(1064, 563);
            this.flPanelDSLV.TabIndex = 26;
            // 
            // groupBoxTraCuuDuyet
            // 
            this.groupBoxTraCuuDuyet.Controls.Add(this.cbbLoaiTraCuu);
            this.groupBoxTraCuuDuyet.Controls.Add(this.lblTrangThai);
            this.groupBoxTraCuuDuyet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTraCuuDuyet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxTraCuuDuyet.Location = new System.Drawing.Point(0, 58);
            this.groupBoxTraCuuDuyet.Name = "groupBoxTraCuuDuyet";
            this.groupBoxTraCuuDuyet.Size = new System.Drawing.Size(1064, 77);
            this.groupBoxTraCuuDuyet.TabIndex = 27;
            this.groupBoxTraCuuDuyet.TabStop = false;
            this.groupBoxTraCuuDuyet.Text = "Tra cứu duyệt luận văn";
            // 
            // cbbLoaiTraCuu
            // 
            this.cbbLoaiTraCuu.DropDownWidth = 261;
            this.cbbLoaiTraCuu.Items.AddRange(new object[] {
            "Tất cả",
            "Đang chờ duyệt",
            "Đã duyệt",
            "Từ chối"});
            this.cbbLoaiTraCuu.Location = new System.Drawing.Point(148, 29);
            this.cbbLoaiTraCuu.Name = "cbbLoaiTraCuu";
            this.cbbLoaiTraCuu.Size = new System.Drawing.Size(233, 41);
            this.cbbLoaiTraCuu.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cbbLoaiTraCuu.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Blue;
            this.cbbLoaiTraCuu.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbLoaiTraCuu.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbbLoaiTraCuu.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbbLoaiTraCuu.StateCommon.ComboBox.Border.Width = 1;
            this.cbbLoaiTraCuu.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbbLoaiTraCuu.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.cbbLoaiTraCuu.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.cbbLoaiTraCuu.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cbbLoaiTraCuu.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cbbLoaiTraCuu.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.cbbLoaiTraCuu.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.cbbLoaiTraCuu.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbLoaiTraCuu.TabIndex = 18;
            this.cbbLoaiTraCuu.Text = "-- Tất cả --";
            this.cbbLoaiTraCuu.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiTraCuu_SelectedIndexChanged);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTrangThai.Location = new System.Drawing.Point(12, 36);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(130, 29);
            this.lblTrangThai.TabIndex = 13;
            this.lblTrangThai.Text = "Trạng thái";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FDuyetLuanVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 702);
            this.Controls.Add(this.groupBoxTraCuuDuyet);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.flPanelDSLV);
            this.Name = "FDuyetLuanVan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDuyetLuanVan";
            this.Load += new System.EventHandler(this.FDuyetLuanVan_Load);
            this.panelTitle.ResumeLayout(false);
            this.groupBoxTraCuuDuyet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiTraCuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblDuyet;
        private System.Windows.Forms.FlowLayoutPanel flPanelDSLV;
        private System.Windows.Forms.GroupBox groupBoxTraCuuDuyet;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbLoaiTraCuu;
        private System.Windows.Forms.Label lblTrangThai;
    }
}