using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FChamDiem : Form
    {
        private string maLV;
        private GiangVienDAO giangVienDAO;
        public FChamDiem()
        {
            InitializeComponent();
        }
        public FChamDiem(string maLV) : this()
        {
            this.maLV = maLV;
            this.giangVienDAO = new GiangVienDAO();
            LoadDSThanhVien();
            LoadDataChart();
        }
        public void LoadDSThanhVien()
        {
            giangVienDAO.LoadListThanhVien(this.maLV, flpDSThanhVien);
        }
        public void LoadDataChart()
        {
            DataTable dt = giangVienDAO.GetStudentProgressDataAll(this.maLV);
            chartTienDo.Series.Clear();
            chartTienDo.Series.Add("Progress");
            chartTienDo.Series["Progress"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            foreach (DataRow row in dt.Rows)
            {
                string studentName = row["TenSV"].ToString();
                int progress = 0;
                if (!Convert.IsDBNull(row["TongPhanTramHoanThanh"]))
                {
                    progress = Convert.ToInt32(row["TongPhanTramHoanThanh"]);
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
        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            bool allScoresValid = true;
            foreach (UCChamDiem uc in flpDSThanhVien.Controls)
            {
                if (string.IsNullOrWhiteSpace(uc.TxtDiem.Text) ||
                    !decimal.TryParse(uc.TxtDiem.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal score) ||
                    score < 0 || score > 10) 
                {
                    MessageBox.Show("Please enter a valid score for all students (0-10).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allScoresValid = false;
                    break;
                }
            }

            if (allScoresValid)
            {
                foreach (UCChamDiem uc in flpDSThanhVien.Controls)
                {
                    decimal score = decimal.Parse(uc.TxtDiem.Text, CultureInfo.InvariantCulture);
                    score = Math.Round(score, 2); 
                    string mssv = uc.LblMSSV.Text;
                    new GiangVienDAO().UpdateStudentScore(mssv, score);
                }
                MessageBox.Show("Scores updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
