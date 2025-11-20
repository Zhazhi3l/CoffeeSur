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
        public string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CadConx"].ConnectionString;
            return connectionString;
        }

        private MySqlConnection GetConnection()
        {
            MySqlConnection conexion = new MySqlConnection(GetConnectionString());
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la BD: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
