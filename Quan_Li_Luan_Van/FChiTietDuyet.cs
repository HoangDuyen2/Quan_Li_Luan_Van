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
        ChiTietLuanVanDAO chiTiet = new ChiTietLuanVanDAO();
        LuanVan luanVan = new LuanVan();
        DBConnection connection = new DBConnection();
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
        public string ThanhVienNhom()
        {
            string query1 = "SELECT LuanVan.MaLV, LuanVan.TenLV, DuyetDangKy.MSSV1, DuyetDangKy.MSSV2, DuyetDangKy.MSSV3 " +
                            "FROM LuanVan, DuyetDangKy " +
                           "WHERE LuanVan.MaLV = DuyetDangKy.MaLV and TenLV = N'" + _message + "'";
            return query1;
        }
        public void KhongTruyCap()
        {
            txtMaLuanVan.Enabled = false;
            txtTenLuanVan.Enabled = false;
            txtChuyenNganh.Enabled = false;
            txtMSSV1.Enabled = false;
            txtMSSV2.Enabled = false;
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
            txtLinhVuc.Text = luanVan.getLinhVuc();
            txtCongNghe.Text = luanVan.getCongNghe();
            txtNgonNgu.Text = luanVan.getNgonNgu();
            txtChucNang.Text = luanVan.getChucNang();
        }

        private void CapNhatDuLieu()
        {
            string query = "SELECT LuanVan.MaLV, LuanVan.TenLV, LuanVan.ChuyenNganh, LuanVan.LinhVuc, LuanVan.ChucNang, LuanVan.CongNghe, " +
                            " LuanVan.NgonNgu, LuanVan.YeuCau, GiangVien.TenGV " +
                           "FROM LuanVan, DuyetDangKy, GiangVien " +
                           "WHERE LuanVan.MaLV = DuyetDangKy.MaLV and GiangVien.MaGV = LuanVan.MaGV  and LuanVan.TenLV = N'" + _message + "'";
            luanVan = chiTiet.Load(query, ThanhVienNhom());
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            string query1 = string.Format("DELETE FROM DSThanhVien WHERE MaLV = '{0}'", luanVan.getMaLV());
            string query2 = string.Format("UPDATE LuanVan SET TrangThai = N'{0}' WHERE MaLV = '{1}'", "Chưa có nhóm", luanVan.getMaLV());
            string query = string.Format("UPDATE DuyetDangKy SET TinhTrang = N'{0}' WHERE MaLV = '{1}'", "Từ chối",luanVan.getMaLV());
            connection.ThucThi(query);
            connection.ThucThi(query1);
            connection.ThucThi(query2);
            this.Close();
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            string query = string.Format("UPDATE DuyetDangKy SET TinhTrang = N'{0}' WHERE MaLV = '{1}'", "Đã duyệt", luanVan.getMaLV());
            string query1 = string.Format("UPDATE LuanVan SET TrangThai = N'{0}' WHERE MaLV = '{1}'", "Đã có nhóm", luanVan.getMaLV());
            string query2;
            if(luanVan.getMSSV3() == "")
            {
                query2 = string.Format("INSERT INTO DSThanhVien (MaLV, MSSV1, MSSV2, MSSV3) " + "VALUES ('{0}','{1}','{2}',NULL)",
                luanVan.getMaLV(), luanVan.getMSSV1(), luanVan.getMSSV2());
            }
            else
            {
                query2 = string.Format("INSERT INTO DSThanhVien (MaLV, MSSV1, MSSV2, MSSV3) " + "VALUES ('{0}','{1}','{2}','{3}')",
                luanVan.getMaLV(), luanVan.getMSSV1(), luanVan.getMSSV2(), luanVan.getMSSV3());
            }
            connection.ThucThi(query);
            connection.ThucThi(query1);
            connection.ThucThi(query2);
            this.Close();
        }


    }
}
