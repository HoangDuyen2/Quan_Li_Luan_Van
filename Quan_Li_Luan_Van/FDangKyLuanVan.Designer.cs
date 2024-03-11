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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GVDK = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cboxLoaitracuu = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonThongTinMonHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTraCuuLuanVan.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxLoaitracuu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTraCuuLuanVan
            // 
            this.groupBoxTraCuuLuanVan.Controls.Add(this.kryptonThongTinMonHoc);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.cboxLoaitracuu);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.btnTimKiem);
            this.groupBoxTraCuuLuanVan.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.groupBoxTraCuuLuanVan.Location = new System.Drawing.Point(0, 47);
            this.groupBoxTraCuuLuanVan.Name = "groupBoxTraCuuLuanVan";
            this.groupBoxTraCuuLuanVan.Size = new System.Drawing.Size(1247, 95);
            this.groupBoxTraCuuLuanVan.TabIndex = 2;
            this.groupBoxTraCuuLuanVan.TabStop = false;
            this.groupBoxTraCuuLuanVan.Text = "Tra cứu luận văn";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(548, 39);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(89, 33);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseMnemonic = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG KÝ LUẬN VĂN";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKy.Location = new System.Drawing.Point(1060, 645);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(146, 35);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng kí đề tài mới";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1133, 52);
            this.panelTitle.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(892, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng kí";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GVDK
            // 
            this.GVDK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.GVDK.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.GVDK.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlCustom1;
            this.GVDK.Location = new System.Drawing.Point(0, 155);
            this.GVDK.Name = "GVDK";
            this.GVDK.RowHeadersWidth = 51;
            this.GVDK.RowTemplate.Height = 24;
            this.GVDK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GVDK.Size = new System.Drawing.Size(1133, 484);
            this.GVDK.TabIndex = 6;
            // 
            // cboxLoaitracuu
            // 
            this.cboxLoaitracuu.DropDownWidth = 213;
            this.cboxLoaitracuu.Items.AddRange(new object[] {
            "Đăng ký được",
            "Giảng Viên",
            "Mã Đề Tài",
            "Tên Đề Tài"});
            this.cboxLoaitracuu.Location = new System.Drawing.Point(36, 35);
            this.cboxLoaitracuu.Name = "cboxLoaitracuu";
            this.cboxLoaitracuu.Size = new System.Drawing.Size(223, 37);
            this.cboxLoaitracuu.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboxLoaitracuu.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cboxLoaitracuu.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cboxLoaitracuu.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboxLoaitracuu.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboxLoaitracuu.StateCommon.ComboBox.Border.Rounding = 15;
            this.cboxLoaitracuu.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.cboxLoaitracuu.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLoaitracuu.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cboxLoaitracuu.TabIndex = 3;
            this.cboxLoaitracuu.Text = "Loại tra cứu";
            // 
            // kryptonThongTinMonHoc
            // 
            this.kryptonThongTinMonHoc.Location = new System.Drawing.Point(298, 37);
            this.kryptonThongTinMonHoc.Name = "kryptonThongTinMonHoc";
            this.kryptonThongTinMonHoc.Size = new System.Drawing.Size(223, 35);
            this.kryptonThongTinMonHoc.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonThongTinMonHoc.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.kryptonThongTinMonHoc.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonThongTinMonHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonThongTinMonHoc.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonThongTinMonHoc.StateCommon.Border.Rounding = 15;
            this.kryptonThongTinMonHoc.StateCommon.Border.Width = 1;
            this.kryptonThongTinMonHoc.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonThongTinMonHoc.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonThongTinMonHoc.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonThongTinMonHoc.TabIndex = 10;
            this.kryptonThongTinMonHoc.Text = "Nhập thông tin ...";
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STT.FillWeight = 30F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 66;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Mã Đề Tài";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 108;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Đề Tài ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 340;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giảng Viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 190;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "Số lượng ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 66;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "Từ ngày";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 88;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "Đến ngày";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 97;
            // 
            // FDangKyLuanVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.GVDK);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.groupBoxTraCuuLuanVan);
            this.Name = "FDangKyLuanVan";
            this.Text = "DangKyLuanVan";
            this.groupBoxTraCuuLuanVan.ResumeLayout(false);
            this.groupBoxTraCuuLuanVan.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxLoaitracuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTraCuuLuanVan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button button1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView GVDK;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboxLoaitracuu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonThongTinMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}