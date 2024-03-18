using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
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
        public Label LbChuyenNganh { get => lbChuyenNganh; set => lbChuyenNganh = value; }
        public Label LbTenLV { get => lbTenLV; set => lbTenLV = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Label LbSoLuong { get => lbSoLuong; set => lbSoLuong = value; }
        public Button ButtonChiTiet { get => buttonChiTiet; set => buttonChiTiet = value; }
        public Button BtnDangKi { get => btnDangKi; set => btnDangKi = value; }
        public Label LblSLCL { get => lblSLCL; set => lblSLCL = value; }
        public Label LblGVHD { get => lblGVHD; set => lblGVHD = value; }
        public Label LblTenGV { get => lblTenGV; set => lblTenGV = value; }

        private void lblTenGV_Click(object sender, EventArgs e)
        {

        }
    }
}
