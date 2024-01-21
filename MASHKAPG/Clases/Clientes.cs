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
        public string? City { get; set; }
        public string? Barrio { get; set; }
        public string? Calles { get; set; }
        public string? Sex { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Salida { get; set; }
        public string? Observaciones { get; set; }

        public void ingresarcliente(Cliente c)
        {
            string sql = $"insert into cliente" +
                $"(Nombre, Apellido, Telefono, Email,Edad,Peso," +
                $"Ciudad,Barrio,Calles,Sexo,Ingreso,Salida,Observaciones)" +
                $"values" +
                $"('{c.Name}'," +
                $"'{c.LastName}'," +
                $"'{c.Phone}'," +
                $"'{c.Email}'," +
                $"'{c.Age}'," +
                $"'{Math.Truncate(c.Weight)}.{Math.Round(c.Weight, 0)}'," +
                $"'{c.City}'," +
                $"'{c.Barrio}'," +
                $"'{c.Calles}'," +
                $"'{c.Sex}'," +
                $"'{c.Ingreso.Year}-{c.Ingreso.Month}-{c.Ingreso.Day}'," +
                $"'{c.Salida.Year}-{c.Salida.Month}-{c.Salida.Day}'," +
                $"'{c.Observaciones}'" +
                $")";
            new ConexionMysql().insertar(sql);

        }

        public void eliminarcli(Cliente c)
        {
            string sql = $"Delete from cliente where id = '{c.Id}'";
            new ConexionMysql().Delete(sql);
        }

    }
}