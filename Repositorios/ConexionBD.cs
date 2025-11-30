using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

			if (Modelos.SesionUsuario.EstaLogueado)
			{
				EstablecerUsuarioAplicacion(conexion, Modelos.SesionUsuario.Username);
			}

			return conexion;
        }

		private void EstablecerUsuarioAplicacion(MySqlConnection conexion, string username)
		{
			try
			{
				using (MySqlCommand cmd = new MySqlCommand("sp_SetAppUser", conexion))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@p_Username", username);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error al establecer usuario de aplicación: " + ex.Message);
			}
		}
	}
}
