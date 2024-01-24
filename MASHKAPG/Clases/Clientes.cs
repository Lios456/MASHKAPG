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
            string sql = $"Delete from cliente where id = '{c.Id}'";
            new ConexionMysql().Delete(sql);
        }

    }
}