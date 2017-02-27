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
    public partial class icecream2: Form
    {
        public icecream2()
        {
            InitializeComponent();
        }

        private void GetOrder_Click(object sender, EventArgs e)
        {
            string s,f;
            if (rdSmall.Checked == true)
                s = "Small";
            else if (rdMedium.Checked == true)
                s = "Medium";
            else
                s = "Big";
            if (rdChocolate.Checked == true)
                f = "Chocolate";
            else
                f = "Strawberry";
            MessageBox.Show("A"+" "+s+" "+f+" "+"flavoured ice cream is selected");
        }
    }
}
