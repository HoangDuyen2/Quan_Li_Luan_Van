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
    public partial class FDuyetLuanVan : Form
    {
        DuyetLuanVanDAO duyetLuanVan = new DuyetLuanVanDAO();
        string quenry;
        string query = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, DuyetDangKy.TinhTrang " +
                                   "FROM LuanVan " +
                                   "JOIN DuyetDangKy ON LuanVan.MaLV = DuyetDangKy.MaLV ";
        public FDuyetLuanVan()
        {
            InitializeComponent();
            quenry = query;
        }


        private void FDuyetLuanVan_Load(object sender, EventArgs e)
        {
            duyetLuanVan.getInfo(quenry, flPanelDSLV);
        }

        private void Chon_Tinh_Trang(object sender, EventArgs e)
        {
            string text = comboxLoaiTraCuu.SelectedItem.ToString();
            if (text != "Tất cả")
            {
                string tracuu = "WHERE TinhTrang = N'" + text + "'";
                quenry = query + tracuu;
            }
            else quenry = query;
            FDuyetLuanVan_Load(sender, e);
        }
    }
}
