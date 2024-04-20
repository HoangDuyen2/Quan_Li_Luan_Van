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
        Person personChinh = null;
        TrangChuSVDAO sVDAO = new TrangChuSVDAO();
        string maLV = "";

        public FTrangChu(Person person)
        {
            InitializeComponent();
            personChinh = person;
            maLV = sVDAO.getMaLV(personChinh.getMaso());
        }
        private void FTrangChu_Load(object sender, EventArgs e)
        {
            sVDAO.LoadDSTB(flpanelDSThongBao, sVDAO.Load(maLV));
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
