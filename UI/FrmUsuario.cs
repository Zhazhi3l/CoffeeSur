using CoffeeSur.Modelos;
using CoffeeSur.Repositorios;
using CoffeeSur.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CoffeeSur.UI 
{
    public partial class FrmUsuario : Form
    {
        UsuarioService servicio = new UsuarioService();
        private int? idSeleccionado = null; // Guarda el IdUsuario del usuario seleccionado

        public FrmUsuario()
        {
            InitializeComponent();
            CargarRoles();
            CargarUsuarios();
        }

        private void CargarRoles()
        {
            cboRol.Items.Clear();
            cboRol.Items.Add("Admin");
            cboRol.Items.Add("Empleado");
            cboRol.SelectedIndex = 0;
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            var lista = servicio.ObtenerTodosLosUsuarios(); // Si tienes este método
            dgvUsuarios.DataSource = lista;

            dgvUsuarios.Columns["Password"].Visible = false; // Ocultar password
            dgvUsuarios.Columns["IdUsuario"].Visible = false; // Ocultar Id
        }

        // Cuando el usuario selecciona una fila
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                Usuario u = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                idSeleccionado = u.IdUsuario;
                txtNombre.Text = u.Nombre;
                txtApellido.Text = u.Apellido;
                txtUsername.Text = u.Username;
                txtPassword.Text = ""; // Password no se carga
                cboRol.SelectedItem = u.Rol;
                checkBox1.Checked = u.Activo;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == null)
            {
                MessageBox.Show("Selecciona un usuario primero");
                return;
            }

            Usuario u = new Usuario()
            {
                IdUsuario = idSeleccionado.Value,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Username = txtUser.Text.Trim(),
                Password = string.IsNullOrWhiteSpace(txtPassword.Text) ? null : txtPassword.Text.Trim(),
                Rol = cmbRol.SelectedItem.ToString(),
                Activo = chkActivo.Checked
            };

            try
            {
                servicio.ModificarUsuarioExistente(u);
                MessageBox.Show("Usuario modificado correctamente");
                Limpiar();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Selecciona un usuario primero");
                return;
            }

            try
            {
                servicio.EliminarUsuario(txtUser.Text);
                MessageBox.Show("Usuario eliminado");
                Limpiar();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
            cmbRol.SelectedIndex = 0;
            chkActivo.Checked = true;
            idSeleccionado = null;
        }
    }

}

