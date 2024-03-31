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
        string quenry = "";
        public FDuyetLuanVan()
        {
            InitializeComponent();
            quenry = duyetLuanVan.Load();
        }

        private void FDuyetLuanVan_Load(object sender, EventArgs e)
        {
            duyetLuanVan.getInfo(quenry, flPanelDSLV);
        }

        private void Chon_Tinh_Trang(object sender, EventArgs e)
        {
            string text = comboxLoaiTraCuu.SelectedItem.ToString();
            quenry = duyetLuanVan.traCuu(text);
            FDuyetLuanVan_Load(sender, e);
        }
    }
}
