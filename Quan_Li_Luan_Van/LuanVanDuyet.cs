using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class LuanVanDuyet
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

        public LuanVanDuyet(string maLV, string tenLV, string maGV, string chuyenNganh, string linhVuc, string chucNang,
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

        public LuanVanDuyet() { }

        public string getMaLV() { return maLV; }
        public string getTenLV() { return tenLV; }
        public string getMaGV() { return maGV; }
        public string getChuyenNganh() { return chuyenNganh; }
        public string getLinhVuc() { return linhVuc; }
        public string getChucNang() { return chucNang; }
        public string getCongNghe() { return congNghe; }
        public string getNgonNgu() { return ngonNgu; }
        public string getYeuCau() { return yeuCau; }
        public string getTrangThai() { return trangThai; }
        public string getTenGV() { return tenGV; }
        public string getMSSV1() { return MSSV1; }
        public string getMSSV2() { return MSSV2; }
        public string getMSSV3() { return MSSV3; }
        public void setMaLV(string maLV) { this.maLV = maLV; }
        public void setTenLV(string tenLV) { this.tenLV = tenLV; }
        public void setMaGV(string maGV) { this.maGV = maGV; }
        public void setChuyenNganh(string chuyenNganh) { this.chuyenNganh = chuyenNganh; }
        public void setLinhVuc(string LinhVuc) { this.linhVuc = LinhVuc; }
        public void setChucNang(string chucNang) { this.chucNang = chucNang; }
        public void setCongNghe(string congNghe) { this.congNghe = congNghe; }
        public void setNgonNgu(string ngonNgu) { this.ngonNgu = ngonNgu; }
        public void setYeuCau(string yeuCau) { this.yeuCau = yeuCau; }
        public void setTrangThai(string trangThai) { this.trangThai = trangThai; }
        public void setTenGV(string tenGV) { this.tenGV = tenGV; }
        public void setMSSV1(string MSSV1) { this.MSSV1 = MSSV1; }
        public void setMSSV2(string MSSV2) { this.MSSV2 = MSSV2; }
        public void setMSSV3(string MSSV3) { this.MSSV3 = MSSV3; }
    }

}
