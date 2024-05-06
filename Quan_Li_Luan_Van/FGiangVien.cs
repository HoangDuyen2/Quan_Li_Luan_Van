using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FGiangVien : Form
    {
        TaiKhoan taiKhoan;
        GiangVienDAO trangChinh = new GiangVienDAO();
        GiangVien gv ;
        public FGiangVien(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }
        public FGiangVien()
        {
            InitializeComponent();
        }

        private void FGiangVien_Load(object sender, EventArgs e)
        {
            gv = trangChinh.LoadLabel<GiangVien>(taiKhoan);
            labelMSSV.Text = gv.getMaso();
            labelTen.Text = gv.getHoTen();
            labelChucVu.Text = taiKhoan.getChucVu();
            OpenChildForm(new FNhom(gv), sender);
        }

        private Form activeForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachLuanVan(), sender);
        }

        private void btnLuanVan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDuyetLuanVan(gv.getMaso()), sender);
        }

        private void picboxUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThongTinCaNhan_GV(gv), sender);
        }

        private void btnLuanVanCuaToi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLuanVanCuaToi_GV(gv), sender);
        }

        private void btnDSNhom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FNhom(gv), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDangNhap fLogin = new FDangNhap();
            fLogin.ShowDialog();
            this.Close();
        }
    }
}
