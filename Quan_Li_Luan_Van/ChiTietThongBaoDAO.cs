using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class ChiTietThongBaoDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        ThongBao tb = new ThongBao();
        public ThongBao noiDungTB(string maTB)
        {
            string query = "SELECT ID_TB, TieuDe, ThoiGian, NoiDung, TenGV " +
                    "FROM ThongBao INNER JOIN LuanVan ON LuanVan.MaLV = ThongBao.MaLV " +
                    "INNER JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                     "WHERE ID_TB = N'" + maTB + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    tb.TieuDe = dataReader["TieuDe"].ToString();
                    tb.ThoiGian = dataReader["ThoiGian"].ToString();
                    tb.NoiDung = dataReader["NoiDung"].ToString();
                    tb.TieuDe = dataReader["TieuDe"].ToString();
                    tb.NguoiGui = dataReader["TenGV"].ToString();
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
            return tb;
        }
    }
}
