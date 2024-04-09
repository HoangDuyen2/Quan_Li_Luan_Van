using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FChiTietDuyet : Form
    {
        private string _message;
        ChiTietLuanVanDuyetDAO chiTiet = new ChiTietLuanVanDuyetDAO();
        LuanVanDuyet luanVan = new LuanVanDuyet();
        DuyetLuanVanDAO duyet = new DuyetLuanVanDAO();
        public FChiTietDuyet(string message) : this()
        {
            _message = message;
        }

        public FChiTietDuyet()
        {
            InitializeComponent();
        }
        private void FChiTietDuyet_Load(object sender, EventArgs e)
        {
            CapNhatDuLieu();
            ThongTin();
            KhongTruyCap();
        }

        public void KhongTruyCap()
        {
            txtMaLuanVan.Enabled = false;
            txtTenLuanVan.Enabled = false;
            txtChuyenNganh.Enabled = false;
            txtMSSV1.Enabled = false;
            txtMSSV2.Enabled = false;
            txtMSSV3.Enabled = false;
            txtLinhVuc.Enabled = false;
            txtCongNghe.Enabled = false;
            txtNgonNgu.Enabled = false;
            txtChucNang.Enabled = false;
        }
        public void ThongTin()
        {
            txtMaLuanVan.Text = luanVan.getMaLV();
            txtTenLuanVan.Text = luanVan.getTenLV();
            txtChuyenNganh.Text = luanVan.getChuyenNganh();
            txtMSSV1.Text = luanVan.getMSSV1();
            txtMSSV2.Text = luanVan.getMSSV2();
            txtMSSV3.Text = luanVan.getMSSV3();
            txtLinhVuc.Text = luanVan.getLinhVuc();
            txtCongNghe.Text = luanVan.getCongNghe();
            txtNgonNgu.Text = luanVan.getNgonNgu();
            txtChucNang.Text = luanVan.getChucNang();
        }

        private void CapNhatDuLieu()
        {
            luanVan = chiTiet.Load(_message);
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            duyet.TuChoi(luanVan);
            this.Close();
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            duyet.ChapNhan(luanVan);
            this.Close();
        }
    }
}
