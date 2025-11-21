using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Repositorios
{
    public class ConexionBD
    {
        public string GetCadenaConexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CadConx"].ConnectionString;
            return connectionString;
        }

        public MySqlConnection GetConexion()
        {
            MySqlConnection conexion = new MySqlConnection(GetCadenaConexion());
            
            conexion.Open();
            return conexion;
        }
    }
}
