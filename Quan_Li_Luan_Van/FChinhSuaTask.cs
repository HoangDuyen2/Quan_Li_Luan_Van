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
    public partial class FChinhSuaTask : Form
    {
        private string maNguoi;
        private string manv;
        NhiemVu nv = null;
        PersonDAO personDAO = new PersonDAO();
        public FChinhSuaTask(string manhiemVu,string maNguoi):this()
        {
            this.manv = manhiemVu;
            this.maNguoi = maNguoi;
            InitializeComponent();
            LoadNhiemVu();
            if (!personDAO.checkMaNguoi(this.maNguoi))
                btnThem.Enabled = false;
        }
        public FChinhSuaTask()
        {
            
        }
        public void LoadNhiemVu()
        {
            nv = personDAO.LoadNhiemVu(manv);
            txtMaNV.Text = nv.MaNV;
            txtTenNV.Text = nv.TenNV;
            txtNoiDungNV.Text = nv.NoiDung;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            nv.TenNV = txtTenNV.Text;
            nv.NoiDung = txtNoiDungNV.Text;
            personDAO.chinhSuaNhiemVu(nv);
            this.Close();
        }
    }
}
