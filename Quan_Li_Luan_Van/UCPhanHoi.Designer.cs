namespace Quan_Li_Luan_Van
{
    partial class UCPhanHoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtPhanHoi = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.SuspendLayout();
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Leelawadee UI Semilight", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblThoiGian.Location = new System.Drawing.Point(365, 3);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(124, 17);
            this.lblThoiGian.TabIndex = 6;
            this.lblThoiGian.Text = "09-04-2024 15:48:00";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTen.Location = new System.Drawing.Point(7, 6);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(137, 17);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Lê Đức Minh Vương ";
            // 
            // txtPhanHoi
            // 
            this.txtPhanHoi.Location = new System.Drawing.Point(3, 26);
            this.txtPhanHoi.Name = "txtPhanHoi";
            this.txtPhanHoi.Size = new System.Drawing.Size(520, 35);
            this.txtPhanHoi.StateCommon.Border.Color1 = System.Drawing.Color.GhostWhite;
            this.txtPhanHoi.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.txtPhanHoi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhanHoi.StateCommon.Border.Rounding = 12;
            this.txtPhanHoi.StateCommon.Border.Width = 1;
            this.txtPhanHoi.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtPhanHoi.StateCommon.Content.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanHoi.TabIndex = 36;
            this.txtPhanHoi.Text = "Chức năng này có vai trò như thế nào";
            // 
            // UCPhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.txtPhanHoi);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblTen);
            this.Name = "UCPhanHoi";
            this.Size = new System.Drawing.Size(528, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblTen;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtPhanHoi;
    }
}
