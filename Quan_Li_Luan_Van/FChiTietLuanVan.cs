using System;
using System.Collections;
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
        public void ThanhVienNhom()
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
                    txtTVien1.Text = dataReader1["MSSV1"].ToString();
                    txtTVien2.Text = dataReader1["MSSV2"].ToString();
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
        private void FChiTietLuanVan_Load(object sender, EventArgs e)
        {
            ThanhVienNhom();
            string query = "SELECT LuanVan.MaLV, LuanVan.TenLV, GiangVien.TenGV, " +
                            "LuanVan.ChuyenNganh, LuanVan.LinhVuc, LuanVan.ChucNang, LuanVan.CongNghe, " +
                            " LuanVan.NgonNgu, LuanVan.YeuCau " +
                           "FROM LuanVan, GiangVien " +
                           "WHERE LuanVan.MaGV = GiangVien.MaGV and TenLV = N'" + _message + "'";
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
                    txtYeuCau.Text = dataReader["YeuCau"].ToString();
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
        public void KhongTruyCap()
        {
            txtChucNang.Enabled = false;
            txtChuyenNganh.Enabled = false;
            txtCongNghe.Enabled = false;
            txtNgonNgu.Enabled = false;
            txtYeuCau.Enabled = false;
            txtGVHD.Enabled = false;
            txtLinhVuc.Enabled = false;
            txtMaLuanVan.Enabled = false;
            txtTVien2.Enabled = false;
            txtTVien1.Enabled = false;
            txtTenLuanVan.Enabled=false;
        }
    }

}
