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
    public partial class icecream5 : Form
    {
        public icecream5()
        {
            InitializeComponent();
        }

        private void icecream5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            if (listBox1.SelectedItems.Count==0)
                t = "with no topping";
            else
            {
                t = "with topping";
                
               foreach(object SI in listBox1.SelectedItems)
                {
                    t +=" "+ SI.ToString();
                }
            }
            MessageBox.Show("A" + " " + s + " " + f + " " + "flavoured ice cream" + t + " " + "is selected");
        }
    }
}
