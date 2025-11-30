using CoffeeSur.Modelos;
using CoffeeSur.Servicios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeSur.UI
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioService _usuarioService = new UsuarioService();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                Usuario usuario = _usuarioService.ValidarLogin(username, password);

                if (usuario == null)
                {
                    MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!usuario.Activo)
                {
                    MessageBox.Show("El usuario está inactivo.", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

				SesionUsuario.IniciarSesion(usuario);

				EstablecerUsuarioEnBD(usuario.Username);

				MessageBox.Show($"Bienvenido {usuario.Nombre} ({usuario.Rol})");


                if (usuario.Rol == "Admin")
                {
                    FrmMenu menu = new FrmMenu(usuario);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    FrmPuntoVenta frm = new FrmPuntoVenta(usuario.IdUsuario);
                    frm.Show();
                    this.Hide();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

		private void EstablecerUsuarioEnBD(string username)
		{
			try
			{
				using (var conexion = new Repositorios.ConexionBD().GetConexion())
				{
					using (var cmd = new MySqlCommand("sp_SetAppUser", conexion))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@p_Username", username);
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error al establecer usuario en BD: " + ex.Message);
			}
		}

		private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
