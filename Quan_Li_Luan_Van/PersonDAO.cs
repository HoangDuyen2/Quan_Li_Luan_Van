using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class PersonDAO
    {
        DBConnection dBConnection = new DBConnection();
        #region Load label ở form FSinhVien và FGiangVien
        public T LoadLabel<T>(TaiKhoan taiKhoan) where T : Person
        {
            string chucVu, ma, name;
            if (taiKhoan.getChucVu() == "Sinh viên")
            {
                chucVu = "SinhVien";
                ma = "MSSV";
                name = "TenSV";
            }
            else
            {
                chucVu = "GiangVien";
                ma = "MaGV";
                name = "TenGV";
            }
            string query = "SELECT * " +
                           "FROM " + chucVu + " " +
                           "WHERE " + ma + " = '" + taiKhoan.getUsername() + "'";
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                if (typeof(T) == typeof(SinhVien))
                {
                    return new SinhVien((string)row[ma].ToString(), (string)row[name].ToString(), (string)row["GioiTinh"].ToString(),
                        (string)row["DiaChi"].ToString(), (string)row["CCCD"].ToString(), (string)row["NgaySinh"].ToString(),
                        (string)row["SDT"].ToString(), (string)row["Email"].ToString()) as T;
                }
                else if (typeof(T) == typeof(GiangVien))
                {
                    return new GiangVien((string)row[ma].ToString(), (string)row[name].ToString(), (string)row["GioiTinh"].ToString(),
                        (string)row["DiaChi"].ToString(), (string)row["CCCD"].ToString(), (string)row["NgaySinh"].ToString(),
                        (string)row["SDT"].ToString(), (string)row["Email"].ToString()) as T;
                }
            }
            return null;
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
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                luanVan.MSSV11 = (string)row["MSSV1"].ToString();
                luanVan.MSSV21 = (string)row["MSSV2"].ToString();
                luanVan.MSSV31 = (string)row["MSSV3"].ToString();
            }
        }
        public string TenThanhVien(string MSSV)
        {
            string query = "SELECT TenSV " +
                            "FROM SinhVien " +
                            "WHERE MSSV = '" + MSSV + "'";
            List<Dictionary<string, object>> tenSV = dBConnection.ExecuteReaderData(query);
            foreach (var row in tenSV)
            {
                return (string)row["TenSV"].ToString();
            }
            return "";
        }
        public LuanVanDuyet LoadLVD(string maLV)
        {
            DSThanhVien(maLV);
            luanVan = loadLuanVanDuyet(maLV, luanVan);
            return luanVan;
        }
        public LuanVanDuyet loadLuanVanDuyet(string maLV, LuanVanDuyet luanVan)
        {
            string query = "SELECT LuanVan.MaLV, LuanVan.TenLV, GiangVien.TenGV, " +
                            "LuanVan.ChuyenNganh, LuanVan.LinhVuc, LuanVan.ChucNang, LuanVan.CongNghe, " +
                            " LuanVan.NgonNgu, LuanVan.YeuCau, LuanVan.TrangThai " +
                            "FROM LuanVan, GiangVien " +
                            "WHERE LuanVan.MaGV = GiangVien.MaGV and MaLV = '" + maLV + "'";
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                luanVan.MaLV = (string)row["MaLV"].ToString();
                luanVan.TenGV = (string)row["TenGV"].ToString();
                luanVan.TenLV = (string)row["TenLV"].ToString();
                luanVan.CongNghe = (string)row["CongNghe"].ToString();
                luanVan.ChuyenNganh = (string)row["ChuyenNganh"].ToString();
                luanVan.LinhVuc = (string)row["LinhVuc"].ToString();
                luanVan.ChucNang = (string)row["ChucNang"].ToString();
                luanVan.NgonNgu = (string)row["NgonNgu"].ToString();
                luanVan.YeuCau = (string)row["YeuCau"].ToString();
                luanVan.TrangThai = (string)row["TrangThai"].ToString();
            }
            luanVan.TenMSSV1 = TenThanhVien(luanVan.MSSV11);
            luanVan.TenMSSV2 = TenThanhVien(luanVan.MSSV21);
            luanVan.TenMSSV3 = TenThanhVien(luanVan.MSSV31);
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
            string sqlStr = "SELECT * FROM TaiKhoan WHERE Username = @Username AND Pass = @Password";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@Username", SqlDbType.NVarChar) {Value = taiKhoan.getUsername()},
                new SqlParameter("@Password", SqlDbType.NVarChar) {Value = taiKhoan.getPassword()},
            };
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(sqlStr, lstParam);
            foreach (var row in getMaLV)
            {
                if ((string)row["ChucVu"].ToString() == "Sinh Viên" && taiKhoan.getChucVu() == "Sinh viên")
                {
                    return true;
                }
                else if ((string)row["ChucVu"].ToString() == "Giảng Viên" && taiKhoan.getChucVu() == "Giảng viên")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }
        public TaiKhoan createTaiKhoan(string username, string password, string chucVu)
        {
            TaiKhoan taiKhoan = new TaiKhoan(username, password, chucVu);
            return taiKhoan;
        }
        #endregion
        #region Form Nhiệm vụ
        public NhiemVu LoadNhiemVu(string maNV)
        {
            string query = "SELECT * " +
                           "FROM NhiemVu " +
                           "WHERE MaNV = @MaNV";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@MaNV", SqlDbType.NVarChar) {Value = maNV},
            };
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query, lstParam);
            foreach (var row in getMaLV)
            {
                int tienTrinh;
                if (!int.TryParse((string)row["TienTrinh"].ToString(), out tienTrinh))
                    tienTrinh = 0;
                return new NhiemVu((string)row["MaNV"].ToString(), (string)row["TenNV"].ToString(), (string)row["NoiDung"].ToString(), tienTrinh,
                        (string)row["TrangThai"].ToString(), (string)row["MaNguoiTao"].ToString(), (string)row["MaLV"].ToString());
            }
            return null;
        }
        public void ThemNhiemVu(NhiemVu nhiemvu)
        {
            string sqlThem = string.Format("INSERT INTO NhiemVu(MaNV, TenNV, NoiDung, TienTrinh, TrangThai, MaNguoiTao, MaLV) " +
                "VALUES (N'{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', '{6}')",
                nhiemvu.MaNV, nhiemvu.TenNV, nhiemvu.NoiDung, nhiemvu.TienTrinh, nhiemvu.TrangThai, nhiemvu.MaNguoiTao, nhiemvu.MaLV);
            dBConnection.ThucThi(sqlThem);
        }
        public void chinhSuaNhiemVu(NhiemVu nhiemvu)
        {
            string sqlSua = string.Format("UPDATE NhiemVu SET TenNV = N'{0}', NoiDung = N'{1}' WHERE MaNV = '{2}' "
                , nhiemvu.TenNV, nhiemvu.NoiDung, nhiemvu.MaNV);
            dBConnection.ThucThi(sqlSua);
        }
        public bool checkMaNguoi(string maNguoi, string maNV)
        {
            string sqlStr = string.Format("SELECT * FROM NhiemVu WHERE MaNguoiTao = '{0}' AND MaNV = '{1}' ", maNguoi, maNV);
            if (dBConnection.KiemTra(sqlStr))
            {
                return true;
            }
            return false;
        }
        public NhiemVu GetTask(string maNV)
        {
            NhiemVu nhiemvu = new NhiemVu();
            string query = "SELECT * FROM NhiemVu " +
                           " WHERE MaNV  = N'" + maNV + "'";
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                nhiemvu.TenNV = (string)row["TenNV"].ToString();
                nhiemvu.TienTrinh = (int)row["TienTrinh"].GetHashCode();
                nhiemvu.NoiDung = (string)row["NoiDung"].ToString();
            }
            return nhiemvu;
        }
        public void ThemPhanHoi(PhanHoi ph)
        {
            string query = string.Format("INSERT INTO PhanHoi(TenNguoiGui, ThoiGianGui, NoiDung, MaNV) VALUES (N'{0}', N'{1}', N'{2}', '{3}')", ph.Name, ph.Thoigian, ph.Noidung, ph.NhiemVu);
            dBConnection.ThucThi(query);
        }
        public void LoadListPhanHoi(string maNV, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            string query = "Select * From PhanHoi " +
                    " WHERE MaNV = N'" + maNV + "'";
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                UCPhanHoi uCPhanHoi = new UCPhanHoi();
                uCPhanHoi.LblTen.Text = (string)row["TenNguoiGui"].ToString();
                uCPhanHoi.LblThoiGian.Text = (string)row["ThoiGianGui"].ToString();
                uCPhanHoi.TxtNoiDung.Text = (string)row["NoiDung"].ToString();
                panel.Controls.Add(uCPhanHoi);
            }
        }
        public void LoadListCapNhatTienTrinh(string maNV, FlowLayoutPanel panel)
        {
            string query = @"
                            SELECT sv.TenSV, cnt.ThoiGian, cnt.PhanTramCapNhat, cnt.TienTrinh
                            FROM SinhVien sv
                            JOIN CapNhatTienTrinh cnt ON sv.MSSV = cnt.MSSV
                            WHERE cnt.MaNV = @maNV
                            ORDER BY cnt.ThoiGian DESC;";
            panel.Controls.Clear();
            SqlParameter[] lstParam =
            {
                new SqlParameter("@maNV", SqlDbType.NVarChar) {Value = maNV},
            };
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query, lstParam);
            foreach (var row in getMaLV)
            {
                UCUpdateTask uCUpdateTask = new UCUpdateTask();
                uCUpdateTask.LblTenSV.Text = (string)row["TenSV"].ToString();
                uCUpdateTask.LblThoiGian.Text = (string)row["ThoiGian"].ToString();
                uCUpdateTask.LblTienTrinh.Text = (string)row["TienTrinh"].ToString();
                panel.Controls.Add(uCUpdateTask);
            }
        }
        public DataTable GetStudentProgressData(string maNV)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                conn.Open();
                string query = @" SELECT sv.TenSV, SUM(ct.PhanTramCapNhat) AS TongPhanTramCapNhat                                
                                FROM NhiemVu nv
                                JOIN LuanVan lv ON nv.MaLV = lv.MaLV
                                JOIN DSThanhVien dstv ON lv.MaLV = dstv.MaLV
                                LEFT JOIN SinhVien sv ON sv.MSSV = dstv.MSSV1 OR sv.MSSV = dstv.MSSV2 OR sv.MSSV = dstv.MSSV3
                                LEFT JOIN CapNhatTienTrinh ct ON sv.MSSV = ct.MSSV AND ct.MaNV = nv.MaNV
                                WHERE nv.MaNV = @MaNV
                                GROUP BY sv.TenSV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public DataTable GetStudentProgressDataAll(string maLV)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                string query = @"
                                SELECT sv.TenSV, 
                                       COALESCE(CAST((ISNULL(SUM(cpt.PhanTramCapNhat), 0) * 100.0 / NULLIF(SUM(SUM(cpt.PhanTramCapNhat)) OVER(), 0)) AS DECIMAL(5,2)), 0) AS TongPhanTramHoanThanh
                                FROM DSThanhVien dtv
                                JOIN SinhVien sv ON sv.MSSV = dtv.MSSV1 OR sv.MSSV = dtv.MSSV2 OR sv.MSSV = dtv.MSSV3
                                LEFT JOIN NhiemVu nv ON nv.MaLV = dtv.MaLV
                                LEFT JOIN CapNhatTienTrinh cpt ON cpt.MaNV = nv.MaNV AND cpt.MSSV = sv.MSSV
                                WHERE dtv.MaLV = @MaLV
                                GROUP BY sv.TenSV";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLV", maLV);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        #endregion
    }
}
