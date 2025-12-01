using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CoffeeSur.Servicios;
using CoffeeSur.Modelos;

namespace CoffeeSur.UI
{
    public partial class FrmGestionProductos : Form
    {
        private ProductoService _servicio = new ProductoService();
        private List<Producto> _listaProductos;

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
                _listaProductos = _servicio.ObtenerTodosProductos();

                DataTable dt = new DataTable();
                dt.Columns.Add("IdProducto", typeof(int));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Precio", typeof(decimal));
                dt.Columns.Add("Stock", typeof(int));
                dt.Columns.Add("Activo", typeof(bool));

                foreach (var p in _listaProductos)
                {
                    dt.Rows.Add(
                        p.IdProducto,
                        p.Nombre,
                        p.Precio,
                        p.Stock,
                        p.Activo

                    );
                }

                dgvProductos.DataSource = dt;

                // Ajustes visuales
                dgvProductos.RowTemplate.Height = 30;
                dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProductos.ClearSelection();
                dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvProductos.MultiSelect = false;
                dgvProductos.ReadOnly = true;
                dgvProductos.AllowUserToAddRows = false;

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

            int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["IdProducto"].Value);
            return _listaProductos.FirstOrDefault(p => p.IdProducto == id);
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
            var prod = GetProductoSeleccionado();
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
            var prod = GetProductoSeleccionado();
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

        private void btnAumentarStock_Click(object sender, EventArgs e)
        {
            var prod = GetProductoSeleccionado();
            if (prod == null)
            {
                MessageBox.Show("Seleccione un producto de la lista.");
                return;
            }

            int cantidad = PedirCantidad();
            if (cantidad <= 0)
            {
                MessageBox.Show("Cantidad no válida.");
                return;
            }

            try
            {
                _servicio.ActualizarStockProducto(prod.IdProducto, cantidad);

                MessageBox.Show($"Stock actualizado correctamente. (+{cantidad})");

                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el stock: " + ex.Message);
            }
        }
        private int PedirCantidad()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingresa la cantidad a agregar al stock:",
                    "Aumentar Stock",
                    "1"
                );

            if (int.TryParse(input, out int cantidad) && cantidad > 0)
                return cantidad;

            return -1;
        }

    }
}

