using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    internal class NhiemVu
    {
            private string maNV;
            private string tenNV;
            private string noiDung;
            private int tienTrinh;
            private string trangThai;
            private string maLV;

            public NhiemVu(string maNV, string tenNV, string noiDung, int tienTrinh, string trangThai, string maLV)
            {
                this.MaNV = maNV;
                this.TenNV = tenNV;
                this.NoiDung = noiDung;
                this.TienTrinh = tienTrinh;
                this.TrangThai = trangThai;
                this.MaLV = maLV;
            }

            public bool KiemTraNull()
            {
                foreach (var prop in typeof(NhiemVu).GetProperties())
                {
                    if (prop.GetValue(this) == "")
                    {
                        return true;
                    }
                }
                return false;
            }

            public string MaNV { get => maNV; set => maNV = value; }
            public string TenNV { get => tenNV; set => tenNV = value; }
            public string NoiDung { get => noiDung; set => noiDung = value; }
            public int TienTrinh { get => tienTrinh; set => tienTrinh = value; }
            public string TrangThai { get => trangThai; set => trangThai = value; }
            public string MaLV { get => maLV; set => maLV = value; }
        
    }
}
