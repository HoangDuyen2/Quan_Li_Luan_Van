using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FThemNhiemVu : Form
    {
        private string maLV;
        private string idNguoiTao;
        PersonDAO nvDao = new PersonDAO();
        public FThemNhiemVu()
        {
            InitializeComponent();
        }

        public FThemNhiemVu(string maLV,string maGV) : this()
        {
            this.maLV = maLV;
            this.idNguoiTao = maGV;
        }
        private NhiemVu ThemNhiemVu()
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string noiDung = txtNoiDungNV.Text;
            string maNguoiTao = idNguoiTao;
            return new NhiemVu(maNV, tenNV, noiDung, 0, "Chưa hoàn thành", maNguoiTao, maLV);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhiemVu nv = ThemNhiemVu();
            if (nv.KiemTraNull())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                nvDao.ThemNhiemVu(nv);
                MessageBox.Show("Thêm thành công");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
    }
}
