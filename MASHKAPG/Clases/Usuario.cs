using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MASHKAPG.clases
{
    public class Usuario
    {
        public int? id { get; set; }
        public string? usuarioName { get; set; }

        public string? usuarioPassword { get; set; }

        public string? Tipo { get; set; }

        public Usuario() { }
        public Usuario(string name, string password, string tipo) 
        {
            this.usuarioName = name;
            this.usuarioPassword = password;
            this.Tipo = tipo;
        }
        public static string GetMD5(string str)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(str);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static void registrarUsuario(Usuario u)
        {
            string sql = $"insert into usuario(Nombre, Password, Tipo) values ('{u.usuarioName}', '{Usuario.GetMD5(u.usuarioPassword)}', '{u.Tipo}')";
            new ConexionMysql().insertar(sql);
        }



    }
}
