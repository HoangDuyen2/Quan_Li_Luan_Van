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
    public partial class FLuanVanCuaToi_GV : Form
    {
        private string maGV;
        GiangVienDAO luanvan;
        private string query = "";
        
        public FLuanVanCuaToi_GV()
        {
            InitializeComponent();
        }
        public FLuanVanCuaToi_GV(string maGV) :this()
        {
            this.maGV = maGV;
            this.luanvan = new GiangVienDAO();
            this.query = luanvan.LoadMyTheses(maGV);
        }


        private void FLuanVanToi_Load(object sender, EventArgs e)
        {
            luanvan.GetMyThesesInfo(query, flPanelDSLV);
        }

        private void LoadDSLuanVan()
        {
            luanvan.GetMyThesesInfo(query, flPanelDSLV);
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
            query = luanvan.LoadMyTheses(maGV);
            string text = cbboxTrangThai.SelectedItem.ToString();
            if (text != "Tất cả")
            {
                query += $" AND LuanVan.TrangThai = N'{text}'";
            }
            LoadDSLuanVan();
        }
    }
}
