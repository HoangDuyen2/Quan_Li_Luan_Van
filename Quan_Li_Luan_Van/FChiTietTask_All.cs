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
    public partial class FChiTietTask_All : Form
    {
        private string maNV;
        public FChiTietTask_All(string MaNV) : this()
        {
            this.maNV = MaNV;
        }

        public FChiTietTask_All()
        {
            InitializeComponent();
        }

        private void FChiTietTask_GV_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {

        }

        private void lblNDTB_Click(object sender, EventArgs e)
        {

        }

        private void txtNoiDungNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
