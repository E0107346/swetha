using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winformworkshop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string s;
            if (rdbtnSmall.Checked == true)
                s = "Small";
            else if (rdbtnMedium.Checked == true)
                s = "Medium";
            else 
                s = "Big";
            MessageBox.Show(s + " is selected");
        }

        private void sizeOrder_Click(object sender, EventArgs e)
        {
            size(sizeSmall);
            size(sizeMedium);
            size(sizeBig);
        }
        private void size(RadioButton rbtn)
        {
            if (rbtn.Checked == true)
                MessageBox.Show(rbtn.Text + " is selected");
        }
    }
}
