﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Quan_Li_Luan_Van
{
    public partial class UCLV : UserControl
    {
        
        public UCLV()
        {
            InitializeComponent();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            FChiTietLuanVan ctlv = new FChiTietLuanVan(LblTenLV.Text);
            ctlv.ShowDialog();
        }
        public Label LblChuyenNganh { get => lblChuyenNganh; set => lblChuyenNganh = value; }
        public Label LblTenLV { get => lblTenLV; set => lblTenLV = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Button ButtonChiTiet { get => btnChiTiet; set => btnChiTiet = value; }
        public Label LblGVHD { get => lblGVHD; set => lblGVHD = value; }
        public Label LblTenGV { get => lblTenGV; set => lblTenGV = value; }
    }
}
