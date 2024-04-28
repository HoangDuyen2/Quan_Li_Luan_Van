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
        private string maGV;
        private string query;
        private DSNhomDAO dsnhom;
        public FNhom()
        {
            InitializeComponent();
        } 
        public FNhom(string maGV) :this()
        {
            this.maGV = maGV;
            dsnhom = new DSNhomDAO(this.maGV);
            this.query = dsnhom.Load();
        }
        
        private void FNhom_Load(object sender, EventArgs e)
        {
            dsnhom.LoadDSNhom(query,flpanelDSNhom,maGV);
        }
    }
}
