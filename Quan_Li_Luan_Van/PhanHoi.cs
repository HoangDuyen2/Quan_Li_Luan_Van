using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class PhanHoi
    {    
        private int id;
        private string name;
        private string thoigian;
        private string noidung;
        private string nhiemvu;

        public PhanHoi() { }
        public PhanHoi(string name, string thoigian, string noidung, string nhiemvu)
        {
            this.name = name;
            this.thoigian = thoigian;
            this.noidung = noidung;
            this.nhiemvu = nhiemvu;
        }

        public bool checkNullPhanHoi()
        {
            if (noidung == null || noidung == "")
            {
                MessageBox.Show("Nội dung không được để trống !");
                return false;
            }
            return true;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string NhiemVu { get => nhiemvu; set => nhiemvu = value; }
    }
}
