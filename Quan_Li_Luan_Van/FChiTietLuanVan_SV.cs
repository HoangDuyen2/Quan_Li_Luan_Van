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
        PersonDAO chiTiet = new PersonDAO();
        SinhVienDAO dangKy = new SinhVienDAO();
        Person person = null;
        public FChiTietLuanVan_SV(string message,Person person) : this()
        {
            _message = message;
            this.person = person;
        }

        public FChiTietLuanVan_SV()
        {
            InitializeComponent();
            ucChiTietLuanVan1.TxtTVien21.Enter += txtTVien2_GetFocus;
            ucChiTietLuanVan1.TxtTV31.Enter += txtTV3_GetFocus;
            ucChiTietLuanVan1.TxtTVien21.LostFocus += txtTVien2_LostFocus;
            ucChiTietLuanVan1.TxtTV31.LostFocus += txtTV3_LostFocus;
        }

        private void txtTV3_LostFocus(object sender, EventArgs e)
        {
            hide.Show(sender, e);
            ucChiTietLuanVan1.LbTenMSSV3.Text = luanVan.TenMSSV3;
        }

        private void txtTVien2_LostFocus(object sender, EventArgs e)
        {
            hide.Show(sender,e);
            ucChiTietLuanVan1.LbTenMSSV2.Text = luanVan.TenMSSV2;
        }


        private void txtTVien2_GetFocus(object sender, EventArgs e)
        {
            hide.Hide(sender, e);
        }


        private void txtTV3_GetFocus(object sender, EventArgs e)
        {
            hide.Hide(sender, e);
        }

        private void FChiTietLuanVan_Load(object sender, EventArgs e)
        {
            CapNhatDuLieu();
            ucChiTietLuanVan1.ThongTin(luanVan);
            ucChiTietLuanVan1.TxtTVien11.Text = person.getMaso();
            ucChiTietLuanVan1.LbTenMSSV1.Text = luanVan.TenMSSV1;
            ucChiTietLuanVan1.KhongTruyCap();
            if(dangKy.checkTungNguoiDangKy(person.getMaso()))
                btnChapNhan.Enabled = false;
        }

        private void CapNhatDuLieu()
        {
            luanVan = chiTiet.Load(_message);
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            luanVan.MSSV11 = person.getMaso();
            luanVan.MSSV21 = ucChiTietLuanVan1.TxtTVien21.Text;
            luanVan.MSSV31 = ucChiTietLuanVan1.TxtTV31.Text;
            
            if(dangKy.checkNguoiDangKy(luanVan))
                dangKy.DangKy(luanVan);
            this.Close();
        }
    }

}
