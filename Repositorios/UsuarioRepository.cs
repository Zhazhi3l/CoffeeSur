using CoffeeSur.Modelos;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Repositorios
{
    /// <summary>
    /// Clase encargada del acceso a datos para la entidad Usuario.
    /// Gestiona las llamadas a los Stored Procedures de MySQL.
    /// </summary>
    public class UsuarioRepository
    {
        private ConexionBD _conexion = new ConexionBD();

        /// <summary>
        /// Inserta un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="usuario">Objeto Usuario con los datos a registrar.</param>
        /// <exception cref="MySqlException">Lanza excepción si hay error de conexión o SQL.</exception>
        public void InsertarUsuario(Usuario usuario)
        {
            using (MySqlConnection conex = _conexion.GetConexion())
            {
                using(MySqlCommand cmd = new MySqlCommand("sp_InsertarUsuario", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@p_Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@p_Username", usuario.Username);
                    cmd.Parameters.AddWithValue("@p_Password", usuario.Password);
                    cmd.Parameters.AddWithValue("@p_Rol", usuario.Rol);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Modifica los datos de un usuario existente.
        /// </summary>
        /// <param name="usuario">Objeto Usuario con los datos actualizados.</param>
        /// <returns>True si se modificó al menos un registro, False si no se encontró.</returns>
        public bool ModificarUSuario(Usuario usuario)
        {
            using (MySqlConnection conex = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ModificarUsuario", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_IdUsuario", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@p_Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@p_Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@p_Username", usuario.Username);
                    // Si el password es nulo, enviamos cadena vacía para que el SP sepa que no debe cambiarlo
                    cmd.Parameters.AddWithValue("@p_Password", usuario.Password ?? "");
                    cmd.Parameters.AddWithValue("@p_Rol", usuario.Rol);
                    cmd.Parameters.AddWithValue("@p_Activo", usuario.Activo);

                    int filasAfectads = cmd.ExecuteNonQuery();
                    return filasAfectads > 0;
                }
            }
        }

        /// <summary>
        /// Realiza un borrado lógico del usuario (Lo marca como inactivo).
        /// </summary>
        /// <param name="username">Nombre de usuario a eliminar.</param>
        /// <returns>True si se eliminó correctamente.</returns>
        public bool EliminarUsuario(string username)
        {
            using (MySqlConnection conex = _conexion.GetConexion())
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

        /// <summary>
        /// Recibe las credenciales de un usuario y valida si son correctas.
        /// Posterior a eso, devuelve el objeto Usuario con sus datos (sin contraseña) o null si no es válido.
        /// </summary>
        /// <param name="username">Username de usuario a validar.</param>
        /// <param name="password">Contraseña(sin hashear) a validar.</param>
        /// <returns>Un usuario con todos sus datos, excepto la contraseña.</returns>
        public Usuario ValidarLogin(string username, string password)
        {
            Usuario usuario = null;
            using (MySqlConnection conx = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ValidarLogin", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_Username", username);
                    cmd.Parameters.AddWithValue("@p_Password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                IdUsuario = reader.GetInt32("IdUsuario"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido"),
                                Username = reader.GetString("Username"),
                                Rol = reader.GetString("Rol"),
                                Activo = reader.GetBoolean("Activo")
                            };
                        }
                    }
                }
            }
            return usuario;
        }

        /// <summary>
        /// Recupera todos los usuarios registrados en la base de datos.
        /// </summary>
        /// <returns>Una lista de usuarios con todos sus datos.</returns>
        public List<Usuario> ObternerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (MySqlConnection conx = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ListarUsuarios", conx)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(new Usuario
                            {
                                IdUsuario = reader.GetInt32("IdUsuario"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido"),
                                Username = reader.GetString("Username"),
                                Rol = reader.GetString("Rol"),
                                Activo = reader.GetBoolean("Activo")
                            });
                        }
                    }
                }
            }
            return usuarios;
        }

        /// <summary>
        /// Método que busca un usuario por su ID en la BD.
        /// </summary>
        /// <param name="id">Valor int de un Id de un usuario.</param>
        /// <returns>Un usuario con todos sus datos, excepto contraseña.
        ///         Si no lo encuentra, devuelve null.
        /// </returns>
        public Usuario ObtenerUsuarioPorId(int id)
        {
            Usuario u = null;

            using (MySqlConnection conx = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ObtenerUsuarioPorId", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_IdUsuario", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            u = new Usuario
                            {
                                IdUsuario = reader.GetInt32("IdUsuario"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido"),
                                Username = reader.GetString("Username"),
                                Rol = reader.GetString("Rol"),
                                Activo = reader.GetBoolean("Activo")
                            };
                        }
                    }
                }
            }
            return u;
        }

    }
}
