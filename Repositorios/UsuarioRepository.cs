using CoffeeSur.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Repositorios
{
    public class UsuarioRepository
    {
        private ConexionBD conexion = new ConexionBD();
        public void InsertarUsuario(Usuario usuario)
        {
            using (MySqlConnection conex = conexion.GetConexion())
            {
                using(MySqlCommand cmd = new MySqlCommand("sp_InsertarUsuario", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pNombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@pApellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@pUsername", usuario.Username);
                    cmd.Parameters.AddWithValue("@pPassword", usuario.Password);
                    cmd.Parameters.AddWithValue("@pRol", usuario.Rol);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool ModificarUSuario(Usuario usuario)
        {
            using (MySqlConnection conex = conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ModificarUsuario", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pNombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@pApellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@pUsername", usuario.Username);
                    cmd.Parameters.AddWithValue("@pPassword", usuario.Password ?? "");
                    cmd.Parameters.AddWithValue("@pRol", usuario.Rol);

                    int filasAfectads = cmd.ExecuteNonQuery();
                    return filasAfectads > 0;
                }
            }
        }

        public bool EliminarUsuario(string username)
        {
            using (MySqlConnection conex = conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_EliminarUsuario", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pUsername", username);

                    int filasAfectads = cmd.ExecuteNonQuery();
                    return filasAfectads > 0;
                }
            }
        }

    }
}
