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
    public partial class FLuanVanToi_SV : Form
    {
        Person person = null;
        LuanVanCuaToiSVDAO luanVan = new LuanVanCuaToiSVDAO();
        public FLuanVanToi_SV(Person person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void FLuanVanToi_SV_Load(object sender, EventArgs e)
        {
            luanVan.Load(person,flPanelDSTask);
        }
    }
}
