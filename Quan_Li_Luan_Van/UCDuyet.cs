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
    public partial class UCDuyet : UserControl
    {
        private string maLV;
        public UCDuyet()
        {
            InitializeComponent();
        }
        public string MaLV { get => maLV; set => maLV = value; }
        public Button ButtonChiTiet { get => buttonChiTiet; set => buttonChiTiet = value; }
        public Label LbChuyenNganh { get => lbChuyenNganh; set => lbChuyenNganh = value; }
        public Label LbTenLV { get => lbTenLV; set => lbTenLV = value; }
        public Label LBTrangThai { get => lbTrangThai; set => lbTrangThai = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            FDuyetLuanVan parentForm = this.ParentForm as FDuyetLuanVan;
            if (parentForm != null)
            {
                FChiTietDuyet chiTietDuyet = new FChiTietDuyet(maLV, parentForm);
                chiTietDuyet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed to find parent form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
