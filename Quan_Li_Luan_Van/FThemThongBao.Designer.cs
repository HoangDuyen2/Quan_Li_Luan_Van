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
            this.lblThemTB = new System.Windows.Forms.Label();
            this.btnThem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelNoidung = new System.Windows.Forms.Panel();
            this.txtNoiDungTB = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.checkListGui = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.lblNDTB = new System.Windows.Forms.Label();
            this.lblGuiDen = new System.Windows.Forms.Label();
            this.txtTenTieuDe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panelNoidung.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThemTB
            // 
            this.lblThemTB.AutoSize = true;
            this.lblThemTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemTB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblThemTB.Location = new System.Drawing.Point(248, 18);
            this.lblThemTB.Name = "lblThemTB";
            this.lblThemTB.Size = new System.Drawing.Size(195, 28);
            this.lblThemTB.TabIndex = 0;
            this.lblThemTB.Text = "THÊM THÔNG BÁO";
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnThem.Location = new System.Drawing.Point(262, 570);
            this.btnThem.Name = "btnThem";
            this.btnThem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnThem.Size = new System.Drawing.Size(169, 40);
            this.btnThem.TabIndex = 8;
            this.btnThem.Values.Text = "THÊM";
            // 
            // panelNoidung
            // 
            this.panelNoidung.Controls.Add(this.txtNoiDungTB);
            this.panelNoidung.Controls.Add(this.checkListGui);
            this.panelNoidung.Controls.Add(this.lblNDTB);
            this.panelNoidung.Controls.Add(this.lblGuiDen);
            this.panelNoidung.Controls.Add(this.txtTenTieuDe);
            this.panelNoidung.Controls.Add(this.lblTieuDe);
            this.panelNoidung.Location = new System.Drawing.Point(18, 62);
            this.panelNoidung.Name = "panelNoidung";
            this.panelNoidung.Size = new System.Drawing.Size(653, 502);
            this.panelNoidung.TabIndex = 9;
            // 
            // txtNoiDungTB
            // 
            this.txtNoiDungTB.Location = new System.Drawing.Point(114, 288);
            this.txtNoiDungTB.Name = "txtNoiDungTB";
            this.txtNoiDungTB.Size = new System.Drawing.Size(516, 198);
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
            // checkListGui
            // 
            this.checkListGui.Location = new System.Drawing.Point(114, 72);
            this.checkListGui.Name = "checkListGui";
            this.checkListGui.Size = new System.Drawing.Size(516, 170);
            this.checkListGui.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.checkListGui.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.checkListGui.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkListGui.StateCommon.Border.Rounding = 12;
            this.checkListGui.StateCommon.Border.Width = 1;
            this.checkListGui.TabIndex = 28;
            // 
            // lblNDTB
            // 
            this.lblNDTB.AutoSize = true;
            this.lblNDTB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNDTB.Location = new System.Drawing.Point(11, 245);
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
            this.lblGuiDen.Size = new System.Drawing.Size(84, 28);
            this.lblGuiDen.TabIndex = 25;
            this.lblGuiDen.Text = "Gửi đến";
            // 
            // txtTenTieuDe
            // 
            this.txtTenTieuDe.Location = new System.Drawing.Point(114, 15);
            this.txtTenTieuDe.Name = "txtTenTieuDe";
            this.txtTenTieuDe.Size = new System.Drawing.Size(516, 36);
            this.txtTenTieuDe.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTenTieuDe.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtTenTieuDe.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTenTieuDe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenTieuDe.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTenTieuDe.StateCommon.Border.Rounding = 16;
            this.txtTenTieuDe.StateCommon.Border.Width = 1;
            this.txtTenTieuDe.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtTenTieuDe.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTieuDe.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtTenTieuDe.StateDisabled.Border.Color1 = System.Drawing.Color.Blue;
            this.txtTenTieuDe.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTenTieuDe.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenTieuDe.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTenTieuDe.StateDisabled.Border.Rounding = 16;
            this.txtTenTieuDe.StateDisabled.Border.Width = 1;
            this.txtTenTieuDe.TabIndex = 24;
            this.txtTenTieuDe.Text = "Tên tiêu đề";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(11, 17);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(80, 28);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Tiêu đề";
            // 
            // FThemThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(690, 622);
            this.Controls.Add(this.panelNoidung);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThemTB);
            this.Name = "FThemThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thông báo";
            this.panelNoidung.ResumeLayout(false);
            this.panelNoidung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private System.Windows.Forms.Label lblThemTB;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThem;
        private System.Windows.Forms.Panel panelNoidung;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNDTB;
        private System.Windows.Forms.Label lblGuiDen;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenTieuDe;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox checkListGui;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtNoiDungTB;
    }
}