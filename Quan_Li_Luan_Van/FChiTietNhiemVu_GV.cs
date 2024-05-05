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
        GiangVienDAO gvDAO = new GiangVienDAO();
        public FChiTietTask_All()
        {
            InitializeComponent();
        }
        public FChiTietTask_All(string MaNV, string maGV) : this()
        {
            this.maNV = MaNV;
            this.maGV = maGV;
            LoadInfoTask();
            LoadPhanHoi();
            LoadCapNhatTienTrinh();
            LoadDataChart();
        }
        public void LoadDataChart()
        {
            DataTable dt = gvDAO.GetStudentProgressData(this.maNV);
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
        public void LoadInfoTask()
        {
            NhiemVu nhiemVu = gvDAO.GetTask(this.maNV);

            if (nhiemVu != null && !nhiemVu.KiemTraNull())
            {
                txtTenNV.Text = nhiemVu.TenNV;
                txtTienTrinh.Text = nhiemVu.TienTrinh.ToString();
                txtNoiDungNV.Text = nhiemVu.NoiDung;
            }
        }
        public void LoadCapNhatTienTrinh()
        {
            gvDAO.LoadListCapNhatTienTrinh(this.maNV, fpnUpdateTask);
        }
        public void LoadPhanHoi()
        {
            gvDAO.LoadListPhanHoi(this.maNV, fpnChat);
        }
        private void btnPhanHoi_Click(object sender, EventArgs e)
        {;
            PhanHoi ph = TaoPhanHoi();
            if (!ph.checkNullPhanHoi())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                gvDAO.ThemPhanHoi(ph);
                MessageBox.Show("Thêm thành công");
                txtPhanHoi.Text = "";
                LoadPhanHoi();
            }
        }
        private PhanHoi TaoPhanHoi()
        {
            string tenNguoiGui = gvDAO.GetTenGV(maGV);
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
