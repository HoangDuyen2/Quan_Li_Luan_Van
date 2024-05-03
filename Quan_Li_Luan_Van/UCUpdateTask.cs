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
    public partial class UCUpdateTask : UserControl
    {
        public UCUpdateTask()
        {
            InitializeComponent();
        }
        public Label LblTenSV { get => lblTenSV; set => lblTenSV = value; }
        public Label LblTienTrinh { get => lblTienTrinh; set => lblTienTrinh = value; }
        public Label LblThoiGian { get => lblThoiGian; set => lblThoiGian = value; }
    }
}
