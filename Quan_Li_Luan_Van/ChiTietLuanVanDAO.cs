using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class ChiTietLuanVanDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        LuanVan luanVan = new LuanVan();
        public void DSThanhVien(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(sql, conn);
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
        public LuanVan Load(string sqlStr,string sql)
        {
            DSThanhVien(sql);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
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
