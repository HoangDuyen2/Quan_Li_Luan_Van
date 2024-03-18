using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Quan_Li_Luan_Van
{
    public partial class FLuanVanToi : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        string query = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.SoLuongConLai " +
                                   "FROM LuanVan " +
                                   "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                                   "WHERE LuanVan.MaGV = 'GV001'";

        public FLuanVanToi()
        {
            InitializeComponent();
        }

        private void FLuanVanToi_Load(object sender, EventArgs e)
        {
    
            try
            {
                conn.Open();
                flPanelDSLV.Controls.Clear();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCLV uclv = new UCLV();

                    uclv.LbTenLV.Text = dataReader["TenLV"].ToString();
                    uclv.LbChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    uclv.LblTenGV.Text = dataReader["TenGV"].ToString();
                    uclv.LbSoLuong.Text = dataReader["SoLuongConLai"].ToString();

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

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            FThemLuanVan fThemLuanVan = new FThemLuanVan();
            fThemLuanVan.ShowDialog();
        }
    }
}
