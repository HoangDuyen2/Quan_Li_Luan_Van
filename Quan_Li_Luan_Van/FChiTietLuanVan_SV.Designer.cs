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
            this.ucChiTietLuanVan1 = new Quan_Li_Luan_Van.UCChiTietLuanVan();
            this.btnChapNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucChiTietLuanVan1
            // 
            this.ucChiTietLuanVan1.Location = new System.Drawing.Point(-1, -34);
            this.ucChiTietLuanVan1.Name = "ucChiTietLuanVan1";
            this.ucChiTietLuanVan1.Size = new System.Drawing.Size(1066, 749);
            this.ucChiTietLuanVan1.TabIndex = 0;
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChapNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChapNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnChapNhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChapNhan.Image = global::Quan_Li_Luan_Van.Properties.Resources.approve1;
            this.btnChapNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChapNhan.Location = new System.Drawing.Point(498, 648);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(146, 42);
            this.btnChapNhan.TabIndex = 61;
            this.btnChapNhan.Text = "  Đăng kí";
            this.btnChapNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChapNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChapNhan.UseVisualStyleBackColor = false;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // FChiTietLuanVan_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 702);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.ucChiTietLuanVan1);
            this.Name = "FChiTietLuanVan_SV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết Luận Văn";
            this.Load += new System.EventHandler(this.FChiTietLuanVan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCChiTietLuanVan ucChiTietLuanVan1;
        private System.Windows.Forms.Button btnChapNhan;
    }
}