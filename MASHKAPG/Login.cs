namespace MASHKAPG
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ver_con_Click(object sender, EventArgs e)
        {
            if(password.PasswordChar == '\0')
            {
                password.PasswordChar = '*';
            }
            else
            {
                password.PasswordChar = '\0';
            }
        }
    }
}
