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
    public partial class UCLVCuaToi : UserControl
    {
        public UCLVCuaToi()
        {
            InitializeComponent();
        }

        public Label LblChuyenNganh { get => lblChuyenNganh; set => lblChuyenNganh = value; }
        public Label LblTenLV { get => lblTenLV; set => lblTenLV = value; }        
        public Label LblTrangThai { get => lblTrangThai; set => lblTrangThai = value;}

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            FChinhLuanVan chinhlv = new FChinhLuanVan(LblTenLV.Text);
            chinhlv.ShowDialog();
            
        }
    }
}
