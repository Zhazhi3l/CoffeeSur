using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Modelos
{
	public static class SesionUsuario
	{
		public static int IdUsuario { get; set; }
		public static string Username { get; set; }
		public static string Nombre { get; set; }
		public static string Rol { get; set; }
		public static bool EstaLogueado => !string.IsNullOrEmpty(Username);

		public static void IniciarSesion(Usuario usuario)
		{
			IdUsuario = usuario.IdUsuario;
			Username = usuario.Username;
			Nombre = usuario.Nombre;
			Rol = usuario.Rol;
		}

		public static void CerrarSesion()
		{
			IdUsuario = 0;
			Username = null;
			Nombre = null;
			Rol = null;
		}
	}
}
