using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Quan_Li_Luan_Van
{
    public class DangKyLuanVan_SVDAO
    {
        DBConnection dbConnection = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        string query = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai, LuanVan.MaLV " +
                                   "FROM LuanVan " +
                                   "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                                   "WHERE LuanVan.TrangThai = N'Chưa có nhóm' ";
        string quenry = "";
        public void DangKy(LuanVanDuyet luanVan)
        {
            string query1;
            if (luanVan.getMSSV3() == "")
            {
                query1 = string.Format("INSERT INTO DuyetDangKy (MaLV, MSSV1, MSSV2, MSSV3, TinhTrang) " + "VALUES ('{0}','{1}','{2}',NULL,N'Đang chờ duyệt')",
                luanVan.getMaLV(), luanVan.getMSSV1(), luanVan.getMSSV2());
            }
            else
            {
                query1 = string.Format("INSERT INTO DuyetDangKy (MaLV, MSSV1, MSSV2, MSSV3, TinhTrang) " + "VALUES ('{0}','{1}','{2}','{3}',N'Đang chờ duyệt')",
                luanVan.getMaLV(), luanVan.getMSSV1(), luanVan.getMSSV2(), luanVan.getMSSV3());
            }
            dbConnection.ThucThi(query1);
        }
        public string traCuuTenGV(string tenGV)
        {
            if (tenGV != "")
            {
                string tracuu = " and TenGV = N'" + tenGV + "'";
                quenry = query + tracuu;
            }
            else quenry = query;
            return quenry;
        }
        public string Load()
        {
            return query;
        }
        public void Load_UC_Con(FlowLayoutPanel flPanelDSLV, string truyVan,Person person)
        {
            
            try
            {
                conn.Open();
                flPanelDSLV.Controls.Clear();
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    UCLV uclv = new UCLV(person);
                    uclv.MaLV = dataReader["MaLV"].ToString();
                    uclv.LblTenLV.Text = dataReader["TenLV"].ToString();
                    uclv.LblChuyenNganh.Text = dataReader["ChuyenNganh"].ToString();
                    uclv.LblTenGV.Text = dataReader["TenGV"].ToString();
                    uclv.LblTrangThai.Text = dataReader["TrangThai"].ToString();

                    flPanelDSLV.Controls.Add(uclv);
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
        public string TraCuuChuyenNganh(string chuyenNganh)
        {
            if (chuyenNganh != "Tất cả")
            {
                string tracuu = " and ChuyenNganh = N'" + chuyenNganh + "'";
                quenry = query + tracuu;
            }
            else quenry = query;
            return quenry;
        }
        public bool checkTungNguoiDangKy(string MSSV)
        {

            string sqlStr = string.Format("SELECT * FROM DSThanhVien WHERE MSSV1 = '{0}' OR MSSV2 = '{1}' OR MSSV3 = '{2}'", MSSV, MSSV, MSSV);
            if (KiemTra(sqlStr))
            {
                return true;
            }
            string sqlStr3 = string.Format("SELECT * FROM DuyetDangKy WHERE MSSV1 = '{0}' OR MSSV2 = '{1}' OR MSSV3 = '{2}' AND TinhTrang = N'Đang chờ duyệt'", MSSV, MSSV, MSSV);
            if (KiemTra(sqlStr3))
            {
                return true;
            }
            return false;
        }
        public bool checkNguoiDangKy(LuanVanDuyet luanVan)
        {
            if(luanVan.getMSSV1() != "")
            {
                if (checkTungNguoiDangKy(luanVan.getMSSV1()))
                {
                    MessageBox.Show("MSSV1 đã có nhóm");
                    return false;
                }
            }
            if (luanVan.getMSSV2() != "")
            {
                if (checkTungNguoiDangKy(luanVan.getMSSV2()))
                {
                    MessageBox.Show("MSSV2 đã có nhóm");
                    return false;
                }
            }
            if (luanVan.getMSSV3() != "")
            {
                if (checkTungNguoiDangKy(luanVan.getMSSV3()))
                {
                    MessageBox.Show("MSSV3 đã có nhóm");
                    return false;
                }
            }
            return true;
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
