using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class ChiTietLuanVanDuyetDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        LuanVanDuyet luanVan = new LuanVanDuyet();

        public void DSThanhVienChuaDuyet(string _message)
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
                    if(luanVan.TenMSSV1 == null)
                        luanVan.TenMSSV1 = dataReader1["TenSV"].ToString();
                    else if(luanVan.TenMSSV2 == null)
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
        public LuanVanDuyet Load(string _message)
        {
            string query = "SELECT LuanVan.MaLV, LuanVan.TenLV, GiangVien.TenGV, " +
                            "LuanVan.ChuyenNganh, LuanVan.LinhVuc, LuanVan.ChucNang, LuanVan.CongNghe, " +
                            " LuanVan.NgonNgu, LuanVan.YeuCau, LuanVan.TrangThai " +
                            "FROM LuanVan, GiangVien " +
                            "WHERE LuanVan.MaGV = GiangVien.MaGV and TenLV = N'" + _message + "'";
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
            DSThanhVienChuaDuyet(_message);
            TenThanhVien(luanVan.MSSV11);
            TenThanhVien(luanVan.MSSV21);
            TenThanhVien(luanVan.MSSV31);
            return luanVan;
        }
    }
}
