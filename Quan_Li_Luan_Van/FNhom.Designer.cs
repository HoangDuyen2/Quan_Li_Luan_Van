namespace Quan_Li_Luan_Van
{
    partial class FNhom
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
            this.PanelTieuDe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpanelDSNhom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PanelTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTieuDe
            // 
            this.PanelTieuDe.Controls.Add(this.label1);
            this.PanelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.PanelTieuDe.Name = "PanelTieuDe";
            this.PanelTieuDe.Size = new System.Drawing.Size(1050, 58);
            this.PanelTieuDe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(141)))));
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "DANH SÁCH CÁC NHÓM";
            // 
            // flpanelDSNhom
            // 
            this.flpanelDSNhom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpanelDSNhom.Location = new System.Drawing.Point(0, 64);
            this.flpanelDSNhom.Name = "flpanelDSNhom";
            this.flpanelDSNhom.Size = new System.Drawing.Size(1038, 561);
            this.flpanelDSNhom.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnThem.Location = new System.Drawing.Point(857, 629);
            this.btnThem.Name = "btnThem";
            this.btnThem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnThem.Size = new System.Drawing.Size(169, 40);
            this.btnThem.TabIndex = 9;
            this.btnThem.Values.Text = "Thêm nhiệm vụ";
            // 
            // FNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 659);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.flpanelDSNhom);
            this.Controls.Add(this.PanelTieuDe);
            this.Name = "FNhom";
            this.Text = "FNhom";
            this.Load += new System.EventHandler(this.FNhom_Load);
            this.PanelTieuDe.ResumeLayout(false);
            this.PanelTieuDe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpanelDSNhom;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThem;
    }
}