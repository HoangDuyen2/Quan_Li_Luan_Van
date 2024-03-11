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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (rbtnSV.Checked)
            {
                this.Hide();
                FSinhVien sv = new FSinhVien();
                sv.ShowDialog();
                this.Close();
            }
            else if (rbtnGV.Checked)
            {
                this.Hide();
                FGiangVien gv = new FGiangVien();
                gv.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select either SV or GV.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
