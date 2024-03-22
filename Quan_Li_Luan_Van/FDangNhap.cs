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
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        TaiKhoanDAO taiKhoan = new TaiKhoanDAO();

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
            KryptonTextBox textBox = (KryptonTextBox)sender;
            textBox.Text = "";
        }

        private void txtTK_GetFocus(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            textBox.Text = "";
        }

        private void txtTK_LostFocus(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                txtTK.Text = "Username";
            }
        }

        private void txtMatKhau_LostFocus(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "111111";
            }
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
                this.Close();
        }

        private void txtMatKhau_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (txtTK.Text == "Username")  // here you can also use txtSearch.Text != "Poduct Name", but it could affect your search code possibly 
            {
                txtTK.Text = "";
            }
        }
    }
}

