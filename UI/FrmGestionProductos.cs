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
        private readonly ProductoService _service = new ProductoService();

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
            dgvProductos.DataSource = _service.Listar();
            dgvProductos.ClearSelection();
        }

        private Producto ObtenerProductoSeleccionado()
        {
            if (dgvProductos.SelectedRows.Count == 0)
                return null;

            return dgvProductos.SelectedRows[0].DataBoundItem as Producto;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.ShowDialog();
            CargarProductos();  // Se actualiza solo
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Producto seleccionado = ObtenerProductoSeleccionado();

            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un producto para editar.");
                return;
            }

            FrmProducto frm = new FrmProducto(seleccionado);
            frm.ShowDialog();
            CargarProductos(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto seleccionado = ObtenerProductoSeleccionado();

            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este producto?",
                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.EliminarProducto(seleccionado.IdProducto);
                MessageBox.Show("Producto eliminado.");
                CargarProductos(); 
            }
        }
    }
}
