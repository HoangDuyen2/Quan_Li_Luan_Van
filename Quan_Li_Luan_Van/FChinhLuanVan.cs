using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FChinhLuanVan : Form
    {
        private string tenLV;
        protected SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        ChinhLuanVanDAO lvDAO = new ChinhLuanVanDAO();
        LuanVan lv = new LuanVan();
        public FChinhLuanVan()
        {
            InitializeComponent();
        }

        public FChinhLuanVan(string tenLV) : this()
        {
            this.tenLV = tenLV;
        }

        private void FChinhSuaLuanVan_Load(object sender, EventArgs e)
        {
            
            lv = lvDAO.getLuanVan(tenLV);
            txtMaLuanVan.Text = lv.MaLV.ToString();
            txtTenLuanVan.Text = lv.TenLV.ToString();
            txtChucNang.Text = lv.ChucNang.ToString();
            txtYeuCau.Text = lv.YeuCau.ToString();
            cbboxChuyenNganh.SelectedItem = lv.ChuyenNganh;
            cbboxCongNghe.SelectedItem = lv.CongNghe;
            cbboxLinhVuc.SelectedItem = lv.LinhVuc;
            cbboxNgonNgu.SelectedItem = lv.NgonNgu;

        }
    }
}
