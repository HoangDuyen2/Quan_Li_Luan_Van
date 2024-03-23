namespace Quan_Li_Luan_Van
{
    partial class FThongTinCaNhan_GV
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
            this.ucThongTinCaNhan1 = new Quan_Li_Luan_Van.UCThongTinCaNhan();
            this.SuspendLayout();
            // 
            // ucThongTinCaNhan1
            // 
            this.ucThongTinCaNhan1.Location = new System.Drawing.Point(1, 1);
            this.ucThongTinCaNhan1.Name = "ucThongTinCaNhan1";
            this.ucThongTinCaNhan1.Size = new System.Drawing.Size(1082, 749);
            this.ucThongTinCaNhan1.TabIndex = 0;
            // 
            // FThongTinCaNhan_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 749);
            this.Controls.Add(this.ucThongTinCaNhan1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThongTinCaNhan_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FThongTinCaNhan_GV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCThongTinCaNhan ucThongTinCaNhan1;
    }
}

