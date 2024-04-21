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
        private string maGV;
        private LuanVanToiDAO luanvan;
        private string query = "";
        
        public FLuanVanToi()
        {
            InitializeComponent();
        }
        public FLuanVanToi(string maGV) :this()
        {
            this.maGV = maGV;
            this.luanvan = new LuanVanToiDAO(this.maGV);
            this.query = luanvan.Load();

        }


        private void FLuanVanToi_Load(object sender, EventArgs e)
        {
            luanvan.getInfo(query, flPanelDSLV);
        }
        private void LoadDSLuanVan()
        {
            luanvan.getInfo(query, flPanelDSLV);
        }
        private void btnThemLuanVan_Click(object sender, EventArgs e)
        {
            FThemLuanVan fThemLuanVan = new FThemLuanVan(maGV);
            if (fThemLuanVan.ShowDialog() == DialogResult.OK)
            {
                LoadDSLuanVan();
            }
        }

        private void ChonTinhTrang(object sender, EventArgs e)
        {
            query = luanvan.Load();
            string text = cbboxTrangThai.SelectedItem.ToString();
            if (text != "Tất cả")
            {
                string chuyenNganh = " AND LuanVan.TrangThai =N'" + text + "'";
                query = query + chuyenNganh;
            }
            LoadDSLuanVan();
        }
    }
}
