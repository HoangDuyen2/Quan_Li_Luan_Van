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
    public partial class UCNhom : UserControl
    {
        public UCNhom()
        {
            InitializeComponent();
        }
        public Label LblChuyenNganh { get => lblChuyenNganh; set => lblChuyenNganh = value; }
        public Label LblTenLV { get => lblTenLV; set => lblTenLV = value; }
        

        private void btnTienTrinh_Click(object sender, EventArgs e)
        {
            FChiTietTask chiTietTask = new FChiTietTask(lblTenLV.Text);
            chiTietTask.Show();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            FChiTietLuanVan_SV chiTietLuanVan = new FChiTietLuanVan_SV(lblTenLV.Text);
            chiTietLuanVan.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void UCNhom_Load(object sender, EventArgs e)
        {

        }
    }
}
