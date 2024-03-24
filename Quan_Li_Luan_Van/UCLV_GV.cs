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
    public partial class UCLV_GV : UserControl
    {
        public UCLV_GV()
        {
            InitializeComponent();
        }
        public Label LblTenGV1 { get => lblTenGV; set => lblTenGV = value; }
        public Label LblGVHD1 { get => lblGVHD; set => lblGVHD = value; }
        public Button BtnChiTiet1 { get => btnChiTiet; set => btnChiTiet = value; }
        public Label LblChuyenNganh1 { get => lblChuyenNganh; set => lblChuyenNganh = value; }
        public Label LblTenLV1 { get => lblTenLV; set => lblTenLV = value; }
        public PictureBox PictureBoxNen1 { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Label LblTrangThai { get => lblTrangThai; set => lblTrangThai = value; }
    }
}
