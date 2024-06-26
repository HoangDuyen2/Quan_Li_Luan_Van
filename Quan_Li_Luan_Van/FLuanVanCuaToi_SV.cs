﻿using System;
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
    public partial class FLuanVanCuaToi_SV : Form
    {
        SinhVien sinhVien = null;
        SinhVienDAO luanVan = new SinhVienDAO();
        public string maLV;
        public FLuanVanCuaToi_SV(SinhVien sinhVien)
        {
            InitializeComponent();
            this.sinhVien = sinhVien;
        }
        private void FLuanVanToi_SV_Load(object sender, EventArgs e)
        {
            maLV = luanVan.getMaLVCuaToi(sinhVien.getMaso());
            if (string.IsNullOrEmpty(maLV))
            {
                btnThemNhiemVu.Enabled = false;
                buttonXemDiem.Enabled = false;
                MessageBox.Show("Sinh viên hiện chưa tham gia vào luận văn nào. Vui lòng đăng kí luận văn trước", "Thông báo");
            }
            else
            {
                LoadNhiemVu();
                string tinhTrangLV = luanVan.getTinhTrangLVCuaToi(maLV);
                btnThemNhiemVu.Enabled = tinhTrangLV != "Đã hoàn thành";
                buttonXemDiem.Enabled = tinhTrangLV == "Đã hoàn thành";
            }
        }
        public void LoadNhiemVu()
        {
            lblTenLV.Text = luanVan.GetTenLV(maLV);
            luanVan.LoadDSNhiemVu(flPanelDSTask, luanVan.QueryDSNhiemVu(maLV), sinhVien.getMaso());
        }
        private void btnThemNhiemVu_Click(object sender, EventArgs e)
        {
            FThemNhiemVu fThemNhiemVu = new FThemNhiemVu(luanVan.getMaLVCuaToi(sinhVien.getMaso()), sinhVien.getMaso());
            if (fThemNhiemVu.ShowDialog() == DialogResult.OK)
            {
                LoadNhiemVu();
            }
        }
        private void buttonXemDiem_Click(object sender, EventArgs e)
        {
            FXemDiem fXemDiem = new FXemDiem(luanVan.getMaLVCuaToi(sinhVien.getMaso()));
            fXemDiem.ShowDialog();
        }
    }
}
