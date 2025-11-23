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
        private readonly UsuarioService _usuarioService = new UsuarioService();
        private Usuario _usuarioEditar = null;  

        public FrmUsuario()
        {
            InitializeComponent();
            cmbRol.Items.Add("Admin");
            cmbRol.Items.Add("Empleado");
        }

        public FrmUsuario(Usuario usuario) : this()
        {
            _usuarioEditar = usuario;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            txtNombre.Text = _usuarioEditar.Nombre;
            txtApellido.Text = _usuarioEditar.Apellido;
            txtUser.Text = _usuarioEditar.Username;
            txtPassword.Text = _usuarioEditar.Password;
            cmbRol.Text = _usuarioEditar.Rol;
            chkActivo.Checked = _usuarioEditar.Activo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos() == false)
                    return;

                if (_usuarioEditar == null)
                    RegistrarUsuario();
                else
                    EditarUsuario();

                MessageBox.Show("Usuario guardado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            if (txtNombre.Text.Trim() == "" ||
                txtApellido.Text.Trim() == "" ||
                txtUser.Text.Trim() == "" ||
                (_usuarioEditar == null && txtPassword.Text.Trim() == ""))
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return false;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol.");
                return false;
            }

            return true;
        }

        private void RegistrarUsuario()
        {
            Usuario nuevo = new Usuario()
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Username = txtUser.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Rol = cmbRol.SelectedItem.ToString(),
                Activo = chkActivo.Checked
            };

            _usuarioService.RegistrarNuevoUsuario(nuevo);
        }

        private void EditarUsuario()
        {
            _usuarioEditar.Nombre = txtNombre.Text.Trim();
            _usuarioEditar.Apellido = txtApellido.Text.Trim();
            _usuarioEditar.Username = txtUser.Text.Trim();

            _usuarioEditar.Password = txtPassword.Text.Trim() == "" ? null : txtPassword.Text.Trim();

            _usuarioEditar.Rol = cmbRol.SelectedItem.ToString();
            _usuarioEditar.Activo = chkActivo.Checked;

            _usuarioService.ModificarUsuarioExistente(_usuarioEditar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

