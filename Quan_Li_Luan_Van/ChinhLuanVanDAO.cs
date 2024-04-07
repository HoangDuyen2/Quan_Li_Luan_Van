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
        LuanVan sualv = new LuanVan();
        public ChinhLuanVanDAO()
        {
            conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            dbConnection = new DBConnection();
        }

        public LuanVan getLuanVan(string maLV)
        {
            string query = "SELECT * " +
                           "FROM LuanVan " +            
                           "WHERE MaLV = N'" + maLV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    
                    sualv.MaLV = dataReader["MaLV"].ToString();
                    sualv.TenLV = dataReader["TenLV"].ToString();
                    sualv.ChuyenNganh = dataReader["ChuyenNganh"].ToString();
                    sualv.ChucNang = dataReader["ChucNang"].ToString();
                    sualv.YeuCau = dataReader["YeuCau"].ToString();
                    sualv.ChuyenNganh = dataReader["ChuyenNganh"].ToString();
                    sualv.CongNghe = dataReader["CongNghe"].ToString();
                    sualv.LinhVuc = dataReader["LinhVuc"].ToString();
                    sualv.NgonNgu = dataReader["NgonNgu"].ToString();
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
            return sualv;
        }
        public void ChinhSua(LuanVan luanvan, string maLV)
        {
            string query = string.Format("UPDATE LuanVan SET TenLV = N'{0}', ChuyenNganh = N'{1}', ChucNang = N'{2}', YeuCau = N'{3}', CongNghe = N'{4}', LinhVuc = N'{5}', NgonNgu = N'{6}' WHERE MaLV = '{7}'",
            luanvan.TenLV, luanvan.ChuyenNganh, luanvan.ChucNang, luanvan.YeuCau, luanvan.CongNghe, luanvan.LinhVuc, luanvan.NgonNgu, luanvan.MaLV );
            dbConnection.ThucThi(query);
        }

    }
}
