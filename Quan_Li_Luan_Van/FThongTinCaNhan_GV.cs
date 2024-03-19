using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Li_Luan_Van
{
    public partial class FThongTinCaNhan_GV : KryptonForm
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        string query = "SELECT *" +
                       "FROM GiangVien " +
                       "WHERE MaGV = 'GV001'";
        public FThongTinCaNhan_GV()
        {
            InitializeComponent();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txtCCCD.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtHoTen.Enabled = true;
            txtPhone.Enabled = true;
            rbNam.Enabled = true;
            rbNu.Enabled = true;
            dtBirth.Enabled = true;
            btnChinhSua.Hide();
            btnOK.Show();
        }

        private void FThongTinCaNhan_GV_Load(object sender, EventArgs e)
        {
            btnOK.Hide();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    txtID.Text = dataReader["MaGV"].ToString();
                    txtHoTen.Text = dataReader["TenGV"].ToString();
                    if (dataReader["GioiTinh"].ToString() == "Nam")
                        rbNam.Checked = true;
                    else rbNu.Checked = true;
                    txtDiaChi.Text = dataReader["DiaChi"].ToString();
                    txtCCCD.Text = dataReader["CCCD"].ToString();
                    string day1 = Convert.ToString(dataReader["NgaySinh"]);
                    DateTime selectedDate;
                    if (DateTime.TryParse(day1, out selectedDate))
                    {
                        dtBirth.Value = selectedDate;
                    }
                    txtPhone.Text = dataReader["SDT"].ToString();
                    txtEmail.Text = dataReader["Email"].ToString();
                }
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sex = "";
                if (rbNam.Checked) sex = "Nam";
                else sex = "Nu";
                string sqlStr = string.Format("UPDATE GiangVien SET TenGV = '{0}', GioiTinh = '{1}', DiaChi = '{3}', " +
                "CCCD = '{3}', NgaySinh = '{4}', SDT = '{5}', Email = '{6}' WHERE MaGV = '{7}'", txtHoTen.Text, sex,
                    txtDiaChi.Text, txtCCCD.Text, dtBirth.Value.ToShortDateString(), txtPhone.Text, txtEmail.Text, txtID.Text);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
            btnOK.Hide();
            txtCCCD.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtHoTen.Enabled = false;
            txtPhone.Enabled = false;
            rbNam.Enabled = false;
            rbNu.Enabled = false;
            dtBirth.Enabled = false;
            btnChinhSua.Show();
        }
    }
}
