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
    public partial class RegistrarClientes : Form
    {
        private Usuario usuarioact;
        public Cliente clienteregistrar = new Cliente();
        public RegistrarClientes(Usuario u)
        {
            this.usuarioact = u;
            InitializeComponent();
            this.tx_edad.Text = "0";
            this.tx_peso.Text = "0.0";
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            this.tx_nombre.Text = "";
            this.tx_apellido.Text = "";
            this.tx_cedula.Text = "";
            this.tx_direccion.Text = "";
            this.tx_edad.Text = "";
            this.tx_fechain.Value = DateTime.Now;
            this.tx_horario.Text = "";
            this.tx_objetivo.Text = "";
            this.tx_observaciones.Text = "";
            this.tx_peso.Text = "";
            this.tx_talla.Text = "";
            this.tx_telefono.Text = "";
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

        private void bt_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteregistrar.Name = tx_nombre.Text;
                clienteregistrar.LastName = tx_apellido.Text;
                clienteregistrar.DNI = tx_cedula.Text;
                clienteregistrar.Direction = tx_direccion.Text;
                clienteregistrar.Age = int.Parse(tx_edad.Text);
                clienteregistrar.Ingreso = DateTime.Now;
                clienteregistrar.Salida = DateTime.Parse(tx_fechain.Text);
                clienteregistrar.Horario = tx_horario.Text;
                clienteregistrar.Objetives = tx_objetivo.Text;
                clienteregistrar.Observaciones = tx_observaciones.Text;
                clienteregistrar.Weight = decimal.Parse(tx_peso.Text);
                clienteregistrar.Size = tx_talla.Text;
                clienteregistrar.Phone = tx_telefono.Text;
                if (Cliente.comprobar_cliente(clienteregistrar) == false)
                {
                    try
                    {
                        Cliente.agregarcli(clienteregistrar);
                        MessageBox.Show($"Se registró al usuario {clienteregistrar.Name} {clienteregistrar.LastName} con la cédula {clienteregistrar.DNI}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                }
                else
                {
                    
                    MessageBox.Show("Ya existe un cliente con esos datos");
                    clienteregistrar = Cliente.get_cliente(clienteregistrar);
                    this.tx_fechain.MinDate = new DateTime(day: clienteregistrar.Ingreso.Day, month: clienteregistrar.Ingreso.Month, year: clienteregistrar.Ingreso.Year);
                    this.tx_nombre.Text = clienteregistrar.Name;
                    this.tx_apellido.Text = clienteregistrar.LastName;
                    this.tx_cedula.Text = clienteregistrar.DNI;
                    this.tx_direccion.Text = clienteregistrar.Direction;
                    this.tx_edad.Text = clienteregistrar.Age.ToString();
                    this.tx_fechain.Value= clienteregistrar.Salida;
                    this.tx_horario.Text = clienteregistrar.Horario;
                    this.tx_objetivo.Text = clienteregistrar.Objetives;
                    this.tx_observaciones.Text = clienteregistrar.Observaciones;
                    this.tx_peso.Text = clienteregistrar.Weight.ToString();
                    this.tx_talla.Text = clienteregistrar.Size;
                    this.tx_telefono.Text = clienteregistrar.Phone;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
