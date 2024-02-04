using MASHKAPG.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASHKAPG.clases
{
    public class Cliente
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public string? Direction { get; set; }
        public string? DNI { get; set; }
        public string? Horario { get; set; }
        public string? Size { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Salida { get; set; }
        public string? Observaciones { get; set; }
        public string? Objetives { get; set; }
        public int? Restant { get; set; }

       

        public void eliminarcli(Cliente c)
        {
            string sql = $"Delete from clientes where id = '{c.Id}'";
            new ConexionMysql().Delete(sql);
        }

        public static void agregarcli(Cliente c)
        {
            string sql = $"Insert into clientes(nombre, apellido, cedula, edad, telefono, direccion, peso , talla, horario, objetivo, observaciones, fechain, salida) values(" +
                $"'{c.Name}'," +
                $"'{c.LastName}'," +
                $"'{c.DNI}'," +
                $"'{c.Age}'," +
                $"'{c.Phone}'," +
                $"'{c.Direction}'," +
                $"'{c.Weight}'," +
                $"'{c.Size}'," +
                $"'{c.Horario}'," +
                $"'{c.Objetives}'," +
                $"'{c.Observaciones}'," +
                $"'{c.Ingreso.Year}-{c.Ingreso.Month}-{c.Ingreso.Day}'," +
                $"'{c.Salida.Year}-{c.Salida.Month}-{c.Salida.Day}'" +
                $")";
            new ConexionMysql().insertar(sql);
        }

        public static bool comprobar_cliente(Cliente c)
        {
            string sql = $"select * from clientes where nombre = '{c.Name}' and Apellido = '{c.LastName}' and cedula = '{c.DNI}'";
            var clientes = new ConexionMysql().consultarClientes(sql);
            if (clientes.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}