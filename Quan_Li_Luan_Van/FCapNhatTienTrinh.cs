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
    public partial class FCapNhatTienTrinh : Form
    {
        private string maNV;
        private string maSV;
        public FCapNhatTienTrinh()
        {
            InitializeComponent();
        }
        public FCapNhatTienTrinh(string maNV, string maSV) :this()
        {
            this.maNV = maNV;
            this.maSV = maSV;
            LoadInfoTask();
        }
        public void LoadInfoTask()
        {
            GiangVienDAO task = new GiangVienDAO(); // có thể sài chung
            NhiemVu nhiemVu = task.GetTask(this.maNV);

            if (nhiemVu != null && !nhiemVu.KiemTraNull())
            {
                txtTenNV.Text = nhiemVu.TenNV;
                txtTienTrinh.Text = nhiemVu.TienTrinh.ToString() + "%";
                txtNoiDungNV.Text = nhiemVu.NoiDung;
                TrackTienTrinh.Value = nhiemVu.TienTrinh;
            }
        }
        public void LoadPhanHoi()
        {
            GiangVienDAO task = new GiangVienDAO();// có thể sài chung
            task.LoadListPhanHoi(this.maNV, fpnChat);
        }

        /*private PhanHoi TaoPhanHoi()
        {
            GiangVienDAO ph = new GiangVienDAO();

            string tenNguoiGui = ph.GetTenSV(maSV);
            string noiDung = txtPhanHoi.Text;
            DateTime thoiGian = DateTime.Now;
            string chuoiThoiGian = thoiGian.ToString("yyyy-MM-dd HH:mm:ss");

            return new PhanHoi(tenNguoiGui, chuoiThoiGian, noiDung, this.maNV);
        }*/

        private void FCapNhatTienTrinh_Load(object sender, EventArgs e)
        {

        }

        /*private void btnLuu_Click(object sender, EventArgs e)
        {
            CapNhatTienTrinh update = TaoCapNhatTienTrinh();
            if (update == null)
            {
                return;
            }
            GiangVienDAO dao = new GiangVienDAO();
            bool result = dao.UpdateProgress(update);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.");
            }
        }*/
        private CapNhatTienTrinh TaoCapNhatTienTrinh()
        {
            int tienTrinhCu = int.Parse(txtTienTrinh.Text.Replace("%", "").Trim());
            int tienTrinhMoi = TrackTienTrinh.Value;

            if (tienTrinhMoi <= tienTrinhCu)
            {
                MessageBox.Show("Giá trị tiến trình mới phải lớn hơn giá trị tiến trình hiện tại.", "Vui lòng chọn lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            int capNhat = tienTrinhMoi - tienTrinhCu;
            DateTime thoiGian = DateTime.Now;
            string chuoiThoiGian = thoiGian.ToString("yyyy-MM-dd HH:mm:ss");

            return new CapNhatTienTrinh(this.maNV, this.maSV, capNhat, tienTrinhMoi, chuoiThoiGian);
        }
    }
}
