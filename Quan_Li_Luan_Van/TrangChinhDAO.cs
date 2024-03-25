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
    public class TrangChinhDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public Person LoadLabel(TaiKhoan taiKhoan)
        {
            string chucVu, ma;
            if (taiKhoan.getChucVu() == "Sinh viên")
            {
                chucVu = "SinhVien";
                ma = "MSSV";
            }
            else
            {
                chucVu = "GiangVien";
                ma = "MaGV";
            }
            string query = "SELECT * " +
                           "FROM " + chucVu + " " +
                           "WHERE "+ ma +" = '" + taiKhoan.getUsername() + "'";
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    return new Person(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(),
                        dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString());
                }
                else return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
