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
    public partial class UCDuyet : UserControl
    {
        public UCDuyet()
        {
            InitializeComponent();
        }
        public Label LbMSSV { get => lbMSSV; set => lbMSSV = value; }
        public Label LblMSSV { get => lblMSSV; set => lblMSSV = value; }
        public Button BtnDangKi { get => btnDangKi; set => btnDangKi = value; }
        public Button ButtonChiTiet { get => buttonChiTiet; set => buttonChiTiet = value; }
        public Label LbChuyenNganh { get => lbChuyenNganh; set => lbChuyenNganh = value; }
        public Label LbTenLV { get => lbTenLV; set => lbTenLV = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Label LbTenSV { get => lbTenSV; set => lbTenSV = value; }
    }
}
