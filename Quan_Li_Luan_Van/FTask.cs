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
    public partial class FTask : Form
    {
        public FTask()
        {
            InitializeComponent();
        }

        private void FTask_Load(object sender, EventArgs e)
        {
            UCTask uCTask = new UCTask();
            flPanelDSTask.Controls.Add(uCTask);
        }
    }
}
