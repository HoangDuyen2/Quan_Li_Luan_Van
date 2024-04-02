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
    public partial class FTienTrinh_GV : Form
    {
        private string maLV;
        TienTrinh_GVDAO tientrinh = new TienTrinh_GVDAO();
        public FTienTrinh_GV()
        {
            InitializeComponent();
        }

        public FTienTrinh_GV(string maLV) : this()
        {
            this.maLV = maLV;
        }
        
        private void FTienTrinh_GV_Load(object sender, EventArgs e)
        {           
            tientrinh.getInfo(maLV, flPanelDSTask);
        }

        public void LoadDSTask()
        {
            tientrinh.getInfo(maLV, flPanelDSTask);
        }

        private void btnThemLuanVan_Click(object sender, EventArgs e)
        {
            FThemNhiemVu fThemNhiemVu = new FThemNhiemVu(maLV);
            fThemNhiemVu.ShowDialog();
        }
    }
}
