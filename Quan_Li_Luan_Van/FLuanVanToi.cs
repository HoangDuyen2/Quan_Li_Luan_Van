using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Quan_Li_Luan_Van
{
    public partial class FLuanVanToi : Form
    {
        
        private string baseQuery = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                                   "FROM LuanVan " +
                                   "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                                   "WHERE LuanVan.MaGV = 'GV001'";
        private string query;

        LuanVanToiDAO luanvan = new LuanVanToiDAO();
        public FLuanVanToi()
        {
            InitializeComponent();
        }

        private void FLuanVanToi_Load(object sender, EventArgs e)
        {
            luanvan.getInfo(baseQuery, flPanelDSLV);
        }
        private void LoadListUC ()
        {
            luanvan.getInfo(query, flPanelDSLV);
        }
        private void btnThemLuanVan_Click(object sender, EventArgs e)
        {
            FThemLuanVan fThemLuanVan = new FThemLuanVan("GV001");
            fThemLuanVan.ShowDialog();
        }

        private void ChonTinhTrang(object sender, EventArgs e)
        {
            query = baseQuery;
            string text = cbboxTrangThai.SelectedItem.ToString();
            if (text != "Tất cả")
            {
                string chuyenNganh = " AND LuanVan.TrangThai =N'" + text + "'";
                query = query + chuyenNganh;
            }
            LoadListUC();
        }
    }
}
