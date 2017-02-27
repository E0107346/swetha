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
    public partial class combo1 : Form
    {
        public combo1()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex != -1)
            {
                if (MessageBox.Show("are you sure you want to delete Item","Delete Item",MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.Yes)
                {
                    ComboBox1.Items.Remove(ComboBox1.SelectedItem);
                }
                else
                    MessageBox.Show("your Item i not deleted");
            }
            else
                MessageBox.Show("Please select an item ");
        }
    }
}
