using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class TaiKhoanDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection dBConnection = new DBConnection();
        public void Load()
        {
            string sqlStr = string.Format("SELECT * FROM TaiKhoan");
            dBConnection.Load(sqlStr);
        }
        public bool DangNhap(TaiKhoan taiKhoan)
        {
            bool check = false;

            string sqlStr = "SELECT * FROM TaiKhoan WHERE Username = @Username AND Pass = @Password";
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            cmd.Parameters.AddWithValue("@Username", taiKhoan.getUsername());
            cmd.Parameters.AddWithValue("@Password", taiKhoan.getPassword());

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader[2].ToString() == "Sinh viên" && taiKhoan.getChucVu() == "Sinh viên")
                    {
                        check = true;
                        FSinhVien sv = new FSinhVien();
                        sv.ShowDialog();
                    }
                    if (reader[2].ToString() == "Giảng viên" && taiKhoan.getChucVu() == "Giảng viên")
                    {
                        check |= true;
                        FGiangVien gv = new FGiangVien();
                        gv.ShowDialog();
                    }
                }
                if (!check)
                {
                    MessageBox.Show("Invalid username, password, or role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username, password, or role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
            dBConnection.ThucThi(sqlStr);

            return check;
        } 
        public TaiKhoan createTaiKhoan(string username, string password,string chucVu)
        {
            TaiKhoan taiKhoan = new TaiKhoan(username, password, chucVu);
            return taiKhoan;
        }
    }
}
