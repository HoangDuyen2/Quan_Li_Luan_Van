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
        private GiangVien giangVien;
        private string query;
        private GiangVienDAO giangVienDao;
        public FNhom()
        {
            InitializeComponent();
        }
        public FNhom(GiangVien gv) : this()
        {
            this.giangVien = gv;
            giangVienDao = new GiangVienDAO();
            this.query = giangVienDao.QueryLoadDSNhom(giangVien.getMaso());
        }
        private void FNhom_Load(object sender, EventArgs e)
        {
            giangVienDao.LoadListNhom(query, flpanelDSNhom);
        }
        public void LoadDSNhom()
        {
            giangVienDao.LoadListNhom(query, flpanelDSNhom);
        }
    }
}
