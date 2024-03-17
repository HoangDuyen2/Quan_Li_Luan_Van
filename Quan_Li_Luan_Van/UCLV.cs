using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class UCLV : UserControl
    {
        public UCLV()
        {
            InitializeComponent();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            FChiTietLuanVan ctlv = new FChiTietLuanVan();
            ctlv.ShowDialog();
        }
    }
}
