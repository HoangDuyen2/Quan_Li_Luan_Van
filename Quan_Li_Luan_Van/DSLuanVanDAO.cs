using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
namespace Quan_Li_Luan_Van
{

    internal class DSLuanVanDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public DSLuanVanDAO() 
        {
            
        }
        public void getInfo(string query, FlowLayoutPanel panel)
        {
            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCLV_GV uclv = new UCLV_GV();

                    uclv.LblTenLV.Text = dataReader["TenLV"].ToString();
                    uclv.LblChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    uclv.LblTenGV.Text = dataReader["TenGV"].ToString();
                    if (dataReader["TrangThai"].ToString() == "Chưa có nhóm")
                        uclv.LblTrangThai.ForeColor = System.Drawing.Color.Green;
                    uclv.LblTrangThai.Text = dataReader["TrangThai"].ToString();

                    panel.Controls.Add(uclv);
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
