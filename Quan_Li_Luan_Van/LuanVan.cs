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
        private string MaGV;
        private string chuyenNganh;
        private string LinhVuc;
        private string ChucNang;
        private string CongNghe;
        private string NgonNgu;
        private string YeuCau;
        private string TrangThai;
        private string tenGV;
        private string MSSV1;
        private string MSSV2;
        private string MSSV3;
        public LuanVan(string maLV, string tenLV, string maGV, string chuyenNganh,
            string LinhVuc,string ChucNang, string CongNghe, string NgonNgu, string YeuCau,
            string trangThai)
        {
            this.maLV = maLV;
            this.tenLV = tenLV;
            this.MaGV = maGV;
            this.chuyenNganh = chuyenNganh;
            this.LinhVuc = LinhVuc;
            this.ChucNang = ChucNang;
            this.CongNghe = CongNghe;
            this.NgonNgu = NgonNgu;
            this.YeuCau = YeuCau;
            this.TrangThai = trangThai;
        }
        public LuanVan() { }
        public string getMaLV() {  return maLV; }
        public string getTenLV() { return tenLV; }
        public string getMaGV() { return MaGV; }
        public string getChuyenNganh() {  return chuyenNganh; }
        public string getLinhVuc() { return LinhVuc; }
        public string getChucNang() { return ChucNang; }
        public string getCongNghe() { return CongNghe; }
        public string getNgonNgu() {  return NgonNgu; }
        public string getYeuCau() {  return YeuCau; }
        public string getTrangThai() { return TrangThai; }
        public string getTenGV() { return tenGV; }
        public string getMSSV1() { return MSSV1; }
        public string getMSSV2() { return MSSV2; }
        public string getMSSV3() { return MSSV3; }
        public void setMaLV(string maLV) {  this.maLV = maLV; }
        public void setTenLV(string tenLV) {  this.tenLV = tenLV; }
        public void setMaGV(string maGV) { this.MaGV =  maGV; }
        public void setChuyenNganh(string chuyenNganh) { this.chuyenNganh = chuyenNganh; }
        public void setLinhVuc(string LinhVuc) { this.LinhVuc = LinhVuc; }
        public void setChucNang(string chucNang) { this.ChucNang = chucNang; }
        public void setCongNghe(string congNghe) { this.CongNghe = congNghe; }
        public void setNgonNgu(string ngonNgu) { this.NgonNgu = ngonNgu; }
        public void setYeuCau(string yeuCau) { this.YeuCau = yeuCau; }
        public void setTrangThai(string trangThai) { this.TrangThai = trangThai; }
        public void setTenGV(string tenGV) { this.tenGV = tenGV; }
        public void setMSSV1(string MSSV1) { this.MSSV1 = MSSV1; }
        public void setMSSV2(string MSSV2) { this.MSSV2 = MSSV2; }
        public void setMSSV3(string MSSV3) { this.MSSV3 = MSSV3; }
    }
}
