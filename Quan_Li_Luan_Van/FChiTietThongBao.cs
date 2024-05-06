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
    public partial class FChiTietThongBao : Form
    {
        private string ID_TB;
        SinhVienDAO cttb = new SinhVienDAO();
        public FChiTietThongBao(string ID)
        {
            InitializeComponent();
            ID_TB = ID;
        }

        private void FChiTietThongBao_Load(object sender, EventArgs e)
        {
            ThongBao tb = cttb.noiDungTB(ID_TB);
            txtNguoiGui.Text = tb.NguoiGui;
            txtNoiDungTB.Text = tb.NoiDung;
            txtTenTieuDe.Text = tb.TieuDe;
            txtThoiGian.Text = tb.ThoiGian;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
