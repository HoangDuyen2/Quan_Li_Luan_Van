using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Quan_Li_Luan_Van
{
    public partial class FThongTinCaNhan_GV : KryptonForm
    {
        public FThongTinCaNhan_GV()
        {
            InitializeComponent();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txtCCCD.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtHoTen.Enabled = true;
            txtPhone.Enabled = true;
        }
    }
}
