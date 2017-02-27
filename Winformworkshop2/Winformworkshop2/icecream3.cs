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
    public partial class icecream3 : Form
    {
        public icecream3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s, f,t;
            if (rbSmall.Checked == true)
                s = "Small";
            else if (rbMedium.Checked == true)
                s = "Medium";
            else
                s = "Big";
            if (rbChocolate.Checked == true)
                f = "Chocolate";
            else
                f = "Strawberry";

            if (!rbNuts.Checked && !rbRaisins.Checked && !rbtChocolate.Checked)
                t = "with no topping";
            else
            {
                t = "with topping";
                if (rbNuts.Checked == true)
                    t+= "Nuts";
                else if (rbRaisins.Checked == true)
                    t+= "Raisins";
                else
                    t+= "Chocolate chips";
            }
            MessageBox.Show("A"+" " +s+" "+f+" "+"flavoured ice cream"+t+" "+"is selected");
        }
    }
}
