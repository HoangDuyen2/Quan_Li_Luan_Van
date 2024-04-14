namespace Quan_Li_Luan_Van
{
    partial class FThemThongBao
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
            this.kryptonContextMenu1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnThem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelNoidung = new System.Windows.Forms.Panel();
            this.cbboxTieuDe = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtNoiDungTB = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lblNDTB = new System.Windows.Forms.Label();
            this.lblGuiDen = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnThoat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelNoidung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbboxTieuDe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblThongBao.Location = new System.Drawing.Point(176, 14);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(132, 28);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "THÔNG BÁO";
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnThem.Location = new System.Drawing.Point(64, 408);
            this.btnThem.Name = "btnThem";
            this.btnThem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnThem.Size = new System.Drawing.Size(136, 40);
            this.btnThem.TabIndex = 8;
            this.btnThem.Values.Text = "Gửi thông báo";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelNoidung
            // 
            this.panelNoidung.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelNoidung.Controls.Add(this.cbboxTieuDe);
            this.panelNoidung.Controls.Add(this.txtNoiDungTB);
            this.panelNoidung.Controls.Add(this.lblNDTB);
            this.panelNoidung.Controls.Add(this.lblGuiDen);
            this.panelNoidung.Controls.Add(this.lblTieuDe);
            this.panelNoidung.Location = new System.Drawing.Point(12, 58);
            this.panelNoidung.Name = "panelNoidung";
            this.panelNoidung.Size = new System.Drawing.Size(460, 344);
            this.panelNoidung.TabIndex = 9;
            // 
            // cbboxTieuDe
            // 
            this.cbboxTieuDe.DropDownWidth = 261;
            this.cbboxTieuDe.Items.AddRange(new object[] {
            "Meeting online",
            "Update task"});
            this.cbboxTieuDe.Location = new System.Drawing.Point(105, 31);
            this.cbboxTieuDe.Name = "cbboxTieuDe";
            this.cbboxTieuDe.Size = new System.Drawing.Size(331, 39);
            this.cbboxTieuDe.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbboxTieuDe.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cbboxTieuDe.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Blue;
            this.cbboxTieuDe.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbboxTieuDe.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbboxTieuDe.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbboxTieuDe.StateCommon.ComboBox.Border.Width = 1;
            this.cbboxTieuDe.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.cbboxTieuDe.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxTieuDe.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.cbboxTieuDe.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cbboxTieuDe.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cbboxTieuDe.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cbboxTieuDe.StateCommon.Item.Back.Color2 = System.Drawing.Color.White;
            this.cbboxTieuDe.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.cbboxTieuDe.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.cbboxTieuDe.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbboxTieuDe.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbboxTieuDe.StateNormal.ComboBox.Border.Color1 = System.Drawing.Color.White;
            this.cbboxTieuDe.StateNormal.ComboBox.Border.Color2 = System.Drawing.Color.White;
            this.cbboxTieuDe.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbboxTieuDe.TabIndex = 53;
            // 
            // txtNoiDungTB
            // 
            this.txtNoiDungTB.Location = new System.Drawing.Point(24, 142);
            this.txtNoiDungTB.Name = "txtNoiDungTB";
            this.txtNoiDungTB.Size = new System.Drawing.Size(412, 186);
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
            this.lblNDTB.Location = new System.Drawing.Point(19, 93);
            this.lblNDTB.Name = "lblNDTB";
            this.lblNDTB.Size = new System.Drawing.Size(210, 28);
            this.lblNDTB.TabIndex = 26;
            this.lblNDTB.Text = "Nội dung thông báo :";
            // 
            // lblGuiDen
            // 
            this.lblGuiDen.AutoSize = true;
            this.lblGuiDen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuiDen.Location = new System.Drawing.Point(11, 143);
            this.lblGuiDen.Name = "lblGuiDen";
            this.lblGuiDen.Size = new System.Drawing.Size(0, 28);
            this.lblGuiDen.TabIndex = 25;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(19, 34);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(80, 28);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Tiêu đề";
            // 
            // btnThoat
            // 
            this.btnThoat.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnThoat.Location = new System.Drawing.Point(257, 408);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnThoat.Size = new System.Drawing.Size(136, 40);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Values.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FThemThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 469);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panelNoidung);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThongBao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThemThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thông báo";
            this.panelNoidung.ResumeLayout(false);
            this.panelNoidung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbboxTieuDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private System.Windows.Forms.Label lblThongBao;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThem;
        private System.Windows.Forms.Panel panelNoidung;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNDTB;
        private System.Windows.Forms.Label lblGuiDen;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtNoiDungTB;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThoat;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbboxTieuDe;
    }
}