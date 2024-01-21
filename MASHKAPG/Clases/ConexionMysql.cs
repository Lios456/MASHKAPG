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

namespace MASHKAPG.clases
{
    internal class ConexionMysql
    {

        private MySqlConnection connection = new MySqlConnection(File.ReadAllText("cadena.txt"));

        // ---------------------------------------------------------------------------------------------------------------
        public void CrearConexion()
        {
            connection.Open();

            //connection.Close();
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
        public List<Cliente> Select(string sql)
        {
            CrearConexion();

            //string sql = $"select * from cliente";
            List<Cliente> Clientes = new List<Cliente>();
            var command = new MySqlCommand(sql, connection);
            var datos = command.ExecuteReader();

            while (datos.Read())
            {
                var usu = new Cliente();
                usu.Id = (int)datos[0];
                usu.Name = Convert.ToString(datos[1]);
                usu.LastName = Convert.ToString(datos[2]);
                usu.Phone = Convert.ToString(datos[3]);
                usu.Email = Convert.ToString(datos[4]);
                usu.Age = Convert.ToInt32(datos[5]);
                usu.Weight = Convert.ToDecimal(datos[6]);
                usu.City = Convert.ToString(datos[7]);
                usu.Barrio = Convert.ToString(datos[8]);
                usu.Calles = Convert.ToString(datos[9]);
                usu.Sex = Convert.ToString(datos[10]);
                usu.Ingreso = Convert.ToDateTime(datos[11]);
                usu.Salida = datos.GetDateTime(12);
                usu.Observaciones = datos.GetString(13);
                Clientes.Add(usu);
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



    }
}
