namespace Quan_Li_Luan_Van
{
    partial class FChiTietTask_All
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
            this.lblChat = new System.Windows.Forms.Label();
            this.fpnChat = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPhanHoi = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lblPhanHoi = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTienTrinh = new System.Windows.Forms.Label();
            this.txtNoiDungNV = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lblNDTB = new System.Windows.Forms.Label();
            this.txtTenNV = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.btnPhanHoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblThemNV = new System.Windows.Forms.Label();
            this.btnThoat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ucPhanHoi1 = new Quan_Li_Luan_Van.UCPhanHoi();
            this.panelNoidung.SuspendLayout();
            this.fpnChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoidung
            // 
            this.panelNoidung.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelNoidung.Controls.Add(this.lblChat);
            this.panelNoidung.Controls.Add(this.fpnChat);
            this.panelNoidung.Controls.Add(this.txtPhanHoi);
            this.panelNoidung.Controls.Add(this.lblPhanHoi);
            this.panelNoidung.Controls.Add(this.kryptonTextBox1);
            this.panelNoidung.Controls.Add(this.lblTienTrinh);
            this.panelNoidung.Controls.Add(this.txtNoiDungNV);
            this.panelNoidung.Controls.Add(this.lblNDTB);
            this.panelNoidung.Controls.Add(this.txtTenNV);
            this.panelNoidung.Controls.Add(this.lblTenNV);
            this.panelNoidung.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panelNoidung.Location = new System.Drawing.Point(16, 43);
            this.panelNoidung.Name = "panelNoidung";
            this.panelNoidung.Size = new System.Drawing.Size(592, 572);
            this.panelNoidung.TabIndex = 18;
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblChat.Location = new System.Drawing.Point(15, 190);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(162, 28);
            this.lblChat.TabIndex = 37;
            this.lblChat.Text = "Lịch sử phản hồi";
            // 
            // fpnChat
            // 
            this.fpnChat.AutoScroll = true;
            this.fpnChat.Controls.Add(this.ucPhanHoi1);
            this.fpnChat.Location = new System.Drawing.Point(20, 221);
            this.fpnChat.Name = "fpnChat";
            this.fpnChat.Size = new System.Drawing.Size(561, 228);
            this.fpnChat.TabIndex = 36;
            // 
            // txtPhanHoi
            // 
            this.txtPhanHoi.Location = new System.Drawing.Point(12, 483);
            this.txtPhanHoi.Name = "txtPhanHoi";
            this.txtPhanHoi.Size = new System.Drawing.Size(569, 86);
            this.txtPhanHoi.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtPhanHoi.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.txtPhanHoi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhanHoi.StateCommon.Border.Rounding = 12;
            this.txtPhanHoi.StateCommon.Border.Width = 1;
            this.txtPhanHoi.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtPhanHoi.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.txtPhanHoi.TabIndex = 35;
            this.txtPhanHoi.Text = "";
            // 
            // lblPhanHoi
            // 
            this.lblPhanHoi.AutoSize = true;
            this.lblPhanHoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanHoi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPhanHoi.Location = new System.Drawing.Point(15, 452);
            this.lblPhanHoi.Name = "lblPhanHoi";
            this.lblPhanHoi.Size = new System.Drawing.Size(95, 28);
            this.lblPhanHoi.TabIndex = 34;
            this.lblPhanHoi.Text = "Nhận xét";
            this.lblPhanHoi.Click += new System.EventHandler(this.label1_Click);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(464, 33);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(119, 35);
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
            this.kryptonTextBox1.StateDisabled.Border.Color1 = System.Drawing.Color.Blue;
            this.kryptonTextBox1.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonTextBox1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox1.StateDisabled.Border.Rounding = 16;
            this.kryptonTextBox1.StateDisabled.Border.Width = 1;
            this.kryptonTextBox1.TabIndex = 33;
            // 
            // lblTienTrinh
            // 
            this.lblTienTrinh.AutoSize = true;
            this.lblTienTrinh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTrinh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTienTrinh.Location = new System.Drawing.Point(459, 5);
            this.lblTienTrinh.Name = "lblTienTrinh";
            this.lblTienTrinh.Size = new System.Drawing.Size(123, 28);
            this.lblTienTrinh.TabIndex = 32;
            this.lblTienTrinh.Text = "Tiến trình %";
            // 
            // txtNoiDungNV
            // 
            this.txtNoiDungNV.Location = new System.Drawing.Point(17, 108);
            this.txtNoiDungNV.Name = "txtNoiDungNV";
            this.txtNoiDungNV.Size = new System.Drawing.Size(567, 80);
            this.txtNoiDungNV.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtNoiDungNV.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.txtNoiDungNV.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNoiDungNV.StateCommon.Border.Rounding = 12;
            this.txtNoiDungNV.StateCommon.Border.Width = 1;
            this.txtNoiDungNV.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtNoiDungNV.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.txtNoiDungNV.TabIndex = 29;
            this.txtNoiDungNV.Text = "";
            this.txtNoiDungNV.TextChanged += new System.EventHandler(this.txtNoiDungNV_TextChanged);
            // 
            // lblNDTB
            // 
            this.lblNDTB.AutoSize = true;
            this.lblNDTB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNDTB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNDTB.Location = new System.Drawing.Point(15, 74);
            this.lblNDTB.Name = "lblNDTB";
            this.lblNDTB.Size = new System.Drawing.Size(166, 28);
            this.lblNDTB.TabIndex = 26;
            this.lblNDTB.Text = "Nội dung chi tiết";
            this.lblNDTB.Click += new System.EventHandler(this.lblNDTB_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(16, 33);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(429, 35);
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
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTenNV.Location = new System.Drawing.Point(15, 5);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(136, 28);
            this.lblTenNV.TabIndex = 0;
            this.lblTenNV.Text = "Tên nhiệm vụ";
            this.lblTenNV.Click += new System.EventHandler(this.lblTenNV_Click);
            // 
            // btnPhanHoi
            // 
            this.btnPhanHoi.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnPhanHoi.Location = new System.Drawing.Point(109, 621);
            this.btnPhanHoi.Name = "btnPhanHoi";
            this.btnPhanHoi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnPhanHoi.Size = new System.Drawing.Size(169, 40);
            this.btnPhanHoi.TabIndex = 17;
            this.btnPhanHoi.Values.Text = "Gửi nhận xét";
            // 
            // lblThemNV
            // 
            this.lblThemNV.AutoSize = true;
            this.lblThemNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemNV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblThemNV.Location = new System.Drawing.Point(214, 9);
            this.lblThemNV.Name = "lblThemNV";
            this.lblThemNV.Size = new System.Drawing.Size(198, 28);
            this.lblThemNV.TabIndex = 16;
            this.lblThemNV.Text = "CHI TIẾT NHIỆM VỤ";
            // 
            // btnThoat
            // 
            this.btnThoat.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnThoat.Location = new System.Drawing.Point(334, 621);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnThoat.Size = new System.Drawing.Size(169, 40);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Values.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ucPhanHoi1
            // 
            this.ucPhanHoi1.BackColor = System.Drawing.Color.LavenderBlush;
            this.ucPhanHoi1.Location = new System.Drawing.Point(3, 3);
            this.ucPhanHoi1.Name = "ucPhanHoi1";
            this.ucPhanHoi1.Size = new System.Drawing.Size(555, 93);
            this.ucPhanHoi1.TabIndex = 0;
            // 
            // FChiTietTask_All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 673);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panelNoidung);
            this.Controls.Add(this.btnPhanHoi);
            this.Controls.Add(this.lblThemNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FChiTietTask_All";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết nhiệm vụ";
            this.Load += new System.EventHandler(this.FChiTietTask_GV_Load);
            this.panelNoidung.ResumeLayout(false);
            this.panelNoidung.PerformLayout();
            this.fpnChat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNoidung;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtNoiDungNV;
        private System.Windows.Forms.Label lblNDTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPhanHoi;
        private System.Windows.Forms.Label lblThemNV;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Label lblTienTrinh;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtPhanHoi;
        private System.Windows.Forms.Label lblPhanHoi;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThoat;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.FlowLayoutPanel fpnChat;
        private UCPhanHoi ucPhanHoi1;
    }
}