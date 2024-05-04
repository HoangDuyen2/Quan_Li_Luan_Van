using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;

namespace Quan_Li_Luan_Van
{
    public class SinhVien : Person
    {
        public SinhVien(string maso, string hoTen, string gioiTinh, string diaChi, string cCCD, string nTNS, string sDT, string email)
            : base(maso, hoTen, gioiTinh, diaChi, cCCD, nTNS, sDT, email) { }
    }
}
