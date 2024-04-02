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
    public partial class UCTask : UserControl
    {
        private string maLV;
        public UCTask()
        {
            InitializeComponent();
        }
        public Label LblTenNV { get => lblTenNV; set => lblTenNV = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Button BtnChiTiet { get => btnChiTiet; set => btnChiTiet = value; }
        public Label LblTienTrinh { get => lblTienTrinh; set => lblTienTrinh = value; }
        public string MaLV { get => maLV; set => maLV = value; }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FChiTietTask fChiTiet = new FChiTietTask(LblTenNV.Text);
            fChiTiet.Show();
        }

        private void btnChiTiet_Click_1(object sender, EventArgs e)
        {
            FChiTietTask task = new FChiTietTask();
            task.Show();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
