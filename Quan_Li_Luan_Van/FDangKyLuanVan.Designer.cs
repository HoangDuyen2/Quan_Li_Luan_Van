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
            this.btnDangKi = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenGV = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupBoxTraCuuLuanVan = new System.Windows.Forms.GroupBox();
            this.cbboxChuyenNganh = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblTraTenGV = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTraChuyenNganh = new System.Windows.Forms.Label();
            this.flPanelDSLV = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitle.SuspendLayout();
            this.groupBoxTraCuuLuanVan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbboxChuyenNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangKi
            // 
            this.btnDangKi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDangKi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangKi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDangKi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKi.Location = new System.Drawing.Point(802, 645);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(250, 38);
            this.btnDangKi.TabIndex = 21;
            this.btnDangKi.Text = "Đăng ký luận văn mới";
            this.btnDangKi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDangKi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangKi.UseVisualStyleBackColor = false;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1058, 52);
            this.panelTitle.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG KÝ LUẬN VĂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(88, 29);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(302, 36);
            this.txtTenGV.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTenGV.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtTenGV.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTenGV.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenGV.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTenGV.StateCommon.Border.Rounding = 16;
            this.txtTenGV.StateCommon.Border.Width = 1;
            this.txtTenGV.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtTenGV.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtTenGV.TabIndex = 14;
            this.txtTenGV.Text = "Tất cả";
            // 
            // groupBoxTraCuuLuanVan
            // 
            this.groupBoxTraCuuLuanVan.Controls.Add(this.cbboxChuyenNganh);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.lblTraTenGV);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.btnTimKiem);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.txtTenGV);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.lblTraChuyenNganh);
            this.groupBoxTraCuuLuanVan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTraCuuLuanVan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxTraCuuLuanVan.Location = new System.Drawing.Point(0, 58);
            this.groupBoxTraCuuLuanVan.Name = "groupBoxTraCuuLuanVan";
            this.groupBoxTraCuuLuanVan.Size = new System.Drawing.Size(1182, 77);
            this.groupBoxTraCuuLuanVan.TabIndex = 17;
            this.groupBoxTraCuuLuanVan.TabStop = false;
            this.groupBoxTraCuuLuanVan.Text = "Tra cứu luận văn";
            // 
            // cbboxChuyenNganh
            // 
            this.cbboxChuyenNganh.DropDownWidth = 261;
            this.cbboxChuyenNganh.Items.AddRange(new object[] {
            "Tất cả",
            "Phát triển phần mềm",
            "Khoa học dữ liệu và Phân tích dữ liệu",
            "An ninh mạng",
            "Quản lý hạ tầng",
            "Trí tuệ nhân tạo",
            "Phát triển Trò chơi",
            "Kỹ thuật ứng dụng"});
            this.cbboxChuyenNganh.Location = new System.Drawing.Point(532, 25);
            this.cbboxChuyenNganh.Name = "cbboxChuyenNganh";
            this.cbboxChuyenNganh.Size = new System.Drawing.Size(273, 39);
            this.cbboxChuyenNganh.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cbboxChuyenNganh.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Blue;
            this.cbboxChuyenNganh.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbboxChuyenNganh.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbboxChuyenNganh.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbboxChuyenNganh.StateCommon.ComboBox.Border.Width = 1;
            this.cbboxChuyenNganh.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.cbboxChuyenNganh.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxChuyenNganh.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.cbboxChuyenNganh.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cbboxChuyenNganh.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cbboxChuyenNganh.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.cbboxChuyenNganh.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.cbboxChuyenNganh.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbboxChuyenNganh.TabIndex = 17;
            this.cbboxChuyenNganh.Text = "Tất cả";
            this.cbboxChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.Chon_Chuyen_Nganh);
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
            this.btnTimKiem.Location = new System.Drawing.Point(894, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(158, 42);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
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
            this.flPanelDSLV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flPanelDSLV.Location = new System.Drawing.Point(0, 132);
            this.flPanelDSLV.Name = "flPanelDSLV";
            this.flPanelDSLV.Size = new System.Drawing.Size(1052, 507);
            this.flPanelDSLV.TabIndex = 22;
            // 
            // FDangKyLuanVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 686);
            this.Controls.Add(this.flPanelDSLV);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.groupBoxTraCuuLuanVan);
            this.Name = "FDangKyLuanVan";
            this.Text = "Đăng ký luận văn";
            this.Load += new System.EventHandler(this.FDKLV_Load);
            this.panelTitle.ResumeLayout(false);
            this.groupBoxTraCuuLuanVan.ResumeLayout(false);
            this.groupBoxTraCuuLuanVan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbboxChuyenNganh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.BindingSource qLLUANVANDataSetBindingSource;
        //private QLLUANVANDataSet qLLUANVANDataSet;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenGV;
        private System.Windows.Forms.Label lblTraChuyenNganh;
        private System.Windows.Forms.GroupBox groupBoxTraCuuLuanVan;
        private System.Windows.Forms.FlowLayoutPanel flPanelDSLV;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbboxChuyenNganh;
        private System.Windows.Forms.Label lblTraTenGV;
    }
}