using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class SinhVienDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection dbConnection = new DBConnection();
        #region Load Form Trang chủ
        string queryTrangChu = "SELECT * " +
                    "FROM ThongBao ";
        public string getMaLV(string MSSV)
        {
            string maLV = "";
            string sqlStr = string.Format("SELECT * FROM DSThanhVien WHERE MSSV1 = '{0}' OR MSSV2 = '{1}' OR MSSV3 = '{2}'", MSSV, MSSV, MSSV);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    maLV = reader["MaLV"].ToString();
                    return maLV;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy mã luận văn: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return maLV;
        }
        public void LoadDSTB(FlowLayoutPanel panel, string truyVan)
        {
            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCThongBao uctb = new UCThongBao();
                    uctb.LblTieuDe.Text = dataReader["TieuDe"].ToString();
                    uctb.LbNoiDungTB.Text = dataReader["NoiDung"].ToString();
                    uctb.LblThoiGian.Text = dataReader["ThoiGian"].ToString();
                    uctb.ID_TB1 = dataReader["ID_TB"].ToString();
                    panel.Controls.Add(uctb);
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

        public string traCuuTheoNoiDung(string noidung)
        {
            if (!string.IsNullOrEmpty(noidung))
            {
                string tracuu = " and NoiDung LIKE N'%" + noidung + "%'";
                return tracuu;
            }
            return "";
        }

        public string TraCuuNgay(DateTime date)
        {
            if (date != DateTime.MinValue)
            {
                string tracuu = " AND CAST(ThoiGian AS date) = '" + date.ToString("MM-dd-yyyy") + "'";
                return tracuu;
            }
            return "";
        }
        public string Load(string maLV)
        {
            string sql = " WHERE MaLV = '" + maLV + "'";
            return queryTrangChu + sql;
        }
        #endregion
        #region Load form đăng kí luận văn
        string queryDKLV = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai, LuanVan.MaLV " +
                                   "FROM LuanVan " +
                                   "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                                   "WHERE LuanVan.TrangThai = N'Chưa có nhóm' ";
        public void DangKy(LuanVanDuyet luanVan)
        {
            string query1;
            if (luanVan.MSSV31 == "")
            {
                query1 = string.Format("INSERT INTO DuyetDangKy (MaLV, MSSV1, MSSV2, MSSV3, TinhTrang) " + "VALUES ('{0}','{1}','{2}',NULL,N'Đang chờ duyệt')",
                luanVan.MaLV, luanVan.MSSV11, luanVan.MSSV21);
            }
            else
            {
                query1 = string.Format("INSERT INTO DuyetDangKy (MaLV, MSSV1, MSSV2, MSSV3, TinhTrang) " + "VALUES ('{0}','{1}','{2}','{3}',N'Đang chờ duyệt')",
                luanVan.MaLV, luanVan.MSSV11, luanVan.MSSV21, luanVan.MSSV31);
            }
            dbConnection.ThucThi(query1);
        }
        public string traCuuTenGV(string tenGV)
        {
            if (tenGV != "")
            {
                string tracuu = " and TenGV LIKE N'%" + tenGV + "%'";
                return queryDKLV + tracuu;
            }
            return queryDKLV;
        }
        public string LoadDKLV()
        {
            return queryDKLV;
        }
        public void Load_UC_Con(FlowLayoutPanel flPanelDSLV, string truyVan, Person person)
        {

            try
            {
                conn.Open();
                flPanelDSLV.Controls.Clear();
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCLV uclv = new UCLV(person);
                    uclv.MaLV = dataReader["MaLV"].ToString();
                    uclv.LblTenLV.Text = dataReader["TenLV"].ToString();
                    uclv.LblChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    uclv.LblTenGV.Text = dataReader["TenGV"].ToString();
                    uclv.LblTrangThai.Text = dataReader["TrangThai"].ToString();

                    flPanelDSLV.Controls.Add(uclv);
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
        public string TraCuuChuyenNganh(string chuyenNganh)
        {
            if (chuyenNganh != "Tất cả")
            {
                string tracuu = " and ChuyenNganh = N'" + chuyenNganh + "'";
                return queryDKLV + tracuu;
            }
            return queryDKLV;
        }
        public bool checkTungNguoiDangKy(string MSSV)
        {

            string sqlStr = string.Format("SELECT * FROM DSThanhVien WHERE MSSV1 = '{0}' OR MSSV2 = '{1}' OR MSSV3 = '{2}'", MSSV, MSSV, MSSV);
            if (KiemTra(sqlStr))
            {
                return true;
            }
            string sqlStr3 = string.Format("SELECT * FROM DuyetDangKy WHERE MSSV1 = '{0}' OR MSSV2 = '{1}' OR MSSV3 = '{2}' AND TinhTrang = N'Đang chờ duyệt'", MSSV, MSSV, MSSV);
            if (KiemTra(sqlStr3))
            {
                return true;
            }
            return false;
        }
        public bool checkNguoiDangKy(LuanVanDuyet luanVan)
        {
            if (luanVan.MSSV11 != "")
            {
                if (checkTungNguoiDangKy(luanVan.MSSV11))
                {
                    MessageBox.Show("MSSV1 đã có nhóm");
                    return false;
                }
            }
            if (luanVan.MSSV21 != "")
            {
                if (checkTungNguoiDangKy(luanVan.MSSV21))
                {
                    MessageBox.Show("MSSV2 đã có nhóm");
                    return false;
                }
            }
            if (luanVan.MSSV31 != "")
            {
                if (checkTungNguoiDangKy(luanVan.MSSV31))
                {
                    MessageBox.Show("MSSV3 đã có nhóm");
                    return false;
                }
            }
            return true;
        }
        public bool KiemTra(string sqlStr)
        {
            bool check = true;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlStr, conn);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return check;
        }
        #endregion
        #region Form luận văn của tôi
        public string LoadLVCT(string maLV)
        {
            if (maLV != "")
            {
                string quenry = "SELECT LuanVan.MaLV, NhiemVu.TenNV, NhiemVu.TienTrinh, NhiemVu.MaNV, NhiemVu.MaNguoiTao " +
                         "FROM NhiemVu, LuanVan " +
                         "WHERE NhiemVu.MaLV = LuanVan.MaLV AND LuanVan.MaLV = '" + maLV + "'";
                return quenry;
            }
            return "";
        }
        public void ShowData(FlowLayoutPanel panel, string truyVan, string User)
        {
            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCTask_SV task = new UCTask_SV();
                    task.MaUser = User;
                    task.MaNV = dataReader["MaNV"].ToString();
                    task.MaNguoiTao = dataReader["MaNguoiTao"].ToString();
                    task.LblTenNV.Text = dataReader["TenNV"].ToString();
                    task.LblTienTrinh.Text = dataReader["TienTrinh"].ToString();
                    panel.Controls.Add(task);
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
        public string GetTenSV(string MSSV)
        {
            string tenSV = "";
            string query = "SELECT TenSV FROM SinhVien WHERE MSSV = @MSSV";
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MSSV", MSSV);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tenSV = reader["TenSV"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy tên giảng viên: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return tenSV;
        }
        public void ThemPhanHoi(PhanHoi ph)
        {
            string query = string.Format("INSERT INTO PhanHoi(TenNguoiGui, ThoiGianGui, NoiDung, MaNV) VALUES (N'{0}', N'{1}', N'{2}', '{3}')", ph.Name, ph.Thoigian, ph.Noidung, ph.NhiemVu);
            dbConnection.ThucThi(query);
        }
        #endregion
    }
}
