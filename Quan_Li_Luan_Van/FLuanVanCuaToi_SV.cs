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
    public partial class FLuanVanCuaToi_SV : Form
    {
        SinhVien sinhVien = null;
        SinhVienDAO luanVan = new SinhVienDAO();
        public FLuanVanCuaToi_SV(SinhVien sinhVien)
        {
            InitializeComponent();
            this.sinhVien = sinhVien;
        }

        private void FLuanVanToi_SV_Load(object sender, EventArgs e)
        {
            string maLV = luanVan.getMaLV(sinhVien.getMaso());
            if (maLV != null)
            {
                luanVan.ShowData(flPanelDSTask, luanVan.LoadLVCT(maLV),sinhVien.getMaso());
            }
            else MessageBox.Show("Sinh viên hiện chưa tham gia vào luận văn nào. Vui lòng đăng kí luận văn trước", "Thông báo");
        }

        private void btnThemNhiemVu_Click(object sender, EventArgs e)
        {
            FThemNhiemVu fThemNhiemVu = new FThemNhiemVu(luanVan.getMaLV(sinhVien.getMaso()), sinhVien.getMaso());
            fThemNhiemVu.ShowDialog();
            FLuanVanToi_SV_Load(sender, e);
        }
    }
}
