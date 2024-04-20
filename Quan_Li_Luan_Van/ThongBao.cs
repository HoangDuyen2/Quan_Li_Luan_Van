using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public class ThongBao
    {
        private int id;
        private string tieuDe;
        private string noiDung;
        private string thoiGian;
        private string maLV; // Nhóm được gửi đến
        private string nguoiGui;

        public ThongBao() { }
        public ThongBao(int id, string tieuDe, string noiDung, string thoiGian,  string maLV)
        {
            this.Id = id;
            this.TieuDe = tieuDe;
            this.NoiDung = noiDung;
            this.ThoiGian = thoiGian;
            this.MaLV = maLV;
        }

        public ThongBao(string tieuDe, string noiDung, string thoiGian, string maLV)
        {
            this.TieuDe = tieuDe;
            this.NoiDung = noiDung;
            this.ThoiGian = thoiGian;
            this.MaLV = maLV;
        }

        public bool checkNullThongBao()
        {
            if (checkTieuDe() && checkNoiDung())
            {
                return true;
            }
            return false;
        }
        public bool checkTieuDe()
        {
            if (tieuDe == null || tieuDe == "")
            {
                MessageBox.Show("Tiêu đề không được để trống !");
                return false;
            }
            return true;
        }
        public bool checkNoiDung()
        {
            if (noiDung == null || noiDung == "")
            {
                MessageBox.Show("Nội dung không được để trống !");
                return false;
            }
            return true;
        }

        public int Id { get => id; set => id = value; }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string MaLV { get => maLV; set => maLV = value; }
        public string NguoiGui { get => nguoiGui; set => nguoiGui = value; }

    }
}
