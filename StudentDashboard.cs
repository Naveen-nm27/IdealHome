using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace IdealHome
{
    public partial class StudentDashboard : Form
    {
        Operations operations = new Operations();
        private List<Dictionary<string, string>> allHomes;
        private int startIndex = 0;

        public int UserID { get; set; }
        int userid = 0;

        public StudentDashboard(int userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void logo_click(object sender, MouseEventArgs e)
        {
            IdealHome ih = new IdealHome();
            ih.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddHome add = new AddHome();
            add.Show();
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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        int a = 0;
        private void button8_Click_1(object sender, EventArgs e)
        {

            if (allHomes == null || allHomes.Count == 0) return;

            startIndex += 3;

            if (startIndex >= allHomes.Count)
                startIndex = 0;

            Show3Homes();
        }

        private void lbl_price_out_1_Click(object sender, EventArgs e)
        {

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

            string rel = h["ImagePath"];               // "Images\\Homes\\01.png"

            if (!h.ContainsKey("ImagePath") || string.IsNullOrWhiteSpace(h["ImagePath"]))
            {
                pb.Image = null;
                return;
            }


            string fullPath = Path.Combine(Application.StartupPath, rel);
            LoadImage(pb, fullPath);

            //MessageBox.Show(
            //    $"PropertyID={h["PropertyID"]}\nRel={h["ImagePath"]}\nFull={fullPath}\nExists={File.Exists(fullPath)}"
            //);

        }



        private void Show3Homes()
        {
            ShowCard(0, groupBox1, pictureBox1, lbl_price_out_1, lbl_rate_out_1, lbl_contact_out_1, label1);
            ShowCard(1, groupBox2, pictureBox2, lbl_price_out_2, lbl_rate_out_2, lbl_contact_out_2, label13);
            ShowCard(2, groupBox3, pictureBox3, lbl_price_out_3, lbl_rate_out_3, lbl_contact_out_3, label7);

        }


        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            allHomes = operations.GetAllPropertiesByUserId(UserID);
            allHomes = operations.GetAllProperties();


            var result = operations.selectUserName(UserID);


            label2.Text = $"Wellcome {result.fname} {result.lname}";
            startIndex = 0;
            Show3Homes();
        }

        private void LoadImage(PictureBox pb, string fullPath)
        {
            // clear old image (prevents memory/file lock issues)
            if (pb.Image != null)
            {
                pb.Image.Dispose();
                pb.Image = null;
            }

            if (!string.IsNullOrWhiteSpace(fullPath) && File.Exists(fullPath))
            {
                using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    pb.Image = Image.FromStream(fs);
                }
            }
            else
            {
                pb.Image = null;
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
