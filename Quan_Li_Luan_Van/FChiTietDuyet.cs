﻿using System;
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
        GiangVienDAO chiTiet = new GiangVienDAO();
        LuanVanDuyet luanVan = new LuanVanDuyet();
        GiangVienDAO duyet = new GiangVienDAO();
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
            txtMaLuanVan.Text = luanVan.MaLV;
            txtTenLuanVan.Text = luanVan.TenLV;
            txtChuyenNganh.Text = luanVan.ChuyenNganh;
            txtMSSV1.Text = luanVan.MSSV11;
            txtMSSV2.Text = luanVan.MSSV21;
            txtMSSV3.Text = luanVan.MSSV31;
            txtLinhVuc.Text = luanVan.LinhVuc;
            txtCongNghe.Text = luanVan.CongNghe;
            txtNgonNgu.Text = luanVan.NgonNgu;
            txtChucNang.Text = luanVan.ChucNang;
            lbTenSV1.Text = luanVan.TenMSSV1;
            lbTenSV2.Text = luanVan.TenMSSV2;
            lbTenSV3.Text = luanVan.TenMSSV3;
        }

        private void CapNhatDuLieu()
        {
            luanVan = chiTiet.LoadCTLV(_message);
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
