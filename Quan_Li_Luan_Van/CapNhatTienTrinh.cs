using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    internal class CapNhatTienTrinh
    {
        private string maNV;
        private string maSV;
        private int capNhat;
        private int tienTrinh;
        private string thoiGian;
        
        public CapNhatTienTrinh(string maNV, string maSV, int  capNhat, int tienTrinh, string thoiGian)
        {
            this.MaNV = maNV;
            this.MaSV = maSV;
            this.CapNhat = capNhat;
            this.TienTrinh = tienTrinh;
            this.ThoiGian = thoiGian;
        }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public int CapNhat { get => capNhat; set => capNhat = value; }
        public int TienTrinh { get => tienTrinh; set => tienTrinh = value; }
        public string ThoiGian { get => thoiGian; set => thoiGian = value; }
    }
}
