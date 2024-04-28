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
        Person personChinh = null;
        SinhVienDAO sVDAO = new SinhVienDAO();
        string maLV = "";

        public FTrangChu(Person person)
        {
            InitializeComponent();
            txtTimkiem.Enter += TxtTimKiem_GetFocus;
            txtTimkiem.LostFocus += TxtTimKiem_LostFocus;
            personChinh = person;
            maLV = sVDAO.getMaLV(personChinh.getMaso());
        }
        private void FTrangChu_Load(object sender, EventArgs e)
        {
            sVDAO.LoadDSTB(flpanelDSThongBao, sVDAO.Load(maLV));
        }
        private void TxtTimKiem_GetFocus(object sender, EventArgs e)
        {
            hide_Show.Hide(sender, e);
        }

        private void TxtTimKiem_LostFocus(object sender, EventArgs e)
        {
            hide_Show.Show(sender, e);
        }

        private void btnThemThongBao_Click(object sender, EventArgs e)
        {
            FThemThongBao tb = new FThemThongBao();
            tb.ShowDialog();

        }

        private void dtNgayThang_ValueChanged(object sender, EventArgs e)
        {
            sVDAO.LoadDSTB(flpanelDSThongBao, sVDAO.Load(maLV)+sVDAO.TraCuuNgay(dtNgayThang.Value));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            sVDAO.LoadDSTB(flpanelDSThongBao, sVDAO.Load(maLV) + sVDAO.traCuuTheoNoiDung(txtTimkiem.Text));
        }
    }
}
