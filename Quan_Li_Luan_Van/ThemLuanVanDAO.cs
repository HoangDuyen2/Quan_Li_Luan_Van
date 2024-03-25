using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace Quan_Li_Luan_Van
{
    internal class ThemLuanVanDAO
    {
        protected SqlConnection conn;
        protected DBConnection dbConnection;
        public ThemLuanVanDAO() 
        {
            conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            dbConnection = new DBConnection();
        }

        public void ThemLuanVan(LuanVan luanVan)
        {
            string sqlThem = string.Format("INSERT INTO LuanVan(MaLV, TenLV, MaGV, ChuyenNganh, LinhVuc, ChucNang, CongNghe,NgonNgu, YeuCau, TrangThai) VALUES ('{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}')",
                luanVan.MaLV, luanVan.TenLV, luanVan.MaGV, luanVan.ChuyenNganh, luanVan.LinhVuc, luanVan.ChucNang, luanVan.CongNghe, luanVan.NgonNgu, luanVan.YeuCau, luanVan.TrangThai);
            dbConnection.ThucThi(sqlThem);
        }

    }
}
