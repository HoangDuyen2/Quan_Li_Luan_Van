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
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.txtPhanHoi = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI Semilight", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(418, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "09-04-2024 15:48:00";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTenSV.Location = new System.Drawing.Point(7, 6);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(137, 17);
            this.lblTenSV.TabIndex = 4;
            this.lblTenSV.Text = "Lê Đức Minh Vương ";
            // 
            // txtPhanHoi
            // 
            this.txtPhanHoi.Location = new System.Drawing.Point(3, 26);
            this.txtPhanHoi.Name = "txtPhanHoi";
            this.txtPhanHoi.Size = new System.Drawing.Size(549, 61);
            this.txtPhanHoi.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtPhanHoi.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.txtPhanHoi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhanHoi.StateCommon.Border.Rounding = 12;
            this.txtPhanHoi.StateCommon.Border.Width = 1;
            this.txtPhanHoi.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtPhanHoi.StateCommon.Content.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanHoi.TabIndex = 36;
            this.txtPhanHoi.Text = "Chức năng này có vai trò như thế nào";
            this.txtPhanHoi.TextChanged += new System.EventHandler(this.txtPhanHoi_TextChanged);
            // 
            // UCPhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.txtPhanHoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTenSV);
            this.Name = "UCPhanHoi";
            this.Size = new System.Drawing.Size(555, 90);
            this.Load += new System.EventHandler(this.UCPhanHoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenSV;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtPhanHoi;
    }
}
