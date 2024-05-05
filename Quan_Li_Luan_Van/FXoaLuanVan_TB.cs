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
    public partial class FXoaLuanVan_TB : Form
    {
        private string maLV;
        GiangVienDAO luanvan = new GiangVienDAO();
        private FLuanVanCuaToi_GV parentForm;
        public FXoaLuanVan_TB()
        {
            InitializeComponent();
        }
        public FXoaLuanVan_TB(string maLV, FLuanVanCuaToi_GV parentForm) : this()
        {
            this.maLV = maLV;
            this.parentForm = parentForm;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            luanvan.XoaLuanVan(maLV);
            this.Close();

            if (parentForm != null)
            {
                parentForm.LoadDSLuanVan();
            }
            else
            {
                MessageBox.Show("Parent form is not available. Cannot refresh the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
