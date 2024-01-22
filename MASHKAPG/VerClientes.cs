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
        public VerClientes()
        {
            InitializeComponent();
            filtro.SelectedIndex = 0;
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
            new VistaAdmin().Show();
            this.Close();
        }

        private void filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox texto = new TextBox();
            if (filtro.SelectedItem.ToString() == "Nombre" || filtro.SelectedItem.ToString() == "Apellido")
            {
                tableLayoutPanel9.Controls.Remove(tableLayoutPanel9.GetControlFromPosition(0, 0));
                tableLayoutPanel9.Controls.Add(texto, 0, 0);
                texto.Size = new Size(100, 10);
                texto.Dock = DockStyle.Fill;
                texto.Name = "texto";
                texto.BorderStyle = BorderStyle.FixedSingle;
                texto.BackColor = Color.White;
                if(filtro.SelectedItem.ToString() == "Nombre")
                {
                    texto.Text = "Nombre";
                }
                else
                {
                    texto.Text = "Apellido";
                }
            }
            else
            {
                tableLayoutPanel9.Controls.Remove(tableLayoutPanel9.GetControlFromPosition(0,0));
            }
        }
    }
}
