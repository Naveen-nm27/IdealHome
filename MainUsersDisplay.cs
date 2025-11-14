using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;


namespace IdealHome
{
    public partial class MainUsersDisplay : Form
    {
        private GroupBox groupBox1;

        public MainUsersDisplay()
        {
            InitializeComponent();
        }

        private GroupBox CreateHouseBox(int index, string address, string owner, string price, Image img)
        {
            GroupBox g = new GroupBox();
            g.Text = $"House {index}";
            g.Size = new Size(755, 128);
            g.Font = new Font("Segoe UI", 9);

            // Address label
            Label lblAddress = new Label();
            lblAddress.Text = "Address: " + address;
            lblAddress.Location = new Point(15, 30);
            lblAddress.AutoSize = true;

            // Owner label
            Label lblOwner = new Label();
            lblOwner.Text = "Owner: " + owner;
            lblOwner.Location = new Point(15, 60);
            lblOwner.AutoSize = true;

            // Price label
            Label lblPrice = new Label();
            lblPrice.Text = "Price: " + price;
            lblPrice.Location = new Point(290, 30);
            lblPrice.AutoSize = true;

            // DETAILS button
            Button btnDetails = new Button();
            btnDetails.Text = "Details";
            btnDetails.Size = new Size(90, 48);
            btnDetails.Location = new Point(543, 16);
            btnDetails.Tag = index;    // pass ID / index

            btnDetails.Click += (s, e) =>
            {
                MessageBox.Show("Open house details for: " + index);
                // open details form here...
            };

            // ADD TO LIST button
            Button btnAdd = new Button();
            btnAdd.Text = "Add To List";
            btnAdd.Size = new Size(90, 48);
            btnAdd.Location = new Point(543, 70);

            // House image
            PictureBox pb = new PictureBox();
            pb.Size = new Size(109, 108);
            pb.Location = new Point(640, 14);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = img;

            // Add all controls
            g.Controls.Add(lblAddress);
            g.Controls.Add(lblOwner);
            g.Controls.Add(lblPrice);
            g.Controls.Add(btnDetails);
            g.Controls.Add(btnAdd);
            g.Controls.Add(pb);

            return g;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StudentSignup signUp = new StudentSignup();
            signUp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeDetail homeDetail = new HomeDetail();
            homeDetail.Show();
            this.Hide();
        }

        private void MainUsersDisplay_Load(object sender, EventArgs e)
        {
            int y = 10;

                    // Example data (replace with DB results)
                    var houses = new List<(string address, string owner, string price, Image img)>
                        {
                            ("123 Road", "Naveen", "$100,000", null),
                            ("78 Main Street", "Amal", "$85,000", null),
                            ("14 Lake View", "Sithu", "$120,000", null),
                            ("14 Lake View", "Sithu", "$120,000", null),
                            ("14 Lake View", "Sithu", "$120,000", null),
                            ("14 Lake View", "Sithu", "$120,000", null)
                        };

                    int index = 1;
                    foreach (var h in houses)
                    {
                        GroupBox box = CreateHouseBox(index, h.address, h.owner, h.price, h.img);
                        box.Location = new Point(10, y);

                        panel1.Controls.Add(box);

                        y += box.Height + 10;
                        index++;
                    }
         }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
