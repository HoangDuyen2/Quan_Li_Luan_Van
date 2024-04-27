using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class GiangVienDAO
    {
        DBConnection dBConnection = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        string sqlQuery;
        public void ThemThongBao(ThongBao tb)
        {
            sqlQuery = string.Format("INSERT INTO ThongBao(TieuDe, NoiDung, ThoiGian, MaLV) VALUES (N'{0}', N'{1}', '{2}', '{3}')", tb.TieuDe, tb.NoiDung, tb.ThoiGian, tb.MaLV);
            dBConnection.ThucThi(sqlQuery);
        }
        #region Form Danh sách các luận văn
        string queryDSLV = "SELECT LuanVan.MaLV, LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                                   "FROM LuanVan " +
                                   "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV ";
        public string Load()
        {
            
            return queryDSLV;
        }
        public string chonChuyenNganh(string text)
        {
            if (text != "Tất cả")
            {
                string chuyenNganh = "WHERE LuanVan.ChuyenNganh = N'" + text + "'";
                return queryDSLV+chuyenNganh;
            }
            return queryDSLV;
        }
        public string timKiem(string text)
        {
            if (text != "")
            {
                string tenGV = "WHERE GiangVien.TenGV LIKE N'%" + text + "%'";
                return queryDSLV + tenGV;
            }
            return queryDSLV;
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
                    UCLV_GV uclv = new UCLV_GV();
                    uclv.MaLV = dataReader["MaLV"].ToString();
                    uclv.LblTenLV.Text = dataReader["TenLV"].ToString();
                    uclv.LblChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    uclv.LblTenGV.Text = dataReader["TenGV"].ToString();
                    if (dataReader["TrangThai"].ToString() == "Chưa có nhóm")
                        uclv.LblTrangThai.ForeColor = System.Drawing.Color.Green;
                    uclv.LblTrangThai.Text = dataReader["TrangThai"].ToString();

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
        #endregion
        #region Form Duyệt luận văn
        private string maGV;
        public string MaGV { get => maGV; set => maGV = value; }
        public string LoadDLV(string maGV)
        {
            MaGV = maGV;
            string quenry = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, DuyetDangKy.TinhTrang " +
                          "FROM LuanVan JOIN DuyetDangKy ON " +
                          "LuanVan.MaLV = DuyetDangKy.MaLV and LuanVan.MaGV = '" + maGV + "'";
            return quenry;
        }
        public void getInfoDLV(string query, FlowLayoutPanel panel)
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
            dBConnection.ThucThi(query);
            dBConnection.ThucThi(query1);
            dBConnection.ThucThi(query2);
        }
        public void TuChoi(LuanVanDuyet luanVan)
        {
            string query1 = string.Format("DELETE FROM DSThanhVien WHERE MaLV = '{0}'", luanVan.MaLV);
            string query2 = string.Format("UPDATE LuanVan SET TrangThai = N'{0}' WHERE MaLV = '{1}'", "Chưa có nhóm", luanVan.MaLV);
            string query = string.Format("UPDATE DuyetDangKy SET TinhTrang = N'{0}' WHERE MaLV = '{1}'", "Từ chối", luanVan.MaLV);
            dBConnection.ThucThi(query);
            dBConnection.ThucThi(query1);
            dBConnection.ThucThi(query2);
        }
        public string traCuu(string text, string quenry)
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
            dBConnection.ThucThi(quenry);
            return quenry;
        }
        #endregion
    }
}
