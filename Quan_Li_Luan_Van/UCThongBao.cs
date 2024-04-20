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
    public partial class UCThongBao : UserControl
    {
        private string ID_TB;
        public UCThongBao()
        {
            InitializeComponent();
        }

        private void buttonThongBao_Click(object sender, EventArgs e)
        {
            FChiTietThongBao tb = new FChiTietThongBao(ID_TB);
            tb.ShowDialog();
        }
        public PictureBox PicBoxUser { get => picBoxUser; set => picBoxUser = value; }
        public Label LblTieuDe { get => lblTieuDe; set => lblTieuDe = value; }
        public Label LbNoiDungTB { get => lbNoiDungTB; set => lbNoiDungTB = value; }
        public Button BtnXem { get => btnXem; set => btnXem = value; }
        public Label LblThoiGian { get => lblThoiGian; set => lblThoiGian = value; }
        public string ID_TB1 { get => ID_TB; set => ID_TB = value; }
    }
}
