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
        public UCTask()
        {
            InitializeComponent();
        }
        public Label LbTienTrinh { get => lbTienTrinh; set => lbTienTrinh = value; }
        public Label LbTenLV { get => lbTenLV; set => lbTenLV = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Button BtnChiTiet { get => btnChiTiet; set => btnChiTiet = value; }
        public Label LbSoTienTrinh { get => lbSoTienTrinh; set => lbSoTienTrinh = value; }
        //public Label LbTT { get => lbTT; set => lbTT = value; }
        //public Label LbTrangThai { get => lbTrangThai; set => lbTrangThai = value; }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FChiTietTask fChiTiet = new FChiTietTask(LbTenLV.Text);
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
