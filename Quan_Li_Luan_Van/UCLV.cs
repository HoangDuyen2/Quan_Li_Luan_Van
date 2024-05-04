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
        SinhVien sinhVien = null;
        private string maLV;
        public UCLV(SinhVien SV)
        {
            InitializeComponent();
            this.sinhVien = SV;
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            FChiTietLuanVan_SV ctlv = new FChiTietLuanVan_SV(maLV,sinhVien);
            ctlv.ShowDialog();
        }
        public Label LblChuyenNganh { get => lblChuyenNganh; set => lblChuyenNganh = value; }
        public Label LblTenLV { get => lblTenLV; set => lblTenLV = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Button ButtonChiTiet { get => btnChiTiet; set => btnChiTiet = value; }
        public Label LblGVHD { get => lblGVHD; set => lblGVHD = value; }
        public Label LblTenGV { get => lblTenGV; set => lblTenGV = value; }
        public Label LblTrangThai { get => lblTrangThai; set => lblTrangThai = value;}
        public string MaLV { get => maLV; set => maLV = value; }

        private void UCLV_Load(object sender, EventArgs e)
        {

        }
    }
}
