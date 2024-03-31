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
        public void DSThanhVien(string _message)
        {
            string query1 = "SELECT LuanVan.MaLV, LuanVan.TenLV, DSThanhVien.MSSV1, " +
                            "DSThanhVien.MSSV2, DSThanhVien.MSSV3 " +
                            "FROM LuanVan, DSThanhVien " +
                            "WHERE LuanVan.MaLV = DSThanhVien.MaLV and TenLV = N'" + _message + "'";
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataReader dataReader1 = cmd1.ExecuteReader();
                if (dataReader1.Read())
                {
                    luanVan.setMSSV1(dataReader1["MSSV1"].ToString());
                    luanVan.setMSSV2(dataReader1["MSSV2"].ToString());
                    luanVan.setMSSV3(dataReader1["MSSV3"].ToString());
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
            DSThanhVien(_message);
            return luanVan;
        }
    }
}
