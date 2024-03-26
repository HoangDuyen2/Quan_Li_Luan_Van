﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{

    internal class ChinhLuanVanDAO
    {
        protected SqlConnection conn;
        protected DBConnection dbConnection;
        LuanVan sualv = new LuanVan();
        public ChinhLuanVanDAO()
        {
            conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            dbConnection = new DBConnection();
        }

        public LuanVan getLuanVan(string tenLV)
        {
            string query = "SELECT * " +
                           "FROM LuanVan " +            
                           "WHERE TenLV = N'" + tenLV + "'";
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
                    sualv.ChuyenNganh = dataReader["ChuyenNganh"].ToString();
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
        
    }
}
