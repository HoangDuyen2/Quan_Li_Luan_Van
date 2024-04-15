namespace Quan_Li_Luan_Van
{
    partial class UCUpdateTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTienTrinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(11, 4);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(137, 17);
            this.lblTenSV.TabIndex = 0;
            this.lblTenSV.Text = "Lê Đức Minh Vương ";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Leelawadee UI Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(12, 29);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(156, 17);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "Đã cập nhật tiến trình lên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI Semilight", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "09-04-2024 15:48:00";
            // 
            // lblTienTrinh
            // 
            this.lblTienTrinh.AutoSize = true;
            this.lblTienTrinh.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTrinh.Location = new System.Drawing.Point(178, 29);
            this.lblTienTrinh.Name = "lblTienTrinh";
            this.lblTienTrinh.Size = new System.Drawing.Size(22, 17);
            this.lblTienTrinh.TabIndex = 3;
            this.lblTienTrinh.Text = "90";
            this.lblTienTrinh.Click += new System.EventHandler(this.lblTienTrinh_Click);
            // 
            // UCUpdateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.lblTienTrinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.lblTenSV);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "UCUpdateTask";
            this.Size = new System.Drawing.Size(400, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTienTrinh;
    }
}
