using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeSur.Servicios;
using CoffeeSur.Repositorios;
using CoffeeSur.Modelos;

namespace CoffeeSur.UI
{
    public partial class FrmGestionProductos : Form
    {
        private ProductoService _servicio = new ProductoService();

        public FrmGestionProductos()
        {
            InitializeComponent();
        }

        private void FrmGestionProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                dgvProductos.DataSource = _servicio.ObtenerTodosProductos();
                dgvProductos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private Producto GetProductoSeleccionado()
        {
            if (dgvProductos.SelectedRows.Count == 0)
                return null;

            return dgvProductos.SelectedRows[0].DataBoundItem as Producto;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarProductos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto prod = GetProductoSeleccionado();

            if (prod == null)
            {
                MessageBox.Show("Seleccione un producto de la lista.");
                return;
            }

            FrmProducto frm = new FrmProducto(prod);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarProductos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto prod = GetProductoSeleccionado();

            if (prod == null)
            {
                MessageBox.Show("Seleccione un producto de la lista.");
                return;
            }

            var resp = MessageBox.Show(
                $"¿Seguro que desea eliminar el producto '{prod.Nombre}'?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resp == DialogResult.Yes)
            {
                try
                {
                    _servicio.EliminarProducto(prod.IdProducto);
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
