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
        string quenry;
        string query = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                                   "FROM LuanVan " +
                                   "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV ";
        public FDanhSachLuanVan()
        {
            InitializeComponent();
            txtTenGV.Enter += TxtTenGV_GetFocus;
            txtTenGV.LostFocus += TxtTenGV_LostFocus;
            quenry = query;
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
            if (text != "Tất cả")
            {
                string chuyenNganh = "WHERE LuanVan.ChuyenNganh = N'" + text + "'";
                quenry = query + chuyenNganh;
            }
            else quenry = query;
            TraCuu_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTenGV.Text != "")
            {
                string tenGV = "WHERE GiangVien.TenGV = N'" + txtTenGV.Text + "'";
                quenry = query + tenGV;
            }
            else quenry = query;
            TraCuu_Load(sender, e);
        }
    }
}
