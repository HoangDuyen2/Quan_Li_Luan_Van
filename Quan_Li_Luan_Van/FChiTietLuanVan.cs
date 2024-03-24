﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FChiTietLuanVan : Form
    {
        private string _message;

        public FChiTietLuanVan(string message) : this()
        {
            _message = message;
        }

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public FChiTietLuanVan()
        {
            InitializeComponent();
        }

        private void FChiTietLuanVan_Load(object sender, EventArgs e)
        {
            string query = "SELECT LuanVan.MaLV, LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV , LuanVan.SoLuongConLai, LuanVan.NgayBD, LuanVan.NgayKT, LuanVan.MoTaChiTiet " +
                           "FROM LuanVan " +
                           "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                           "WHERE TenLV = N'" + _message + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    txtMaLuanVan.Text = dataReader["MaLV"].ToString();
                    txtGVHD.Text = dataReader["TenGV"].ToString();
                    txtTenLuanVan.Text = dataReader["TenLV"].ToString();
                    txtChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    txtLinhVuc.Text = dataReader["LinhVuc"].ToString();
                    txtChucNang.Text = dataReader["ChucNang"].ToString();
                    txtCongNghe.Text = dataReader["CongNghe"].ToString();
                    txtNgonNgu.Text = dataReader["NgonNgu"].ToString();
                    txtYeuCau.Text = dataReader["MoTaChiTiet"].ToString();
                    txtTVien1.Text = dataReader["MSSV1"].ToString();
                    txtTVien2.Text = dataReader["MSSV2"].ToString();
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
    }

}
