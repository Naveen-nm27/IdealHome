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
    public partial class EditHomeDetails : Form
    {
        int userid;
        public EditHomeDetails(int userid)
        {
            this.userid = userid;
            InitializeComponent();
        }

        Operations operations = new Operations();

        private void button1_Click(object sender, EventArgs e)
        {

            string searchTerm = txt_title.Text;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                var resultHomes = operations.SearchHomesByTitle(userid);

                // Bind result to DataGridView
                dataGridView1.DataSource = resultHomes;
            }
            else
            {
                MessageBox.Show("Please enter a title to search.");
            }
        }

        private void EditHomeDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
