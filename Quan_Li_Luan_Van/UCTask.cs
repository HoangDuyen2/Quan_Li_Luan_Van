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
    public partial class UCTask : UserControl
    {
        public UCTask()
        {
            InitializeComponent();
        }
        public Label LbTienTrinh { get => lbTienTrinh; set => lbTienTrinh = value; }
        public Label LbTenLV { get => lbTenLV; set => lbTenLV = value; }
        public PictureBox PictureBoxNen { get => pictureBoxNen; set => pictureBoxNen = value; }
        public Button BtnChinhSua { get => btnChinhSua; set => btnChinhSua = value; }
        public Button ButtonXoa { get => buttonXoa; set => buttonXoa = value; }
        public Button BtnChiTiet { get => btnChiTiet; set => btnChiTiet = value; }
        public Label LbSoTienTrinh { get => lbSoTienTrinh; set => lbSoTienTrinh = value; }
        public Label LbTT { get => lbTT; set => lbTT = value; }
        public Label LbTrangThai { get => lbTrangThai; set => lbTrangThai = value; }
    }
}
