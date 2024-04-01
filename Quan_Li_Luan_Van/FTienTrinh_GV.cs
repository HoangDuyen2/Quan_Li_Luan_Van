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
        private string tenLV;
        TienTrinh_GVDAO tientrinh = new TienTrinh_GVDAO();
        public FTienTrinh_GV()
        {
            InitializeComponent();
        }

        public FTienTrinh_GV(string tenLV) : this()
        {
            this.tenLV = tenLV;
        }
        
        private void FTienTrinh_GV_Load(object sender, EventArgs e)
        {           
            tientrinh.getInfo(tenLV, flPanelDSTask);
        }

        public void LoadDSTask()
        {
            tientrinh.getInfo(tenLV, flPanelDSTask);
        }
    }
}
