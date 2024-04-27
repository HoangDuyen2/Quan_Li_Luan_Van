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
    public partial class FDuyetLuanVan : Form
    {
        private string maGV;
        private GiangVienDAO duyetLuanVan = new GiangVienDAO();
        private string query = "";

        public FDuyetLuanVan()
        {
            InitializeComponent();
        }

        public FDuyetLuanVan(string maGV) : this()
        {
            this.maGV = maGV;
        }

        private void FDuyetLuanVan_Load(object sender, EventArgs e)
        {

            duyetLuanVan.getInfoDLV(duyetLuanVan.LoadDLV(maGV), flPanelDSLV);
        }
        private void cbbLoaiTraCuu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiTraCuu.SelectedItem != null)
            {
                string text = cbbLoaiTraCuu.SelectedItem.ToString();
                query = duyetLuanVan.traCuu(text,duyetLuanVan.LoadDLV(maGV));
                duyetLuanVan.getInfoDLV(query, flPanelDSLV);            }
        }
    }
}
