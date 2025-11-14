namespace IdealHome
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            StudentSignup signUp = new StudentSignup();
            signUp.Show();
            this.Hide();
        }
    }
}
