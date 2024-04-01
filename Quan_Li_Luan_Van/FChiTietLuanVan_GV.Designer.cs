namespace Quan_Li_Luan_Van
{
    partial class FChiTietLuanVan_GV
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
            this.SuspendLayout();
            // 
            // ucChiTietLuanVan1
            // 
            this.ucChiTietLuanVan1.Location = new System.Drawing.Point(-3, -26);
            this.ucChiTietLuanVan1.Name = "ucChiTietLuanVan1";
            this.ucChiTietLuanVan1.Size = new System.Drawing.Size(1068, 730);
            this.ucChiTietLuanVan1.TabIndex = 0;
            this.ucChiTietLuanVan1.Load += new System.EventHandler(this.ucChiTietLuanVan1_Load);
            // 
            // FChiTietLuanVan_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 702);
            this.Controls.Add(this.ucChiTietLuanVan1);
            this.Name = "FChiTietLuanVan_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FChiTietLuanVan_GV";
            this.Load += new System.EventHandler(this.FChiTietLuanVan_GV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCChiTietLuanVan ucChiTietLuanVan1;
    }
}