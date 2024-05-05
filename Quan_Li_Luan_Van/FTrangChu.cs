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
    public partial class FTrangChu : Form
    {
        Hide_Show hide_Show = new Hide_Show();
        SinhVien sinhVien = null;
        SinhVienDAO sVDAO = new SinhVienDAO();
        string maLV = "";

        public FTrangChu(SinhVien sinhvien)
        {
            InitializeComponent();
            txtTimkiem.Enter += TxtTimKiem_GetFocus;
            txtTimkiem.LostFocus += TxtTimKiem_LostFocus;
            this.sinhVien = sinhvien;
        }
        private void FTrangChu_Load(object sender, EventArgs e)
        {
            if (sVDAO.getMaLVCuaToi(sinhVien.getMaso()) == "")
            {
                MessageBox.Show("Hiện bạn chưa tham gia bất kì một luận văn nào. Hãy tham gia luận văn để nhận các thông báo từ giảng viên", "Thông báo");
            }
            else maLV = sVDAO.getMaLVCuaToi(sinhVien.getMaso());
            sVDAO.LoadDSTB(flpanelDSThongBao, sVDAO.LoadTrangChu(maLV));
        }
        private void TxtTimKiem_GetFocus(object sender, EventArgs e)
        {
            hide_Show.Hide(sender, e);
        }
        private void TxtTimKiem_LostFocus(object sender, EventArgs e)
        {
            hide_Show.Show(sender, e);
        }
        private void dtNgayThang_ValueChanged(object sender, EventArgs e)
        {
            sVDAO.LoadDSTB(flpanelDSThongBao, sVDAO.LoadTrangChu(maLV)+sVDAO.TraCuuNgay(dtNgayThang.Value));
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            sVDAO.LoadDSTB(flpanelDSThongBao, sVDAO.LoadTrangChu(maLV) + sVDAO.traCuuTheoNoiDung(txtTimkiem.Text));
        }

    }

}
