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
        public FNhom()
        {
            InitializeComponent();
        }

        DSNhomDAO nhomDAO = new DSNhomDAO();
        string query = "SELECT LuanVan.TenLV, LuanVan.ChuyenNganh, GiangVien.TenGV, LuanVan.TrangThai " +
                    "FROM LuanVan " +
                    "JOIN GiangVien ON LuanVan.MaGV = GiangVien.MaGV " +
                    "WHERE LuanVan.MaGV = 'GV001'" + " AND LuanVan.TrangThai = N'Đã có nhóm'";
        private void FNhom_Load(object sender, EventArgs e)
        {
            nhomDAO.getInfo(query, flpanelDSNhom);
        }

    }
}
