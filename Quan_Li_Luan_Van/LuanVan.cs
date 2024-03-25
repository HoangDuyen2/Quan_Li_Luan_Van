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
                if (prop.GetValue(this) == "")
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
    }
}
