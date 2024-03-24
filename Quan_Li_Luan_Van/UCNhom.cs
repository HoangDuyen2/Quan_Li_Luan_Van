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
    public partial class UCNhom : UserControl
    {
        public UCNhom()
        {
            InitializeComponent();
        }
        public Label LbChuyenNganh { get => lbChuyenNganh; set => lbChuyenNganh = value; }
        public Label LbTenLV { get => lbTenLV; set => lbTenLV = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Button BtnDSTV { get => btnDSTV; set => btnDSTV = value; }
        public Button BtnTienTrinh { get => btnTienTrinh; set => btnTienTrinh = value; }
        public Button BtnThemNV { get => btnThemNV; set => btnThemNV = value; }

        private void btnTienTrinh_Click(object sender, EventArgs e)
        {
            FChiTietTask chiTietTask = new FChiTietTask(LbTenLV.Text);
            chiTietTask.Show();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {

        }
    }
}
