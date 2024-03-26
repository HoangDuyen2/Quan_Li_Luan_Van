using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class DangKyLuanVan_SVDAO
    {
        DBConnection dbConnection = new DBConnection();

        public void DangKy(LuanVanDuyet luanVan)
        {
            string query;
            if (luanVan.getMSSV3() == "")
            {
                query = string.Format("INSERT INTO DuyetDangKy (MaLV, MSSV1, MSSV2, MSSV3, TinhTrang) " + "VALUES ('{0}','{1}','{2}',NULL,N'Đang chờ duyệt')",
                luanVan.getMaLV(), luanVan.getMSSV1(), luanVan.getMSSV2());
            }
            else
            {
                query = string.Format("INSERT INTO DuyetDangKy (MaLV, MSSV1, MSSV2, MSSV3, TinhTrang) " + "VALUES ('{0}','{1}','{2}','{3}',N'Đang chờ duyệt')",
                luanVan.getMaLV(), luanVan.getMSSV1(), luanVan.getMSSV2(), luanVan.getMSSV3());
            }
            dbConnection.ThucThi(query);
        }
    }
}
