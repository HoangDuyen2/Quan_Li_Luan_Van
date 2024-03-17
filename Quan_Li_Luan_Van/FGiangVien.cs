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
    public partial class FGiangVien : Form
    {
        public FGiangVien()
        {
            InitializeComponent();
        }

        private void FGiangVien_Load(object sender, EventArgs e)
        {

        }

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
        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTrangChu(), sender);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachLuanVan(), sender);
        }

        private void btnLuanVan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDuyetLuanVan(), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDangNhap fLogin = new FDangNhap();
            fLogin.ShowDialog();
            this.Close();
        }

        private void picboxUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThongTinCaNhan(), sender);
        }

        private void btnLuanVanCuaToi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLuanVanToi(), sender);
        }

        private void btnDSNhom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FNhom(), sender);
        }
    }
}
