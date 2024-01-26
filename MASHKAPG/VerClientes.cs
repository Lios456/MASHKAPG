using MASHKAPG.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASHKAPG
{
    public partial class VerClientes : Form
    {
        private Usuario usuarioact;
        public VerClientes(Usuario u)
        {
            this.usuarioact = u;
            InitializeComponent();
            filtro.SelectedIndex = 0;
            new ConexionMysql().NoQuery("call actualizarrestante()");
            this.clientes_view.DataSource = new ConexionMysql().consultarClientes("select * from clientes");
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            if (usuarioact.Tipo == "admin")
            {
                this.Hide();
                new VistaAdmin(usuarioact).Show();
            }
            else
            {
                this.Hide();
                new Vistausu(usuarioact).Show();
            }
        }

        private void filtro_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (filtro.SelectedItem.ToString() == "Nombre" || filtro.SelectedItem.ToString() == "Apellido")
            {
                tableLayoutPanel9.Controls.Remove(tableLayoutPanel9.GetControlFromPosition(0, 0));
                tableLayoutPanel9.Controls.Add(texto, 0, 0);
                if (filtro.SelectedItem.ToString() == "Nombre")
                {
                    texto.Text = "Nombre";
                }
                else if (filtro.SelectedItem.ToString() == "Apellido")
                {
                    texto.Text = "Apellido";
                }

            }
            else if (filtro.SelectedItem.ToString() != "Nombre" || filtro.SelectedItem.ToString() != "Apellido")
            {
                tableLayoutPanel9.Controls.Remove(tableLayoutPanel9.GetControlFromPosition(0, 0));
                if (filtro.SelectedItem.ToString() == "Por Pagar")
                {
                    this.clientes_view.DataSource = new ConexionMysql().consultarClientes($"select * from clientes where restante <= 0 order by restante asc");
                }
                else if (filtro.SelectedItem.ToString() == "Pagados")
                {
                    this.clientes_view.DataSource = new ConexionMysql().consultarClientes($"select * from clientes where restante > 0");
                }
                else if (filtro.SelectedItem.ToString() == "Todos")
                {
                    this.clientes_view.DataSource = new ConexionMysql().consultarClientes($"select * from clientes");
                }
            }


        }

        private void texto_TextChanged(object sender, EventArgs e)
        {
            if (filtro.SelectedItem.ToString() == "Nombre")
            {
                this.clientes_view.DataSource = new ConexionMysql().consultarClientes($"select * from clientes where nombre like '%{this.texto.Text}%'");
            }
            else if (filtro.SelectedItem.ToString() == "Apellido")
            {
                this.clientes_view.DataSource = new ConexionMysql().consultarClientes($"select * from clientes where apellido like '%{this.texto.Text}%'");
            }

        }
    }
}
