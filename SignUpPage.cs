using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace IdealHome
{
    public partial class StudentSignup : Form
    {
        Operations operations = new Operations();
        public StudentSignup()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            grp_student.Enabled = false;
            grp_owner.Enabled = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void logo_click(object sender, MouseEventArgs e)
        {
            IdealHome id = new IdealHome();
            id.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            IdealHome id = new IdealHome();
            id.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //// Get data from form fields


            //// Check if the user is a Student or HomeOwner
            //bool isStudent = radioButton1.Checked;

            //string university = null;
            //string faculty = null;
            //string department = null;
            //string area = null;
            //string googleLocation = null;
            //string propertyAddress = null;

            //// If Student, get student details
            //if (isStudent)
            //{

            //}
            //// If HomeOwner, get homeowner details
            //else
            //{

            //}

            // Get data from form fields
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string address = textBox3.Text;
            int age = int.Parse(textBox4.Text);  // Add proper validation for age
            string nic = textBox7.Text;
            string gender = comboBox6.SelectedItem.ToString();
            string username = textBox8.Text;
            string password = textBox9.Text;

            // Check if the user is a Student or HomeOwner
            bool isStudent = radioButton1.Checked;

            string university = null;
            string faculty = null;
            string department = null;
            string area = null;
            string googleLocation = null;
            string propertyAddress = null;

            // If Student, get student details
            if (isStudent)
            {
                university = comboBox3.SelectedItem.ToString();
                faculty = comboBox2.SelectedItem.ToString();
                department = comboBox5.SelectedItem.ToString();
            }
            // If HomeOwner, get homeowner details
            else
            {
                area = comboBox4.SelectedItem.ToString();
                googleLocation = textBox5.Text;
                propertyAddress = textBox6.Text;
            }

            // Create a User object with all the data
            User newUser = new User(
                0, username, firstName + " " + lastName, password,
                isStudent ? "Student" : "HomeOwner", address, null,
                age, nic, gender,
                university, faculty, department,
                area, googleLocation, propertyAddress
            );

            if (newUser.Verify(out string errorMessage))
            {
                // Call the SignUp method in Operations class
                bool success = operations.SignUp(newUser);

                if (success)
                {
                    MessageBox.Show("SignUp successful!");
                    IdealHome id = new IdealHome();
                    id.Show();
                    this.Hide();
                    // Optionally, navigate to login page or the next screen
                }
                else
                {
                    MessageBox.Show("SignUp failed, please try again.");
                }
            }
            else
            {
                // Show error message from verification
                MessageBox.Show("SignUp failed: " + errorMessage);
            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void StudentSignup_Load(object sender, EventArgs e)
        {
            //groupBox1.Enabled = false;
            //grp_student.Enabled = false;
            //grp_owner.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Enabled = true;
                grp_student.Enabled = true;
                grp_owner.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox1.Enabled = true;
                grp_owner.Enabled = true;
                grp_student.Enabled = false;
            }
        }

        private void messege(object sender, EventArgs e)
        {
            //if (!radioButton1.Checked && !radioButton2.Checked)
            //{
            //    var result = MessageBox.Show("Slect Your User Type", "Verify", MessageBoxButtons.OK);
            //    groupBox1.Enabled = false;

            //    if (result == DialogResult.OK)
            //    {

            //    }
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //if (!radioButton1.Checked || !radioButton2.Checked)
            //{
            //    this.Enabled = false;
            //}
        }

        private void grp_student_Enter(object sender, EventArgs e)
        {
            //if (!radioButton1.Checked || !radioButton2.Checked)
            //{
            //    this.Enabled = false;
            //}
        }

        private void grp_owner_Enter(object sender, EventArgs e)
        {
            //if (!radioButton1.Checked || !radioButton2.Checked)
            //{
            //    this.Enabled = false;
            //}
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
