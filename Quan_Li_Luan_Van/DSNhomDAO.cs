using ComponentFactory.Krypton.Navigator;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    internal class DSNhomDAO
    {
        protected SqlConnection conn;
        public DSNhomDAO()
        {
            conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        }
        public void LoadDSNhom( FlowLayoutPanel panel)
        {
            string query = "SELECT LuanVan.MaLV, LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                    "FROM LuanVan " +
                    "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                    "WHERE LuanVan.MaGV = 'GV001'" + " AND LuanVan.TrangThai = N'Đã có nhóm'";

            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCNhom uclv = new UCNhom();
                    uclv.MaLV = dataReader["MaLV"].ToString();
                    uclv.LblTenLV.Text = dataReader["TenLV"].ToString();
                    uclv.LblChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    panel.Controls.Add(uclv);
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
