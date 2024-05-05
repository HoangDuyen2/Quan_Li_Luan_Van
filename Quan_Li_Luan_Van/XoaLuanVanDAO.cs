using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    internal class XoaLuanVanDAO
    {
        protected SqlConnection conn;
        protected DBConnection dbConnection;
        public XoaLuanVanDAO()
        {
            conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            dbConnection = new DBConnection();
        }
        public void XoaLuanVan(string maLV)
        {
            string XoaDuyet = string.Format("Delete From DuyetDangKy WHERE MaLV = '{0}'", maLV);
            dbConnection.ThucThi(XoaDuyet);
            string sqlXoa = string.Format("DELETE FROM LuanVan WHERE MaLV = '{0}'", maLV);
            dbConnection.ThucThi(sqlXoa);
        }
    }
}
