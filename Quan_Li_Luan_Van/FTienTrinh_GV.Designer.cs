namespace Quan_Li_Luan_Van
{
    partial class FTienTrinh_GV
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
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.flPanelDSTask = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemLuanVan = new System.Windows.Forms.Button();
            this.lblTenLV = new System.Windows.Forms.Label();
            this.lblDSNV = new System.Windows.Forms.Label();
            this.panelThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelThongTin
            // 
            this.panelThongTin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelThongTin.Controls.Add(this.lblDSNV);
            this.panelThongTin.Controls.Add(this.lblTenLV);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTin.Location = new System.Drawing.Point(0, 0);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(1064, 76);
            this.panelThongTin.TabIndex = 0;
            // 
            // flPanelDSTask
            // 
            this.flPanelDSTask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flPanelDSTask.Location = new System.Drawing.Point(0, 82);
            this.flPanelDSTask.Name = "flPanelDSTask";
            this.flPanelDSTask.Size = new System.Drawing.Size(1064, 569);
            this.flPanelDSTask.TabIndex = 1;
            // 
            // btnThemLuanVan
            // 
            this.btnThemLuanVan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThemLuanVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLuanVan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemLuanVan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThemLuanVan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLuanVan.Location = new System.Drawing.Point(868, 657);
            this.btnThemLuanVan.Name = "btnThemLuanVan";
            this.btnThemLuanVan.Size = new System.Drawing.Size(184, 42);
            this.btnThemLuanVan.TabIndex = 26;
            this.btnThemLuanVan.Text = "Thêm Nhiệm Vụ";
            this.btnThemLuanVan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemLuanVan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemLuanVan.UseVisualStyleBackColor = false;
            this.btnThemLuanVan.Click += new System.EventHandler(this.btnThemLuanVan_Click);
            // 
            // lblTenLV
            // 
            this.lblTenLV.AutoSize = true;
            this.lblTenLV.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLV.Location = new System.Drawing.Point(11, 6);
            this.lblTenLV.Name = "lblTenLV";
            this.lblTenLV.Size = new System.Drawing.Size(326, 38);
            this.lblTenLV.TabIndex = 0;
            this.lblTenLV.Text = "Thiết kế trình duyệt web";
            this.lblTenLV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTenLV.Click += new System.EventHandler(this.lblTenLV_Click);
            // 
            // lblDSNV
            // 
            this.lblDSNV.AutoSize = true;
            this.lblDSNV.Location = new System.Drawing.Point(18, 52);
            this.lblDSNV.Name = "lblDSNV";
            this.lblDSNV.Size = new System.Drawing.Size(127, 16);
            this.lblDSNV.TabIndex = 1;
            this.lblDSNV.Text = "Danh sách nhiệm vụ";
            // 
            // FTienTrinh_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 702);
            this.Controls.Add(this.btnThemLuanVan);
            this.Controls.Add(this.flPanelDSTask);
            this.Controls.Add(this.panelThongTin);
            this.Name = "FTienTrinh_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí hoạt động nhóm";
            this.Load += new System.EventHandler(this.FTienTrinh_GV_Load);
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.FlowLayoutPanel flPanelDSTask;
        private System.Windows.Forms.Button btnThemLuanVan;
        private System.Windows.Forms.Label lblTenLV;
        private System.Windows.Forms.Label lblDSNV;
    }
}