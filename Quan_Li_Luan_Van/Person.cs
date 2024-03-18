using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class Person
    {
        private string Maso;
        private string HoTen;
        private string GioiTinh;
        private string DiaChi;
        private string CCCD;
        private string NTNS;
        private string SDT;
        private string Email;
        public Person(string maso, string hoTen, string gioiTinh, string diaChi, string cCCD, string nTNS, string sDT, string email)
        {
            Maso = maso;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            CCCD = cCCD;
            NTNS = nTNS;
            SDT = sDT;
            Email = email;
        }
        public string getMaso(){ return Maso; }
        public string getSDT() { return SDT; }
        public string getEmail() { return Email; }
        public string getHoTen() {  return HoTen; }
        public string getGioiTinh() { return GioiTinh; }
        public string getDiaChi() { return DiaChi; }
        public string getCCCD() { return CCCD; }
        public string getNTNS() {  return NTNS; }
    }
}
