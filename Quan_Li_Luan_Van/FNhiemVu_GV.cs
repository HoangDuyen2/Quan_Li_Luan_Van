using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FNhiemVu_GV : Form
    {
        private string maLV;
        private string maGV;
        GiangVienDAO luanvan;  
        public FNhiemVu_GV()
        {
            InitializeComponent();
        }
        public FNhiemVu_GV(string maLV, string maGV) : this()
        {
            this.maLV = maLV;
            this.maGV = maGV;
            this.luanvan = new GiangVienDAO(); 
        }
        private void FNhiemVu_GV_Load(object sender, EventArgs e)
        {
            luanvan.LoadDSTask(maLV, flPanelDSTask, maGV);
            lblTenLV.Text = luanvan.GetTenLV(maLV);
            if (luanvan.getTinhTrangLVCuaToi(maLV) == "Đã hoàn thành")
            {
                btnThemNhiemVu.Enabled = false;
            }
        }
        public void LoadDSNV()
        {
            luanvan.LoadDSTask(maLV, flPanelDSTask, maGV);
            lblTenLV.Text = luanvan.GetTenLV(maLV);
        }
        private void btnThemNhiemVu_Click(object sender, EventArgs e)
        {
            FThemNhiemVu fThemNhiemVu = new FThemNhiemVu(maLV, maGV);
            if (fThemNhiemVu.ShowDialog() == DialogResult.OK)
            {
               LoadDSNV();
            }

        }

    }

}
