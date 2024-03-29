﻿using MASHKAPG.clases;
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
    public partial class Vistausu : Form
    {
        private Usuario usuarioact;
        public Vistausu(Usuario u)
        {
            this.usuarioact = u;
            InitializeComponent();
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
            new Login().Show();
            this.Close();
        }

        private void bt_nuevocliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrarClientes(usuarioact).Show();
        }

        private void bt_administrarclientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VerClientes(usuarioact).Show();
        }
    }
}
