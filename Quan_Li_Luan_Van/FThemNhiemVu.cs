using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FThemNhiemVu : Form
    {
        private static int countNV = 0; 
        private string tenLV;
        TienTrinh_GVDAO nvDAO = new TienTrinh_GVDAO();

        public FThemNhiemVu()
        {
            InitializeComponent();
        }

        public FThemNhiemVu(string tenLV) : this()
        {
            this.tenLV = tenLV;
        }

        private void FThemNhiemVu_Load(object sender, EventArgs e)
        {
            
        }

        private NhiemVu ThemNhiemVu()
        {
            string maNV = "NV" + countNV.ToString().PadLeft(5, '0'); 
            string tenNV = txtTenNV.ToString();
            string noiDung = txtNoiDungNV.ToString();
            string maLV = "LV001";
            return new NhiemVu(maNV, tenNV, noiDung, 0, "Chưa hoàn thành", maLV);
        }
    }
}
