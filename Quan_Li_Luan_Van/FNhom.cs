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
    public partial class FNhom : Form
    {
        public FNhom()
        {
            InitializeComponent();
        }

        private void FNhom_Load(object sender, EventArgs e)
        {
            UCNhom uCDuyet = new UCNhom();
            flpanelDSNhom.Controls.Add(uCDuyet);
        }
    }
}