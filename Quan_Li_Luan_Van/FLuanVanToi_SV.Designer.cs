namespace Quan_Li_Luan_Van
{
    partial class FLuanVanToi_SV
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
            this.comboxLoaiTraCuu = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.labelLoaiTraCuu = new System.Windows.Forms.Label();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.groupBoxTraCuuLuanVan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxLoaiTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // flPanelDSTask
            // 
            this.flPanelDSTask.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flPanelDSTask.Location = new System.Drawing.Point(0, 103);
            this.flPanelDSTask.Name = "flPanelDSTask";
            this.flPanelDSTask.Size = new System.Drawing.Size(1067, 559);
            this.flPanelDSTask.TabIndex = 30;
            // 
            // groupBoxTraCuuLuanVan
            // 
            this.groupBoxTraCuuLuanVan.Controls.Add(this.comboxLoaiTraCuu);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.labelLoaiTraCuu);
            this.groupBoxTraCuuLuanVan.Controls.Add(this.buttonTimKiem);
            this.groupBoxTraCuuLuanVan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTraCuuLuanVan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxTraCuuLuanVan.Location = new System.Drawing.Point(-6, 5);
            this.groupBoxTraCuuLuanVan.Name = "groupBoxTraCuuLuanVan";
            this.groupBoxTraCuuLuanVan.Size = new System.Drawing.Size(1073, 95);
            this.groupBoxTraCuuLuanVan.TabIndex = 29;
            this.groupBoxTraCuuLuanVan.TabStop = false;
            // 
            // comboxLoaiTraCuu
            // 
            this.comboxLoaiTraCuu.DropDownWidth = 261;
            this.comboxLoaiTraCuu.Items.AddRange(new object[] {
            "Chưa nộp task",
            "Đợi chấm điểm",
            "Đã chấm điểm"});
            this.comboxLoaiTraCuu.Location = new System.Drawing.Point(170, 46);
            this.comboxLoaiTraCuu.Name = "comboxLoaiTraCuu";
            this.comboxLoaiTraCuu.Size = new System.Drawing.Size(228, 39);
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Blue;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Rounding = 20;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Border.Width = 1;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxLoaiTraCuu.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.comboxLoaiTraCuu.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.comboxLoaiTraCuu.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboxLoaiTraCuu.TabIndex = 17;
            this.comboxLoaiTraCuu.Text = "Tất cả";
            // 
            // labelLoaiTraCuu
            // 
            this.labelLoaiTraCuu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiTraCuu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelLoaiTraCuu.Location = new System.Drawing.Point(27, 52);
            this.labelLoaiTraCuu.Name = "labelLoaiTraCuu";
            this.labelLoaiTraCuu.Size = new System.Drawing.Size(127, 33);
            this.labelLoaiTraCuu.TabIndex = 16;
            this.labelLoaiTraCuu.Text = "Tình trạng";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonTimKiem.Image = global::Quan_Li_Luan_Van.Properties.Resources.find;
            this.buttonTimKiem.Location = new System.Drawing.Point(421, 45);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(43, 42);
            this.buttonTimKiem.TabIndex = 15;
            this.buttonTimKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // FLuanVanToi_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 659);
            this.Controls.Add(this.flPanelDSTask);
            this.Controls.Add(this.groupBoxTraCuuLuanVan);
            this.Name = "FLuanVanToi_SV";
            this.Text = "FLuanVanToi_SV";
            this.groupBoxTraCuuLuanVan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboxLoaiTraCuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPanelDSTask;
        private System.Windows.Forms.GroupBox groupBoxTraCuuLuanVan;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboxLoaiTraCuu;
        private System.Windows.Forms.Label labelLoaiTraCuu;
        private System.Windows.Forms.Button buttonTimKiem;
    }
}