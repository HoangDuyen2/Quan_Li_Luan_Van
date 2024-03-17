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
    public partial class FDuyetLuanVan : Form
    {
        public FDuyetLuanVan()
        {
            InitializeComponent();
        }

        private void FDuyetLuanVan_Load(object sender, EventArgs e)
        {
            UCDuyet uCDuyet = new UCDuyet();
            flPanelDSLV.Controls.Add(uCDuyet);
        }
    }
}
