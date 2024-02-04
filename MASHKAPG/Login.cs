using MASHKAPG.clases;
using System.Runtime.InteropServices;

namespace MASHKAPG
{
    public partial class Login : Form
    {
        private int intentos = 3;
        private Usuario usuarioact = new Usuario();

        public Login()
        {
            InitializeComponent();
            //new ConexionMysql().NoQuery($"Insert into Usuarios(id, Nombre, Password, Tipo) values('1','admin','{Usuario.GetMD5("admin")}','admin')");
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void ver_con_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '\0')
            {
                password.PasswordChar = '*';
            }
            else
            {
                password.PasswordChar = '\0';
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            // Se comprueba que la contraseña del usuario sea la misma que la que está en la base de datos
            var datos = new ConexionMysql().GetList($"select * from usuario where Nombre = '{usuario.Text}'");
            var nombre = datos[0];
            var pass = datos[1];
            if (usuario.Text == nombre && Usuario.GetMD5(password.Text) == pass)
            {
                usuarioact.Tipo = new ConexionMysql().consultaUsuarios($"select * from usuario where Nombre = '{usuario.Text}'")[0].Tipo;
                usuarioact.usuarioName = new ConexionMysql().consultaUsuarios($"select * from usuario where Nombre = '{usuario.Text}'")[0].usuarioName;
                MessageBox.Show("Bienvenido:  " + usuarioact.usuarioPassword + "  " + usuarioact.Tipo);
                // Si el tipo de usuario es "admin" se abre la vista de administradores, sino, se abre la vista de usuarios

                if (usuarioact.Tipo == "admin")
                {
                    new VistaAdmin(usuarioact).Show();

                }
                else
                {
                    new Vistausu(usuarioact).Show();

                }
                this.Hide();

            }
            else
            {
                // Se controlan los intentos de ingreso de contraseña
                if (intentos <= 0)
                {
                    MessageBox.Show("No te quedan intentos, vuelve a iniciar la aplicación.");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Credenciales incorrectas.\nTienes {intentos} intentos.");
                    intentos -= 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
