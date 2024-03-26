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
            this.panelTraCuu = new System.Windows.Forms.Panel();
            this.flPanelDSTask = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemLuanVan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelTraCuu
            // 
            this.panelTraCuu.BackColor = System.Drawing.SystemColors.Control;
            this.panelTraCuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTraCuu.Location = new System.Drawing.Point(0, 0);
            this.panelTraCuu.Name = "panelTraCuu";
            this.panelTraCuu.Size = new System.Drawing.Size(1064, 76);
            this.panelTraCuu.TabIndex = 0;
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
            // 
            // FTienTrinh_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 702);
            this.Controls.Add(this.btnThemLuanVan);
            this.Controls.Add(this.flPanelDSTask);
            this.Controls.Add(this.panelTraCuu);
            this.Name = "FTienTrinh_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí hoạt động nhóm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTraCuu;
        private System.Windows.Forms.FlowLayoutPanel flPanelDSTask;
        private System.Windows.Forms.Button btnThemLuanVan;
    }
}