using CoffeeSur.Modelos;
using CoffeeSur.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Servicios
{
    public class UsuarioService
    {
        private UsuarioRepository _repoUsuario = new UsuarioRepository();

        public void RegistrarNuevoUsuario(Usuario usuario)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Apellido))
                {
                    throw new Exception("Los campos de Nombre y Apellido deben estar llenos.");
                }
                if(string.IsNullOrWhiteSpace(usuario.Username) || string.IsNullOrWhiteSpace(usuario.Password))
                {
                    throw new Exception("El usuario y la contraseña son obligatorios.");
                }

                _repoUsuario.InsertarUsuario(usuario);
            }catch (Exception ex)
            {
                throw new Exception("Error al registrar nuevo usuario: " + ex.Message);
            }


    }
}
