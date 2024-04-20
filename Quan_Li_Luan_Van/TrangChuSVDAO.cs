using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Quan_Li_Luan_Van
{
    internal class TrangChuSVDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        string query = "SELECT * " +
                    "FROM ThongBao ";
        public string getMaLV(string MSSV)
        {
            string maLV = "";
            string sqlStr = string.Format("SELECT * FROM DSThanhVien WHERE MSSV1 = '{0}' OR MSSV2 = '{1}' OR MSSV3 = '{2}'", MSSV, MSSV, MSSV);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    maLV = reader["MaLV"].ToString();
                    return maLV;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy mã luận văn: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return maLV;
        }
        public void LoadDSTB(FlowLayoutPanel panel, string truyVan)
        {
            try
            {
                conn.Open();
                panel.Controls.Clear();
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCThongBao uctb = new UCThongBao();
                    uctb.LblTieuDe.Text = dataReader["TieuDe"].ToString();
                    uctb.LbNoiDungTB.Text = dataReader["NoiDung"].ToString();
                    uctb.LblThoiGian.Text = dataReader["ThoiGian"].ToString();
                    uctb.ID_TB1 = dataReader["ID_TB"].ToString();
                    panel.Controls.Add(uctb);
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

        public string traCuuTheoNoiDung(string noidung)
        {
            if (!string.IsNullOrEmpty(noidung))
            {
                string tracuu = " and NoiDung LIKE N'%" + noidung + "%'";
                return tracuu;
            }
            return "";
        }

        public string TraCuuNgay(DateTime date)
        {
            if (date != DateTime.MinValue)
            {
                string tracuu = " AND CAST(ThoiGian AS date) = '" + date.ToString("MM-dd-yyyy") + "'";
                return tracuu;
            }
            return "";
        }
        public string Load(string maLV)
        {
            string sql = " WHERE MaLV = '" + maLV + "'";
            return query + sql;
        }
    }
}
