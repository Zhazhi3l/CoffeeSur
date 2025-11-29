using CoffeeSur.Modelos;
using CoffeeSur.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Servicios
{
	public class SesionUsuarioService  // Agregar 'public'
	{
		private readonly SesionUsuarioRepository _sesionRepo = new SesionUsuarioRepository();
		private SesionUsuario _sesionActual = new SesionUsuario();

		public SesionUsuario SesionActual => _sesionActual;

		/// <summary>
		/// Inicia sesión estableciendo el usuario en la aplicación y en la base de datos
		/// </summary>
		public void IniciarSesion(Usuario usuario)
		{
			_sesionActual.IniciarSesion(usuario);
			_sesionRepo.EstablecerUsuarioAplicacion(usuario.Username);
		}

		/// <summary>
		/// Cierra sesión limpiando tanto la aplicación como la base de datos
		/// </summary>
		public void CerrarSesion()
		{
			_sesionRepo.LimpiarUsuarioAplicacion();
			_sesionActual.CerrarSesion();
		}

		/// <summary>
		/// Verifica si hay una sesión activa y establece el usuario en la BD si es necesario
		/// </summary>
		public void VerificarSesionActiva()
		{
			if (_sesionActual.EstaAutenticado)
			{
				_sesionRepo.EstablecerUsuarioAplicacion(_sesionActual.Username);
			}
		}
	}
}