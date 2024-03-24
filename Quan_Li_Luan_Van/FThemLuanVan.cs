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
    public partial class FThemLuanVan : Form
    {
        private string maGiangVien;
        Hide_Show hide_Show = new Hide_Show();

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
    }
}
