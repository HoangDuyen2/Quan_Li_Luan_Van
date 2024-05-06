using System;
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
    public class SinhVienDAO: PersonDAO
    {
        DBConnection dbConnection = new DBConnection();
        #region Load Form Trang chủ
        string queryTrangChu = "SELECT * " +
                    "FROM ThongBao ";
        public string getMaLVCuaToi(string MSSV)
        {
            string maLV = "";
            string sqlStr = string.Format("SELECT * FROM DSThanhVien WHERE MSSV1 = '{0}' OR MSSV2 = '{1}' OR MSSV3 = '{2}'", MSSV, MSSV, MSSV);
            List<Dictionary<string,object>> getMaLV = dbConnection.ExecuteReaderData(sqlStr);
            foreach(var row in getMaLV)
            {
                maLV = (string)row["MaLV"].ToString();
            }
            return maLV;
        }

        public void LoadDSTB(FlowLayoutPanel panel, string truyVan)
        {
            panel.Controls.Clear();
            List<Dictionary<string, object>> ds = dbConnection.ExecuteReaderData(truyVan);
            foreach(var row in ds)
            {
                UCThongBao uctb = new UCThongBao();
                uctb.ID_TB1 = (string)row["ID_TB"].ToString();
                uctb.LblTieuDe.Text = (string)row["Tieude"].ToString();
                uctb.LbNoiDungTB.Text = (string)row["NoiDung"].ToString();
                uctb.LblThoiGian.Text = (string)row["ThoiGian"].ToString();
                panel.Controls.Add(uctb);
            }
        }

        public string traCuuTheoNoiDung(string noidung)
        {
            if (!string.IsNullOrEmpty(noidung))
            {
                string tracuu = " AND CONCAT(Tieude, NoiDung) LIKE N'%" + noidung + "%'";
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

        public string LoadTrangChu(string maLV)
        {
            string sql = " WHERE MaLV = '" + maLV + "' ";
            return queryTrangChu + sql;
        }

        public ThongBao noiDungTB(string maTB)
        {
            string query = "SELECT ID_TB, TieuDe, ThoiGian, NoiDung, TenGV " +
                    "FROM ThongBao INNER JOIN LuanVan ON LuanVan.MaLV = ThongBao.MaLV " +
                    "INNER JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                     "WHERE ID_TB = N'" + maTB + "'";

            ThongBao tb = new ThongBao();
            List<Dictionary<string, object>> ds = dbConnection.ExecuteReaderData(query);
            foreach (var row in ds)
            {
                tb.TieuDe = (string)row["TieuDe"].ToString();
                tb.ThoiGian = (string)row["ThoiGian"].ToString();
                tb.NoiDung = (string)row["NoiDung"].ToString();
                tb.TieuDe = (string)row["TieuDe"].ToString();
                tb.NguoiGui = (string)row["TenGV"].ToString();
            }
            return tb;
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
            if (luanVan.MSSV31 == "" || luanVan.MSSV31 == "Mời nhập vào")
            {
                query1 = string.Format("INSERT INTO DuyetDangKy (MaLV, MSSV1, MSSV2, MSSV3, TinhTrang) " + " VALUES ('{0}','{1}','{2}',NULL,N'Đang chờ duyệt')",
                luanVan.MaLV, luanVan.MSSV11, luanVan.MSSV21);
            }
            else
            {
                query1 = string.Format("INSERT INTO DuyetDangKy (MaLV, MSSV1, MSSV2, MSSV3, TinhTrang) " + " VALUES ('{0}','{1}','{2}','{3}',N'Đang chờ duyệt')",
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

        public void LoadCTLVSV(FlowLayoutPanel flPanelDSLV, string truyVan, SinhVien sinhVien)
        {
            flPanelDSLV.Controls.Clear();
            List<Dictionary<string, object>> ds = dbConnection.ExecuteReaderData(truyVan);
            foreach (var row in ds)
            {
                UCLV uclv = new UCLV(sinhVien);
                uclv.MaLV = (string)row["MaLV"].ToString();
                uclv.LblTenLV.Text = (string)row["TenLV"].ToString();
                uclv.LblChuyenNganh.Text = (string)row["ChuyenNganh"].ToString();
                uclv.LblTenGV.Text = (string)row["TenGV"].ToString();
                uclv.LblTrangThai.Text = (string)row["TrangThai"].ToString();

                flPanelDSLV.Controls.Add(uclv);
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
        public bool isValidStudent(string MSSV)
        {
            string sqlStr = string.Format("SELECT * FROM SinhVien WHERE MSSV = '{0}'", MSSV);
            return dbConnection.KiemTra(sqlStr);
        }
        public bool checkTungNguoiDangKy(string MSSV)
        {
            string sqlStr = string.Format("SELECT * FROM DSThanhVien WHERE MSSV1 = '{0}' OR MSSV2 = '{1}' OR MSSV3 = '{2}'", MSSV, MSSV, MSSV);
            if (dbConnection.KiemTra(sqlStr))
            {
                return true;
            }
            string sqlStr3 = string.Format("SELECT * FROM DuyetDangKy WHERE MSSV1 = '{0}' OR MSSV2 = '{1}' OR MSSV3 = '{2}' AND TinhTrang = N'Đang chờ duyệt'", MSSV, MSSV, MSSV);
            if (dbConnection.KiemTra(sqlStr3))
            {
                return true;
            }
            return false;
        }

        public bool checkNguoiDangKy(LuanVanDuyet luanVan)
        {
            if (!isValidStudent(luanVan.MSSV21))
            {
                MessageBox.Show("MSSV thành viên thứ 2 không hợp lệ");
                return false;
            } else if (checkTungNguoiDangKy(luanVan.MSSV21))
            {
                MessageBox.Show("MSSV2 đã có nhóm");
                return false;
            }
            if (luanVan.MSSV31 != "" && luanVan.MSSV31 != "Mời nhập vào")
            {
                if (!isValidStudent(luanVan.MSSV31))
                {
                    MessageBox.Show("MSSV thành viên thứ 3 không hợp lệ");
                    return false;
                }
                else if (checkTungNguoiDangKy(luanVan.MSSV31))
                {
                    MessageBox.Show("MSSV3 đã có nhóm");
                    return false;
                }
            }
            return true;
        }

        #endregion
        #region Form luận văn của tôi

        public string QueryDSNhiemVu(string maLV)
        {
            if (maLV != "")
            {
                string query = "SELECT LuanVan.MaLV, NhiemVu.TenNV, NhiemVu.TienTrinh, NhiemVu.MaNV, NhiemVu.MaNguoiTao " +
                         "FROM NhiemVu, LuanVan " +
                         "WHERE NhiemVu.MaLV = LuanVan.MaLV AND LuanVan.MaLV = '" + maLV + "'";
                return query;
            }
            return "";
        }

        public void LoadDSNhiemVu(FlowLayoutPanel panel, string truyVan, string User)
        {
            panel.Controls.Clear();
            List<Dictionary<string, object>> nhiemvus = dbConnection.ExecuteReaderData(truyVan);
            foreach (var row in nhiemvus)
            {
                UCTask_SV task = new UCTask_SV();
                task.MaUser = User;
                task.MaNV = (string)row["MaNV"].ToString();
                task.MaNguoiTao = (string)row["MaNguoiTao"].ToString();
                task.LblTenNV.Text = (string)row["TenNV"].ToString();
                task.LblTienTrinh.Text = (string)row["TienTrinh"].ToString();
                panel.Controls.Add(task);
            }
        }
        public bool UpdateProgress(CapNhatTienTrinh update)
        {
            string queryInsertProgress = "INSERT INTO CapNhatTienTrinh (MaNV, MSSV, PhanTramCapNhat, TienTrinh, ThoiGian) VALUES (@MaNV, @MSSV, @PhanTramCapNhat, @TienTrinh, @ThoiGian)";
            string queryUpdateTask = "UPDATE NhiemVu SET TienTrinh = @TienTrinh WHERE MaNV = @MaNV";

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            SqlTransaction transaction;

            conn.Open();
            transaction = conn.BeginTransaction();

            try
            {
                SqlCommand cmdInsert = new SqlCommand(queryInsertProgress, conn, transaction);
                cmdInsert.Parameters.AddWithValue("@MaNV", update.MaNV);
                cmdInsert.Parameters.AddWithValue("@MSSV", update.MSSV);
                cmdInsert.Parameters.AddWithValue("@PhanTramCapNhat", update.PhanTramCapNhat);
                cmdInsert.Parameters.AddWithValue("@TienTrinh", update.TienTrinh);
                cmdInsert.Parameters.AddWithValue("@ThoiGian", update.ThoiGian);
                cmdInsert.ExecuteNonQuery();

                SqlCommand cmdUpdate = new SqlCommand(queryUpdateTask, conn, transaction);
                cmdUpdate.Parameters.AddWithValue("@MaNV", update.MaNV);
                cmdUpdate.Parameters.AddWithValue("@TienTrinh", update.TienTrinh);
                cmdUpdate.ExecuteNonQuery();

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {

                transaction.Rollback();
                MessageBox.Show("Cập nhật tiến trình thất bại: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
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
                string quenry = "SELECT TenSV " +
                                "FROM SinhVien " +
                                "WHERE MSSV = '" + MSSV + "'";
                List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(quenry);
                foreach (var row in getMaLV)
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
            #endregion
        }

    }
        #endregion
}


