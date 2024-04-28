﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    internal class TienTrinh_GVDAO
    {
        protected SqlConnection conn;
        public TienTrinh_GVDAO()
        {
            conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        }
        public void LoadDSTask(string maLV, FlowLayoutPanel panel,string maGV)
        {
            string query = "SELECT * " +
                    "FROM NhiemVu " +
                    "JOIN LuanVan ON NhiemVu.MaLV = LuanVan.MaLV " +
                     "WHERE  NhiemVu.MaLV = N'" + maLV + "'";

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
                    uctask.MaNV = dataReader["MaNV"].ToString();
                    uctask.MaLV = maLV;
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
    }
}
