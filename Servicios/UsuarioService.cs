using CoffeeSur.Modelos;
using CoffeeSur.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Servicios
{
    /// <summary>
    /// Servicio encargado de la lógica de negocio de Usuarios (Empleados/Admins).
    /// </summary>
    public class UsuarioService
    {
        private readonly UsuarioRepository _repoUsuario = new UsuarioRepository();

        /// <summary>
        /// Registra un usuario nuevo validando campos obligatorios.
        /// </summary>
        public void RegistrarNuevoUsuario(Usuario usuario)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Apellido))
                {
                    throw new Exception("Los campos de Nombre y Apellido deben estar llenos.");
                }
                if (string.IsNullOrWhiteSpace(usuario.Username) || string.IsNullOrWhiteSpace(usuario.Password))
                {
                    throw new Exception("El usuario y la contraseña son obligatorios.");
                }

                _repoUsuario.InsertarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar nuevo usuario: " + ex.Message);
            }
        }

        /// <summary>
        /// Modifica un usuario existente.
        /// </summary>
        public void ModificarUsuarioExistente(Usuario usuario)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Apellido))
                {
                    throw new Exception("Los campos de Nombre y Apellido deben estar llenos.");
                }
                if (string.IsNullOrWhiteSpace(usuario.Username))
                {
                    throw new Exception("El usuario es obligatorio.");
                }   
                if (usuario.Rol != "Admin" && usuario.Rol != "Empleado")
                {
                    throw new Exception("El rol del usuario debe ser 'Admin' o 'User'.");
                }

                bool actualizado = _repoUsuario.ModificarUSuario(usuario);
                if (!actualizado)
                {
                    throw new Exception("No se encontró el usuario para modificar.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar usuario: " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina un usuario por su nombre de usuario.
        /// </summary>
        /// <param name="username">Username de usuario a eliminar</param>
        /// <returns>Devuelve True si se logró eliminar exitosamente.</returns>
        /// <exception cref="Exception"></exception>
        public bool EliminarUsuario(string username)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username))
                {
                    throw new Exception("El nombre de usuario no puede estar vacío.");
                }
                bool eliminado = _repoUsuario.EliminarUsuario(username);
                if (!eliminado)
                {
                    throw new Exception("No se encontró el usuario para eliminar.");
                }
                return eliminado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar usuario: " + ex.Message);
            }
        }

        /// <summary>
        /// Valida las credenciales de un usuario para loggearse.
        /// </summary>
        /// <param name="username">Username del usuario a validar.</param>
        /// <param name="password">Password(sin hashear) del usuario a validar.</param>
        /// <returns>Un usuario con todos sus datos, excepto la contraseña.</returns>
        /// <exception cref="Exception"></exception>
        public Usuario ValidarLogin(string username, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                    throw new Exception("El nombre de usuario y la contraseña son obligatorios.");

                Usuario usuario = _repoUsuario.ValidarLogin(username, password);
                if (usuario == null)
                    throw new Exception("Credenciales inválidas o usuario inactivo.");

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar login: " + ex.Message);
            }
        }

        /// <summary>
        /// Devuelve una lista con todos los usuarios registrados en la BD con todos sus datos,
        /// excepto la contraseña.
        /// </summary>
        /// <returns>Una lista de Usuarios.</returns>
        /// <exception cref="Exception"></exception>
        public List<Usuario> ObtenerTodosUsuarios()
        {
            try
            {
                return _repoUsuario.ObternerTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de usuarios: " + ex.Message);
            }
        }
    }
}
