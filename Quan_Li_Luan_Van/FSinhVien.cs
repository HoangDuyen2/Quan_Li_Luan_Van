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
        TrangChinhDAO trangChinh = new TrangChinhDAO();
        Person person = null;
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

        /*private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }*/
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
            /*person = trangChinh.LoadLabel(taiKhoan);
            labelMSSV.Text = person.getMaso();
            labelTen.Text = person.getHoTen();
            labelChucVu.Text = taiKhoan.getChucVu();*/
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTrangChu(), sender);
            //FSinhVien_Load(sender, e);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyLuanVan(), sender);
            //FSinhVien_Load(sender, e);
        }

        private void btnLuanVan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLuanVanToi_SV(),sender);
            //FSinhVien_Load(sender, e);
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
            OpenChildForm(new FThongTinCaNhan_SV(person), sender);
            //FSinhVien_Load(sender, e);
        }
    }
}
