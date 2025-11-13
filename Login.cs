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
            UserSignUp signUp = new UserSignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
