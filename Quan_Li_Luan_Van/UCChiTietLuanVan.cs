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
            TxtChucNang.Enabled = false;
            TxtChuyenNganh.Enabled = false;
            TxtCongNghe.Enabled = false;
            TxtNgonNgu.Enabled = false;
            TxtYeuCau.Enabled = false;
            TxtGVHD.Enabled = false;
            TxtLinhVuc.Enabled = false;
            TxtMaLuanVan.Enabled = false;
            TxtTenLuanVan.Enabled = false;
        }
        public void ThongTin(LuanVanDuyet luanVan)
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
            txtTV3.Text = luanVan.getMSSV3();
            txtTenLuanVan.Text = luanVan.getTenLV();
        }
        public Label Label7 { get => label7; set => label7 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label LbSoLuong { get => lbSoLuong; set => lbSoLuong = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label LbMoTaChiTiet { get => lbMoTaChiTiet; set => lbMoTaChiTiet = value; }
        public Label LbMaLuanVan { get => lbMaLuanVan; set => lbMaLuanVan = value; }
        public Label LbTenLuanVan { get => lbTenLuanVan; set => lbTenLuanVan = value; }
        public Label LblCTLV { get => lblCTLV; set => lblCTLV = value; }
        public KryptonTextBox TxtChucNang { get => txtChucNang; set => txtChucNang = value; }
        public KryptonTextBox TxtChuyenNganh { get => txtChuyenNganh; set => txtChuyenNganh = value; }
        public KryptonTextBox TxtTVien2 { get => txtTVien2; set => txtTVien2 = value; }
        public KryptonTextBox TxtCongNghe { get => txtCongNghe; set => txtCongNghe = value; }
        public KryptonTextBox TxtNgonNgu { get => txtNgonNgu; set => txtNgonNgu = value; }
        public KryptonTextBox TxtTVien1 { get => txtTVien1; set => txtTVien1 = value; }
        public KryptonTextBox TxtTV3 { get => txtTV3; set => txtTV3 = value; }
        public KryptonTextBox TxtLinhVuc { get => txtLinhVuc; set => txtLinhVuc = value; }
        public KryptonTextBox TxtGVHD { get => txtGVHD; set => txtGVHD = value; }
        public KryptonTextBox TxtYeuCau { get => txtYeuCau; set => txtYeuCau = value; }
        public KryptonTextBox TxtTenLuanVan { get => txtTenLuanVan; set => txtTenLuanVan = value; }
        public KryptonTextBox TxtMaLuanVan { get => txtMaLuanVan; set => txtMaLuanVan = value; }
        public Panel PanelNoiDung { get => panelNoiDung; set => panelNoiDung = value; }
    }
}
