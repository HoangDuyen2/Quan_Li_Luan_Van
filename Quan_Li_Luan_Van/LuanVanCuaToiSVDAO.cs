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
    public class LuanVanCuaToiSVDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        string maLV = "";
        public LuanVanCuaToiSVDAO() { }
        string quenry = "";
        
        public void Load(Person person,FlowLayoutPanel panel)
        {
            KiemTra(person);
            if(maLV != "")
            {
                quenry = "SELECT LuanVan.MaLV, NhiemVu.TenNV, NhiemVu.TienTrinh " +
                         "FROM NhiemVu, LuanVan " +
                         "WHERE NhiemVu.MaLV = LuanVan.MaLV AND LuanVan.MaLV = '" + maLV + "'";
                ShowData(panel,person);
            }
        }
        public void ShowData(FlowLayoutPanel panel,Person person)
        {
            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(quenry, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCTask uclv = new UCTask();

                    uclv.LblTenNV.Text = dataReader["TenNV"].ToString();
                    uclv.LblTienTrinh.Text = dataReader["TienTrinh"].ToString();

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
        public bool KiemTra(Person person)
        {
            bool check = true;
            string sqlStr = string.Format("SELECT * FROM DSThanhVien WHERE MSSV1 = '{0}' OR MSSV2 = '{1}' OR MSSV3 = '{2}'", person.getMaso(), person.getMaso(), person.getMaso());
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlStr, conn);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                while(reader.Read())
                {
                    maLV = reader["MaLV"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return check;
        }
    }
}
