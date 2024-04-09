namespace Quan_Li_Luan_Van
{
    partial class FXoaNhiemVu
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
            this.panelNoiDung = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panelNoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNoiDung.Controls.Add(this.lblText);
            this.panelNoiDung.Location = new System.Drawing.Point(2, 28);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(337, 123);
            this.panelNoiDung.TabIndex = 3;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(3, 46);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(329, 25);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Bạn chắc chắn muốn xóa nhiệm vụ này !";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(194, 177);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 26);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Từ chối";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(66, 177);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 26);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Chấp nhận";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // FXoaNhiemVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(341, 230);
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FXoaNhiemVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FXoaNhiemVu";
            this.panelNoiDung.ResumeLayout(false);
            this.panelNoiDung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNoiDung;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
    }
}