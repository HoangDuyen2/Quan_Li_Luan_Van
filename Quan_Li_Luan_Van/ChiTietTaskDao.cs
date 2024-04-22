using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    internal class ChiTietTaskDao
    {
        private string maNV;
        
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection dbConn = new DBConnection();
        
        string query;
        public ChiTietTaskDao(string maNV)
        {
            this.maNV = maNV;
        }

        public NhiemVu GetTask(string maNV)
        {
            NhiemVu nhiemvu = new NhiemVu();
            query = "SELECT * FROM NhiemVu " +
                           " WHERE MaNV  = N'"+ maNV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                { 
                    nhiemvu.TenNV= dataReader["TenNV"].ToString();
                    nhiemvu.TienTrinh = dataReader["TienTrinh"].GetHashCode();
                    nhiemvu.NoiDung = dataReader["NoiDung"].ToString();
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
            return nhiemvu;
        }

        public void LoadListPhanHoi(string maNV, FlowLayoutPanel panel)
        {
            query = "Select *From PhanHoi " +
                    " WHERE MaNV  = N'" + maNV + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                panel.Controls.Clear();
                while (dataReader.Read())
                {
                    UCPhanHoi uCPhanHoi = new UCPhanHoi();
                    uCPhanHoi.LblTen.Text= dataReader["TenNguoiGui"].ToString();
                    uCPhanHoi.LblThoiGian.Text = dataReader["ThoiGianGui"].ToString();
                    uCPhanHoi.TxtNoiDung.Text = dataReader["NoiDung"].ToString();
                    panel.Controls.Add(uCPhanHoi);
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
        public void ThemPhanHoi(PhanHoi ph)
        {
            query = string.Format("INSERT INTO PhanHoi(TenNguoiGui, ThoiGianGui, NoiDung, MaNV) VALUES (N'{0}', N'{1}', N'{2}', '{3}')", ph.Name, ph.Thoigian, ph.Noidung, ph.NhiemVu);
            dbConn.ThucThi(query);
        }
    }
}
