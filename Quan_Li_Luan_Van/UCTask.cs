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
        private string maNV;
        private string maNguoi;


        public UCTask()
        {
            InitializeComponent();
        }
        public Label LblTenNV { get => lblTenNV; set => lblTenNV = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Button BtnChiTiet { get => btnChiTiet; set => btnChiTiet = value; }
        public Label LblTienTrinh { get => lblTienTrinh; set => lblTienTrinh = value; }
        public string MaLV { get => maLV; set => maLV = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaNguoi { get => maNguoi; set => maNguoi = value; }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            FChinhSuaTask task = new FChinhSuaTask(MaNV,MaNguoi);
            task.ShowDialog();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FChiTietTask_All fChiTietTask_GV = new FChiTietTask_All(maNV,maNguoi);
            fChiTietTask_GV.ShowDialog();
        }

        private void UCTask_Load(object sender, EventArgs e)
        {

        }
    }
}
