using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Li_Luan_Van
{
    public partial class FThongTinCaNhan_GV : KryptonForm
    {
        Person person = null;
        public FThongTinCaNhan_GV(Person person)
        {
            InitializeComponent();
            this.person = person;
            ucThongTinCaNhan1.BtnChinhSua.Click += btnChinhSua_Click;
            ucThongTinCaNhan1.BtnOK.Click += btnOK_Click;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            ucThongTinCaNhan1.TruyCap(person);
        }

        private void FThongTinCaNhan_GV_Load(object sender, EventArgs e)
        {
            ucThongTinCaNhan1.KhongTruyCap(person);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            person = ucThongTinCaNhan1.capNhat(person,"GiangVien");
        }

    }

}
