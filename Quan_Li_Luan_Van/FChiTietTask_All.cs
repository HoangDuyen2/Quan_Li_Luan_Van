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

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
