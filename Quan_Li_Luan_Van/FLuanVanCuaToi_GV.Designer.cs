namespace Quan_Li_Luan_Van
{
    partial class FLuanVanCuaToi_GV
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
            this.btnThemLuanVan = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblDSLuanVanCuaToi = new System.Windows.Forms.Label();
            this.groupBoxTraCuuLuanVan = new System.Windows.Forms.GroupBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cbboxTrangThai = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.flPanelDSLV = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitle.SuspendLayout();
            this.groupBoxTraCuuLuanVan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbboxTrangThai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemLuanVan
            // 
            this.btnThemLuanVan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThemLuanVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLuanVan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemLuanVan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThemLuanVan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLuanVan.Location = new System.Drawing.Point(859, 660);
            this.btnThemLuanVan.Name = "btnThemLuanVan";
            this.btnThemLuanVan.Size = new System.Drawing.Size(184, 42);
            this.btnThemLuanVan.TabIndex = 25;
            this.btnThemLuanVan.Text = "Thêm luận văn";
            this.btnThemLuanVan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemLuanVan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemLuanVan.UseVisualStyleBackColor = false;
            this.btnThemLuanVan.Click += new System.EventHandler(this.btnThemLuanVan_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblDSLuanVanCuaToi);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1064, 52);
            this.panelTitle.TabIndex = 24;
            // 
            // lblDSLuanVanCuaToi
            // 
            this.lblDSLuanVanCuaToi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.lblDSLuanVanCuaToi.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.lblDSLuanVanCuaToi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDSLuanVanCuaToi.Location = new System.Drawing.Point(6, 9);
            this.lblDSLuanVanCuaToi.Name = "lblDSLuanVanCuaToi";
            this.lblDSLuanVanCuaToi.Size = new System.Drawing.Size(357, 35);
            this.lblDSLuanVanCuaToi.TabIndex = 1;
            this.lblDSLuanVanCuaToi.Text = "LUẬN VĂN CỦA TÔI";
            // 
            // groupBoxTraCuuLuanVan
            // 
            this.groupBoxTraCuuLuanVan.Controls.Add(this.lblTrangThai);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.cbboxTrangThai);
            this.groupBoxTraCuuLuanVan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTraCuuLuanVan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxTraCuuLuanVan.Location = new System.Drawing.Point(7, 56);
            this.groupBoxTraCuuLuanVan.Name = "groupBoxTraCuuLuanVan";
            this.groupBoxTraCuuLuanVan.Size = new System.Drawing.Size(1060, 81);
            this.groupBoxTraCuuLuanVan.TabIndex = 23;
            this.groupBoxTraCuuLuanVan.TabStop = false;
            this.groupBoxTraCuuLuanVan.Text = "Tra cứu luận văn";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTrangThai.Location = new System.Drawing.Point(1, 40);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(130, 29);
            this.lblTrangThai.TabIndex = 18;
            this.lblTrangThai.Text = "Trạng thái";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbboxTrangThai
            // 
            this.cbboxTrangThai.DropDownWidth = 261;
            this.cbboxTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đã có nhóm",
            "Chưa có nhóm"});
            this.cbboxTrangThai.Location = new System.Drawing.Point(136, 36);
            this.cbboxTrangThai.Name = "cbboxTrangThai";
            this.cbboxTrangThai.Size = new System.Drawing.Size(228, 39);
            this.cbboxTrangThai.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cbboxTrangThai.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Blue;
            this.cbboxTrangThai.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbboxTrangThai.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbboxTrangThai.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbboxTrangThai.StateCommon.ComboBox.Border.Width = 1;
            this.cbboxTrangThai.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.cbboxTrangThai.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxTrangThai.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.cbboxTrangThai.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cbboxTrangThai.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cbboxTrangThai.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.cbboxTrangThai.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.cbboxTrangThai.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbboxTrangThai.TabIndex = 17;
            this.cbboxTrangThai.Text = "Tất cả";
            this.cbboxTrangThai.SelectedIndexChanged += new System.EventHandler(this.ChonTinhTrang);
            // 
            // flPanelDSLV
            // 
            this.flPanelDSLV.AutoScroll = true;
            this.flPanelDSLV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flPanelDSLV.Location = new System.Drawing.Point(0, 137);
            this.flPanelDSLV.Name = "flPanelDSLV";
            this.flPanelDSLV.Size = new System.Drawing.Size(1064, 517);
            this.flPanelDSLV.TabIndex = 26;
            // 
            // FLuanVanCuaToi_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 702);
            this.Controls.Add(this.btnThemLuanVan);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.groupBoxTraCuuLuanVan);
            this.Controls.Add(this.flPanelDSLV);
            this.Name = "FLuanVanCuaToi_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luận Văn Của Tôi";
            this.Load += new System.EventHandler(this.FLuanVanToi_Load);
            this.panelTitle.ResumeLayout(false);
            this.groupBoxTraCuuLuanVan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbboxTrangThai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemLuanVan;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblDSLuanVanCuaToi;
        private System.Windows.Forms.GroupBox groupBoxTraCuuLuanVan;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbboxTrangThai;
        private System.Windows.Forms.FlowLayoutPanel flPanelDSLV;
        private System.Windows.Forms.Label lblTrangThai;
    }
}