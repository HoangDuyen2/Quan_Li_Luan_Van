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
        private string maGV;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection connection = new DBConnection();
        private string query;
        public DSNhomDAO() { }

        public DSNhomDAO(string maGV)
        {
            this.maGV = maGV;
            this.query = $"SELECT LuanVan.MaLV, LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                    $"FROM LuanVan " +
                    $"JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                    $"WHERE LuanVan.MaGV = '{maGV}'" + " AND LuanVan.TrangThai = N'Đã có nhóm'";
        }
        public string Load()
        {
            return query;
        }
        public string MaGV { get => maGV; set => maGV = value; }
        public void LoadDSNhom(string query, FlowLayoutPanel panel,string maGV)
        {           
            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCNhom uclv = new UCNhom();
                    uclv.MaGV = maGV;
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
