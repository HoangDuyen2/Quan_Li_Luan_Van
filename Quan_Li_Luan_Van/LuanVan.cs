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
        private string maGV;
        private string chuyenNganh;
        private string linhVuc;
        private string chucNang;
        private string congNghe;
        private string ngonNgu;
        private string yeuCau;
        private string trangThai;
        private string MSSV1;
        private string MSSV2;
        private string MSSV3;
        private string tenGV;

        public LuanVan(string maLV, string tenLV, string maGV, string chuyenNganh, string linhVuc, string chucNang,
                        string congNghe, string ngonNgu, string yeuCau, string trangThai)
        {
            this.maLV = maLV;
            this.tenLV = tenLV;
            this.maGV = maGV;
            this.chuyenNganh = chuyenNganh;
            this.linhVuc = linhVuc;
            this.chucNang = chucNang;
            this.congNghe = congNghe;
            this.ngonNgu = ngonNgu;
            this.yeuCau = yeuCau;
            this.trangThai = trangThai;
        }
        public bool KiemTraNull()
        {
            foreach (var prop in typeof(LuanVan).GetProperties())
            {
                if (prop.GetValue(this) == null)
                {
                    return true;
                }
            }
            return false;
        }

        public LuanVan() { }
        public string MaLV { get => maLV; set => maLV = value; }
        public string TenLV { get => tenLV; set => tenLV = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }
        public string LinhVuc { get => linhVuc; set => linhVuc = value; }
        public string ChucNang { get => chucNang; set => chucNang = value; }
        public string CongNghe { get => congNghe; set => congNghe = value; }
        public string NgonNgu { get => ngonNgu; set => ngonNgu = value; }
        public string YeuCau { get => yeuCau; set => yeuCau = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string MSSV11 { get => MSSV1; set => MSSV1 = value; }
        public string MSSV21 { get => MSSV2; set => MSSV2 = value; }
        public string MSSV31 { get => MSSV3; set => MSSV3 = value; }
        public string getMaLV() { return maLV; }
        public string getTenLV() { return tenLV; }
        public string getMaGV() { return MaGV; }
        public string getChuyenNganh() { return chuyenNganh; }
        public string getLinhVuc() { return LinhVuc; }
        public string getChucNang() { return ChucNang; }
        public string getCongNghe() { return CongNghe; }
        public string getNgonNgu() { return NgonNgu; }
        public string getYeuCau() { return YeuCau; }
        public string getTrangThai() { return TrangThai; }
        public string getTenGV() { return tenGV; }
        public string getMSSV1() { return MSSV1; }
        public string getMSSV2() { return MSSV2; }
        public string getMSSV3() { return MSSV3; }
        public void setMaLV(string maLV) { this.maLV = maLV; }
        public void setTenLV(string tenLV) { this.tenLV = tenLV; }
        public void setMaGV(string maGV) { this.MaGV = maGV; }
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
        public void setMSSV3(string MSSV3) {  this.MSSV3 = MSSV3;}
    }
}
