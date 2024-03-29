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
    public partial class RegistrarUsuarios : Form
    {
        private Usuario usuarioact;

        public RegistrarUsuarios(Usuario u)
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

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaAdmin(usuarioact).Show();
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            this.usuario.Text = "";
            this.password1.Text = "";
            this.password2.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.password1.PasswordChar == '\0')
            {
                this.password1.PasswordChar = '*';
            }
            else
            {
                this.password1.PasswordChar = '\0';
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (this.password2.PasswordChar == '\0')
            {
                this.password2.PasswordChar = '*';
            }
            else
            {
                this.password2.PasswordChar = '\0';
            }
        }

        private void bt_registrar_Click(object sender, EventArgs e)
        {
            if (this.usuario.Text != "")
            {
                if (comprobar_contra())
                {
                    if (Usuario.comprobar_existencia(new Usuario(name: this.usuario.Text, password: Usuario.GetMD5(password1.Text), tipo: "usuario")) == false)
                    {
                        try
                        {
                            Usuario.registrarUsuario(new Usuario(name: this.usuario.Text, password: password1.Text, tipo: "usuario"));
                            MessageBox.Show($"Se ha registrado al usuario {this.usuario.Text}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }


                    }
                    else
                    {
                        MessageBox.Show("Ya existe un usuario con ese nombre");
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }

            }
            else
            {
                MessageBox.Show("Nombre de Usuario no válido");
            }
        }

        private bool comprobar_contra()
        {
            bool iguales;

            if (this.password1.Text == this.password2.Text && this.password1.Text != "" && this.password2.Text != "")
            {
                iguales = true;
            }
            else
            {
                iguales = false;

            }

            return iguales;
        }


    }
}
