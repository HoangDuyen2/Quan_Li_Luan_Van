namespace Quan_Li_Luan_Van
{
    partial class FChamDiem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblChamDiem = new System.Windows.Forms.Label();
            this.btnLuDiem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnThoat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chartTienDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flpDSThanhVien = new System.Windows.Forms.FlowLayoutPanel();
            this.ucChamDiem1 = new Quan_Li_Luan_Van.UCChamDiem();
            ((System.ComponentModel.ISupportInitialize)(this.chartTienDo)).BeginInit();
            this.flpDSThanhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChamDiem
            // 
            this.lblChamDiem.AutoSize = true;
            this.lblChamDiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChamDiem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblChamDiem.Location = new System.Drawing.Point(178, 19);
            this.lblChamDiem.Name = "lblChamDiem";
            this.lblChamDiem.Size = new System.Drawing.Size(129, 28);
            this.lblChamDiem.TabIndex = 15;
            this.lblChamDiem.Text = "CHẤM ĐIỂM";
            // 
            // btnLuDiem
            // 
            this.btnLuDiem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnLuDiem.Location = new System.Drawing.Point(80, 344);
            this.btnLuDiem.Name = "btnLuDiem";
            this.btnLuDiem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnLuDiem.Size = new System.Drawing.Size(125, 40);
            this.btnLuDiem.TabIndex = 16;
            this.btnLuDiem.Values.Text = "Lưu Điểm";
            this.btnLuDiem.Click += new System.EventHandler(this.btnLuuDiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnThoat.Location = new System.Drawing.Point(269, 344);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnThoat.Size = new System.Drawing.Size(125, 40);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Values.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(603, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "THỐNG KÊ ";
            // 
            // chartTienDo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTienDo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTienDo.Legends.Add(legend1);
            this.chartTienDo.Location = new System.Drawing.Point(455, 52);
            this.chartTienDo.Name = "chartTienDo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTienDo.Series.Add(series1);
            this.chartTienDo.Size = new System.Drawing.Size(495, 250);
            this.chartTienDo.TabIndex = 24;
            this.chartTienDo.Text = "chart1";
            // 
            // flpDSThanhVien
            // 
            this.flpDSThanhVien.Controls.Add(this.ucChamDiem1);
            this.flpDSThanhVien.Location = new System.Drawing.Point(28, 83);
            this.flpDSThanhVien.Name = "flpDSThanhVien";
            this.flpDSThanhVien.Size = new System.Drawing.Size(421, 250);
            this.flpDSThanhVien.TabIndex = 25;
            // 
            // ucChamDiem1
            // 
            this.ucChamDiem1.Location = new System.Drawing.Point(3, 3);
            this.ucChamDiem1.Name = "ucChamDiem1";
            this.ucChamDiem1.Size = new System.Drawing.Size(412, 78);
            this.ucChamDiem1.TabIndex = 0;
            // 
            // FChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(991, 391);
            this.Controls.Add(this.flpDSThanhVien);
            this.Controls.Add(this.chartTienDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuDiem);
            this.Controls.Add(this.lblChamDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FChamDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FChamDiem";
            ((System.ComponentModel.ISupportInitialize)(this.chartTienDo)).EndInit();
            this.flpDSThanhVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChamDiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLuDiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTienDo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flpDSThanhVien;
        private UCChamDiem ucChamDiem1;
    }
}