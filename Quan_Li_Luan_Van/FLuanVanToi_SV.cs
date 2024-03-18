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
    public partial class FLuanVanToi_SV : Form
    {
        public FLuanVanToi_SV()
        {
            InitializeComponent();
        }

        private void FLuanVanToi_SV_Load(object sender, EventArgs e)
        {
            UCTask uCTask = new UCTask();
            flPanelDSTask.Controls.Add(uCTask); 
        }
    }
}
