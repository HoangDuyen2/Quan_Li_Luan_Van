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
    public partial class UCLVCuaToi : UserControl
    {
        public UCLVCuaToi()
        {
            InitializeComponent();
        }
        public Label LbTenGVHD { get => lbTenGVHD; set => lbTenGVHD = value; }
        public Label LbGVHD { get => lbGVHD; set => lbGVHD = value; }
        public Label LbSoLuongConLai { get => lbSoLuongConLai; set => lbSoLuongConLai = value; }
        public Label LbSoLuong { get => lbSoLuong; set => lbSoLuong = value; }
        public Label LbChuyenNganh { get => lbChuyenNganh; set => lbChuyenNganh = value; }
        public Label LbTenLV { get => lbTenLV; set => lbTenLV = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Button ButtonChiTiet { get => buttonChiTiet; set => buttonChiTiet = value; }
        public Button BtnDangKi { get => btnDangKi; set => btnDangKi = value; }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            FChiTietLuanVan_SV chiTietLuanVan = new FChiTietLuanVan_SV(LbTenLV.Text);
            chiTietLuanVan.Show();
        }
    }
}
