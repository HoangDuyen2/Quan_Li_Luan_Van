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
        private string MSSV;
        private SinhVienDAO svDAO = new SinhVienDAO();
        private FLuanVanCuaToi_SV parentForm;
        public FCapNhatTienTrinh()
        {
            InitializeComponent();
        }
        public FCapNhatTienTrinh(string maNV, string maSV, FLuanVanCuaToi_SV parentForm) : this()
        {
            this.maNV = maNV;
            this.MSSV = maSV;
            LoadInfoTask();
            LoadCapNhatTienTrinh();
            LoadPhanHoi();
            LoadDataChart();
            InitializeProgressLabel();
            if (svDAO.getTinhTrangLVCuaToi(svDAO.getMaLVCuaToi(maSV)) == "Đã hoàn thành")
            {
                btnCapNhat.Enabled = false;
                btnPhanHoi.Enabled = false;
            }
            this.parentForm = parentForm;
        }
        public void LoadInfoTask()
        {
            NhiemVu nhiemVu = svDAO.GetTask(this.maNV);

            if (nhiemVu != null && !nhiemVu.KiemTraNull())
            {
                txtTenNV.Text = nhiemVu.TenNV;
                txtTienTrinh.Text = nhiemVu.TienTrinh.ToString();
                txtNoiDungNV.Text = nhiemVu.NoiDung;
                TrackTienTrinh.Value = nhiemVu.TienTrinh;
            }
        }
        public void LoadPhanHoi()
        {
            svDAO.LoadListPhanHoi(this.maNV, fpnChat);
        }
        public void LoadCapNhatTienTrinh()
        {
            svDAO.LoadListCapNhatTienTrinh(this.maNV, fpnUpdateTask);
        }
        public void LoadDataChart()
        {
            DataTable dt = svDAO.GetStudentProgressData(this.maNV);
            chartTienDo.Series.Clear();
            chartTienDo.Series.Add("Progress");
            chartTienDo.Series["Progress"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            foreach (DataRow row in dt.Rows)
            {
                string studentName = row["TenSV"].ToString();
                int progress = 0;
                if (!Convert.IsDBNull(row["TongPhanTramCapNhat"]))
                {
                    progress = Convert.ToInt32(row["TongPhanTramCapNhat"]);
                }

                int pointIndex = chartTienDo.Series["Progress"].Points.AddXY(studentName, progress);
                chartTienDo.Series["Progress"].Points[pointIndex].Label = $"{progress}%";
                chartTienDo.Series["Progress"].Points[pointIndex].Color = GetColorBasedOnProgress(progress);
            }

            chartTienDo.Series["Progress"].BorderWidth = 2;
            chartTienDo.ChartAreas[0].AxisX.Interval = 1;
            chartTienDo.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Tahoma", 8);
            chartTienDo.ChartAreas[0].AxisY.Minimum = 0;
            chartTienDo.ChartAreas[0].AxisY.Maximum = 100;
            chartTienDo.ChartAreas[0].AxisY.Interval = 10;
            chartTienDo.ChartAreas[0].AxisY.LabelStyle.Angle = 0;
            chartTienDo.Legends[0].Enabled = false;
            chartTienDo.ChartAreas[0].RecalculateAxesScale();
        }
        private Color GetColorBasedOnProgress(int progress)
        {
            if (progress < 10)
                return System.Drawing.Color.Red;
            else if (progress < 20)
                return System.Drawing.Color.Orange;
            else if (progress < 30)
                return System.Drawing.Color.YellowGreen;
            else
                return System.Drawing.Color.Green;
        }
        private void InitializeProgressLabel()
        {
            if (txtTienTrinh != null && lblThanhTienDo != null)
            {
                lblThanhTienDo.Text = "Tiến độ: " + txtTienTrinh.Text + "%";
            }
        }
        private PhanHoi TaoPhanHoi()
        {
            string tenNguoiGui = svDAO.TenThanhVien(MSSV);
            string noiDung = txtPhanHoi.Text;
            DateTime thoiGian = DateTime.Now;
            string chuoiThoiGian = thoiGian.ToString("yyyy-MM-dd HH:mm:ss");

            return new PhanHoi(tenNguoiGui, chuoiThoiGian, noiDung, this.maNV);
        }
        private void btnPhanHoi_Click(object sender, EventArgs e)
        {
            PhanHoi ph = TaoPhanHoi();
            if (!ph.checkNullPhanHoi())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                svDAO.ThemPhanHoi(ph);
                MessageBox.Show("Thêm thành công");
                txtPhanHoi.Text = "";
                LoadPhanHoi();
            }
        }
        private CapNhatTienTrinh TaoCapNhatTienTrinh()
        {
            int tienTrinhCu = int.Parse(txtTienTrinh.Text.Trim());
            int tienTrinhMoi = TrackTienTrinh.Value;

            if (tienTrinhCu == 100)
            {
                MessageBox.Show("Nhiệm vụ này đã hoàn thành xong.", "Có thể chọn nhiệm vụ khác để làm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (tienTrinhMoi <= tienTrinhCu)
            {
                MessageBox.Show("Giá trị tiến trình mới phải lớn hơn giá trị tiến trình hiện tại.", "Vui lòng chọn lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            int capNhat = tienTrinhMoi - tienTrinhCu;
            DateTime thoiGian = DateTime.Now;
            string chuoiThoiGian = thoiGian.ToString("yyyy-MM-dd HH:mm:ss");

            return new CapNhatTienTrinh(this.maNV, this.MSSV, capNhat, tienTrinhMoi, chuoiThoiGian);
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhatTienTrinh update = TaoCapNhatTienTrinh();
            if (update == null)
            {
                return;
            }
            bool result = svDAO.UpdateProgress(update);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDataChart();
                LoadCapNhatTienTrinh();
                LoadInfoTask();
                if (parentForm != null)
                {
                    parentForm.LoadNhiemVu();
                }
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.");
            }
        }
        private void TrackTienTrinh_ValueChanged(object sender, EventArgs e)
        {
            if (lblThanhTienDo != null)
            {
                lblThanhTienDo.Text = "Tiến độ: " + TrackTienTrinh.Value.ToString() + "%";
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
