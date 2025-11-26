using CoffeeSur.DTO;
using CoffeeSur.Modelos;
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
    public partial class FrmReporteComparativo : Form
    {
        private readonly VentaService _servicioVenta = new VentaService();
        private readonly ProductoService _servicioProducto = new ProductoService();

        public FrmReporteComparativo()
        {
            InitializeComponent();
            ConfigurarGridSeleccion();
            // ConfigurarGrafico();
        }

        private void FrmReporteComparativo_Load(object sender, EventArgs e)
        {
            // CargarCatalogoVisual();
        }

        private void ConfigurarGridSeleccion()
        {
            dgvListaProductos.AllowUserToAddRows = false;
            dgvListaProductos.ReadOnly = true;
            dgvListaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaProductos.RowHeadersVisible = false;

            if (dgvListaProductos.Columns.Count == 0)
            {
                dgvListaProductos.Columns.Add("IdProducto", "ID");
                dgvListaProductos.Columns["IdProducto"].Visible = false; // Oculto
                dgvListaProductos.Columns.Add("Nombre", "Producto Seleccionado");
            }
        }
        /*
        private void ConfigurarGrafico()
        {
            chartComparativo.Series.Clear();
            chartComparativo.Titles.Clear();
            chartComparativo.ChartAreas.Clear();

            // Área del gráfico
            ChartArea area = new ChartArea("AreaComparativa");
            area.AxisX.Interval = 1; // Mostrar todas las etiquetas del eje X
            area.AxisY.LabelStyle.Format = "C0"; // Formato moneda sin decimales
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            chartComparativo.ChartAreas.Add(area);

            // Leyenda y Título
            chartComparativo.Legends.Add(new Legend("Leyenda"));
            chartComparativo.Titles.Add("Comparativo de Ventas Mensuales");
        }

        private void CargarCatalogoVisual()
        {
            flpCOntendedorProductos.Controls.Clear();
            try
            {
                List<Producto> productos = _servicioProducto.ObtenerTodosProductos();

                foreach (var p in productos)
                {
                    ProductoCard card = new ProductoCard();

                    card.IdProducto = p.IdProducto;
                    card.Nombre = p.Nombre;
                    card.Precio = p.Precio;

                    if (p.Imagen != null)
                    {
                        card.Imagen = _servicioProducto.ConvertirBytesAImagen(p.Imagen);
                    }

                    card.ProductoClick += (s, args) =>
                    {
                        AgregarProductoAlGrid(p);
                    };

                    flpCOntendedorProductos.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar catálogo: " + ex.Message);
            }
        }

        private void AgregarProductoAlGrid(Producto producto)
        {
            foreach (DataGridViewRow row in dgvListaProductos.Rows)
            {
                if (Convert.ToInt32(row.Cells["IdProducto"].Value) == producto.IdProducto)
                {
                    return;
                }
            }

            int indiceFila = dgvListaProductos.Rows.Add(producto.IdProducto, producto.Nombre);
            dgvListaProductos.Rows[indiceFila].Tag = producto;
        }

        // PEndiente de validación
        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Producto> productosParaAnalizar = new List<Producto>();

                foreach (DataGridViewRow row in dgvListaProductos.Rows)
                {
                    if (row.Tag is Producto prod)
                    {
                        productosParaAnalizar.Add(prod);
                    }
                }

                if (productosParaAnalizar.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos un producto del catálogo (Pestaña 1).");
                    return;
                }

                var datosReporte = _servicioVenta.GenerarReporteComparativo(
                    productosParaAnalizar,
                    dtpFecha1.Value,
                    dtpFecha2.Value
                    );

                if (datosReporte.Count == 0)
                {
                    MessageBox.Show("No hay ventas registradas en esas fechas para los productos seleccionados.");
                    return;
                }

                // DibujarGraficoBarras(datosReporte);
                tbCntrlSeleccionYAnalisis.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar análisis: " + ex.Message);
            }
        }

        /*
        private void DibujarGraficoBarras(List<ReporteComparativoDTO> datos)
        {
            chartComparativo.Series.Clear();

            // Nombres de las series dinámicos (Ej: "Noviembre 2023")
            string nombreSerie1 = dtpInicio.Value.ToString("MMMM yyyy");
            string nombreSerie2 = dtpFin.Value.ToString("MMMM yyyy");

            // Serie 1 (Mes Inicio)
            Series s1 = new Series(nombreSerie1);
            s1.ChartType = SeriesChartType.Column; // Barras verticales
            s1.Color = Color.RoyalBlue;
            s1.IsValueShownAsLabel = true; // Muestra el valor ($) arriba de la barra

            // Serie 2 (Mes Fin)
            Series s2 = new Series(nombreSerie2);
            s2.ChartType = SeriesChartType.Column;
            s2.Color = Color.DarkOrange;
            s2.IsValueShownAsLabel = true;

            // Llenar puntos
            foreach (var item in datos)
            {
                // Eje X: Nombre Producto (item.NombreProducto)
                // Eje Y: Monto (item.VentaMes1 / item.VentaMes2)
                s1.Points.AddXY(item.NombreProducto, item.VentaMes1);
                s2.Points.AddXY(item.NombreProducto, item.VentaMes2);
            }

            chartComparativo.Series.Add(s1);
            chartComparativo.Series.Add(s2);
        }
        */
        
        
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            dgvListaProductos.Rows.Clear();
            // chartComparativo.Series.Clear();
            tbCntrlSeleccionYAnalisis.SelectedIndex = 0;
        }
    }
}
