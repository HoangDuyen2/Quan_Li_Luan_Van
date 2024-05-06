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
    public partial class FXemDiem : Form
    {
        private string maLV;
        SinhVienDAO sinhVienDAO = new SinhVienDAO();
        public FXemDiem(string MaLV) : this()
        {
            maLV = MaLV;
        }
        public FXemDiem()
        {
            InitializeComponent();
        }

        private void FXemDiem_Load(object sender, EventArgs e)
        {
            sinhVienDAO.LoadListScoreThanhVien(this.maLV, flpDSThanhVien,false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
