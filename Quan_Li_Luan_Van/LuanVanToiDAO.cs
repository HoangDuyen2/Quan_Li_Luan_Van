using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    internal class LuanVanToiDAO
    {
        private string maGV;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection connection = new DBConnection();
        string quenry;
        public LuanVanToiDAO() { }
        public LuanVanToiDAO(string maGV)
        {
            this.maGV = maGV;
            this.quenry =  $"SELECT LuanVan.MaLV, LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                $"FROM LuanVan JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                $"WHERE LuanVan.MaGV = '{maGV}'";
        }
        public string MaGV { get => maGV; set => maGV = value; }
        public string Load()
        {
            return quenry;
        }
        public void getInfo(string query, FlowLayoutPanel panel)
        {
            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCLVCuaToi uclv  = new UCLVCuaToi();
                    uclv.MaGV = MaGV;
                    uclv.MaLV = dataReader["MaLV"].ToString();
                    uclv.LblTenLV.Text = dataReader["TenLV"].ToString();
                    uclv.LblChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    uclv.LblTrangThai.Text = dataReader["TrangThai"].ToString();
                    if (uclv.LblTrangThai.Text == "Đã có nhóm")
                    {
                        uclv.BtnDelete.Enabled = false;
                    }
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
        public string traCuu(string text)
        {
            string query = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, DuyetDangKy.TinhTrang " +
           "FROM LuanVan " +
           "JOIN DuyetDangKy ON LuanVan.MaLV = DuyetDangKy.MaLV and LuanVan.MaGV = '" + MaGV + "'";
            if (text != "Tất cả")
            {
                string tracuu = "WHERE TinhTrang = N'" + text + "'";
                quenry = query + tracuu;
            }
            else quenry = query;
            connection.ThucThi(quenry);
            return quenry;
        }    
    }
}
