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
        private Person gv;
        GiangVienDAO luanvan;
        private string query = "";
        
        public FLuanVanCuaToi_GV()
        {
            InitializeComponent();
        }
        public FLuanVanCuaToi_GV(Person gv) :this()
        {
            this.gv = gv;
            this.luanvan = new GiangVienDAO();
            this.query = luanvan.LoadMyTheses(gv.getMaso());
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
            FThemLuanVan fThemLuanVan = new FThemLuanVan(gv.getMaso());
            if (fThemLuanVan.ShowDialog() == DialogResult.OK)
            {
                LoadDSLuanVan();
            }
        }

        private void ChonTinhTrang(object sender, EventArgs e)
        {
            query = luanvan.LoadMyTheses(gv.getMaso());
            string text = cbboxTrangThai.SelectedItem.ToString();
            if (text != "Tất cả")
            {
                query += $" AND LuanVan.TrangThai = N'{text}'";
            }
            LoadDSLuanVan();
        }
    }
}
