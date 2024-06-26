﻿namespace Quan_Li_Luan_Van
{
    partial class FDanhSachLuanVan
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
            this.lblDSLuanVan = new System.Windows.Forms.Label();
            this.txtTenGV = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupBoxTraCuuLuanVan = new System.Windows.Forms.GroupBox();
            this.comboxChuyenNganh = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblTraTenGV = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTraChuyenNganh = new System.Windows.Forms.Label();
            this.flPanelDSLV = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitle.SuspendLayout();
            this.groupBoxTraCuuLuanVan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxChuyenNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblDSLuanVan);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1064, 52);
            this.panelTitle.TabIndex = 24;
            // 
            // lblDSLuanVan
            // 
            this.lblDSLuanVan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.lblDSLuanVan.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDSLuanVan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDSLuanVan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDSLuanVan.Location = new System.Drawing.Point(12, 9);
            this.lblDSLuanVan.Name = "lblDSLuanVan";
            this.lblDSLuanVan.Size = new System.Drawing.Size(331, 41);
            this.lblDSLuanVan.TabIndex = 1;
            this.lblDSLuanVan.Text = "DANH SÁCH LUẬN VĂN";
            this.lblDSLuanVan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(88, 29);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(284, 36);
            this.txtTenGV.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTenGV.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtTenGV.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTenGV.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenGV.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTenGV.StateCommon.Border.Rounding = 16;
            this.txtTenGV.StateCommon.Border.Width = 1;
            this.txtTenGV.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTenGV.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtTenGV.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtTenGV.TabIndex = 14;
            // 
            // groupBoxTraCuuLuanVan
            // 
            this.groupBoxTraCuuLuanVan.Controls.Add(this.comboxChuyenNganh);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.lblTraTenGV);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.btnTimKiem);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.txtTenGV);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.lblTraChuyenNganh);
            this.groupBoxTraCuuLuanVan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTraCuuLuanVan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxTraCuuLuanVan.Location = new System.Drawing.Point(-4, 64);
            this.groupBoxTraCuuLuanVan.Name = "groupBoxTraCuuLuanVan";
            this.groupBoxTraCuuLuanVan.Size = new System.Drawing.Size(1076, 77);
            this.groupBoxTraCuuLuanVan.TabIndex = 23;
            this.groupBoxTraCuuLuanVan.TabStop = false;
            this.groupBoxTraCuuLuanVan.Text = "Tra cứu luận văn";
            // 
            // comboxChuyenNganh
            // 
            this.comboxChuyenNganh.DropDownWidth = 261;
            this.comboxChuyenNganh.Items.AddRange(new object[] {
            "Tất cả",
            "Phát triển phần mềm",
            "Khoa học dữ liệu",
            "An ninh mạng",
            "Trí tuệ nhân tạo",
            "Phát triển Trò chơi",
            "Kỹ thuật ứng dụng"});
            this.comboxChuyenNganh.Location = new System.Drawing.Point(532, 26);
            this.comboxChuyenNganh.Name = "comboxChuyenNganh";
            this.comboxChuyenNganh.Size = new System.Drawing.Size(273, 41);
            this.comboxChuyenNganh.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.comboxChuyenNganh.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Blue;
            this.comboxChuyenNganh.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxChuyenNganh.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.comboxChuyenNganh.StateCommon.ComboBox.Border.Rounding = 20;
            this.comboxChuyenNganh.StateCommon.ComboBox.Border.Width = 1;
            this.comboxChuyenNganh.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboxChuyenNganh.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.comboxChuyenNganh.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.comboxChuyenNganh.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.comboxChuyenNganh.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.comboxChuyenNganh.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.comboxChuyenNganh.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.comboxChuyenNganh.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxChuyenNganh.TabIndex = 18;
            this.comboxChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.ChonChuyenNganh);
            // 
            // lblTraTenGV
            // 
            this.lblTraTenGV.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTraTenGV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTraTenGV.Location = new System.Drawing.Point(6, 35);
            this.lblTraTenGV.Name = "lblTraTenGV";
            this.lblTraTenGV.Size = new System.Drawing.Size(82, 24);
            this.lblTraTenGV.TabIndex = 16;
            this.lblTraTenGV.Text = "Tên GV";
            this.lblTraTenGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.Image = global::Quan_Li_Luan_Van.Properties.Resources.find;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(820, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(158, 42);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblTraChuyenNganh
            // 
            this.lblTraChuyenNganh.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTraChuyenNganh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTraChuyenNganh.Location = new System.Drawing.Point(396, 33);
            this.lblTraChuyenNganh.Name = "lblTraChuyenNganh";
            this.lblTraChuyenNganh.Size = new System.Drawing.Size(130, 29);
            this.lblTraChuyenNganh.TabIndex = 13;
            this.lblTraChuyenNganh.Text = "Chuyên ngành";
            this.lblTraChuyenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flPanelDSLV
            // 
            this.flPanelDSLV.AutoScroll = true;
            this.flPanelDSLV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flPanelDSLV.Location = new System.Drawing.Point(0, 137);
            this.flPanelDSLV.Name = "flPanelDSLV";
            this.flPanelDSLV.Size = new System.Drawing.Size(1062, 553);
            this.flPanelDSLV.TabIndex = 26;
            // 
            // FDanhSachLuanVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 702);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.groupBoxTraCuuLuanVan);
            this.Controls.Add(this.flPanelDSLV);
            this.Name = "FDanhSachLuanVan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Luận Văn";
            this.Load += new System.EventHandler(this.TraCuu_Load);
            this.panelTitle.ResumeLayout(false);
            this.groupBoxTraCuuLuanVan.ResumeLayout(false);
            this.groupBoxTraCuuLuanVan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxChuyenNganh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblDSLuanVan;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenGV;
        private System.Windows.Forms.GroupBox groupBoxTraCuuLuanVan;
        private System.Windows.Forms.Label lblTraTenGV;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTraChuyenNganh;
        private System.Windows.Forms.FlowLayoutPanel flPanelDSLV;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboxChuyenNganh;
    }
}