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
    public partial class FDKLV : Form
    {
        public FDKLV()
        {
            InitializeComponent();
        }

        private void FDKLV_Load(object sender, EventArgs e)
        {
            UCLV uCLV = new UCLV();
            flPanelDSLV.Controls.Add(uCLV);
        }
    }
}
