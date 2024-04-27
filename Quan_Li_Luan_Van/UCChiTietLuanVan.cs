using ComponentFactory.Krypton.Toolkit;
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
    public partial class UCChiTietLuanVan : UserControl
    {
        public UCChiTietLuanVan()
        {
            InitializeComponent();
            KhongTruyCap();
        }
        public void KhongTruyCap()
        {
            TxtTVien11.Enabled = false;
            txtChucNang.Enabled = false;
            txtChuyenNganh.Enabled = false;
            txtCongNghe.Enabled = false;
            txtNgonNgu.Enabled = false;
            txtYeuCau.Enabled = false;
            txtGVHD.Enabled = false;
            txtLinhVuc.Enabled = false;
            txtMaLuanVan.Enabled = false;
            txtTenLuanVan.Enabled = false;
        }
        public void ThongTin(LuanVanDuyet luanVan)
        {
            TxtChucNang1.Text = luanVan.ChucNang;
            TxtChuyenNganh1.Text = luanVan.ChuyenNganh;
            TxtCongNghe1.Text = luanVan.CongNghe;
            TxtNgonNgu1.Text = luanVan.NgonNgu;
            TxtYeuCau1.Text = luanVan.YeuCau;
            TxtGVHD1.Text = luanVan.TenGV;
            TxtLinhVuc1.Text = luanVan.LinhVuc;
            TxtMaLuanVan1.Text = luanVan.MaLV;
            TxtTVien21.Text = luanVan.MSSV21;
            TxtTVien11.Text = luanVan.MSSV11;
            TxtTV31.Text = luanVan.MSSV31;
            TxtTenLuanVan1.Text = luanVan.TenLV;
            LbTenMSSV1.Text = luanVan.TenMSSV1;
            LbTenMSSV2.Text = luanVan.TenMSSV2;
            LbTenMSSV3.Text = luanVan.TenMSSV3;
        }
        public Label LbNgonNgu { get => lbNgonNgu; set => lbNgonNgu = value; }
        public Label LbCongNghe { get => lbCongNghe; set => lbCongNghe = value; }
        public Label LbLinhVuc { get => lbLinhVuc; set => lbLinhVuc = value; }
        public Label LbChuyenNganh { get => lbChuyenNganh; set => lbChuyenNganh = value; }
        public Label LbMSSV1 { get => lbMSSV1; set => lbMSSV1 = value; }
        public Label LbChucNang { get => lbChucNang; set => lbChucNang = value; }
        public Label LbTenGVHD { get => lbTenGVHD; set => lbTenGVHD = value; }
        public Label LbMoTaChiTiet1 { get => lbMoTaChiTiet; set => lbMoTaChiTiet = value; }
        public Label LbMaLuanVan1 { get => lbMaLuanVan; set => lbMaLuanVan = value; }
        public Label LbTenLuanVan1 { get => lbTenLuanVan; set => lbTenLuanVan = value; }
        public Label LblCTLV1 { get => lblCTLV; set => lblCTLV = value; }
        public KryptonTextBox TxtChucNang1 { get => txtChucNang; set => txtChucNang = value; }
        public KryptonTextBox TxtChuyenNganh1 { get => txtChuyenNganh; set => txtChuyenNganh = value; }
        public KryptonTextBox TxtCongNghe1 { get => txtCongNghe; set => txtCongNghe = value; }
        public KryptonTextBox TxtNgonNgu1 { get => txtNgonNgu; set => txtNgonNgu = value; }
        public KryptonTextBox TxtTVien11 { get => txtTVien1; set => txtTVien1 = value; }
        public KryptonTextBox TxtLinhVuc1 { get => txtLinhVuc; set => txtLinhVuc = value; }
        public KryptonTextBox TxtGVHD1 { get => txtGVHD; set => txtGVHD = value; }
        public KryptonTextBox TxtYeuCau1 { get => txtYeuCau; set => txtYeuCau = value; }
        public KryptonTextBox TxtTenLuanVan1 { get => txtTenLuanVan; set => txtTenLuanVan = value; }
        public KryptonTextBox TxtMaLuanVan1 { get => txtMaLuanVan; set => txtMaLuanVan = value; }
        public Panel PanelNoiDung1 { get => panelNoiDung; set => panelNoiDung = value; }
        public KryptonTextBox TxtTV31 { get => txtTV3; set => txtTV3 = value; }
        public Label LbMSSV3 { get => lbMSSV3; set => lbMSSV3 = value; }
        public KryptonTextBox TxtTVien21 { get => txtTVien2; set => txtTVien2 = value; }
        public Label LbMSSV2 { get => lbMSSV2; set => lbMSSV2 = value; }
        public Label LbTenMSSV2 { get => lbTenMSSV2; set => lbTenMSSV2 = value; }
        public Label LbTenMSSV1 { get => lbTenMSSV1; set => lbTenMSSV1 = value; }
        public Label LbTenMSSV3 { get => lbTenMSSV3; set => lbTenMSSV3 = value; }
    }
}
