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
using static System.Net.Mime.MediaTypeNames;

namespace Quan_Li_Luan_Van
{
    public partial class FDanhSachLuanVan : Form
    {
        Hide_Show hide_Show = new Hide_Show();
        GiangVienDAO dSLuanVan = new GiangVienDAO();
        public FDanhSachLuanVan()
        {
            InitializeComponent();
            txtTenGV.Enter += TxtTenGV_GetFocus;
            txtTenGV.LostFocus += TxtTenGV_LostFocus;
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
            dSLuanVan.getInfo(dSLuanVan.Load(),flPanelDSLV);
        }

        private void ChonChuyenNganh(object sender, EventArgs e)
        {
            string text = comboxChuyenNganh.SelectedItem.ToString();
            dSLuanVan.getInfo(dSLuanVan.chonChuyenNganh(text), flPanelDSLV);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dSLuanVan.getInfo(dSLuanVan.timKiem(txtTenGV.Text), flPanelDSLV);
        }

    }

}
