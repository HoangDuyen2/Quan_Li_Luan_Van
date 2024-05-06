namespace Quan_Li_Luan_Van
{
    partial class FLuanVanCuaToi_SV
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
            this.flPanelDSTask = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxTraCuuLuanVan = new System.Windows.Forms.GroupBox();
            this.buttonXemDiem = new System.Windows.Forms.Button();
            this.btnThemNhiemVu = new System.Windows.Forms.Button();
            this.lblTenLV = new System.Windows.Forms.Label();
            this.groupBoxTraCuuLuanVan.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPanelDSTask
            // 
            this.flPanelDSTask.AutoScroll = true;
            this.flPanelDSTask.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flPanelDSTask.Location = new System.Drawing.Point(0, 123);
            this.flPanelDSTask.Name = "flPanelDSTask";
            this.flPanelDSTask.Size = new System.Drawing.Size(1067, 535);
            this.flPanelDSTask.TabIndex = 30;
            // 
            // groupBoxTraCuuLuanVan
            // 
            this.groupBoxTraCuuLuanVan.Controls.Add(this.lblTenLV);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.buttonXemDiem);
            this.groupBoxTraCuuLuanVan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTraCuuLuanVan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxTraCuuLuanVan.Location = new System.Drawing.Point(-6, 5);
            this.groupBoxTraCuuLuanVan.Name = "groupBoxTraCuuLuanVan";
            this.groupBoxTraCuuLuanVan.Size = new System.Drawing.Size(1073, 121);
            this.groupBoxTraCuuLuanVan.TabIndex = 29;
            this.groupBoxTraCuuLuanVan.TabStop = false;
            // 
            // buttonXemDiem
            // 
            this.buttonXemDiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonXemDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXemDiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonXemDiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonXemDiem.Location = new System.Drawing.Point(84, 64);
            this.buttonXemDiem.Name = "buttonXemDiem";
            this.buttonXemDiem.Size = new System.Drawing.Size(142, 39);
            this.buttonXemDiem.TabIndex = 15;
            this.buttonXemDiem.Text = "Xem điểm";
            this.buttonXemDiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonXemDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXemDiem.UseVisualStyleBackColor = false;
            this.buttonXemDiem.Click += new System.EventHandler(this.buttonXemDiem_Click);
            // 
            // btnThemNhiemVu
            // 
            this.btnThemNhiemVu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThemNhiemVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNhiemVu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemNhiemVu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThemNhiemVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhiemVu.Location = new System.Drawing.Point(870, 659);
            this.btnThemNhiemVu.Name = "btnThemNhiemVu";
            this.btnThemNhiemVu.Size = new System.Drawing.Size(184, 42);
            this.btnThemNhiemVu.TabIndex = 31;
            this.btnThemNhiemVu.Text = "Thêm Nhiệm Vụ";
            this.btnThemNhiemVu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemNhiemVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNhiemVu.UseVisualStyleBackColor = false;
            this.btnThemNhiemVu.Click += new System.EventHandler(this.btnThemNhiemVu_Click);
            // 
            // lblTenLV
            // 
            this.lblTenLV.AutoSize = true;
            this.lblTenLV.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLV.Location = new System.Drawing.Point(6, 0);
            this.lblTenLV.Name = "lblTenLV";
            this.lblTenLV.Size = new System.Drawing.Size(506, 38);
            this.lblTenLV.TabIndex = 16;
            this.lblTenLV.Text = "Bạn chưa tham gia bất kì luận văn nào";
            this.lblTenLV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FLuanVanCuaToi_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 702);
            this.Controls.Add(this.btnThemNhiemVu);
            this.Controls.Add(this.flPanelDSTask);
            this.Controls.Add(this.groupBoxTraCuuLuanVan);
            this.Name = "FLuanVanCuaToi_SV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLuanVanToi_SV";
            this.Load += new System.EventHandler(this.FLuanVanToi_SV_Load);
            this.groupBoxTraCuuLuanVan.ResumeLayout(false);
            this.groupBoxTraCuuLuanVan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPanelDSTask;
        private System.Windows.Forms.GroupBox groupBoxTraCuuLuanVan;
        private System.Windows.Forms.Button buttonXemDiem;
        private System.Windows.Forms.Button btnThemNhiemVu;
        private System.Windows.Forms.Label lblTenLV;
    }
}