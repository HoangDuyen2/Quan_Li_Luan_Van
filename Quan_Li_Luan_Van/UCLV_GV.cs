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
    public partial class UCLV_GV : UserControl
    {
        private string maLV;
        public UCLV_GV()
        {
            InitializeComponent();
        }
        public Label LblTenGV { get => lblTenGV; set => lblTenGV = value; }
        public Label LblGVHD { get => lblGVHD; set => lblGVHD = value; }
        public Button BtnChiTiet { get => btnChiTiet; set => btnChiTiet = value; }
        public Label LblChuyenNganh { get => lblChuyenNganh; set => lblChuyenNganh = value; }
        public Label LblTenLV { get => lblTenLV; set => lblTenLV = value; }
        public PictureBox PictureBoxNen1 { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Label LblTrangThai { get => lblTrangThai; set => lblTrangThai = value; }
        public string MaLV { get => maLV; set => maLV = value; }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FChiTietLuanVan_GV chiTietLuanVan = new FChiTietLuanVan_GV(maLV);
            chiTietLuanVan.Show();
        }

        private void UCLV_GV_Load(object sender, EventArgs e)
        {

        }

        private void lblGVHD_Click(object sender, EventArgs e)
        {

        }
    }
}
