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
        TrangChinhDAO trangChinh = new TrangChinhDAO();
        Person person = null;
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
            person = trangChinh.LoadLabel(taiKhoan);
            labelMSSV.Text = person.getMaso();
            labelTen.Text = person.getHoTen();
            labelChucVu.Text = taiKhoan.getChucVu();

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
        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTrangChu(), sender);
            FGiangVien_Load(sender,e);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachLuanVan(), sender);
            FGiangVien_Load(sender, e);

        }

        private void btnLuanVan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDuyetLuanVan(person.getMaso()), sender);
            FGiangVien_Load(sender, e);
        }


        private void picboxUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThongTinCaNhan_GV(person), sender);
            FGiangVien_Load(sender, e);

        }

        private void btnLuanVanCuaToi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLuanVanToi(person.getMaso()), sender);
            FGiangVien_Load(sender, e);
        }

        private void btnDSNhom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FNhom(person.getMaso()), sender);
            FGiangVien_Load(sender, e);
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
