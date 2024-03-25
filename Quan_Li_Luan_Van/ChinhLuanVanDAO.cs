using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{

    internal class ChinhLuanVanDAO
    {
        protected SqlConnection conn;
        protected DBConnection dbConnection;
        public ChinhLuanVanDAO()
        {
            conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            dbConnection = new DBConnection();
        }

        public void getInfo(string tenLV)
        {
            string query = "SELECT * " +
                           "FROM LuanVan " +            
                           "WHERE TenLV = N'" + tenLV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    /*txtMaLuanVan.Text = dataReader["MaLV"].ToString();
                    txtTenLuanVan.Text = dataReader["TenLV"].ToString();
                    txtChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    txtGVHD.Text = dataReader["TenGV"].ToString();
                    txtMota.Text = dataReader["MoTaChiTiet"].ToString();
                    txtSoLuong.Text = dataReader["SoLuongConLai"].ToString();
                    */
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
