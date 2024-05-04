using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FChinhLuanVan : Form
    {
        private string maLV;
        private string maGV;
        GiangVienDAO lvDAO = new GiangVienDAO();
        LuanVan lv = new LuanVan();
        public FChinhLuanVan()
        {
            InitializeComponent();
        }

        public FChinhLuanVan(string maLV, string maGV) : this()
        {
            this.maLV = maLV;
            this.maGV = maGV;
        }

        private void FChinhSuaLuanVan_Load(object sender, EventArgs e)
        {
            
            lv = lvDAO.getLuanVan(maLV);
            txtMaLuanVan.Text = lv.MaLV.ToString();
            txtMaLuanVan.Enabled = false;
            txtTenLuanVan.Text = lv.TenLV.ToString();
            txtChucNang.Text = lv.ChucNang.ToString();
            txtYeuCau.Text = lv.YeuCau.ToString();
            cbboxChuyenNganh.SelectedItem = lv.ChuyenNganh;
            cbboxCongNghe.SelectedItem = lv.CongNghe;
            cbboxLinhVuc.SelectedItem = lv.LinhVuc;
            cbboxNgonNgu.SelectedItem = lv.NgonNgu;
            this.ActiveControl = null;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            LuanVan lv = TaoLuanVan();
            if (lv.KiemTraNull())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                lvDAO.ChinhSua(lv);
                MessageBox.Show("Lưu thành công");
                this.Close();
            }

        }
        private LuanVan TaoLuanVan()
        {
            string maLuanVan = txtMaLuanVan.Text;
            string tenLuanVan = txtTenLuanVan.Text;
            string chuyenNganh = cbboxChuyenNganh.SelectedItem != null ? cbboxChuyenNganh.SelectedItem.ToString() : "";
            string linhVuc = cbboxLinhVuc.SelectedItem != null ? cbboxLinhVuc.SelectedItem.ToString() : "";
            string chucNang = txtChucNang.Text;
            string congNghe = cbboxCongNghe.SelectedItem != null ? cbboxCongNghe.SelectedItem.ToString() : "";
            string ngonNgu = cbboxNgonNgu.SelectedItem != null ? cbboxNgonNgu.SelectedItem.ToString() : "";
            string yeuCau = txtYeuCau.Text;
            return new LuanVan(maLuanVan, tenLuanVan, maGV, chuyenNganh, linhVuc, chucNang, congNghe, ngonNgu, yeuCau, "Chưa có nhóm");
        }

        private void txtYeuCau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
