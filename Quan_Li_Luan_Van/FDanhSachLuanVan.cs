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
    public partial class FDanhSachLuanVan : Form
    {
        Hide_Show hide_Show = new Hide_Show();
        DSLuanVanDAO dSLuanVan = new DSLuanVanDAO();
        string quenry = "";
        public FDanhSachLuanVan()
        {
            InitializeComponent();
            txtTenGV.Enter += TxtTenGV_GetFocus;
            txtTenGV.LostFocus += TxtTenGV_LostFocus;
            quenry = dSLuanVan.Load();
        } 
        private void TxtTenGV_GetFocus(object sender, EventArgs e)
        {
            hide_Show.Hide(sender,e);
        }

        private void TxtTenGV_LostFocus(object sender, EventArgs e)
        {
            hide_Show.Show(sender,e);
        }

        private void TraCuu_Load(object sender, EventArgs e)
        {
            dSLuanVan.getInfo(quenry,flPanelDSLV);
        }

        private void ChonChuyenNganh(object sender, EventArgs e)
        {
            string text = comboxChuyenNganh.SelectedItem.ToString();
            quenry = dSLuanVan.chonChuyenNganh(text);
            TraCuu_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            quenry = dSLuanVan.timKiem(txtTenGV.Text);
            TraCuu_Load(sender, e);
        }
    }
}
