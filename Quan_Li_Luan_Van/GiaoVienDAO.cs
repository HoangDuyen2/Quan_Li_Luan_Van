using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    internal class GiaoVienDAO
    {
        DBConnection dbConn;
        string sqlQuery;
        public GiaoVienDAO() 
        {
            dbConn = new DBConnection();
        }
        public void ThemThongBao(ThongBao tb)
        {
            sqlQuery = string.Format("INSERT INTO ThongBao(TieuDe, NoiDung, ThoiGian, MaLV) VALUES (N'{0}', N'{1}', '{2}', '{3}')", tb.TieuDe, tb.NoiDung, tb.ThoiGian, tb.MaLV);
            dbConn.ThucThi(sqlQuery);
        }
    }
}
