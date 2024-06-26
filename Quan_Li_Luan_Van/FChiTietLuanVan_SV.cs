﻿using System;
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
        private string maLV;
        Hide_Show hide = new Hide_Show();
        LuanVanDuyet luanVan = new LuanVanDuyet();
        SinhVienDAO chiTiet = new SinhVienDAO();
        SinhVien sinhVien = null;
        public FChiTietLuanVan_SV(string maLV,SinhVien SV) : this()
        {
            this.maLV = maLV;
            this.sinhVien = SV;
        }

        public FChiTietLuanVan_SV()
        {
            InitializeComponent();
            ucChiTietLuanVan1.TxtTVien2.Enter += txtTVien2_GetFocus;
            ucChiTietLuanVan1.TxtTV3.Enter += txtTV3_GetFocus;
            ucChiTietLuanVan1.TxtTVien2.LostFocus += txtTVien2_LostFocus;
            ucChiTietLuanVan1.TxtTV3.LostFocus += txtTV3_LostFocus;
        }

        private void txtTV3_LostFocus(object sender, EventArgs e)
        {
            hide.Show(sender, e);
            ucChiTietLuanVan1.LbTenMSSV3.Text = chiTiet.TenThanhVien(ucChiTietLuanVan1.TxtTV3.Text);
        }

        private void txtTVien2_LostFocus(object sender, EventArgs e)
        {
            hide.Show(sender,e);
            ucChiTietLuanVan1.LbTenMSSV2.Text = chiTiet.TenThanhVien(ucChiTietLuanVan1.TxtTVien2.Text);
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
            ucChiTietLuanVan1.TxtTVien1.Text = sinhVien.getMaso();
            ucChiTietLuanVan1.LbTenMSSV1.Text = chiTiet.TenThanhVien(sinhVien.getMaso());
            ucChiTietLuanVan1.KhongTruyCap();
            if(chiTiet.checkTungNguoiDangKy(sinhVien.getMaso()))
                btnDangKy.Enabled = false;
        }

        private void CapNhatDuLieu()
        {
            luanVan = chiTiet.LoadLVD(maLV);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            luanVan.MSSV11 = sinhVien.getMaso();
            luanVan.MSSV21 = ucChiTietLuanVan1.TxtTVien2.Text;
            luanVan.MSSV31 = ucChiTietLuanVan1.TxtTV3.Text;
            if (string.IsNullOrWhiteSpace(luanVan.MSSV21) && string.IsNullOrWhiteSpace(luanVan.MSSV31))
            {
                MessageBox.Show("Cần thêm ít nhất 1 thành viên nữa để tạo nhóm! ");
                return;
            }
            if (chiTiet.checkNguoiDangKy(luanVan))
            {
                chiTiet.DangKy(luanVan);
                MessageBox.Show("Đăng kí thành công, chờ giáo viên duyệt để chính thức tham gia luận văn này");
            }
        }
    }
}
