using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    internal class TienTrinh_GVDAO
    {
        protected SqlConnection conn;
        public TienTrinh_GVDAO()
        {
            conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        }
        public void getInfo(string maLV, FlowLayoutPanel panel)
        {
            string query = "SELECT * " +
                    "FROM NhiemVu " +
                    "JOIN LuanVan ON NhiemVu.MaLV = LuanVan.MaLV " +
                     "WHERE  NhiemVu.MaLV = N'" + maLV + "'";

            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCTask uctask = new UCTask();
                    uctask.MaLV = maLV;
                    uctask.LblTenNV.Text = dataReader["TenNV"].ToString();
                    uctask.LblTienTrinh.Text = dataReader["TienTrinh"].ToString();
                    panel.Controls.Add(uctask);
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
