using ComponentFactory.Krypton.Toolkit;
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
    public partial class UCPhanHoi : UserControl
    {
        public UCPhanHoi()
        {
            InitializeComponent();
        }
        public Label LblTen { get => lblTen; set => lblTen = value; }
        public Label LblThoiGian { get => lblThoiGian; set => lblThoiGian = value; }
        public KryptonRichTextBox TxtNoiDung { get => txtPhanHoi; set => txtPhanHoi = value; }
    }
}
