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
    public partial class FThongTinCaNhan_SV : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public FThongTinCaNhan_SV()
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
/*            try
            {
                // Ket noi
                conn.Open();
                string sqlStr = string.Format("UPDATE {0} SET Full_Name = '{1}', Sex = '{2}', Addresses = '{3}', " +
                "CCCD = '{4}', Birthday = '{5}', Phone = '{6}', Email = '{7}' WHERE ID = '{8}')","SinhVien",)
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }*/
        }

        private void FThongTinCaNhan_SV_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM SinhVien");
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
    }
}
