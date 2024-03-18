using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class LuanVan
    {
        private string maLV;
        private string tenLV;
        private string MoTaChiTiet;
        private DateTime NgayBD;
        private DateTime NgayKT;
        private string GioBD;
        private string GioKT;
        private string chuyenNganh;
        private int soLuong;
        private string maGV;
        public LuanVan(string maLV, string tenLV, string moTaChiTiet, DateTime ngayBD, DateTime ngayKT, string gioBD, string gioKT, string chuyenNganh, int soLuong, string maGV)
        {
            this.maLV = maLV;
            this.tenLV = tenLV;
            MoTaChiTiet = moTaChiTiet;
            NgayBD = ngayBD;
            NgayKT = ngayKT;
            GioBD = gioBD;
            GioKT = gioKT;
            this.chuyenNganh = chuyenNganh;
            this.soLuong = soLuong;
            this.maGV = maGV;
        }
        public string getMaLV() {  return maLV; }
        public string getTenLV() { return tenLV; }
        public string getMoTaChiTiet() { return MoTaChiTiet; }
        public DateTime getNgayBD() {  return NgayBD; }
        public DateTime getNgayKT() {  return NgayKT; }
        public string getGioBD() {  return GioBD; }
        public string getChuyenNganh() {  return chuyenNganh; }
        public int getSoLuong() {  return soLuong; }
        public string getMaGV() {  return maGV; }
    }
}
