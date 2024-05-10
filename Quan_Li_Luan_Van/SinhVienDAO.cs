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
    public class SinhVienDAO : PersonDAO
    {
        DBConnection dbConnection = new DBConnection();
        #region Load Form Trang chủ
        string queryTrangChu = "SELECT * " +
                    "FROM ThongBao ";
        public string getMaLVCuaToi(string MSSV)
        {
            string maLV = "";
            string sqlStr = string.Format("SELECT * FROM DSThanhVien WHERE MSSV1 = '{0}' OR MSSV2 = '{1}' OR MSSV3 = '{2}'", MSSV, MSSV, MSSV);
            List<Dictionary<string, object>> getMaLV = dbConnection.ExecuteReaderData(sqlStr);
            foreach (var row in getMaLV)
            {
                maLV = (string)row["MaLV"].ToString();
            }
            return maLV;
        }

        public void LoadDSTB(FlowLayoutPanel panel, string truyVan)
        {
            panel.Controls.Clear();
            List<Dictionary<string, object>> ds = dbConnection.ExecuteReaderData(truyVan);
            foreach (var row in ds)
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
            }
            else if (checkTungNguoiDangKy(luanVan.MSSV21))
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
        #endregion
    }
}


