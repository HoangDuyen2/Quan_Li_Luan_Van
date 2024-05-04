using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FDangKyLuanVan : Form
    {
        Hide_Show hide = new Hide_Show();
        SinhVien sinhVien = null;
        SinhVienDAO dangKy = new SinhVienDAO();
        public FDangKyLuanVan(SinhVien sinhVien)
        {
            InitializeComponent();
            txtTenGV.Enter += TxtTenGV_Click;
            txtTenGV.LostFocus += TxtTenGV_LostFocus;
            this.sinhVien = sinhVien;
        }

        private void TxtTenGV_LostFocus(object sender, EventArgs e)
        {
            hide.Show(sender,e);
        }

        private void TxtTenGV_Click(object sender, EventArgs e)
        {
            hide.Hide(sender, e);
        }

        private void FDKLV_Load(object sender, EventArgs e)
        {
            dangKy.Load_UC_Con(flPanelDSLV,dangKy.LoadDKLV(),sinhVien);
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            dangKy.Load_UC_Con(flPanelDSLV, dangKy.traCuuTenGV(txtTenGV.Text),sinhVien);
        }

        private void Chon_Chuyen_Nganh(object sender, EventArgs e)
        {
            string text = cbboxChuyenNganh.SelectedItem.ToString();
            
            dangKy.Load_UC_Con(flPanelDSLV, dangKy.TraCuuChuyenNganh(text),sinhVien);
        }
    }
}
