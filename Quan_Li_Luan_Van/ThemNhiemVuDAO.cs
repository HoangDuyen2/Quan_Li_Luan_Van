using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    internal class ThemNhiemVuDAO
    {
        protected SqlConnection conn;
        protected DBConnection dbConnection;
        public ThemNhiemVuDAO()
        {
            conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            dbConnection = new DBConnection();
        }

        public void ThemNhiemVu(NhiemVu nhiemvu)
        {
            string sqlThem = string.Format("INSERT INTO NhiemVu(MaNV, TenNV, NoiDung, TienTrinh, TrangThai, MaLV) " +
                "VALUES (N'{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}')",
                nhiemvu.MaNV, nhiemvu.TenNV, nhiemvu.NoiDung, nhiemvu.TienTrinh, nhiemvu.TrangThai, nhiemvu.MaLV);
            dbConnection.ThucThi(sqlThem);
        }
    }
}
