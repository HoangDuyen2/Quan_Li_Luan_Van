using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class SinhVien : Person
    {
        private float DiemSo;
        public SinhVien(string maso, string hoTen, string gioiTinh, string diaChi, string cCCD, string nTNS, string sDT, string email, float diemSo)
            : base(maso, hoTen, gioiTinh, diaChi, cCCD, nTNS, sDT, email)
        {
            DiemSo = diemSo;
        }
        public float getDiemSo() { return DiemSo; }
    }
}
