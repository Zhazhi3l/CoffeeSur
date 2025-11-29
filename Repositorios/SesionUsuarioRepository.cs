using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Repositorios
{
	public class SesionUsuarioRepository 
	{
		private readonly ConexionBD _conexion = new ConexionBD();

		/// <summary>
		/// Establece el usuario de la aplicación en la sesión MySQL para los triggers de auditoría
		/// </summary>
		/// <param name="username">Username del usuario autenticado</param>
		public void EstablecerUsuarioAplicacion(string username)
		{
			using (MySqlConnection conex = _conexion.GetConexion())
			{
				using (MySqlCommand cmd = new MySqlCommand("sp_SetAppUser", conex))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@p_Username", username);
					cmd.ExecuteNonQuery();
				}
			}
		}

		/// <summary>
		/// Limpia el usuario de la aplicación en la sesión MySQL
		/// </summary>
		public void LimpiarUsuarioAplicacion()
		{
			using (MySqlConnection conex = _conexion.GetConexion())
			{
				using (MySqlCommand cmd = new MySqlCommand("sp_SetAppUser", conex))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@p_Username", DBNull.Value);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}