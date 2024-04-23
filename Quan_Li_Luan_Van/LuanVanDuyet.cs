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
        private string tenMSSV1;
        private string tenMSSV2;
        private string tenMSSV3;
        private string tenGV;

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
        public string TenMSSV1 { get => tenMSSV1; set => tenMSSV1 = value; }
        public string TenMSSV2 { get => tenMSSV2; set => tenMSSV2 = value; }
        public string TenMSSV3 { get => tenMSSV3; set => tenMSSV3 = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }

        public LuanVanDuyet(string maLV, string tenLV, string maGV, string chuyenNganh, string linhVuc, string chucNang,
                        string congNghe, string ngonNgu, string yeuCau, string trangThai)
        {
            this.MaLV = maLV;
            this.TenLV = tenLV;
            this.MaGV = maGV;
            this.ChuyenNganh = chuyenNganh;
            this.LinhVuc = linhVuc;
            this.ChucNang = chucNang;
            this.CongNghe = congNghe;
            this.NgonNgu = ngonNgu;
            this.YeuCau = yeuCau;
            this.TrangThai = trangThai;
        }

        public LuanVanDuyet() { }
    }

}
