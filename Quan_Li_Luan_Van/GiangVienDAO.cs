﻿using System;
using System.Collections;
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

        #region Chỉnh luận văn
        public LuanVan getLuanVan(string maLV)
        {
            LuanVan sualv = new LuanVan();
            string query = "SELECT * FROM LuanVan WHERE MaLV = N'" + maLV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    sualv.MaLV = dataReader["MaLV"].ToString();
                    sualv.TenLV = dataReader["TenLV"].ToString();
                    sualv.ChuyenNganh = dataReader["ChuyenNganh"].ToString();
                    sualv.ChucNang = dataReader["ChucNang"].ToString();
                    sualv.YeuCau = dataReader["YeuCau"].ToString();
                    sualv.CongNghe = dataReader["CongNghe"].ToString();
                    sualv.LinhVuc = dataReader["LinhVuc"].ToString();
                    sualv.NgonNgu = dataReader["NgonNgu"].ToString();
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
            return sualv;
        }

        public void ChinhSua(LuanVan luanvan, string maLV)
        {
            string query = $"UPDATE LuanVan SET TenLV = N'{luanvan.TenLV}', ChuyenNganh = N'{luanvan.ChuyenNganh}', ChucNang = N'{luanvan.ChucNang}', YeuCau = N'{luanvan.YeuCau}', CongNghe = N'{luanvan.CongNghe}', LinhVuc = N'{luanvan.LinhVuc}', NgonNgu = N'{luanvan.NgonNgu}' WHERE MaLV = '{luanvan.MaLV}'";
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
            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCLVCuaToi uclv = new UCLVCuaToi();
                    uclv.MaGV = MaGV;
                    uclv.MaLV = dataReader["MaLV"].ToString();
                    uclv.LblTenLV.Text = dataReader["TenLV"].ToString();
                    uclv.LblChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    uclv.LblTrangThai.Text = dataReader["TrangThai"].ToString();
                    if (uclv.LblTrangThai.Text == "Đã có nhóm")
                    {
                        uclv.BtnDelete.Enabled = false;
                        uclv.BtnUpdate.Enabled = false;
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
            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCNhom ucnhom = new UCNhom();
                    ucnhom.MaGV = this.maGV;
                    ucnhom.MaLV = dataReader["MaLV"].ToString();
                    ucnhom.LblTenLV.Text = dataReader["TenLV"].ToString();
                    ucnhom.LblChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    panel.Controls.Add(ucnhom);
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
        public void ThemThongBao(ThongBao tb)
        {
            sqlQuery = string.Format("INSERT INTO ThongBao(TieuDe, NoiDung, ThoiGian, MaLV) VALUES (N'{0}', N'{1}', '{2}', '{3}')", tb.TieuDe, tb.NoiDung, tb.ThoiGian, tb.MaLV);
            dBConnection.ThucThi(sqlQuery);
        }

        public void LoadDSTask(string maLV, FlowLayoutPanel panel, string maGV)
        {
            string query = $"SELECT * FROM NhiemVu JOIN LuanVan ON NhiemVu.MaLV = LuanVan.MaLV WHERE NhiemVu.MaLV = N'{maLV}'";
            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCTask uctask = new UCTask();
                    uctask.MaNguoi = maGV;
                    uctask.MaLV = maLV;
                    uctask.MaNV = dataReader["MaNV"].ToString();
                    uctask.LblTenNV.Text = dataReader["TenNV"].ToString();
                    uctask.LblTienTrinh.Text = dataReader["TienTrinh"].ToString();
                    panel.Controls.Add(uctask);
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

        public string GetTenLV(string maLV)
        {
            string tenLV = "";
            string query = "SELECT TenLV FROM LuanVan WHERE MaLV = @maLV";
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maLV", maLV);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tenLV = reader["TenLV"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy tên luận văn: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return tenLV;
        }

        public string GetTenGV(string maGV)
        {
            string tenGV = "";
            string query = "SELECT TenGV FROM GiangVien WHERE MaGV = @maGV";
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maGV", maGV);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tenGV = reader["TenGV"].ToString();
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
            return tenGV;
        }

        public NhiemVu GetTask(string maNV)
        {
            NhiemVu nhiemvu = new NhiemVu();
            string query = "SELECT * FROM NhiemVu " +
                           " WHERE MaNV  = N'" + maNV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    nhiemvu.TenNV = dataReader["TenNV"].ToString();
                    nhiemvu.TienTrinh = dataReader["TienTrinh"].GetHashCode();
                    nhiemvu.NoiDung = dataReader["NoiDung"].ToString();
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
            return nhiemvu;
        }
        public void LoadListPhanHoi(string maNV, FlowLayoutPanel panel)
        {
            string query = "Select *From PhanHoi " +
                    " WHERE MaNV  = N'" + maNV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                panel.Controls.Clear();
                while (dataReader.Read())
                {
                    UCPhanHoi uCPhanHoi = new UCPhanHoi();
                    uCPhanHoi.LblTen.Text = dataReader["TenNguoiGui"].ToString();
                    uCPhanHoi.LblThoiGian.Text = dataReader["ThoiGianGui"].ToString();
                    uCPhanHoi.TxtNoiDung.Text = dataReader["NoiDung"].ToString();
                    panel.Controls.Add(uCPhanHoi);
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
        #region Chi tiết luận văn
        public void DSThanhVienChuaDuyet(string _message, LuanVanDuyet luanVan)
        {
            string query1 = "SELECT LuanVan.MaLV, LuanVan.TenLV, DuyetDangKy.MSSV1, " +
                            "DuyetDangKy.MSSV2, DuyetDangKy.MSSV3 " +
                            "FROM LuanVan, DuyetDangKy " +
                            "WHERE LuanVan.MaLV = DuyetDangKy.MaLV and TenLV = N'" + _message + "'";
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataReader dataReader1 = cmd1.ExecuteReader();
                if (dataReader1.Read())
                {
                    luanVan.MSSV11 = dataReader1["MSSV1"].ToString();
                    luanVan.MSSV21 = dataReader1["MSSV2"].ToString();
                    luanVan.MSSV31 = dataReader1["MSSV3"].ToString();
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
        public void TenThanhVien(string MSSV, LuanVanDuyet luanVan)
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
        public LuanVanDuyet LoadCTLV(string _message)
        {
            string query = "SELECT LuanVan.MaLV, LuanVan.TenLV, GiangVien.TenGV, " +
                            "LuanVan.ChuyenNganh, LuanVan.LinhVuc, LuanVan.ChucNang, LuanVan.CongNghe, " +
                            " LuanVan.NgonNgu, LuanVan.YeuCau, LuanVan.TrangThai " +
                            "FROM LuanVan, GiangVien " +
                            "WHERE LuanVan.MaGV = GiangVien.MaGV and TenLV = N'" + _message + "'";
            LuanVanDuyet luanVan = new LuanVanDuyet();
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
            DSThanhVienChuaDuyet(_message, luanVan);
            TenThanhVien(luanVan.MSSV11,luanVan);
            TenThanhVien(luanVan.MSSV21,luanVan);
            TenThanhVien(luanVan.MSSV31, luanVan);
            return luanVan;
        }
        #endregion
    }
}