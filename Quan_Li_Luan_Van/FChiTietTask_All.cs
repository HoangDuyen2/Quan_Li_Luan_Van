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
        
        public FChiTietTask_All(string MaNV) : this()
        {
            this.maNV = MaNV;
            LoadInfoTask();
            LoadPhanHoi();
        }

        public FChiTietTask_All()
        {
            InitializeComponent();
        }

        public void LoadInfoTask()
        {
            ChiTietTaskDao taskDao = new ChiTietTaskDao(this.maNV);
            NhiemVu nhiemVu = taskDao.GetTask(this.maNV);

            if (nhiemVu != null && !nhiemVu.KiemTraNull())
            {
                txtTenNV.Text = nhiemVu.TenNV;
                txtTienTrinh.Text = nhiemVu.TienTrinh.ToString() + "%";
                txtNoiDungNV.Text = nhiemVu.NoiDung;
            }
        }

        public void LoadPhanHoi()
        {
            ChiTietTaskDao taskDao = new ChiTietTaskDao(this.maNV);
            taskDao.LoadListPhanHoi(this.maNV, fpnChat);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                this.Close();
            }

        }

        private PhanHoi TaoPhanHoi()
        {
            string ten = "Nguyễn Thùy An";
            string noiDung = txtPhanHoi.Text;
            DateTime thoiGian = DateTime.Now;
            string chuoiThoiGian = thoiGian.ToString("yyyy-MM-dd HH:mm:ss");

            return new PhanHoi(ten, chuoiThoiGian, noiDung, this.maNV);
        }
    }
}
