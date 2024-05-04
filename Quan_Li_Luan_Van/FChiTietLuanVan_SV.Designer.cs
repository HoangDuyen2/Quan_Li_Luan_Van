namespace Quan_Li_Luan_Van
{
    partial class FChiTietLuanVan_SV
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
            this.btnDangKy = new System.Windows.Forms.Button();
            this.ucChiTietLuanVan1 = new Quan_Li_Luan_Van.UCChiTietLuanVan();
            this.SuspendLayout();
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangKy.Image = global::Quan_Li_Luan_Van.Properties.Resources.approve1;
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.Location = new System.Drawing.Point(459, 702);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(146, 42);
            this.btnDangKy.TabIndex = 61;
            this.btnDangKy.Text = "  Đăng kí";
            this.btnDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangKy.UseVisualStyleBackColor = false;
            // 
            // ucChiTietLuanVan1
            // 
            this.ucChiTietLuanVan1.Location = new System.Drawing.Point(3, -17);
            this.ucChiTietLuanVan1.Name = "ucChiTietLuanVan1";
            this.ucChiTietLuanVan1.Size = new System.Drawing.Size(1060, 716);
            this.ucChiTietLuanVan1.TabIndex = 62;
            // 
            // FChiTietLuanVan_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 745);
            this.Controls.Add(this.ucChiTietLuanVan1);
            this.Controls.Add(this.btnDangKy);
            this.Name = "FChiTietLuanVan_SV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết Luận Văn";
            this.Load += new System.EventHandler(this.FChiTietLuanVan_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDangKy;
        private UCChiTietLuanVan ucChiTietLuanVan1;
    }
}