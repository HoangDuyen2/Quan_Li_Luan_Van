using ComponentFactory.Krypton.Toolkit;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Li_Luan_Van
{
    public partial class FDangNhap : Form
    {
        TaiKhoanDAO taiKhoan = new TaiKhoanDAO();
        Hide_Show hide = new Hide_Show();
        public FDangNhap()
        {
            InitializeComponent();
            txtTK.Enter += txtTK_GetFocus;
            txtMatKhau.Enter += TxtMatKhau_GetFocus;
            txtTK.LostFocus += txtTK_LostFocus;
            txtMatKhau.LostFocus += txtMatKhau_LostFocus;
        }

        private void TxtMatKhau_GetFocus(object sender, EventArgs e)
        {
            hide.Hide(sender,e);
        }

        private void txtTK_GetFocus(object sender, EventArgs e)
        {
            hide.Hide(sender, e);
        }

        private void txtTK_LostFocus(object sender, EventArgs e)
        {
            hide.Show(sender, e);
        }

        private void txtMatKhau_LostFocus(object sender, EventArgs e)
        {
            hide.Show(sender, e);
        }
        private void FLogin_Load(object sender, EventArgs e)
        {
            taiKhoan.Load();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string chucVu = "";
            if (rbtnSV.Checked) chucVu = "Sinh viên";
            else chucVu = "Giảng viên";
            if (taiKhoan.DangNhap(taiKhoan.createTaiKhoan(txtTK.Text, txtMatKhau.Text, chucVu)))
            {
                if(chucVu == "Sinh viên")
                {
                    FSinhVien sv = new FSinhVien(taiKhoan.createTaiKhoan(txtTK.Text, txtMatKhau.Text, chucVu));
                    this.Hide();
                    sv.ShowDialog();
                    this.Close();
                }
                else
                {
                    FGiangVien gv = new FGiangVien(taiKhoan.createTaiKhoan(txtTK.Text, txtMatKhau.Text, chucVu));
                    this.Hide();
                    gv.ShowDialog();
                    this.Close();
                }

            }

            /*            if (rbtnSV.Checked)
                        {
                            this.Hide();
                            FSinhVien sv = new FSinhVien();
                            sv.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            this.Hide();
                            FGiangVien gv = new FGiangVien();
                            gv.ShowDialog();
                            this.Close();
                        }*/
        }
    }
}

