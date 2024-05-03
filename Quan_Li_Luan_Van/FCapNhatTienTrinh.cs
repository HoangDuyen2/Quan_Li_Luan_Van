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
            LoadCapNhatTienTrinh();
            LoadPhanHoi();
            LoadDataChart();
        }
        public void LoadInfoTask()
        {
            GiangVienDAO task = new GiangVienDAO(); // Có thể sài chung
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
            GiangVienDAO task = new GiangVienDAO();
            task.LoadListPhanHoi(this.maNV, fpnChat);
        }
        public void LoadCapNhatTienTrinh()
        {
            GiangVienDAO tientrinh = new GiangVienDAO();
            tientrinh.LoadListCapNhatTienTrinh(this.maNV, fpnUpdateTask);
        }
        public void LoadDataChart()
        {
            GiangVienDAO chartData = new GiangVienDAO();
            DataTable dt = chartData.GetStudentProgressData(this.maNV);
            chartTienDo.Series.Clear();
            chartTienDo.Series.Add("Progress");
            chartTienDo.Series["Progress"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;


            chartTienDo.Series["Progress"].Color = System.Drawing.Color.DodgerBlue;
            chartTienDo.Series["Progress"].BorderWidth = 2;

            foreach (DataRow row in dt.Rows)
            {
                int pointIndex = chartTienDo.Series["Progress"].Points.AddXY(row["TenSV"], row["TongPhanTramCapNhat"]);
                chartTienDo.Series["Progress"].Points[pointIndex].Label = $"{row["TongPhanTramCapNhat"]}%";
            }


            chartTienDo.ChartAreas[0].AxisX.Interval = 1;
            chartTienDo.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartTienDo.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Tahoma", 8);
            chartTienDo.ChartAreas[0].AxisY.Minimum = 0;
            chartTienDo.ChartAreas[0].AxisY.Maximum = 100;
            chartTienDo.ChartAreas[0].AxisY.Interval = 10;


            chartTienDo.Titles.Clear();
            chartTienDo.Titles.Add("Progress of Students");
            chartTienDo.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);

            chartTienDo.ChartAreas[0].RecalculateAxesScale();
        }
        private void btnPhanHoi_Click(object sender, EventArgs e)
        {
            GiangVienDAO phanhoi = new GiangVienDAO();
            PhanHoi ph = TaoPhanHoi();
            if (!ph.checkNullPhanHoi())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                phanhoi.ThemPhanHoi(ph);
                MessageBox.Show("Thêm thành công");
                txtPhanHoi.Text = "";
                LoadPhanHoi();
            }
        }
        private PhanHoi TaoPhanHoi()
        {
            SinhVienDAO ph = new SinhVienDAO();

            string tenNguoiGui = ph.GetTenSV(maSV);
            string noiDung = txtPhanHoi.Text;
            DateTime thoiGian = DateTime.Now;
            string chuoiThoiGian = thoiGian.ToString("yyyy-MM-dd HH:mm:ss");

            return new PhanHoi(tenNguoiGui, chuoiThoiGian, noiDung, this.maNV);
        }
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
            SinhVienDAO dao = new SinhVienDAO();
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
