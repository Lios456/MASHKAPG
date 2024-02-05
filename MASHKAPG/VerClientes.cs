using MASHKAPG.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASHKAPG
{
    public partial class VerClientes : Form
    {
        private Usuario usuarioact;
        private List<Cliente> clientesselected = new List<Cliente>();
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

        private void clientes_view_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow fila in clientes_view.Rows)
            {
                DataGridViewCheckBoxCell check = fila.Cells["Eleccion"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(check?.Value))
                {
                    clientesselected.Add(new Cliente
                    {
                        Id = Convert.ToInt32(fila.Cells["Id"].Value),
                        Name = fila.Cells["Nombre"].Value.ToString(),
                        LastName = fila.Cells["Apellido"].Value.ToString(),
                        DNI = fila.Cells["Cedula"].Value.ToString(),
                        Age = Convert.ToInt32(fila.Cells["Edad"].Value),
                        Phone = fila.Cells["Teléfono"].Value.ToString(),
                        Direction = fila.Cells["Dirección"].Value.ToString(),
                        Weight = Convert.ToDecimal(fila.Cells["Peso"].Value),
                        Size = fila.Cells["Talla"].Value.ToString(),
                        Horario = fila.Cells["Horario"].Value.ToString(),
                        Observaciones = fila.Cells["Observaciones"].Value.ToString(),
                        Ingreso = Convert.ToDateTime(fila.Cells["Ingreso"].Value),
                        Salida = Convert.ToDateTime(fila.Cells["Salida"].Value),
                        Restant = Convert.ToInt16(fila.Cells["Días restantes"].Value)
                    });
                }
                else
                {

                }
            }
            Console.WriteLine("");
        }

        private void bt_borrar_Click(object sender, EventArgs e)
        {
            foreach (Cliente cliente in clientesselected)
            {
                new ConexionMysql().Delete($"delete from clientes where id = {cliente.Id}");
            }
            MessageBox.Show("Se han eliminado a los clientes seleccionados");
            this.clientes_view.DataSource = new ConexionMysql().consultarClientes("select * from clientes");
        }

        private void bt_autorenov_Click(object sender, EventArgs e)
        {
            foreach (Cliente cliente in clientesselected)
            {
                new ConexionMysql().Update($"update clientes set Salida = '{cliente.Salida.Year}-{cliente.Salida.Month + 1}-{cliente.Salida.Day}' where id = {cliente.Id}");
            }
            MessageBox.Show("Se actualizó la suscripción de los clientes seleccionados");
            new ConexionMysql().NoQuery("call actualizarrestante()");
            this.clientes_view.DataSource = new ConexionMysql().consultarClientes("select * from clientes");
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            if (clientesselected.Count > 0 && clientesselected.Count<=1) 
            {
                this.Hide();
                new RegistrarClientes(u: usuarioact, c: clientesselected[0], tipo: "update").Show();
            }
        }
    }
}
