using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class ChiTietLuanVanDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
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
                    luanVan.setMSSV1(dataReader["MSSV1"].ToString());
                    luanVan.setMSSV2(dataReader["MSSV2"].ToString());
                    luanVan.setMSSV3(dataReader["MSSV3"].ToString());
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
                    luanVan.setMaLV(dataReader["MaLV"].ToString());
                    luanVan.setTenGV(dataReader["TenGV"].ToString());
                    luanVan.setTenLV(dataReader["TenLV"].ToString());
                    luanVan.setCongNghe(dataReader["CongNghe"].ToString());
                    luanVan.setChuyenNganh(dataReader["ChuyenNganh"].ToString());
                    luanVan.setLinhVuc(dataReader["LinhVuc"].ToString());
                    luanVan.setChucNang(dataReader["ChucNang"].ToString());
                    luanVan.setNgonNgu(dataReader["NgonNgu"].ToString());
                    luanVan.setYeuCau(dataReader["YeuCau"].ToString());
                    luanVan.setTrangThai(dataReader["TrangThai"].ToString());
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
    }
}
