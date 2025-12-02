using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdealHome
{
    public partial class AddHome : Form
    {
        
        public AddHome()
        {
            InitializeComponent();
            
        }

        Operations op = new Operations();
        
        private void AddHome_Load(object sender, EventArgs e)
        {
            txt_rent_price.Enabled = false;
            txt_sell_price.Enabled = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txt_sell_price.Enabled = true;
            }
            else
            {
                txt_sell_price.Enabled = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                txt_rent_price.Enabled = true;

            }
            else
            {
                txt_rent_price.Enabled = false;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int oid = 1;
            int price = 0;
            string sellOrRent = null;

            if (radioButton2.Checked) // Sell
            {
                sellOrRent = "Sell";
                if (!int.TryParse(txt_sell_price.Text.Trim(), out price))
                {
                    MessageBox.Show("Enter a valid sell price.");
                    return;
                }
            }
            else if (radioButton1.Checked) // Rent
            {
                sellOrRent = "Rent";
                if (!int.TryParse(txt_rent_price.Text.Trim(), out price))
                {
                    MessageBox.Show("Enter a valid rent price.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Select Rent or Sell.");
                return;
            }

            var home = new Home(
                txt_title.Text,
                combo_locate.Text,
                price,
                home_desc.Text,
                sellOrRent
            );

            bool added = op.addHome(home);

            if (added)
            {
                MessageBox.Show("House Added");
            }


        }

        private void price_rent_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
