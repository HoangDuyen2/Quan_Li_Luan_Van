﻿using System;
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
        private string maLV;
        GiangVienDAO chiTiet = new GiangVienDAO();
        LuanVanDuyet luanVan = new LuanVanDuyet();
        public FChiTietLuanVan_GV()
        {
            InitializeComponent();
        }
        public FChiTietLuanVan_GV(string MaLV) : this()
        {
            this.maLV = MaLV;
        }
        private void FChiTietLuanVan_GV_Load(object sender, EventArgs e)
        {
            CapNhatDuLieu();
            ucChiTietLuanVan1.ThongTin(luanVan);
            ucChiTietLuanVan1.KhongTruyCap();
            ucChiTietLuanVan1.TxtTVien1.Enabled = false;
            ucChiTietLuanVan1.TxtTVien2.Enabled = false;
            ucChiTietLuanVan1.TxtTV3.Enabled = false;
        }
        private void CapNhatDuLieu()
        {
            luanVan = chiTiet.LoadLVD(maLV);
        }

    }

}
