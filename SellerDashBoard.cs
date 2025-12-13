using Mysqlx;
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
        Operations operations = new Operations();
        private List<Dictionary<string, string>> allHomes;
        private int startIndex = 0;

        int userid = 0;
        public SellerDashBoard(int userId)
        {
            this.userid = userId;
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

        private void ShowCard(
            int slot,
            GroupBox gb,
            PictureBox pb,
            Label lblTitle,
            Label lblAddress,
            Label lblPrice,
            Label lblDesc
        )
        {
            int index = startIndex + slot;

            if (index >= allHomes.Count)
            {
                gb.Visible = false;
                return;
            }

            gb.Visible = true;

            var h = allHomes[index];

            gb.Text = $"House {h["PropertyID"]}";
            lblTitle.Text = h["Title"];
            lblAddress.Text = h["Address"];
            lblPrice.Text = h["Price"];
            lblDesc.Text = h["Description"];

            LoadImage(pb, h["ImagePath"]);
        }


        private void Show3Homes()
        {
            ShowCard(0, groupBox1, pictureBox1, lbl_price_out_1, lbl_rate_out_1, lbl_contact_out_1, label1);
            ShowCard(1, groupBox2, pictureBox2, lbl_price_out_2, lbl_rate_out_2, lbl_contact_out_2, label13);
            ShowCard(2, groupBox3, pictureBox3, lbl_price_out_3, lbl_rate_out_3, lbl_contact_out_3, label7);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (allHomes == null || allHomes.Count == 0) return;

            startIndex += 3;

            if (startIndex >= allHomes.Count)
                startIndex = 0;

            Show3Homes();
        }


        private void LoadImage(PictureBox pb, string path)
        {
            if (pb.Image != null)
            {
                pb.Image.Dispose();
                pb.Image = null;
            }

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    pb.Image = Image.FromStream(fs);
                }
            }
        }
        private void SellerDashBoard_Load(object sender, EventArgs e)
        {


            allHomes = operations.GetAllPropertiesByUserId(userid);

            var result = operations.selectUserName(userid);
            label2.Text = $"Wellcome {result.fname} {result.lname}";

            startIndex = 0;
            Show3Homes();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            EditHomeDetails ed = new EditHomeDetails(userid);
            this.Hide();
            ed.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EditHomeDetails ed = new EditHomeDetails(userid);
            this.Hide();
            ed.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EditHomeDetails ed = new EditHomeDetails(userid);
            this.Hide();
            ed.Show();
        }
    }
}
