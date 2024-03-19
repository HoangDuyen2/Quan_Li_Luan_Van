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
    public partial class FDangKyLuanVan : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        string query = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.SoLuongConLai " +
                                   "FROM LuanVan " +
                                   "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV ";
        public FDangKyLuanVan()
        {
            InitializeComponent();
        }

        private void FDKLV_Load(object sender, EventArgs e)
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
            FDangKyLuanVanMoi dklvmoi = new FDangKyLuanVanMoi();
            dklvmoi.ShowDialog();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string filterCondition = string.Empty;

            switch (comboxLoaiTraCuu.SelectedIndex)
            {
                case 0: // "Có thể đăng ký"
                    filterCondition = "AND LuanVan.SoLuongConLai > 0";
                    break;
                case 1: // "Không thể đăng ký"
                    filterCondition = "AND LuanVan.SoLuongConLai = 0";
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn một loại tra cứu.");
                    return;
            }

            try
            {
                conn.Open();
                flPanelDSLV.Controls.Clear();

                
                SqlCommand cmd = new SqlCommand(query + " WHERE 1=1 " + filterCondition, conn);
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

    }
}
