using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class ThongTinCaNhanDAO
    {
        DBConnection conn = new DBConnection();
        public void CapNhatThongTin(Person person)
        {
            string sqlStr = string.Format("UPDATE SinhVien SET TenSV = '{0}', GioiTinh = '{1}', DiaChi = '{3}', " +
            "CCCD = '{3}', NgaySinh = '{4}', SDT = '{5}', Email = '{6}' WHERE MSSV = '{7}'", person.getHoTen(), person.getGioiTinh(),
                person.getDiaChi(), person.getCCCD(), person.getNTNS(), person.getSDT(), person.getEmail(), person.getMaso());
            conn.ThucThi(sqlStr);
        }
    }
}
