namespace Quan_Li_Luan_Van
{
    partial class FXemDiem
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
            this.btnThoat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblXemDiem = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flpDSThanhVien = new System.Windows.Forms.FlowLayoutPanel();
            this.ucChamDiem1 = new Quan_Li_Luan_Van.UCChamDiem();
            this.flpDSThanhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnThoat.Location = new System.Drawing.Point(275, 342);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnThoat.Size = new System.Drawing.Size(125, 40);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Values.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblXemDiem
            // 
            this.lblXemDiem.AutoSize = true;
            this.lblXemDiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemDiem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblXemDiem.Location = new System.Drawing.Point(288, 9);
            this.lblXemDiem.Name = "lblXemDiem";
            this.lblXemDiem.Size = new System.Drawing.Size(112, 28);
            this.lblXemDiem.TabIndex = 26;
            this.lblXemDiem.Text = "XEM ĐIỂM";
            // 
            // flpDSThanhVien
            // 
            this.flpDSThanhVien.Controls.Add(this.ucChamDiem1);
            this.flpDSThanhVien.Location = new System.Drawing.Point(132, 50);
            this.flpDSThanhVien.Name = "flpDSThanhVien";
            this.flpDSThanhVien.Size = new System.Drawing.Size(421, 281);
            this.flpDSThanhVien.TabIndex = 31;
            // 
            // ucChamDiem1
            // 
            this.ucChamDiem1.Location = new System.Drawing.Point(3, 3);
            this.ucChamDiem1.Name = "ucChamDiem1";
            this.ucChamDiem1.Size = new System.Drawing.Size(412, 78);
            this.ucChamDiem1.TabIndex = 0;
            // 
            // FXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 391);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblXemDiem);
            this.Controls.Add(this.flpDSThanhVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FXemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FXemDiem";
            this.Load += new System.EventHandler(this.FXemDiem_Load);
            this.flpDSThanhVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThoat;
        private System.Windows.Forms.Label lblXemDiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flpDSThanhVien;
        private UCChamDiem ucChamDiem1;
    }
}