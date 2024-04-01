namespace Quan_Li_Luan_Van
{
    partial class FThemNhiemVu
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
            this.panelNoidung = new System.Windows.Forms.Panel();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.txtNoiDungTB = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lblNDTB = new System.Windows.Forms.Label();
            this.txtTenNV = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.btnThem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblThemNV = new System.Windows.Forms.Label();
            this.comboxTienTrinh = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.panelNoidung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxTienTrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNoidung
            // 
            this.panelNoidung.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelNoidung.Controls.Add(this.comboxTienTrinh);
            this.panelNoidung.Controls.Add(this.lblThoiGian);
            this.panelNoidung.Controls.Add(this.txtNoiDungTB);
            this.panelNoidung.Controls.Add(this.lblNDTB);
            this.panelNoidung.Controls.Add(this.txtTenNV);
            this.panelNoidung.Controls.Add(this.lblTenNV);
            this.panelNoidung.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panelNoidung.Location = new System.Drawing.Point(19, 59);
            this.panelNoidung.Name = "panelNoidung";
            this.panelNoidung.Size = new System.Drawing.Size(576, 451);
            this.panelNoidung.TabIndex = 15;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblThoiGian.Location = new System.Drawing.Point(11, 91);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(137, 28);
            this.lblThoiGian.TabIndex = 32;
            this.lblThoiGian.Text = "Tiến trình (%)";
            // 
            // txtNoiDungTB
            // 
            this.txtNoiDungTB.Location = new System.Drawing.Point(12, 206);
            this.txtNoiDungTB.Name = "txtNoiDungTB";
            this.txtNoiDungTB.Size = new System.Drawing.Size(548, 224);
            this.txtNoiDungTB.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtNoiDungTB.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.txtNoiDungTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNoiDungTB.StateCommon.Border.Rounding = 12;
            this.txtNoiDungTB.StateCommon.Border.Width = 1;
            this.txtNoiDungTB.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtNoiDungTB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.txtNoiDungTB.TabIndex = 29;
            this.txtNoiDungTB.Text = "";
            // 
            // lblNDTB
            // 
            this.lblNDTB.AutoSize = true;
            this.lblNDTB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNDTB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNDTB.Location = new System.Drawing.Point(11, 159);
            this.lblNDTB.Name = "lblNDTB";
            this.lblNDTB.Size = new System.Drawing.Size(166, 28);
            this.lblNDTB.TabIndex = 26;
            this.lblNDTB.Text = "Nội dung chi tiết";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(159, 15);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(405, 36);
            this.txtTenNV.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTenNV.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtTenNV.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTenNV.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenNV.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTenNV.StateCommon.Border.Rounding = 16;
            this.txtTenNV.StateCommon.Border.Width = 1;
            this.txtTenNV.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtTenNV.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtTenNV.StateDisabled.Border.Color1 = System.Drawing.Color.Blue;
            this.txtTenNV.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTenNV.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenNV.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTenNV.StateDisabled.Border.Rounding = 16;
            this.txtTenNV.StateDisabled.Border.Width = 1;
            this.txtTenNV.TabIndex = 24;
            this.txtTenNV.Text = "Tên tiêu đề";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTenNV.Location = new System.Drawing.Point(11, 17);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(136, 28);
            this.lblTenNV.TabIndex = 0;
            this.lblTenNV.Text = "Tên nhiệm vụ";
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnThem.Location = new System.Drawing.Point(227, 540);
            this.btnThem.Name = "btnThem";
            this.btnThem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnThem.Size = new System.Drawing.Size(169, 40);
            this.btnThem.TabIndex = 14;
            this.btnThem.Values.Text = "Thêm Nhiệm Vụ";
            // 
            // lblThemNV
            // 
            this.lblThemNV.AutoSize = true;
            this.lblThemNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemNV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblThemNV.Location = new System.Drawing.Point(224, 15);
            this.lblThemNV.Name = "lblThemNV";
            this.lblThemNV.Size = new System.Drawing.Size(175, 28);
            this.lblThemNV.TabIndex = 13;
            this.lblThemNV.Text = "THÊM NHIỆM VỤ";
            // 
            // comboxTienTrinh
            // 
            this.comboxTienTrinh.DropDownWidth = 261;
            this.comboxTienTrinh.Items.AddRange(new object[] {
            "0%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.comboxTienTrinh.Location = new System.Drawing.Point(159, 88);
            this.comboxTienTrinh.Name = "comboxTienTrinh";
            this.comboxTienTrinh.Size = new System.Drawing.Size(237, 39);
            this.comboxTienTrinh.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.comboxTienTrinh.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.comboxTienTrinh.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Blue;
            this.comboxTienTrinh.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxTienTrinh.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.comboxTienTrinh.StateCommon.ComboBox.Border.Rounding = 20;
            this.comboxTienTrinh.StateCommon.ComboBox.Border.Width = 1;
            this.comboxTienTrinh.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.comboxTienTrinh.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxTienTrinh.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.comboxTienTrinh.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.comboxTienTrinh.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.comboxTienTrinh.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.comboxTienTrinh.StateCommon.Item.Back.Color2 = System.Drawing.Color.White;
            this.comboxTienTrinh.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.comboxTienTrinh.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.comboxTienTrinh.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxTienTrinh.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.comboxTienTrinh.StateNormal.ComboBox.Border.Color1 = System.Drawing.Color.White;
            this.comboxTienTrinh.StateNormal.ComboBox.Border.Color2 = System.Drawing.Color.White;
            this.comboxTienTrinh.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxTienTrinh.TabIndex = 43;
            this.comboxTienTrinh.Text = "Tiến trình";
            // 
            // FThemNhiemVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 589);
            this.Controls.Add(this.panelNoidung);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThemNV);
            this.Name = "FThemNhiemVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FThemNhiemVu";
            this.Load += new System.EventHandler(this.FThemNhiemVu_Load);
            this.panelNoidung.ResumeLayout(false);
            this.panelNoidung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxTienTrinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNoidung;
        private System.Windows.Forms.Label lblThoiGian;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtNoiDungTB;
        private System.Windows.Forms.Label lblNDTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThem;
        private System.Windows.Forms.Label lblThemNV;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboxTienTrinh;
    }
}