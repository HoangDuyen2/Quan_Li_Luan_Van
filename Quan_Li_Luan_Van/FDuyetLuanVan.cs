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
        private string maGV;
        private DuyetLuanVanDAO duyetLuanVan;
        private string query = "";

        public FDuyetLuanVan()
        {
            InitializeComponent();
        }

        public FDuyetLuanVan(string maGV) : this()
        {
            this.maGV = maGV;
            this.duyetLuanVan = new DuyetLuanVanDAO(this.maGV);
            this.query = duyetLuanVan.Load();
        }

        private void FDuyetLuanVan_Load(object sender, EventArgs e)
        {
            
            LoadData();
        }

        private void LoadData()
        {
            if (!string.IsNullOrEmpty(query))
            {
                duyetLuanVan.getInfo(query, flPanelDSLV);
            }
        }

        private void Chon_Tinh_Trang(object sender, EventArgs e)
        {
            
        }

        private void cbbLoaiTraCuu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiTraCuu.SelectedItem != null)
            {
                string text = cbbLoaiTraCuu.SelectedItem.ToString();
                query = duyetLuanVan.traCuu(text);
                LoadData();
            }
        }
    }
}
