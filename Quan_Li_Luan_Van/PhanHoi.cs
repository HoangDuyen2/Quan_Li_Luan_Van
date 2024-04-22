using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class PhanHoi
    {
        public PhanHoi() { }
        private int id;
        private string name;
        private string thoigian;
        private string noidung;
        private string nhom;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Nhom { get => nhom; set => nhom = value; }
    }
}
