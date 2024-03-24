using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FDanhSachLuanVan : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        Hide_Show hide_Show = new Hide_Show();
        string query = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV " +
                                   "FROM LuanVan " +
                                   "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV ";
        public FDanhSachLuanVan()
        {
            InitializeComponent();
            txtTenGV.Enter += TxtTenGV_GetFocus;
            txtTenGV.LostFocus += TxtTenGV_LostFocus;
        }

        private void TxtTenGV_GetFocus(object sender, EventArgs e)
        {
            hide_Show.Hide(sender,e);
        }

        private void TxtTenGV_LostFocus(object sender, EventArgs e)
        {
            hide_Show.Show(sender,e);
        }

        private void TraCuu_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                flPanelDSLV.Controls.Clear();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCLV_GV uclv = new UCLV_GV();

                    uclv.LblTenLV.Text = dataReader["TenLV"].ToString();
                    uclv.LblChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    uclv.LblTenGV.Text = dataReader["TenGV"].ToString();


                    flPanelDSLV.Controls.Add(uclv);
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

        private void ChonChuyenNganh(object sender, EventArgs e)
        {
            string text = comboxChuyenNganh.SelectedItem.ToString();
            if (text != "Tất cả")
            {
                query = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                        "FROM LuanVan " +
                        "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                        "WHERE LuanVan.ChuyenNganh = N'" + text + "'";
            }
            else query = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                        "FROM LuanVan " +
                        "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV ";
            TraCuu_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTenGV.Text != "")
            {
                query = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                        "FROM LuanVan " +
                        "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                        "WHERE GiangVien.TenGV = N'" + txtTenGV.Text + "'";
            }
            TraCuu_Load(sender, e);
        }
    }
}
