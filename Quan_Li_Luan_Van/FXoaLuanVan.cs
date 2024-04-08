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
    public partial class FXoaLuanVan : Form
    {
        private string maLV;
        XoaLuanVanDAO xoaLV = new XoaLuanVanDAO();
        public FXoaLuanVan()
        {
            InitializeComponent();
        }
        public FXoaLuanVan(string maLV):this()
        {
            this.maLV = maLV;
        }

        private void FXoaLuanVan_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaLV.Xoa(maLV);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
