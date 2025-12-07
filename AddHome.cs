using Microsoft.VisualBasic;
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
        private FlowLayoutPanel flowLayoutPanelImages;

        public AddHome()
        {
            InitializeComponent();

            flowLayoutPanelImages = new FlowLayoutPanel();
            flowLayoutPanelImages.Name = "flowLayoutPanelImages";

            // Set position and size of the panel
            flowLayoutPanelImages.Location = new Point(13, 777);  // Your specified position
            flowLayoutPanelImages.Size = new Size(1068, 208);
            flowLayoutPanelImages.BackColor = Color.FromArgb(0, 192, 192);
            // Adjust width/height as needed

            flowLayoutPanelImages.AutoScroll = true;             // Enable scroll bar
            flowLayoutPanelImages.WrapContents = true;           // Wrap images to next line
            flowLayoutPanelImages.FlowDirection = FlowDirection.LeftToRight;

            this.Controls.Add(flowLayoutPanelImages);
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

        private void DisplayImagesOnPanel(List<string> imagePaths)
        {
            flowLayoutPanelImages.Controls.Clear();

            foreach (string path in imagePaths)
            {
                PictureBox pb = new PictureBox();
                pb.Width = 152;
                pb.Height = 210;                       // Updated height
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.Image = Image.FromFile(path);

                flowLayoutPanelImages.Controls.Add(pb);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Validate Property ID
            if (!int.TryParse(uid.Text, out int propertyId))
            {
                MessageBox.Show("Invalid Property ID");
                return;
            }

            // Select multiple files
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Images";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<string> selectedPaths = new List<string>(ofd.FileNames);

                // Save each path to DB
                bool success = op.AddImagesForProperty(propertyId, selectedPaths);

                if (success)
                {
                    // CALL NEW METHOD
                    List<string> previews = op.PreviewAndLoadImages(propertyId);

                    if (previews != null)
                    {
                        DisplayImagesOnPanel(previews); // show preview on UI panel
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Opens Google Maps and asks browser for the device's current location
            string url = "https://www.google.com/maps/@?api=1&map_action=map&basemap=satellite&zoom=15";

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
