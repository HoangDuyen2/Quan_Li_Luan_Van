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
        private string maNguoiDN;
        private string maNV;
        NhiemVu nv = null;
        PersonDAO personDAO = new PersonDAO();
        public FChinhSuaTask(string manhiemVu,string maNguoi):this()
        {
            this.maNV = manhiemVu;
            this.maNguoiDN = maNguoi;
            InitializeComponent();
            LoadNhiemVu();
            if (!personDAO.checkMaNguoi(this.maNguoiDN, this.maNV))
                btnChinhSua.Enabled = false;
        }
        public FChinhSuaTask()
        {
            
        }
        public void LoadNhiemVu()
        {
            nv = personDAO.LoadNhiemVu(maNV);
            txtMaNV.Text = nv.MaNV;
            txtTenNV.Text = nv.TenNV;
            txtNoiDungNV.Text = nv.NoiDung;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            nv.TenNV = txtTenNV.Text;
            nv.NoiDung = txtNoiDungNV.Text;
            personDAO.chinhSuaNhiemVu(nv);
            this.Close();
        }
    }
}
