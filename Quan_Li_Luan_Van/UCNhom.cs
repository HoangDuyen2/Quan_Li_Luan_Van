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
        private string maLV;
        public UCNhom()
        {
            InitializeComponent();
        }
        public Label LblChuyenNganh { get => lblChuyenNganh; set => lblChuyenNganh = value; }
        public Label LblTenLV { get => lblTenLV; set => lblTenLV = value; }
        public string MaLV { get => maLV; set => maLV = value; }

        private void UCNhom_Load(object sender, EventArgs e)
        {

        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FChiTietLuanVan_GV ctlv = new FChiTietLuanVan_GV(maLV);
            ctlv.ShowDialog();
        }
        private void btnTienTrinh_Click(object sender, EventArgs e)
        {
            FNhiemVu_GV task = new FNhiemVu_GV(maLV);
            task.Show();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            FThemThongBao fThemThongBao = new FThemThongBao(MaLV);
            fThemThongBao.ShowDialog();
        }

        private void btnChamDiem_Click(object sender, EventArgs e)
        {
            FChamDiem fChamDiem = new FChamDiem();
            fChamDiem.ShowDialog();
        }
    }
}
