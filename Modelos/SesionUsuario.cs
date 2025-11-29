using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Modelos
{
	public class SesionUsuario
	{
		public int IdUsuario { get; set; }
		public string Nombre { get; set; }
		public string Username { get; set; }
		public string Rol { get; set; }
		public bool EstaAutenticado { get; set; }

		public SesionUsuario()
		{
			EstaAutenticado = false;
		}

		public void IniciarSesion(Usuario usuario)
		{
			IdUsuario = usuario.IdUsuario;
			Nombre = usuario.Nombre;
			Username = usuario.Username;
			Rol = usuario.Rol;
			EstaAutenticado = true;
		}

		public void CerrarSesion()
		{
			IdUsuario = 0;
			Nombre = string.Empty;
			Username = string.Empty;
			Rol = string.Empty;
			EstaAutenticado = false;
		}
	}
}
