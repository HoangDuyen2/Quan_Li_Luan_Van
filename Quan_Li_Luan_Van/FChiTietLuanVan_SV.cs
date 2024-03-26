using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FChiTietLuanVan_SV : Form
    {
        private string _message;
        Hide_Show hide = new Hide_Show();
        LuanVanDuyet luanVan = new LuanVanDuyet();
        ChiTietLuanVanDAO chiTiet = new ChiTietLuanVanDAO();
        DangKyLuanVan_SVDAO dangKy = new DangKyLuanVan_SVDAO();
        public FChiTietLuanVan_SV(string message) : this()
        {
            _message = message;
        }

        public FChiTietLuanVan_SV()
        {
            InitializeComponent();
            ucChiTietLuanVan1.TxtTVien1.Enter += txtTVien1_GetFocus;
            ucChiTietLuanVan1.TxtTVien2.Enter += txtTVien2_GetFocus;
            ucChiTietLuanVan1.TxtTVien1.LostFocus += txtTVien1_LostFocus;
            ucChiTietLuanVan1.TxtTVien2.LostFocus += txtTVien2_LostFocus;
        }

        private void txtTVien2_LostFocus(object sender, EventArgs e)
        {
            hide.Show(sender,e);
        }

        private void txtTVien1_LostFocus(object sender, EventArgs e)
        {
            hide.Show(sender, e);
        }

        private void txtTVien2_GetFocus(object sender, EventArgs e)
        {
            hide.Hide(sender, e);
        }

        private void txtTVien1_GetFocus(object sender, EventArgs e)
        {
            hide.Hide(sender, e);
        }

        private void FChiTietLuanVan_Load(object sender, EventArgs e)
        {
            CapNhatDuLieu();
            ucChiTietLuanVan1.ThongTin(luanVan);
            ucChiTietLuanVan1.KhongTruyCap();
        }

        private void CapNhatDuLieu()
        {
            luanVan = chiTiet.Load(_message, "Luận văn");
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            luanVan.setMSSV1(ucChiTietLuanVan1.TxtTVien1.Text);
            luanVan.setMSSV2(ucChiTietLuanVan1.TxtTVien2.Text);
            luanVan.setMSSV3("");
            dangKy.DangKy(luanVan);
            this.Close();
        }
    }

}
