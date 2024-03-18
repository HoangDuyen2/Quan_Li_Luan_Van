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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Li_Luan_Van
{
    public partial class FDangNhap : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM TaiKhoan");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string chucVu = "";
            if (rbtnSV.Checked) chucVu = "Sinh vien";
            else chucVu = "Giang vien";
            try
            {
                conn.Open();

                string sqlStr = "SELECT * FROM TaiKhoan WHERE Username = @Username AND Pass = @Password";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@Username", txtTK.Text);
                cmd.Parameters.AddWithValue("@Password", txtMatKhau.Text);
 //               cmd.Parameters.AddWithValue("@ChucVu", chucVu);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    this.Hide();
                    if (chucVu == "Sinh vien")
                    {
                        FSinhVien sv = new FSinhVien();
                        sv.ShowDialog();
                    }
                    else
                    {
                        FGiangVien gv = new FGiangVien();
                        gv.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
