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

namespace CoffeeSur.UI
{
    public partial class FrmGestionUsuarios : Form
    {
        private UsuarioService _servicio = new UsuarioService();

        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                UsuarioRepository repo = new UsuarioRepository();
                var lista = repo.ObtenerTodosLosUsuarios();

                dgvUsuarios.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.ShowDialog();

            CargarUsuarios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un usuario.");
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            FrmUsuario frm = new FrmUsuario(id); // edición
            frm.ShowDialog();

            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un usuario.");
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
            UsuarioRepository repo = new UsuarioRepository();

            DialogResult r = MessageBox.Show("¿Eliminar usuario?", "Confirmación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                _servicio.EliminarUsuario(id);
                MessageBox.Show("Usuario eliminado.");
                CargarUsuarios();
            }
        }
    }
}
