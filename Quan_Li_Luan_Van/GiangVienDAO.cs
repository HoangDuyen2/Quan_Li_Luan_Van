using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class GiangVienDAO:PersonDAO
    {
        DBConnection dBConnection = new DBConnection();
        string sqlQuery;

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
            panel.Controls.Clear();
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                UCLV_GV uclv = new UCLV_GV();
                uclv.MaLV = (string)row["MaLV"].ToString();
                uclv.LblTenLV.Text = (string)row["TenLV"].ToString();
                uclv.LblChuyenNganh.Text = (string)row["ChuyenNganh"].ToString();
                uclv.LblTenGV.Text = (string)row["TenGV"].ToString();
                if ((string)row["TrangThai"].ToString() == "Chưa có nhóm")
                    uclv.LblTrangThai.ForeColor = System.Drawing.Color.Green;
                uclv.LblTrangThai.Text = (string)row["TrangThai"].ToString();
                panel.Controls.Add(uclv);
            }
        }
        #endregion
        #region Form Duyệt luận văn
        private string maGV;
        public string MaGV { get => maGV; set => maGV = value; }
        public string LoadDLV(string maGV)
        {
            MaGV = maGV;
            string quenry = "SELECT LuanVan.MaLV, LuanVan.TenLV, LuanVan.ChuyenNganh, DuyetDangKy.TinhTrang " +
                          "FROM LuanVan JOIN DuyetDangKy ON " +
                          "LuanVan.MaLV = DuyetDangKy.MaLV and LuanVan.MaGV = '" + maGV + "'";
            return quenry;
        }
        public void getInfoDLV(string query, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                UCDuyet ucd = new UCDuyet();
                ucd.MaLV = (string)row["MaLV"].ToString();
                ucd.LbTenLV.Text = (string)row["TenLV"].ToString();
                ucd.LbChuyenNganh.Text = (string)row["ChuyenNganh"].ToString();
                if ((string)row["TinhTrang"].ToString() == "Đang chờ duyệt")
                    ucd.LBTrangThai.ForeColor = System.Drawing.Color.Green;
                if ((string)row["TinhTrang"].ToString() == "Từ chối")
                    ucd.LBTrangThai.ForeColor = System.Drawing.Color.Black;
                if ((string)row["TinhTrang"].ToString() == "Đã duyệt")
                    ucd.LBTrangThai.ForeColor = System.Drawing.Color.Red;
                ucd.LBTrangThai.Text = (string)row["TinhTrang"].ToString();
                panel.Controls.Add(ucd);
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
        #region Thêm luận văn
        public void ThemLuanVan(LuanVan luanVan)
        {
            string sqlThem = string.Format("INSERT INTO LuanVan(MaLV, TenLV, MaGV, ChuyenNganh, LinhVuc, ChucNang, CongNghe,NgonNgu, YeuCau, TrangThai) VALUES ('{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}')",
                luanVan.MaLV, luanVan.TenLV, luanVan.MaGV, luanVan.ChuyenNganh, luanVan.LinhVuc, luanVan.ChucNang, luanVan.CongNghe, luanVan.NgonNgu, luanVan.YeuCau, luanVan.TrangThai);
            dBConnection.ThucThi(sqlThem);
        }
        #endregion
        #region Chỉnh luận văn
        public LuanVan getLuanVan(string maLV)
        {
            LuanVan sualv = new LuanVan();
            string query = "SELECT * FROM LuanVan WHERE MaLV = N'" + maLV + "'";
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                sualv.MaLV = (string)row["MaLV"].ToString();
                sualv.TenLV = (string)row["TenLV"].ToString();
                sualv.ChuyenNganh = (string)row["ChuyenNganh"].ToString();
                sualv.ChucNang = (string)row["ChucNang"].ToString();
                sualv.YeuCau = (string)row["YeuCau"].ToString();
                sualv.CongNghe = (string)row["CongNghe"].ToString();
                sualv.LinhVuc = (string)row["LinhVuc"].ToString();
                sualv.NgonNgu = (string)row["NgonNgu"].ToString();
            }
            return sualv;
        }

        public void ChinhSua(LuanVan luanvan)
        {
            string query = $"UPDATE LuanVan SET TenLV = N'{luanvan.TenLV}', ChuyenNganh = N'{luanvan.ChuyenNganh}', " +
                $"ChucNang = N'{luanvan.ChucNang}', YeuCau = N'{luanvan.YeuCau}', CongNghe = N'{luanvan.CongNghe}'," +
                $" LinhVuc = N'{luanvan.LinhVuc}', NgonNgu = N'{luanvan.NgonNgu}' WHERE MaLV = '{luanvan.MaLV}'";
            dBConnection.ThucThi(query);
        }
        #endregion
        #region Luận Văn Của Tôi
        public string LoadMyTheses(string maGV)
        {
            this.maGV = maGV;
            string query = $"SELECT LuanVan.MaLV, LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                           $"FROM LuanVan JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                           $"WHERE LuanVan.MaGV = '{maGV}'";
            return query;
        }

        public void GetMyThesesInfo(string query, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                UCLVCuaToi uclv = new UCLVCuaToi();
                uclv.MaGV = MaGV;
                uclv.MaLV = (string)row["MaLV"].ToString();
                uclv.LblTenLV.Text = (string)row["TenLV"].ToString();
                uclv.LblChuyenNganh.Text = (string)row["ChuyenNganh"].ToString();
                uclv.LblTrangThai.Text = (string)row["TrangThai"].ToString();
                if (uclv.LblTrangThai.Text == "Đã có nhóm")
                {
                    uclv.BtnDelete.Enabled = false;
                    uclv.BtnUpdate.Enabled = false;
                }
                panel.Controls.Add(uclv);
            }
        }

        public string QueryMyTheses(string text)
        {
            string baseQuery = $"SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, DuyetDangKy.TinhTrang " +
                               $"FROM LuanVan JOIN DuyetDangKy ON LuanVan.MaLV = DuyetDangKy.MaLV AND LuanVan.MaGV = '{MaGV}'";
            if (text != "Tất cả")
            {
                baseQuery += $" WHERE TinhTrang = N'{text}'";
            }
            return baseQuery;
        }

        #endregion
        #region Quản lí nhóm luận văn
        public string TruyVanDSNhom(string maGV)
        {
            this.maGV = maGV;
            string query = $"SELECT LuanVan.MaLV, LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                           $"FROM LuanVan " +
                           $"JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                           $"WHERE LuanVan.MaGV = '{maGV}' AND LuanVan.TrangThai = N'Đã có nhóm'";
            return query;
        }

        public void DSNhomInfo(string query, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                UCNhom ucnhom = new UCNhom();
                ucnhom.MaGV = this.maGV;
                ucnhom.MaLV = (string)row["MaLV"].ToString();
                ucnhom.LblTenLV.Text = (string)row["TenLV"].ToString();
                ucnhom.LblChuyenNganh.Text = (string)row["ChuyenNganh"].ToString();
                panel.Controls.Add(ucnhom);
            }
        }
        public void ThemThongBao(ThongBao tb)
        {
            sqlQuery = string.Format("INSERT INTO ThongBao(TieuDe, NoiDung, ThoiGian, MaLV) VALUES (N'{0}', N'{1}', '{2}', '{3}')", tb.TieuDe, tb.NoiDung, tb.ThoiGian, tb.MaLV);
            dBConnection.ThucThi(sqlQuery);
        }

        public void LoadDSTask(string maLV, FlowLayoutPanel panel, string maGV)
        {
            panel.Controls.Clear();
            string query = "SELECT LuanVan.MaLV, NhiemVu.MaNV, NhiemVu.TenNV, NhiemVu.TienTrinh FROM NhiemVu JOIN LuanVan ON NhiemVu.MaLV = LuanVan.MaLV WHERE NhiemVu.MaLV = '" + maLV + "'";
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                UCTask uctask = new UCTask();
                uctask.MaNguoiDangNhap = maGV;

                uctask.MaLV = maLV;
                uctask.MaNV = (string)row["MaNV"].ToString();
                uctask.LblTenNV.Text = (string)row["TenNV"].ToString();
                uctask.LblTienTrinh.Text = (string)row["TienTrinh"].ToString();
                panel.Controls.Add(uctask);
            }
        }

        public string GetTenLV(string maLV)
        {
            string tenLV = "";
            string query = "SELECT TenLV FROM LuanVan WHERE MaLV = @maLV";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@maLV", SqlDbType.NVarChar) {Value = maLV},
            };
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query, lstParam);
            foreach (var row in getMaLV)
            {
                tenLV = (string)row["TenLV"].ToString();
            }
            return tenLV;
        }

        public string GetTenGV(string maGV)
        {
            string tenGV = "";
            string query = "SELECT TenGV FROM GiangVien WHERE MaGV = @maGV";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@maGV", SqlDbType.NVarChar) {Value = maGV},
            };
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query, lstParam);
            foreach (var row in getMaLV)
            {
                tenGV = (string)row["TenGV"].ToString();
            }
            return tenGV;
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
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query,lstParam);
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
        public void ThemPhanHoi(PhanHoi ph)
        {
            string query = string.Format("INSERT INTO PhanHoi(TenNguoiGui, ThoiGianGui, NoiDung, MaNV) VALUES (N'{0}', N'{1}', N'{2}', '{3}')", ph.Name, ph.Thoigian, ph.Noidung, ph.NhiemVu);
            dBConnection.ThucThi(query);
        }
        public void LoadListThanhVien(string maLV, FlowLayoutPanel panel)
        {
            string query = @"SELECT DISTINCT sv.MSSV, sv.TenSV, sv.Diem
                     FROM DSThanhVien dtv
                     JOIN SinhVien sv ON sv.MSSV = dtv.MSSV1 OR sv.MSSV = dtv.MSSV2 OR sv.MSSV = dtv.MSSV3
                     WHERE dtv.MaLV = @MaLV";

            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in getMaLV)
            {
                luanVan.MSSV11 = (string)row["MSSV1"].ToString();
                luanVan.MSSV21 = (string)row["MSSV2"].ToString();
                luanVan.MSSV31 = (string)row["MSSV3"].ToString();
            }
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLV", maLV);
                conn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                panel.Controls.Clear();
                while (dataReader.Read())
                {
                    UCChamDiem uCChamDiem = new UCChamDiem();
                    uCChamDiem.LblMSSV.Text = dataReader["MSSV"].ToString();
                    uCChamDiem.LblTenSV.Text = dataReader["TenSV"].ToString();
                    uCChamDiem.TxtDiem.Text = dataReader["Diem"].ToString();   
                    panel.Controls.Add(uCChamDiem);
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
        public void UpdateStudentScore(string mssv, decimal score)
        {
            string query = "UPDATE SinhVien SET Diem = @score WHERE MSSV = @mssv";
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@score", score);
                        cmd.Parameters.AddWithValue("@mssv", mssv);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating score: " + ex.Message);
            }
        }



        #endregion
        #region Chi tiết luận văn
        public void DSThanhVienChuaDuyet(string maLV, LuanVanDuyet luanVan)
        {
            string query1 = "SELECT LuanVan.MaLV, LuanVan.TenLV, DuyetDangKy.MSSV1, " +
                            "DuyetDangKy.MSSV2, DuyetDangKy.MSSV3 " +
                            "FROM LuanVan, DuyetDangKy " +
                            "WHERE LuanVan.MaLV = DuyetDangKy.MaLV and LuanVan.MaLV = N'" + maLV + "'";
            List<Dictionary<string, object>> getMaLV = dBConnection.ExecuteReaderData(query1);
            foreach (var row in getMaLV)
            {
                luanVan.MSSV11 = (string)row["MSSV1"].ToString();
                luanVan.MSSV21 = (string)row["MSSV2"].ToString();
                luanVan.MSSV31 = (string)row["MSSV3"].ToString();
            }
        }
        public LuanVanDuyet LoadCTLV(string maLV)
        {
            LuanVanDuyet luanVan = new LuanVanDuyet();
            DSThanhVienChuaDuyet(maLV, luanVan);
            personDAO.loadLuanVanDuyet(maLV, luanVan);
            return luanVan;
        }
        #endregion
    }
}
