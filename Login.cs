using Microsoft.VisualBasic.ApplicationServices;

namespace IdealHome
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Operations operations = new Operations();


        private void label4_Click(object sender, EventArgs e)
        {
            StudentSignup signUp = new StudentSignup();
            signUp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StudentSignup signUp = new StudentSignup();
            signUp.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            var loginResult = operations.Login(username, password);

            if (loginResult.UserID.HasValue)
            {
                // Successful login, get user ID and user type
                int userId = loginResult.UserID.Value;
                string userType = loginResult.UserType;

                // Pass these to the next form

                //lblUserType.Text = userType;  // Optional, for debug or display purposes

                // Now, pass the UserID and UserType to the StudentDashboard (or any other form)

                if (userType == "Student")
                {
                    StudentDashboard studentDashboard = new StudentDashboard(userId);
                    studentDashboard.UserID = userId;
                    studentDashboard.Show();
                    this.Hide(); // Hide login form
                    
                } else if(userType == "HomeOwner")
                {
                    SellerDashBoard sellerDash = new SellerDashBoard(userId);
                    sellerDash.Show();
                    //sellerDash.UserID = userId;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }

            }
            else
            {
                // Show error message if login fails
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
