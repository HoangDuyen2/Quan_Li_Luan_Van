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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.fpnUpdateTask = new System.Windows.Forms.FlowLayoutPanel();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.chartTienDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnThoat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ucUpdateTask1 = new Quan_Li_Luan_Van.UCUpdateTask();
            this.fpnUpdateTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTienDo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUpdate.Location = new System.Drawing.Point(22, 9);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(213, 25);
            this.lblUpdate.TabIndex = 15;
            this.lblUpdate.Text = "Lịch sử cập nhật tiến độ ";
            // 
            // fpnUpdateTask
            // 
            this.fpnUpdateTask.BackColor = System.Drawing.SystemColors.HighlightText;
            this.fpnUpdateTask.Controls.Add(this.ucUpdateTask1);
            this.fpnUpdateTask.Location = new System.Drawing.Point(27, 37);
            this.fpnUpdateTask.Name = "fpnUpdateTask";
            this.fpnUpdateTask.Size = new System.Drawing.Size(406, 222);
            this.fpnUpdateTask.TabIndex = 16;
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblThongKe.Location = new System.Drawing.Point(22, 273);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(154, 25);
            this.lblThongKe.TabIndex = 17;
            this.lblThongKe.Text = "Thống kê tiến độ";
            // 
            // chartTienDo
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTienDo.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTienDo.Legends.Add(legend4);
            this.chartTienDo.Location = new System.Drawing.Point(27, 301);
            this.chartTienDo.Name = "chartTienDo";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTienDo.Series.Add(series4);
            this.chartTienDo.Size = new System.Drawing.Size(406, 130);
            this.chartTienDo.TabIndex = 18;
            this.chartTienDo.Text = "chart1";
            // 
            // btnThoat
            // 
            this.btnThoat.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnThoat.Location = new System.Drawing.Point(172, 463);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnThoat.Size = new System.Drawing.Size(115, 40);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Values.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ucUpdateTask1
            // 
            this.ucUpdateTask1.BackColor = System.Drawing.Color.LavenderBlush;
            this.ucUpdateTask1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ucUpdateTask1.Location = new System.Drawing.Point(3, 3);
            this.ucUpdateTask1.Name = "ucUpdateTask1";
            this.ucUpdateTask1.Size = new System.Drawing.Size(400, 52);
            this.ucUpdateTask1.TabIndex = 0;
            // 
            // FTienTrinh_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(459, 515);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.chartTienDo);
            this.Controls.Add(this.lblThongKe);
            this.Controls.Add(this.fpnUpdateTask);
            this.Controls.Add(this.lblUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTienTrinh_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTienTrinh_GV";
            this.fpnUpdateTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTienDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.FlowLayoutPanel fpnUpdateTask;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTienDo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThoat;
        private UCUpdateTask ucUpdateTask1;
    }
}