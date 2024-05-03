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
            LoadCapNhatTienTrinh();
            LoadDataChart();
        }

        public FChiTietTask_All()
        {
            InitializeComponent();
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

        public void LoadCapNhatTienTrinh()
        {
            GiangVienDAO tientrinh = new GiangVienDAO();
            tientrinh.LoadListCapNhatTienTrinh(this.maNV, fpnUpdateTask);
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
