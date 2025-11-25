using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using CoffeeSur.Modelos;
using CoffeeSur.Servicios;

namespace CoffeeSur.UI
{
    public partial class FrmPuntoVenta : Form
    {
        private readonly ProductoService _servicioProductos = new ProductoService();
        private readonly VentaService _servicioVentas = new VentaService();
        private int usuarioLogueadoId;
        private Producto productoActual;

        public FrmPuntoVenta(int idUsuario)
        {
            InitializeComponent();
            usuarioLogueadoId = idUsuario;

            lblUsuario.Text = $"Usuario: {usuarioLogueadoId}";
            ConfigurarReloj();

            CargarProductosEnPanel();
            ConfigurarTablaVenta();
        }

        private void ConfigurarReloj()
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += (s, e) =>
            {
                lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
                lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
            };
            t.Start();
        }

        private void CargarProductosEnPanel()
        {
            flpProductos.Controls.Clear();
            List<Producto> productos = _servicioProductos.ObtenerTodosProductos();

            foreach (var p in productos)
            {
                ProductoCard card = new ProductoCard();
                card.Nombre = p.Nombre;
                card.Precio = p.Precio;
                card.Imagen = _servicioProductos.ConvertirBytesAImagen(p.Imagen);
                card.IdProducto = p.IdProducto;

                card.ProductoClick += (s, e) =>
                {
                    SeleccionarProducto(card);
                    AgregarProductoALaVenta(card.IdProducto, card.Nombre, card.Precio);
                };

                flpProductos.Controls.Add(card);
            }
        }

        private void SeleccionarProducto(ProductoCard card)
        {
            lblDetalleNombre.Text = card.Nombre;
            lblDetallePrecio.Text = "$" + card.Precio.ToString("0.00");
            picDetalle.Image = card.Imagen;
            lblDetalleId.Text = card.IdProducto.ToString();

            productoActual = new Producto
            {
                IdProducto = card.IdProducto,
                Nombre = card.Nombre,
                Precio = card.Precio
            };
        }

        private void ConfigurarTablaVenta()
        {
            dgvVenta.Columns.Clear();
            dgvVenta.Columns.Add("IdProducto", "ID");
            dgvVenta.Columns.Add("Nombre", "Producto");
            dgvVenta.Columns.Add("Precio", "Precio");
            dgvVenta.Columns.Add("Cantidad", "Cant.");
            dgvVenta.Columns.Add("Subtotal", "Subtotal");

            dgvVenta.Columns["IdProducto"].Visible = false;

            dgvVenta.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dgvVenta.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
        }

        private void AgregarProductoALaVenta(int id, string nombre, decimal precio)
        {
            bool encontrado = false;
            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                if (row.Cells["IdProducto"].Value != null &&
                    Convert.ToInt32(row.Cells["IdProducto"].Value) == id)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    cantidadActual++;
                    row.Cells["Cantidad"].Value = cantidadActual;
                    row.Cells["Subtotal"].Value = cantidadActual * precio;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                dgvVenta.Rows.Add(id, nombre, precio, 1, precio);
            }

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            lblTotal.Text = total.ToString("C2");
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (productoActual != null)
            {
                foreach (DataGridViewRow row in dgvVenta.Rows)
                {
                    if (row.Cells["IdProducto"].Value != null &&
                        Convert.ToInt32(row.Cells["IdProducto"].Value) == productoActual.IdProducto)
                    {
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                        cantidad++;
                        row.Cells["Cantidad"].Value = cantidad;
                        row.Cells["Subtotal"].Value = cantidad * precio;
                        CalcularTotal();
                        return;
                    }
                }

                AgregarProductoALaVenta(productoActual.IdProducto, productoActual.Nombre, productoActual.Precio);
            }
            else
            {
                MessageBox.Show("Seleccione un producto primero.");
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (productoActual != null)
            {
                foreach (DataGridViewRow row in dgvVenta.Rows)
                {
                    if (row.Cells["IdProducto"].Value != null &&
                        Convert.ToInt32(row.Cells["IdProducto"].Value) == productoActual.IdProducto)
                    {
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);

                        if (cantidad > 1)
                        {
                            cantidad--;
                            row.Cells["Cantidad"].Value = cantidad;
                            row.Cells["Subtotal"].Value = cantidad * precio;
                        }
                        else
                        {
                            dgvVenta.Rows.Remove(row);
                        }
                        CalcularTotal();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista.");
            }
        }

        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvVenta.Rows.Count)
            {
                var row = dgvVenta.Rows[e.RowIndex];
                if (row.Cells["IdProducto"].Value != null)
                {
                    int id = Convert.ToInt32(row.Cells["IdProducto"].Value);
                    string nombre = row.Cells["Nombre"].Value.ToString();
                    decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);

                    productoActual = new Producto
                    {
                        IdProducto = id,
                        Nombre = nombre,
                        Precio = precio
                    };

                    lblDetalleNombre.Text = nombre;
                    lblDetallePrecio.Text = "$" + precio.ToString("0.00");
                    lblDetalleId.Text = id.ToString();

                    try
                    {
                        var producto = _servicioProductos.ObtenerProductoPorId(id);
                        if (producto != null && producto.Imagen != null)
                        {
                            picDetalle.Image = _servicioProductos.ConvertirBytesAImagen(producto.Imagen);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al cargar imagen: " + ex.Message);
                    }
                }
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.");
                return;
            }

            try
            {
                Venta venta = new Venta
                {
                    IdUsuario = usuarioLogueadoId,
                    FechaVenta = DateTime.Now,
                    Detalles = new List<DetalleVenta>()
                };

                foreach (DataGridViewRow row in dgvVenta.Rows)
                {
                    if (row.Cells["IdProducto"].Value == null) continue;

                    int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["Precio"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                    venta.Detalles.Add(new DetalleVenta
                    {
                        IdProducto = idProducto,
                        Cantidad = cantidad,
                        PrecioUnitario = precioUnitario,
                        Subtotal = subtotal
                    });
                }

                if (venta.Detalles.Count == 0)
                {
                    MessageBox.Show("No hay productos válidos en la venta.");
                    return;
                }

                venta.Total = venta.Detalles.Sum(d => d.Subtotal);

                _servicioVentas.RealizarVenta(venta);

                MessageBox.Show($"Venta cobrada correctamente.\nTotal: {venta.Total:C2}",
                              "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarVenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la venta: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarVenta()
        {
            dgvVenta.Rows.Clear();
            CalcularTotal();
            lblDetalleNombre.Text = "";
            lblDetallePrecio.Text = "";
            lblDetalleId.Text = "";
            picDetalle.Image = null;
            productoActual = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}