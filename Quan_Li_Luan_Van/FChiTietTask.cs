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
    public partial class FChiTietTask : Form
    {
        private string tenLV;
        public FChiTietTask(string TenLV) : this()
        {
            this.tenLV = TenLV;
        }

        public FChiTietTask()
        {
            InitializeComponent();
        }
    }
}
