using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FChiTietTask_All : Form
    {
        private string maNV;
        private string maGV;
        
        
        public FChiTietTask_All(string MaNV, string maGV) : this()
        {
            this.maNV = MaNV;
            this.maGV = maGV;
            LoadInfoTask();
            LoadPhanHoi();
        }

        public FChiTietTask_All()
        {
            InitializeComponent();
        }

        public void LoadInfoTask()
        {
            GiangVienDAO task = new GiangVienDAO();
            NhiemVu nhiemVu = task.GetTask(this.maNV);

            if (nhiemVu != null && !nhiemVu.KiemTraNull())
            {
                txtTenNV.Text = nhiemVu.TenNV;
                txtTienTrinh.Text = nhiemVu.TienTrinh.ToString() + "%";
                txtNoiDungNV.Text = nhiemVu.NoiDung;
            }
        }

        public void LoadPhanHoi()
        {
            GiangVienDAO task = new GiangVienDAO();
            task.LoadListPhanHoi(this.maNV, fpnChat);
        }

        private void btnPhanHoi_Click(object sender, EventArgs e)
        {
            ChiTietTaskDao taskDao = new ChiTietTaskDao(this.maNV);
            PhanHoi ph = TaoPhanHoi();
            if (!ph.checkNullPhanHoi())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                taskDao.ThemPhanHoi(ph);
                MessageBox.Show("Thêm thành công");
                txtPhanHoi.Text = "";
                LoadPhanHoi();
            }

        }
        private PhanHoi TaoPhanHoi()
        {
            GiangVienDAO ph = new GiangVienDAO();

            string tenNguoiGui = ph.GetTenGV(maGV);
            string noiDung = txtPhanHoi.Text;
            DateTime thoiGian = DateTime.Now;
            string chuoiThoiGian = thoiGian.ToString("yyyy-MM-dd HH:mm:ss");

            return new PhanHoi(tenNguoiGui, chuoiThoiGian, noiDung, this.maNV);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
