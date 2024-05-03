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
    public partial class UCTask_SV : UserControl
    {
        private string maLV;
        private string maNV;
        private string maNguoiTao;
        private string mssvLogin;

        public UCTask_SV()
        {
            InitializeComponent();
        }
        public Label LblTenNV { get => lblTenNV; set => lblTenNV = value; }
        public Button BtnChiTiet { get => btnChiTiet; set => btnChiTiet = value; }
        public Label LblTienTrinh { get => lblTienTrinh; set => lblTienTrinh = value; }
        public string MaLV { get => maLV; set => maLV = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaNguoiTao { get => maNguoiTao; set => maNguoiTao = value; }
        public string MaUser { get => mssvLogin; set => mssvLogin = value; }
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            FChinhSuaTask task = new FChinhSuaTask(MaNV, maNguoiTao);
            task.ShowDialog();
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FCapNhatTienTrinh fCapNhatTienTrinh = new FCapNhatTienTrinh(maNV, mssvLogin);
            fCapNhatTienTrinh.ShowDialog();
        }

        private void UCTask_SV_Load(object sender, EventArgs e)
        {

        }
    }
}

