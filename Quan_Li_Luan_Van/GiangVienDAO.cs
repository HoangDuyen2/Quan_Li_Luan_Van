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
        public string QueryBase()
        {
            return queryDSLV;
        }
        public string QueryChonChuyenNganh(string text)
        {
            if (text != "Tất cả")
            {
                string chuyenNganh = "WHERE LuanVan.ChuyenNganh = N'" + text + "'";
                return queryDSLV+chuyenNganh;
            }
            return queryDSLV;
        }
        public string QueryTimKiemGV(string text)
        {
            if (text != "")
            {
                string tenGV = "WHERE GiangVien.TenGV LIKE N'%" + text + "%'";
                return queryDSLV + tenGV;
            }
            return queryDSLV;
        }
        public void LoadListLuanVan(string query, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            List<Dictionary<string, object>> dsLuanVan = dBConnection.ExecuteReaderData(query);
            foreach (var row in dsLuanVan)
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
        public string QueryDLV(string maGV)
        {
            string stringSQL = "SELECT LuanVan.MaLV, TenLV, ChuyenNganh, DuyetDangKy.TinhTrang " +
                          "FROM LuanVan JOIN DuyetDangKy ON " +
                          "LuanVan.MaLV = DuyetDangKy.MaLV WHERE MaGV = '" + maGV + "' ";
            return stringSQL;
        }
        public string traCuu(string text)
        {
            if (text != "Tất cả")
            {
                string tracuu = "AND DuyetDangKy.TinhTrang = N'" + text + "'";
                return tracuu;
            }
            return "";
        }
        public void getInfoDLV(string query, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            List<Dictionary<string, object>> listDLV = dBConnection.ExecuteReaderData(query);
            foreach (var row in listDLV)
            {
                UCDuyet ucd = new UCDuyet();
                ucd.MaLV = (string)row["MaLV"].ToString();
                ucd.LbTenLV.Text = (string)row["TenLV"].ToString();
                ucd.LbChuyenNganh.Text = (string)row["ChuyenNganh"].ToString();
                if ((string)row["TinhTrang"].ToString() == "Đang chờ duyệt")
                    ucd.LBTrangThai.ForeColor = System.Drawing.Color.Green;
                else if ((string)row["TinhTrang"].ToString() == "Từ chối")
                    ucd.LBTrangThai.ForeColor = System.Drawing.Color.Black;
                else if ((string)row["TinhTrang"].ToString() == "Đã duyệt")
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
        #endregion
        #region Danh sách luận văn của tôi
        public void XoaLuanVan(string maLV)
        {
            string XoaDuyet = string.Format("Delete From DuyetDangKy WHERE MaLV = '{0}'", maLV);
            dBConnection.ThucThi(XoaDuyet);
            string sqlXoa = string.Format("DELETE FROM LuanVan WHERE MaLV = '{0}'", maLV);
            dBConnection.ThucThi(sqlXoa);
        }
        public void ThemLuanVan(LuanVan luanVan)
        {
            string sqlThem = string.Format("INSERT INTO LuanVan(MaLV, TenLV, MaGV, ChuyenNganh, LinhVuc, ChucNang, CongNghe,NgonNgu, YeuCau, TrangThai) VALUES ('{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}')",
                luanVan.MaLV, luanVan.TenLV, luanVan.MaGV, luanVan.ChuyenNganh, luanVan.LinhVuc, luanVan.ChucNang, luanVan.CongNghe, luanVan.NgonNgu, luanVan.YeuCau, luanVan.TrangThai);
            dBConnection.ThucThi(sqlThem);
        }
        public LuanVan getLuanVan(string maLV)
        {
            LuanVan luanVan = new LuanVan();
            string query = "SELECT * FROM LuanVan WHERE MaLV = N'" + maLV + "'";
            List<Dictionary<string, object>> LV = dBConnection.ExecuteReaderData(query);
            foreach (var row in LV)
            {
                luanVan.MaLV = (string)row["MaLV"].ToString();
                luanVan.TenLV = (string)row["TenLV"].ToString();
                luanVan.ChuyenNganh = (string)row["ChuyenNganh"].ToString();
                luanVan.ChucNang = (string)row["ChucNang"].ToString();
                luanVan.YeuCau = (string)row["YeuCau"].ToString();
                luanVan.CongNghe = (string)row["CongNghe"].ToString();
                luanVan.LinhVuc = (string)row["LinhVuc"].ToString();
                luanVan.NgonNgu = (string)row["NgonNgu"].ToString();
            }
            return luanVan;
        }
        public void ChinhSua(LuanVan luanvan)
        {
            string query = $"UPDATE LuanVan SET TenLV = N'{luanvan.TenLV}', ChuyenNganh = N'{luanvan.ChuyenNganh}', " +
                $"ChucNang = N'{luanvan.ChucNang}', YeuCau = N'{luanvan.YeuCau}', CongNghe = N'{luanvan.CongNghe}'," +
                $" LinhVuc = N'{luanvan.LinhVuc}', NgonNgu = N'{luanvan.NgonNgu}' WHERE MaLV = '{luanvan.MaLV}'";
            dBConnection.ThucThi(query);
        }
        public string QueryLoadLVCT(string maGV)
        {
            this.maGV = maGV;
            string query = $"SELECT LuanVan.MaLV, LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                           $"FROM LuanVan JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                           $"WHERE LuanVan.MaGV = '{maGV}'";
            return query;
        }
        public void LoadLVCT(string query, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            List<Dictionary<string, object>> dsLVCT = dBConnection.ExecuteReaderData(query);
            foreach (var row in dsLVCT)
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
        #endregion        
        #region Quản lí nhóm luận văn
        public string QueryLoadDSNhom(string maGV)
        {
            this.maGV = maGV;
            string query = $"SELECT LuanVan.MaLV, LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                           $"FROM LuanVan " +
                           $"JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                           $"WHERE LuanVan.MaGV = '{maGV}' AND LuanVan.TrangThai = N'Đã có nhóm'";
            return query;
        }
        public void LoadListNhom(string query, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            List<Dictionary<string, object>> nhoms = dBConnection.ExecuteReaderData(query);
            foreach (var row in nhoms)
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
            string query = "SELECT TenGV " +
                            "FROM GiangVien " +
                            "WHERE MaGV = '" + maGV + "'";
            List<Dictionary<string, object>> tenGV = dBConnection.ExecuteReaderData(query);
            foreach (var row in tenGV)
            {
                return (string)row["TenGV"].ToString();
            }
            return "";
        }
        public void LoadListThanhVien(string maLV, FlowLayoutPanel panel)
        {
            string query = @"SELECT DISTINCT sv.MSSV, sv.TenSV, sv.Diem
                     FROM DSThanhVien dtv
                     JOIN SinhVien sv ON sv.MSSV = dtv.MSSV1 OR sv.MSSV = dtv.MSSV2 OR sv.MSSV = dtv.MSSV3
                     WHERE dtv.MaLV = @MaLV";
            panel.Controls.Clear();
            SqlParameter[] lstParam =
            {
                new SqlParameter("@MaLV", SqlDbType.NVarChar) {Value = maLV},
            };
            List<Dictionary<string, object>> ds = dBConnection.ExecuteReaderData(query,lstParam);
            foreach (var row in ds)
            {
                UCChamDiem uCChamDiem = new UCChamDiem();
                uCChamDiem.LblMSSV.Text = (string)row["MSSV"].ToString();
                uCChamDiem.LblTenSV.Text = (string)row["TenSV"].ToString();
                panel.Controls.Add(uCChamDiem);
            }
        }
        public void UpdateStudentScore(string mssv, decimal score, string maLV)
        {
            string query = "UPDATE SinhVien SET Diem = @score,  WHERE MSSV = @mssv";
            string quenry = "UPDATE LuanVan SET TinhTrang = N'Đã hoàn thành' WHERE MaLV = @MaLV";
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
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(quenry, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLV", maLV);
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
            loadLuanVanDuyet(maLV, luanVan);
            return luanVan;
        }
        #endregion
    }
}
