using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FSinhVien : Form
    {
        TaiKhoan taiKhoan;
        SinhVienDAO trangChinh = new SinhVienDAO();
        SinhVien sinhVien = null;

        public FSinhVien(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }

        public FSinhVien()
        {
            InitializeComponent();
        }

        //private Button currentButton;
        private Form activeForm;

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FSinhVien_Load(object sender, EventArgs e)
        {
            sinhVien = trangChinh.LoadLabel<SinhVien>(taiKhoan);
            labelMSSV.Text = sinhVien.getMaso();
            labelTen.Text = sinhVien.getHoTen();
            labelChucVu.Text = taiKhoan.getChucVu();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTrangChu(sinhVien), sender);
            FSinhVien_Load(sender, e);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyLuanVan(sinhVien), sender);
            FSinhVien_Load(sender, e);
        }

        private void btnLuanVan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLuanVanCuaToi_SV(sinhVien),sender);
            FSinhVien_Load(sender, e);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDangNhap fLogin = new FDangNhap();
            fLogin.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThongTinCaNhan_SV(sinhVien), sender);
            FSinhVien_Load(sender, e);
        }

    }

}
