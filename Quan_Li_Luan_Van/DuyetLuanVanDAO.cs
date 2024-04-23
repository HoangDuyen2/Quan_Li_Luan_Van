using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Quan_Li_Luan_Van
{
    public class DuyetLuanVanDAO
    {
        private string maGV;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection connection = new DBConnection();
        string quenry;
        public DuyetLuanVanDAO() { }
        public DuyetLuanVanDAO(string maGV)
        {
            this.MaGV = maGV;
            this.quenry = $"SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, DuyetDangKy.TinhTrang " +
                          $"FROM LuanVan JOIN DuyetDangKy ON " +
                          $"LuanVan.MaLV = DuyetDangKy.MaLV and LuanVan.MaGV = '{maGV}'";
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
                    UCDuyet ucd = new UCDuyet();

                    ucd.LbTenLV.Text = dataReader["TenLV"].ToString();
                    ucd.LbChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    if (dataReader["TinhTrang"].ToString() == "Đang chờ duyệt")
                        ucd.LBTrangThai.ForeColor = System.Drawing.Color.Green;
                    if (dataReader["TinhTrang"].ToString() == "Từ chối")
                        ucd.LBTrangThai.ForeColor = System.Drawing.Color.Black;
                    if (dataReader["TinhTrang"].ToString() == "Đã duyệt")
                        ucd.LBTrangThai.ForeColor = System.Drawing.Color.Red;
                    ucd.LBTrangThai.Text = dataReader["TinhTrang"].ToString();
                    panel.Controls.Add(ucd);
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
        public void ChapNhan(LuanVanDuyet luanVan)
        {
            string query = string.Format("UPDATE DuyetDangKy SET TinhTrang = N'{0}' WHERE MaLV = '{1}'", "Đã duyệt", luanVan.MaLV);
            string query1 = string.Format("UPDATE LuanVan SET TrangThai = N'{0}' WHERE MaLV = '{1}'", "Đã có nhóm", luanVan.MaLV);
            string query2;
            if (luanVan.MSSV31 == "")
            {
                query2 = string.Format("INSERT INTO DSThanhVien (MaLV, MSSV1, MSSV2, MSSV3) " + "VALUES ('{0}','{1}','{2}',NULL)",
                luanVan.MaLV, luanVan.MSSV11, luanVan.MSSV21);
            }
            else
            {
                query2 = string.Format("INSERT INTO DSThanhVien (MaLV, MSSV1, MSSV2, MSSV3) " + "VALUES ('{0}','{1}','{2}','{3}')",
                luanVan.MaLV, luanVan.MSSV11, luanVan.MSSV21, luanVan.MSSV31);
            }
            connection.ThucThi(query);
            connection.ThucThi(query1);
            connection.ThucThi(query2);
        }
        public void TuChoi(LuanVanDuyet luanVan)
        {
            string query1 = string.Format("DELETE FROM DSThanhVien WHERE MaLV = '{0}'", luanVan.MaLV);
            string query2 = string.Format("UPDATE LuanVan SET TrangThai = N'{0}' WHERE MaLV = '{1}'", "Chưa có nhóm", luanVan.MaLV);
            string query = string.Format("UPDATE DuyetDangKy SET TinhTrang = N'{0}' WHERE MaLV = '{1}'", "Từ chối", luanVan.MaLV);
            connection.ThucThi(query);
            connection.ThucThi(query1);
            connection.ThucThi(query2);
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
