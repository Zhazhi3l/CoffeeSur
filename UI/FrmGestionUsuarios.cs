using CoffeeSur.Repositorios;
using CoffeeSur.Servicios;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using CoffeeSur.Modelos;

namespace CoffeeSur.UI
{
    public partial class FrmGestionUsuarios : Form
    {
        private UsuarioService _servicio = new UsuarioService();
        private UsuarioRepository _repo = new UsuarioRepository();

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
                var lista = _repo.ObternerTodos();
                dgvUsuario.DataSource = lista;
                dgvUsuario.Columns["Password"].Visible = false;
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
            if (dgvUsuario.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un usuario.");
                return;
            }

            int id = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value);

            Usuario usuario = _repo.ObtenerUsuarioPorId(id);

            if (usuario == null)
            {
                MessageBox.Show("No se pudo cargar el usuario.");
                return;
            }

            FrmUsuario frm = new FrmUsuario(usuario);
            frm.ShowDialog();

            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un usuario.");
                return;
            }

            string username = dgvUsuario.CurrentRow.Cells["Username"].Value.ToString();

            DialogResult r = MessageBox.Show("¿Eliminar usuario?", "Confirmación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                bool ok = _repo.EliminarUsuario(username);

                if (ok)
                    MessageBox.Show("Usuario eliminado.");
                else
                    MessageBox.Show("No fue posible eliminar el usuario.");

                CargarUsuarios();
            }
        }
    }
}


