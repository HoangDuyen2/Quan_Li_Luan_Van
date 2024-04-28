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
        TienTrinh_GVDAO tientrinh = new TienTrinh_GVDAO();
        public FNhiemVu_GV()
        {
            InitializeComponent();
        }

        public FNhiemVu_GV(string maLV,string maGV) : this()
        {
            this.maLV = maLV;
            this.maGV = maGV;
        }
        
        private void FTienTrinh_GV_Load(object sender, EventArgs e)
        {           
            tientrinh.LoadDSTask(maLV, flPanelDSTask,maGV);
            lblTenLV.Text = tientrinh.GetTenLV(maLV);
        }
        private void btnThemNhiemVu_Click(object sender, EventArgs e)
        {
            FThemNhiemVu fThemNhiemVu = new FThemNhiemVu(maLV,maGV);
            fThemNhiemVu.ShowDialog();
            FTienTrinh_GV_Load(sender,e);
        }
    }
}
