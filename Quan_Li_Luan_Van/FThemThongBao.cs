using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FThemThongBao : Form
    {
        private string maLV;
        GiangVienDAO GiaoVienDAO = new GiangVienDAO();
        public FThemThongBao()
        {
            InitializeComponent();
        }

        public FThemThongBao(string maLV) :this()
        {
            this.maLV = maLV;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            ThongBao tb = TaoThongBao();
            if (!tb.checkNullThongBao())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                GiaoVienDAO.ThemThongBao(tb);
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private ThongBao TaoThongBao()
        {
            string tieuDe = cbboxTieuDe.SelectedItem != null ? cbboxTieuDe.SelectedItem.ToString() : "";
            string noiDung = txtNoiDungTB.Text;
            DateTime thoiGian = DateTime.Now;
            string chuoiThoiGian = thoiGian.ToString("yyyy-MM-dd HH:mm:ss");

            return new ThongBao(tieuDe, noiDung, chuoiThoiGian, maLV);
        }
    }
}
