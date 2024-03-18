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
        public Label LbChuyenNganh { get => lblChuyenNganh; set => lblChuyenNganh = value; }
        public Label LbTenLV { get => lblTenLV; set => lblTenLV = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Label LbSoLuong { get => lblSoLuong; set => lblSoLuong = value; }
        public Button ButtonChiTiet { get => btnChiTiet; set => btnChiTiet = value; }
        public Label LblSLCL { get => lblSLCL; set => lblSLCL = value; }
        public Label LblGVHD { get => lblGVHD; set => lblGVHD = value; }
        public Label LblTenGV { get => lblTenGV; set => lblTenGV = value; }
    }
}
