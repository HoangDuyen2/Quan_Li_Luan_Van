using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class PersonDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection dBConnection = new DBConnection();

        #region Load label ở form FSinhVien và FGiangVien
        public Person LoadLabel(TaiKhoan taiKhoan)
        {
            string chucVu, ma;
            if (taiKhoan.getChucVu() == "Sinh viên")
            {
                chucVu = "SinhVien";
                ma = "MSSV";
            }
            else
            {
                chucVu = "GiangVien";
                ma = "MaGV";
            }
            string query = "SELECT * " +
                           "FROM " + chucVu + " " +
                           "WHERE " + ma + " = '" + taiKhoan.getUsername() + "'";
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    return new Person(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(),
                        dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString());
                }
                else return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion
        #region Update dữ liệu trong form thông tin cá nhân
        public void CapNhatThongTin(Person person)
        {
            string sqlStr = string.Format("UPDATE SinhVien SET TenSV = '{0}', GioiTinh = '{1}', DiaChi = '{3}', " +
            "CCCD = '{3}', NgaySinh = '{4}', SDT = '{5}', Email = '{6}' WHERE MSSV = '{7}'", person.getHoTen(), person.getGioiTinh(),
                person.getDiaChi(), person.getCCCD(), person.getNTNS(), person.getSDT(), person.getEmail(), person.getMaso());
            dBConnection.ThucThi(sqlStr);
        }
        #endregion
        #region Chi tiết luận văn trong UCChiTietLuanVan
        LuanVanDuyet luanVan = new LuanVanDuyet();
        public void DSThanhVien(string maLV)
        {
            string query = "SELECT LuanVan.MaLV, LuanVan.TenLV, DSThanhVien.MSSV1, " +
                            "DSThanhVien.MSSV2, DSThanhVien.MSSV3 " +
                            "FROM LuanVan, DSThanhVien " +
                            "WHERE LuanVan.MaLV = DSThanhVien.MaLV and LuanVan.MaLV = N'" + maLV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    luanVan.MSSV11 = dataReader["MSSV1"].ToString();
                    luanVan.MSSV21 = dataReader["MSSV2"].ToString();
                    luanVan.MSSV31 = dataReader["MSSV3"].ToString();
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
        public void TenThanhVien(string MSSV)
        {
            string quenry = "SELECT TenSV " +
                            "FROM SinhVien " +
                            "WHERE MSSV = '" + MSSV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(quenry, conn);
                SqlDataReader dataReader1 = cmd1.ExecuteReader();
                if (dataReader1.Read())
                {
                    if (luanVan.TenMSSV1 == null)
                        luanVan.TenMSSV1 = dataReader1["TenSV"].ToString();
                    else if (luanVan.TenMSSV2 == null)
                        luanVan.TenMSSV2 = dataReader1["TenSV"].ToString();
                    else luanVan.TenMSSV3 = dataReader1["TenSV"].ToString();
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
        public LuanVanDuyet Load(string maLV)
        {
            DSThanhVien(maLV);
            TenThanhVien(luanVan.MSSV11);
            TenThanhVien(luanVan.MSSV21);
            TenThanhVien(luanVan.MSSV31);
            string query = "SELECT LuanVan.MaLV, LuanVan.TenLV, GiangVien.TenGV, " +
                            "LuanVan.ChuyenNganh, LuanVan.LinhVuc, LuanVan.ChucNang, LuanVan.CongNghe, " +
                            " LuanVan.NgonNgu, LuanVan.YeuCau, LuanVan.TrangThai " +
                            "FROM LuanVan, GiangVien " +
                            "WHERE LuanVan.MaGV = GiangVien.MaGV and MaLV = N'" + maLV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    luanVan.MaLV = dataReader["MaLV"].ToString();
                    luanVan.TenGV = dataReader["TenGV"].ToString();
                    luanVan.TenLV = dataReader["TenLV"].ToString();
                    luanVan.CongNghe = dataReader["CongNghe"].ToString();
                    luanVan.ChuyenNganh = dataReader["ChuyenNganh"].ToString();
                    luanVan.LinhVuc = dataReader["LinhVuc"].ToString();
                    luanVan.ChucNang = dataReader["ChucNang"].ToString();
                    luanVan.NgonNgu = dataReader["NgonNgu"].ToString();
                    luanVan.YeuCau = dataReader["YeuCau"].ToString();
                    luanVan.TrangThai = dataReader["TrangThai"].ToString();
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
            return luanVan;
        }
        #endregion
        #region Tài khoản
        public void LoadTK()
        {
            string sqlStr = string.Format("SELECT * FROM TaiKhoan");
            dBConnection.Load(sqlStr);
        }
        public bool DangNhap(TaiKhoan taiKhoan)
        {
            try
            {
                conn.Open();
                string sqlStr = "SELECT * FROM TaiKhoan WHERE Username = @Username AND Pass = @Password";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@Username", taiKhoan.getUsername());
                cmd.Parameters.AddWithValue("@Password", taiKhoan.getPassword());

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        if (reader[2].ToString() == "Sinh Viên" && taiKhoan.getChucVu() == "Sinh viên")
                        {
                            return true;
                        }
                        if (reader[2].ToString() == "Giảng Viên" && taiKhoan.getChucVu() == "Giảng viên")
                        {
                            return true;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username, password, or role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        public TaiKhoan createTaiKhoan(string username, string password, string chucVu)
        {
            TaiKhoan taiKhoan = new TaiKhoan(username, password, chucVu);
            return taiKhoan;
        }
        #endregion
    }
}
