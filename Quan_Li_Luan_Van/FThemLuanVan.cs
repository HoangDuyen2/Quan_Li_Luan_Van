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
    public partial class FThemLuanVan : Form
    {
        private string maGiangVien;
        public FThemLuanVan()
        {
            InitializeComponent();
        }
        public FThemLuanVan(string maGV): this()
        {
            maGiangVien = maGV;
        }

        private void FThemLuanVan_Load(object sender, EventArgs e)
        {

        }

    }
}
