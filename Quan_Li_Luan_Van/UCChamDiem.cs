﻿using ComponentFactory.Krypton.Toolkit;
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
    public partial class UCChamDiem : UserControl
    {
        public UCChamDiem()
        {
            InitializeComponent();
        }
        public Label LblTenSV { get => lblTenSV; set => lblTenSV = value; }
        public Label LblMSSV { get => lblMSSV; set => lblMSSV = value; }
        public KryptonTextBox TxtDiem { get => txtDiem; set => txtDiem = value; }
    }
}
