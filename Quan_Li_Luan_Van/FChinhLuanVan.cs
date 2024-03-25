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
        public FChinhLuanVan()
        {
            InitializeComponent();
        }

        public FChinhLuanVan(string tenLV)
        {
            this.tenLV = tenLV;
        }

        private void FChinhSuaLuanVan_Load(object sender, EventArgs e)
        {
            string query = "SELECT *" +
                           "FROM LuanVan " +                         
                           "WHERE TenLV = N'" + tenLV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    txtMaLuanVan.Text = dataReader["MaLV"].ToString();
                    txtTenLuanVan.Text = dataReader["TenLV"].ToString();
                    cbboxChuyenNganh.SelectedItem = dataReader["ChuyenNganh"].ToString();
                    cbboxCongNghe.SelectedItem = dataReader["CongNghe"].ToString();
                    txtChucNang.Text = dataReader["ChucNang"].ToString();
                    txtYeuCau.Text = dataReader["YeuCau"].ToString();
                    cbboxLinhVuc.SelectedItem = dataReader["LinhVuc"].ToString();
                    cbboxNgonNgu.SelectedItem = dataReader["NgonNgu"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
