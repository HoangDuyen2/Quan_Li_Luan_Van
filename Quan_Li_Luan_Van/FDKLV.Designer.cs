namespace Quan_Li_Luan_Van
{
    partial class FDKLV
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.comboxLoaiTraCuu = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.groupBoxTraCuuLuanVan = new System.Windows.Forms.GroupBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.labelThongTinMonHoc = new System.Windows.Forms.Label();
            this.labelLoaiTraCuu = new System.Windows.Forms.Label();
            this.flPanelDSLV = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxLoaiTraCuu)).BeginInit();
            this.groupBoxTraCuuLuanVan.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(745, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Đăng ký luận văn mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1041, 52);
            this.panelTitle.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG KÝ LUẬN VĂN";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(505, 39);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(297, 36);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox1.StateCommon.Border.Rounding = 16;
            this.kryptonTextBox1.StateCommon.Border.Width = 1;
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox1.TabIndex = 14;
            this.kryptonTextBox1.Text = "EN035524";
            // 
            // comboxLoaiTraCuu
            // 
            this.comboxLoaiTraCuu.DropDownWidth = 261;
            this.comboxLoaiTraCuu.Items.AddRange(new object[] {
            "Chưa nhận",
            "Đang tiến hành",
            "Đã hoàn thành"});
            this.comboxLoaiTraCuu.Location = new System.Drawing.Point(95, 39);
            this.comboxLoaiTraCuu.Name = "comboxLoaiTraCuu";
            this.comboxLoaiTraCuu.Size = new System.Drawing.Size(273, 39);
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Blue;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Rounding = 20;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Width = 1;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.comboxLoaiTraCuu.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxLoaiTraCuu.TabIndex = 12;
            this.comboxLoaiTraCuu.Text = "Chưa nhận";
            // 
            // groupBoxTraCuuLuanVan
            // 
            this.groupBoxTraCuuLuanVan.Controls.Add(this.buttonTimKiem);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.kryptonTextBox1);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.labelThongTinMonHoc);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.comboxLoaiTraCuu);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.labelLoaiTraCuu);
            this.groupBoxTraCuuLuanVan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTraCuuLuanVan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxTraCuuLuanVan.Location = new System.Drawing.Point(0, 58);
            this.groupBoxTraCuuLuanVan.Name = "groupBoxTraCuuLuanVan";
            this.groupBoxTraCuuLuanVan.Size = new System.Drawing.Size(1182, 95);
            this.groupBoxTraCuuLuanVan.TabIndex = 17;
            this.groupBoxTraCuuLuanVan.TabStop = false;
            this.groupBoxTraCuuLuanVan.Text = "Tra cứu luận văn";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonTimKiem.Image = global::Quan_Li_Luan_Van.Properties.Resources.find;
            this.buttonTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimKiem.Location = new System.Drawing.Point(859, 36);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(158, 42);
            this.buttonTimKiem.TabIndex = 15;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // labelThongTinMonHoc
            // 
            this.labelThongTinMonHoc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelThongTinMonHoc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelThongTinMonHoc.Image = global::Quan_Li_Luan_Van.Properties.Resources.information;
            this.labelThongTinMonHoc.Location = new System.Drawing.Point(417, 27);
            this.labelThongTinMonHoc.Name = "labelThongTinMonHoc";
            this.labelThongTinMonHoc.Size = new System.Drawing.Size(82, 63);
            this.labelThongTinMonHoc.TabIndex = 13;
            this.labelThongTinMonHoc.Text = "  ";
            // 
            // labelLoaiTraCuu
            // 
            this.labelLoaiTraCuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelLoaiTraCuu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelLoaiTraCuu.Image = global::Quan_Li_Luan_Van.Properties.Resources.category;
            this.labelLoaiTraCuu.Location = new System.Drawing.Point(12, 33);
            this.labelLoaiTraCuu.Name = "labelLoaiTraCuu";
            this.labelLoaiTraCuu.Size = new System.Drawing.Size(70, 57);
            this.labelLoaiTraCuu.TabIndex = 11;
            this.labelLoaiTraCuu.Text = "  ";
            // 
            // flPanelDSLV
            // 
            this.flPanelDSLV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flPanelDSLV.Location = new System.Drawing.Point(12, 159);
            this.flPanelDSLV.Name = "flPanelDSLV";
            this.flPanelDSLV.Size = new System.Drawing.Size(1017, 483);
            this.flPanelDSLV.TabIndex = 22;
            // 
            // FDKLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 702);
            this.Controls.Add(this.flPanelDSLV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.groupBoxTraCuuLuanVan);
            this.Name = "FDKLV";
            this.Text = "FDKLV";
            this.Load += new System.EventHandler(this.FDKLV_Load);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboxLoaiTraCuu)).EndInit();
            this.groupBoxTraCuuLuanVan.ResumeLayout(false);
            this.groupBoxTraCuuLuanVan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Label labelLoaiTraCuu;
        private System.Windows.Forms.BindingSource qLLUANVANDataSetBindingSource;
        //private QLLUANVANDataSet qLLUANVANDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Label labelThongTinMonHoc;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboxLoaiTraCuu;
        private System.Windows.Forms.GroupBox groupBoxTraCuuLuanVan;
        private System.Windows.Forms.FlowLayoutPanel flPanelDSLV;
    }
}