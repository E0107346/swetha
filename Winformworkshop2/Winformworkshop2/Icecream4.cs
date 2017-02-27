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
    public partial class Icecream4 : Form
    {
        public Icecream4()
        {
            InitializeComponent();
        }

        private void btnGetorder_Click(object sender, EventArgs e)
        {
            string s, f, t;
            if (comboBox1.Text == "Small")
                s = "Small";
            else if (comboBox1.Text == "Medium")
                s = "Medium";
            else
                s = "Big";
            if (rbChocolate.Checked == true)
                f = "Chocolate";
            else
                f = "Strawberry";

            if (!rbNuts.Checked && !rbRaisins.Checked && !rbChocolatechips.Checked)
                t = "with no topping";
            else
            {
                t = "with topping";
                t += " ";
                if (rbNuts.Checked == true)
                    t += "Nuts";
                else if (rbRaisins.Checked == true)
                    t += "Raisins";
                else
                    t += "Chocolate chips";
            }
            MessageBox.Show("A" + " " + s + " " + f + " " + "flavoured ice cream" +t+" " + "is selected");
        }
    }
}
