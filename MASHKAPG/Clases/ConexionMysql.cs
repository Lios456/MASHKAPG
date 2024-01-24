using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using MASHKAPG.clases;
using System.Collections;
using System.Data;
using System.Security.Cryptography;

namespace MASHKAPG.clases
{
    internal class ConexionMysql
    {
        private MySqlConnection connection = new MySqlConnection(File.ReadAllText("cadena.txt"));
        // ---------------------------------------------------------------------------------------------------------------
        public void CrearConexion()
        {
            //MessageBox.Show(File.ReadAllText("cadena.txt"));
            connection.Open();

            //connection.Close();
        }
        // ---------------------------------------------------------------------------------------------------------------
        public void NoQuery(string sql)
        {
            CrearConexion();
            var command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        // ---------------------------------------------------------------------------------------------------------------
        public void insertar(string sql)
        {
            CrearConexion();
            var command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        // ---------------------------------------------------------------------------------------------------------------
        public DataTable consultarClientes(string sql)
        {
            CrearConexion();

            //string sql = $"select * from cliente";
            DataTable Clientes = new DataTable();
            Clientes.Columns.Add("Id", typeof(int));
            Clientes.Columns.Add("Nombre", typeof(string));
            Clientes.Columns.Add("Apellido", typeof(string));
            Clientes.Columns.Add("Cedula", typeof(string));
            Clientes.Columns.Add("Edad", typeof(int));
            Clientes.Columns.Add("Teléfono", typeof(string));
            Clientes.Columns.Add("Dirección", typeof(string));
            Clientes.Columns.Add("Peso", typeof(float));
            Clientes.Columns.Add("Talla", typeof(string));
            Clientes.Columns.Add("Horario", typeof(string));
            Clientes.Columns.Add("Objetivo", typeof(string));
            Clientes.Columns.Add("Observaciones", typeof(string));
            Clientes.Columns.Add("Ingreso", typeof(DateTime));
            Clientes.Columns.Add("Salida", typeof(DateTime));
            Clientes.Columns.Add("Días restantes", typeof(int));



            var command = new MySqlCommand(sql, connection);
            var datos = command.ExecuteReader();

            while (datos.Read())
            {
                /*var usu = new Hashtable
                {
                    { "Id", datos.GetInt16(0) },
                    { "Name", datos.GetString(1) },
                    { "LastName", datos.GetString(2) },
                    { "Phone", datos.GetString(3) },
                    { "Email", datos.GetString(4) },
                    { "Age", datos.GetInt16(5) },
                    { "Weight", datos.GetDecimal(6) },
                    { "City", datos.GetString(7) },
                    { "Barrio", datos.GetString(8) },
                    { "Calles", datos.GetString(9) },
                    { "Sex", datos.GetString(10) },
                    { "Ingreso", datos.GetDateTime(11) },
                    { "Salida", datos.GetDateTime(12) },
                    { "Observaciones", datos.GetString(13) }
                };
                Clientes.Rows.Add(
                    datos.GetInt16(0), 
                    datos.GetString(1), 
                    datos.GetString(2),
                    datos.GetString(3),
                    datos.GetInt16(4),
                    datos.GetString(5),
                    datos.GetString(6),
                    datos.GetFloat(7),
                    datos.GetString(8),
                    datos.GetString(9),
                    datos.GetString(10),
                    datos.GetString(11),
                    datos.GetDateTime(12),
                    datos.GetDateTime(13),
                    datos.GetInt16(14)
                    );
                Clientes.Add(usu);*/

                Clientes.Rows.Add(
                    datos.GetInt32(0),
                    datos.GetString(1),
                    datos.GetString(2),
                    datos.GetString(3),
                    datos.GetInt32(4),
                    datos.GetString(5),
                    datos.GetString(6),
                    datos.GetFloat(7),
                    datos.GetString(8),
                    datos.GetString(9),
                    datos.GetString(10),
                    datos.GetString(11),
                    datos.GetDateTime(12),
                    datos.GetDateTime(13),
                    datos.GetInt32(14)
                    );

            }

            connection.Close();
            return Clientes;
        }
        // ---------------------------------------------------------------------------------------------------------------
        public void Update(string sql)
        {
            CrearConexion();
            var command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        // ---------------------------------------------------------------------------------------------------------------
        public void Delete(string sql)
        {
            CrearConexion();
            var command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<string> GetList(string sql)
        {
            CrearConexion();
            List<string> list = new List<string>();
            var command = new MySqlCommand(sql, connection);
            var datos = command.ExecuteReader();
            while (datos.Read())
            {
                list.Add(datos.GetString(1));
                list.Add(datos.GetString(2));
            }
            connection.Close();
            return list;
        }
        public List<Usuario> consultaUsuarios(string sql)
        {
            CrearConexion();
            var usuarios = new List<Usuario>();
            var command = new MySqlCommand(sql, connection);
            var datos = command.ExecuteReader();
            while (datos.Read())
            {
                var usu = new Usuario();
                usu.id = datos.GetInt16(0);
                usu.usuarioName = datos.GetString(1);
                usu.usuarioPassword = datos.GetString(2);
                usu.Tipo = datos.GetString(3);
                usuarios.Add(usu);
            }
            return usuarios;
        }



    }
}
