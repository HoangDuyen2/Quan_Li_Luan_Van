using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class CapNhatTienTrinh
    {
        private string maNV;
        private string mSSV;
        private int phanTramCapNhat;
        private int tienTrinh;
        private string thoiGian;
        
        public CapNhatTienTrinh(string maNV, string MSSV, int phanTramCapNhat, int tienTrinh, string thoiGian)
        {
            this.MaNV = maNV;
            this.mSSV = MSSV;
            this.phanTramCapNhat = phanTramCapNhat;
            this.TienTrinh = tienTrinh;
            this.ThoiGian = thoiGian;
        }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MSSV { get => mSSV; set => mSSV = value; }
        public int PhanTramCapNhat { get => phanTramCapNhat; set => phanTramCapNhat = value; }
        public int TienTrinh { get => tienTrinh; set => tienTrinh = value; }
        public string ThoiGian { get => thoiGian; set => thoiGian = value; }
    }
}
