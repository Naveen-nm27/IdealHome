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
    public partial class SellerDashBoard : Form
    {
        public SellerDashBoard()
        {
            InitializeComponent();
        }

        private void logo_click(object sender, MouseEventArgs e)
        {
            IdealHome id = new IdealHome();
            id.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            IdealHome id = new IdealHome();
            id.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeDetail homedetail = new HomeDetail();
            homedetail.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddHome addhome = new AddHome();
            addhome.Show();
            this.Hide();
        }
    }
}
