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
            TxtTVien1.Enabled = false;
            TxtChucNang.Enabled = false;
            CbboxChuyenNganh.Enabled = false;
            CbboxCongNghe.Enabled = false;
            CbboxNgonNgu.Enabled = false;
            TxtYeuCau.Enabled = false;
            TxtGVHD.Enabled = false;
            CbboxLinhVuc.Enabled = false;
            TxtMaLuanVan.Enabled = false;
            TxtTenLuanVan.Enabled = false;
        }

        public void ThongTin(LuanVanDuyet luanVan)
        {
            TxtChucNang.Text = luanVan.ChucNang;
            CbboxChuyenNganh.Text = luanVan.ChuyenNganh;
            CbboxCongNghe.Text = luanVan.CongNghe;
            CbboxNgonNgu.Text = luanVan.NgonNgu;
            TxtYeuCau.Text = luanVan.YeuCau;
            TxtGVHD.Text = luanVan.TenGV;
            CbboxLinhVuc.Text = luanVan.LinhVuc;
            TxtMaLuanVan.Text = luanVan.MaLV;
            TxtTVien2.Text = luanVan.MSSV21;
            TxtTVien1.Text = luanVan.MSSV11;
            TxtTV3.Text = luanVan.MSSV31;
            TxtTenLuanVan.Text = luanVan.TenLV;
            LbTenMSSV1.Text = luanVan.TenMSSV1;
            LbTenMSSV2.Text = luanVan.TenMSSV2;
            LbTenMSSV3.Text = luanVan.TenMSSV3;
        }

        public Label LbMSSV1 { get => lbMSSV1; set => lbMSSV1 = value; }
        public Label LbChucNang { get => lbChucNang; set => lbChucNang = value; }
        public Label LbTenGVHD { get => lbTenGVHD; set => lbTenGVHD = value; }
        public Label LbMoTaChiTiet { get => lbMoTaChiTiet; set => lbMoTaChiTiet = value; }
        public Label LbMaLuanVan { get => lbMaLuanVan; set => lbMaLuanVan = value; }
        public Label LbTenLuanVan { get => lbTenLuanVan; set => lbTenLuanVan = value; }
        public Label LblCTLV { get => lblCTLV; set => lblCTLV = value; }
        public KryptonTextBox TxtChucNang { get => txtChucNang; set => txtChucNang = value; }
        public KryptonTextBox TxtTVien1 { get => txtTVien1; set => txtTVien1 = value; }
        public KryptonTextBox TxtGVHD { get => txtGVHD; set => txtGVHD = value; }
        public KryptonTextBox TxtYeuCau { get => txtYeuCau; set => txtYeuCau = value; }
        public KryptonTextBox TxtTenLuanVan { get => txtTenLuanVan; set => txtTenLuanVan = value; }
        public KryptonTextBox TxtMaLuanVan { get => txtMaLuanVan; set => txtMaLuanVan = value; }
        public Panel PanelNoiDung { get => panelNoiDung; set => panelNoiDung = value; }
        public KryptonTextBox TxtTV3 { get => txtTV3; set => txtTV3 = value; }
        public Label LbMSSV3 { get => lbMSSV3; set => lbMSSV3 = value; }
        public KryptonTextBox TxtTVien2 { get => txtTVien2; set => txtTVien2 = value; }
        public Label LbMSSV2 { get => lbMSSV2; set => lbMSSV2 = value; }
        public Label LbTenMSSV2 { get => lbTenMSSV2; set => lbTenMSSV2 = value; }
        public Label LbTenMSSV1 { get => lbTenMSSV1; set => lbTenMSSV1 = value; }
        public Label LbTenMSSV3 { get => lbTenMSSV3; set => lbTenMSSV3 = value; }
        public KryptonComboBox CbboxChuyenNganh { get => cbboxChuyenNganh; set => cbboxChuyenNganh = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public KryptonComboBox CbboxNgonNgu { get => cbboxNgonNgu; set => cbboxNgonNgu = value; }
        public KryptonComboBox CbboxCongNghe { get => cbboxCongNghe; set => cbboxCongNghe = value; }
        public KryptonComboBox CbboxLinhVuc { get => cbboxLinhVuc; set => cbboxLinhVuc = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
    }
}
