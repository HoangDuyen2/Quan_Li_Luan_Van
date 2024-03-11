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
            this.kryptonDataGridViewTraCuu = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboxLoaiTraCuu = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.kryptonThongTinMonHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelLoaiTraCuu = new System.Windows.Forms.Label();
            this.labelThongTinMonHoc = new System.Windows.Forms.Label();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewTraCuu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxLoaiTraCuu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonDataGridViewTraCuu
            // 
            this.kryptonDataGridViewTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewTraCuu.Location = new System.Drawing.Point(19, 99);
            this.kryptonDataGridViewTraCuu.Name = "kryptonDataGridViewTraCuu";
            this.kryptonDataGridViewTraCuu.RowHeadersWidth = 51;
            this.kryptonDataGridViewTraCuu.RowTemplate.Height = 24;
            this.kryptonDataGridViewTraCuu.Size = new System.Drawing.Size(930, 395);
            this.kryptonDataGridViewTraCuu.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboxLoaiTraCuu);
            this.panel2.Controls.Add(this.buttonTimKiem);
            this.panel2.Controls.Add(this.kryptonDataGridViewTraCuu);
            this.panel2.Controls.Add(this.kryptonThongTinMonHoc);
            this.panel2.Controls.Add(this.labelLoaiTraCuu);
            this.panel2.Controls.Add(this.labelThongTinMonHoc);
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 506);
            this.panel2.TabIndex = 5;
            // 
            // comboxLoaiTraCuu
            // 
            this.comboxLoaiTraCuu.DropDownWidth = 261;
            this.comboxLoaiTraCuu.Items.AddRange(new object[] {
            "Chưa nhận",
            "Đang tiến hành",
            "Đã hoàn thành"});
            this.comboxLoaiTraCuu.Location = new System.Drawing.Point(88, 32);
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
            this.comboxLoaiTraCuu.TabIndex = 11;
            this.comboxLoaiTraCuu.Text = "Chưa nhận";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonTimKiem.Image = global::Quan_Li_Luan_Van.Properties.Resources.find;
            this.buttonTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimKiem.Location = new System.Drawing.Point(791, 29);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(158, 42);
            this.buttonTimKiem.TabIndex = 6;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // kryptonThongTinMonHoc
            // 
            this.kryptonThongTinMonHoc.Location = new System.Drawing.Point(476, 32);
            this.kryptonThongTinMonHoc.Name = "kryptonThongTinMonHoc";
            this.kryptonThongTinMonHoc.Size = new System.Drawing.Size(297, 36);
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
            this.kryptonThongTinMonHoc.Text = "EN035524";
            // 
            // labelLoaiTraCuu
            // 
            this.labelLoaiTraCuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelLoaiTraCuu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelLoaiTraCuu.Image = global::Quan_Li_Luan_Van.Properties.Resources.category;
            this.labelLoaiTraCuu.Location = new System.Drawing.Point(12, 22);
            this.labelLoaiTraCuu.Name = "labelLoaiTraCuu";
            this.labelLoaiTraCuu.Size = new System.Drawing.Size(70, 57);
            this.labelLoaiTraCuu.TabIndex = 6;
            this.labelLoaiTraCuu.Text = "  ";
            // 
            // labelThongTinMonHoc
            // 
            this.labelThongTinMonHoc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelThongTinMonHoc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelThongTinMonHoc.Image = global::Quan_Li_Luan_Van.Properties.Resources.information;
            this.labelThongTinMonHoc.Location = new System.Drawing.Point(388, 16);
            this.labelThongTinMonHoc.Name = "labelThongTinMonHoc";
            this.labelThongTinMonHoc.Size = new System.Drawing.Size(82, 63);
            this.labelThongTinMonHoc.TabIndex = 5;
            this.labelThongTinMonHoc.Text = "  ";
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.labelTieuDe.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTieuDe.Location = new System.Drawing.Point(27, 10);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(154, 35);
            this.labelTieuDe.TabIndex = 4;
            this.labelTieuDe.Text = "TRA CỨU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.labelTieuDe);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 53);
            this.panel1.TabIndex = 6;
            // 
            // FTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FTraCuu";
            this.Text = "TraCuu";
            this.Load += new System.EventHandler(this.TraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewTraCuu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxLoaiTraCuu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewTraCuu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonThongTinMonHoc;
        private System.Windows.Forms.Label labelLoaiTraCuu;
        private System.Windows.Forms.Label labelThongTinMonHoc;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboxLoaiTraCuu;
    }
}