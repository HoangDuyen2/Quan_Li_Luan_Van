using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class Hide_Show
    {
        public void Hide(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            textBox.Text = "";
        }

        public void Show(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Mời nhập vào";
            }
        }
    }
}
