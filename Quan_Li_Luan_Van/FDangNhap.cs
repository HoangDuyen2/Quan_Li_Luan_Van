using ComponentFactory.Krypton.Toolkit;
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
            txtTK.Enter += txtTK_GetFocus;
            txtMatKhau.Enter += TxtMatKhau_GetFocus;
            txtTK.LostFocus += txtTK_LostFocus;
            txtMatKhau.LostFocus += txtMatKhau_LostFocus;
        }

        private void TxtMatKhau_GetFocus(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            textBox.Text = "";
        }

        private void txtTK_GetFocus(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            textBox.Text = "";
        }

        private void txtTK_LostFocus(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                txtTK.Text = "Username";
            }
        }

        private void txtMatKhau_LostFocus(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "111111";
            }
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

                Boolean check = false;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader[2].ToString() == "Sinh viên")
                        {
                            check = true;
                            this.Hide();
                            FSinhVien sv = new FSinhVien();
                            sv.ShowDialog();
                            this.Close();
                        }
                        if (reader[2].ToString() == "Giảng viên")
                        {
                            check |= true;
                            this.Hide();
                            FGiangVien gv = new FGiangVien();
                            gv.ShowDialog();
                            this.Close();
                        }
                    }
                    if(!check)
                    {
                        MessageBox.Show("Invalid username, password, or role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void txtMatKhau_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (txtTK.Text == "Username")  // here you can also use txtSearch.Text != "Poduct Name", but it could affect your search code possibly 
            {
                txtTK.Text = "";
            }
        }
    }
}

