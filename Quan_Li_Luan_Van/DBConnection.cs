using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Quan_Li_Luan_Van
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public DataTable Load(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                return dtSinhVien;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public void ThucThi(string sqlStr)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
//                    MessageBox.Show("Thực thi dữ liệu thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
        public List<Dictionary<string, object>> ExecuteReaderData(string sqlStr)
        {
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> rowData = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData.Add(reader.GetName(i), reader.GetValue(i));
                            }
                            resultList.Add(rowData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n" + ex.Message);
                }
            }
            return resultList;
        }

        public List<Dictionary<string, object>> ExecuteReaderData(string sqlStr, SqlParameter[] lstParam)
        {
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddRange(lstParam);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> rowData = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData.Add(reader.GetName(i), reader.GetValue(i));
                            }
                            resultList.Add(rowData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n" + ex.Message);
                }
            }
            return resultList;
        }
        public bool KiemTra(string sqlStr)
        {
            bool check = true;
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
