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
        private string maLV;
        private string maGV;

        public UCLVCuaToi()
        {
            InitializeComponent();
        }

        public Label LblChuyenNganh { get => lblChuyenNganh; set => lblChuyenNganh = value; }
        public Label LblTenLV { get => lblTenLV; set => lblTenLV = value; }        
        public Label LblTrangThai { get => lblTrangThai; set => lblTrangThai = value;}
        public Button BtnDelete { get => btnXoa; set => btnXoa = value; }
        public string MaLV { get => maLV; set => maLV = value; }
        public string MaGV { get => maGV; set => maGV = value; }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            FChinhLuanVan chinhlv = new FChinhLuanVan(maLV,maGV);
            chinhlv.ShowDialog();
            
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FChiTietLuanVan_GV ctlv = new FChiTietLuanVan_GV(maLV);
            ctlv.ShowDialog();
        }

        private void UCLVCuaToi_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            FXoaLuanVan xoalv = new FXoaLuanVan(maLV); 
            xoalv.ShowDialog();
        }
    }
}
