﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Li_Luan_Van
{
    public partial class FThongTinCaNhan_SV : Form
    {
        Person person = null;
        public FThongTinCaNhan_SV(Person person)
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

        private void FThongTinCaNhan_SV_Load(object sender, EventArgs e)
        {
            ucThongTinCaNhan1.KhongTruyCap(person);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            person = ucThongTinCaNhan1.capNhat(person,"SinhVien");
        }

    }

}
