using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FThemLuanVan : Form
    {
        private string maGiangVien;
        Hide_Show hide_Show = new Hide_Show();
        ThemLuanVanDAO lvDao = new ThemLuanVanDAO();

        public FThemLuanVan()
        {
            InitializeComponent();
            txtMaLuanVan.Enter += TxtMaLuanVan_GetFocus;
            txtMaLuanVan.LostFocus += TxtMaLuanVan_LostFocus;
            txtTenLuanVan.Enter += TxtTenLuanVan_GetFocus;
            txtTenLuanVan.LostFocus += TxtTenLuanVan_LostFocus;
            txtChucNang.Enter += TxtChucNang_GetFocus;
            txtChucNang.LostFocus += TxtChucNang_LostFocus;
            txtYeuCau.Enter += TxtYeuCau_GetFocus;
            txtYeuCau.LostFocus += TxtYeuCau_LostFocus;
        }

        public FThemLuanVan(string maGV) : this()
        {
            maGiangVien = maGV;
        }

        private void FThemLuanVan_Load(object sender, EventArgs e)
        {
            
        }

        private void TxtMaLuanVan_GetFocus(object sender, EventArgs e)
        {
            hide_Show.Hide(sender, e);
        }

        private void TxtMaLuanVan_LostFocus(object sender, EventArgs e)
        {
            hide_Show.Show(sender, e);
        }

        private void TxtTenLuanVan_GetFocus(object sender, EventArgs e)
        {
            hide_Show.Hide(sender, e);
        }

        private void TxtTenLuanVan_LostFocus(object sender, EventArgs e)
        {
            hide_Show.Show(sender, e);
        }

        private void TxtChucNang_GetFocus(object sender, EventArgs e)
        {
            hide_Show.Hide(sender, e);
        }

        private void TxtChucNang_LostFocus(object sender, EventArgs e)
        {
            hide_Show.Show(sender, e);
        }

        private void TxtYeuCau_GetFocus(object sender, EventArgs e)
        {
            hide_Show.Hide(sender, e);
        }

        private void TxtYeuCau_LostFocus(object sender, EventArgs e)
        {
            hide_Show.Show(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LuanVan lv = TaoLuanVan();
            if (lv.KiemTraNull())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                lvDao.ThemLuanVan(lv);
                MessageBox.Show("Thêm thành công");
                this.Hide();
            }
        }
        private LuanVan TaoLuanVan()
        {
            string maLuanVan = txtMaLuanVan.Text;
            string tenLuanVan = txtTenLuanVan.Text;
            string chuyenNganh = cbboxChuyenNganh.SelectedItem != null ? cbboxChuyenNganh.SelectedItem.ToString() : "";
            string linhVuc = cbboxLinhVuc.SelectedItem != null ? cbboxLinhVuc.SelectedItem.ToString() : "";
            string chucNang = txtChucNang.Text;
            string congNghe = cbboxCongNghe.SelectedItem != null ? cbboxCongNghe.SelectedItem.ToString() : "";
            string ngonNgu = cbboxNgonNgu.SelectedItem != null ? cbboxNgonNgu.SelectedItem.ToString() : "";
            string yeuCau = txtYeuCau.Text;

            return new LuanVan(maLuanVan, tenLuanVan, maGiangVien, chuyenNganh, linhVuc, chucNang, congNghe, ngonNgu, yeuCau, "Chưa có nhóm");
        }

    }
}
