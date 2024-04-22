using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    internal class ChiTietTaskDao
    {
        private string maNV;
        
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection connection = new DBConnection();
        
        string query;
        public ChiTietTaskDao(string maNV)
        {
            this.maNV = maNV;
        }

        public NhiemVu GetTask(string maNV)
        {
            NhiemVu nhiemvu = new NhiemVu();
            query = "SELECT * FROM NhiemVu " +
                           " WHERE MaNV  = N'"+ maNV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                { 
                    nhiemvu.TenNV= dataReader["TenNV"].ToString();
                    nhiemvu.TienTrinh = dataReader["TienTrinh"].GetHashCode();
                    nhiemvu.NoiDung = dataReader["NoiDung"].ToString();
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
            return nhiemvu;
        }
    }
}
