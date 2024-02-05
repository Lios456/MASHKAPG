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

        public static Cliente get_cliente(Cliente c)
        {
            /*
            
            
            
            
            
            Clientes.Columns.Add("Dirección", typeof(string));
            Clientes.Columns.Add("Peso", typeof(float));
            Clientes.Columns.Add("Talla", typeof(string));
            Clientes.Columns.Add("Horario", typeof(string));
            Clientes.Columns.Add("Objetivo", typeof(string));
            Clientes.Columns.Add("Observaciones", typeof(string));
            Clientes.Columns.Add("Ingreso", typeof(DateTime));
            Clientes.Columns.Add("Salida", typeof(DateTime));
            Clientes.Columns.Add("Días restantes", typeof(int));
             */
            Cliente nc = new Cliente();
            string sql = $"select * from clientes where nombre = '{c.Name}' and Apellido = '{c.LastName}' and cedula = '{c.DNI}'";
            var clientes = new ConexionMysql().consultarClientes(sql);
            nc.Id = (int)clientes.Rows[0]["Id"];
            nc.Name = (string)clientes.Rows[0]["Nombre"];
            nc.LastName = (string)clientes.Rows[0]["Apellido"];
            nc.DNI = (string)clientes.Rows[0]["Cedula"];
            nc.Age = (int)clientes.Rows[0]["Edad"];
            nc.Phone = (string)clientes.Rows[0]["Teléfono"];
            nc.Direction = (string)clientes.Rows[0]["Dirección"];
            nc.Weight = Convert.ToDecimal(clientes.Rows[0]["Peso"]);
            nc.Size = (string)clientes.Rows[0]["Talla"];
            nc.Horario = (string)clientes.Rows[0]["Horario"];
            nc.Objetives = (string)clientes.Rows[0]["Objetivo"];
            nc.Observaciones = (string)clientes.Rows[0]["Observaciones"];
            nc.Ingreso = (DateTime)clientes.Rows[0]["Ingreso"];
            nc.Salida = (DateTime)clientes.Rows[0]["Salida"];
            nc.Restant = (int)clientes.Rows[0]["Días restantes"];
            return nc;

        }

        public static void actualizar(Cliente c)
        {
            string sql = $"update clientes set " +
                $"Nombre = '{c.Name}'," +
                $"apellido = '{c.LastName}'," +
                $"cedula = '{c.DNI}'," +
                $"edad = '{c.Age}'," +
                $"telefono = '{c.Phone}'," +
                $"direccion = '{c.Direction}'," +
                $"peso = '{c.Weight}'," +
                $"talla = '{c.Size}'," +
                $"horario = '{c.Horario}'," +
                $"objetivo = '{c.Objetives}'," +
                $"observaciones = '{c.Observaciones}'," +
                $"salida = '{c.Salida.Year}-{c.Salida.Month}-{c.Salida.Day}'" +
                $"where id = '{c.Id}'";
            new ConexionMysql().Update(sql);
        }

    }
}