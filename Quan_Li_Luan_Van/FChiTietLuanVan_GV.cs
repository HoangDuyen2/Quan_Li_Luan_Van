using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FChiTietLuanVan_GV : Form
    {
        private string _message;
        ChiTietLuanVanDAO chiTiet = new ChiTietLuanVanDAO();
        LuanVan luanVan = new LuanVan();
        public FChiTietLuanVan_GV(string message) : this()
        {
            _message = message;
        }

        public FChiTietLuanVan_GV()
        {
            InitializeComponent();
        }
        public string ThanhVienNhom()
        {
            string query1 = "SELECT LuanVan.MaLV, LuanVan.TenLV, DSThanhVien.MSSV1, " +
                            "DSThanhVien.MSSV2, DSThanhVien.MSSV3 " +
                            "FROM LuanVan, DSThanhVien " +
                           "WHERE LuanVan.MaLV = DSThanhVien.MaLV and TenLV = N'" + _message + "'";
            return query1;
        }
        public void KhongTruyCap()
        {
            txtChucNang.Enabled = false;
            txtChuyenNganh.Enabled = false;
            txtCongNghe.Enabled = false;
            txtNgonNgu.Enabled = false;
            txtYeuCau.Enabled = false;
            txtGVHD.Enabled = false;
            txtLinhVuc.Enabled = false;
            txtMaLuanVan.Enabled = false;
            txtTVien2.Enabled = false;
            txtTVien1.Enabled = false;
            txtTenLuanVan.Enabled = false;
        }
        public void ThongTin()
        {
            txtChucNang.Text = luanVan.getChucNang();
            txtChuyenNganh.Text = luanVan.getChuyenNganh();
            txtCongNghe.Text = luanVan.getCongNghe();
            txtNgonNgu.Text = luanVan.getNgonNgu();
            txtYeuCau.Text = luanVan.getYeuCau();
            txtGVHD.Text = luanVan.getTenGV();
            txtLinhVuc.Text = luanVan.getLinhVuc();
            txtMaLuanVan.Text = luanVan.getMaLV();
            txtTVien2.Text = luanVan.getMSSV1();
            txtTVien1.Text = luanVan.getMSSV2();
            txtTenLuanVan.Text = luanVan.getTenLV();
        }

        private void FChiTietLuanVan_GV_Load(object sender, EventArgs e)
        {
            CapNhatDuLieu();
            ThongTin();
            KhongTruyCap();
        }
        private void CapNhatDuLieu()
        {
            string query = "SELECT LuanVan.MaLV, LuanVan.TenLV, GiangVien.TenGV, " +
                            "LuanVan.ChuyenNganh, LuanVan.LinhVuc, LuanVan.ChucNang, LuanVan.CongNghe, " +
                            " LuanVan.NgonNgu, LuanVan.YeuCau " +
                           "FROM LuanVan, GiangVien " +
                           "WHERE LuanVan.MaGV = GiangVien.MaGV and TenLV = N'" + _message + "'";
            luanVan = chiTiet.Load(query, ThanhVienNhom());
        }
    }
}
