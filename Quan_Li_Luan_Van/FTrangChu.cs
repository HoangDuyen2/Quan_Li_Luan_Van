﻿using System;
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
    public partial class FTrangChu : Form
    {
        public FTrangChu()
        {
            InitializeComponent();
        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {
            UCThongBao uCTB = new UCThongBao();
            panelTB.Controls.Add(uCTB);
        }

        private void btnThemThongBao_Click(object sender, EventArgs e)
        {
            FThemThongBao tb = new FThemThongBao();
            tb.ShowDialog();

        }
    }
}
