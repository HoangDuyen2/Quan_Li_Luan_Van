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
    public partial class FNhom : Form
    {
        private Person gv;
        private string query;
        private GiangVienDAO giangVienDao;

        public FNhom()
        {
            InitializeComponent();
        }

        public FNhom(Person gv) : this()
        {
            this.gv = gv;
            giangVienDao = new GiangVienDAO();
            this.query = giangVienDao.TruyVanDSNhom(gv.getMaso());
        }

        private void FNhom_Load(object sender, EventArgs e)
        {
            giangVienDao.DSNhomInfo(query, flpanelDSNhom);
        }
    }
}
