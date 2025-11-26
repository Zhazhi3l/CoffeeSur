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
        }

        private void FrmReporteComparativo_Load(object sender, EventArgs e)
        {
            CargarProductos();

        }


        // Pendiente de validación
        private void CargarCatalogoVisual()
        {
            try
            {
                List<Producto> lista = _servicioProducto.ObtenerTodosProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void AgregarAlGrid(Producto prod)
        {
            // Evitar duplicados en la lista de selección
            foreach (DataGridViewRow row in dgvSeleccionados.Rows)
            {
                if (Convert.ToInt32(row.Cells["IdProducto"].Value) == prod.IdProducto)
                {
                    // Si ya está, no hacemos nada (o podrías hacer un efecto visual)
                    return;
                }
            }

            // Agregar a la lista "Global"
            dgvSeleccionados.Rows.Add(prod.IdProducto, prod.Nombre);
        }

        // Pendiente de validación
        private void DibujarGrafico(List<ReporteComparacionProductosDTO> datos)
        {
            chartComparativo.Series.Clear();

            // Definimos los nombres de las series basados en las fechas elegidas
            string serieMes1 = dtpFecha1.Value.ToString("MMMM yyyy");
            string serieMes2 = dtpFecha2.Value.ToString("MMMM yyyy");

            // Serie 1
            Series s1 = new Series(serieMes1);
            s1.ChartType = SeriesChartType.Column; // Barras
            s1.Color = Color.CornflowerBlue;
            s1.IsValueShownAsLabel = true; // Mostrar numerito arriba de la barra

            // Serie 2
            Series s2 = new Series(serieMes2);
            s2.ChartType = SeriesChartType.Column;
            s2.Color = Color.Salmon;
            s2.IsValueShownAsLabel = true;

            // Llenado de puntos
            foreach (var item in datos)
            {
                // Eje X: Nombre Producto, Eje Y: Monto
                s1.Points.AddXY(item.NombreProducto, item.VentaMes1);
                s2.Points.AddXY(item.NombreProducto, item.VentaMes2);
            }

            chartComparativo.Series.Add(s1);
            chartComparativo.Series.Add(s2);
        }


        // PEndiente de validación
        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener IDs desde el Grid externo
                List<int> idsParaAnalizar = new List<int>();

                foreach (DataGridViewRow row in dgvSeleccionados.Rows)
                {
                    idsParaAnalizar.Add(Convert.ToInt32(row.Cells["IdProducto"].Value));
                }

                if (idsParaAnalizar.Count == 0)
                {
                    MessageBox.Show("Selecciona productos del catálogo (Pestaña 1) primero.");
                    tabControl1.SelectedIndex = 0; // Mover al usuario a la selección
                    return;
                }

                // 2. Llamar al Backend (Service)
                var datos = _ventaService.GenerarReporteComparativo(
                    idsParaAnalizar,
                    dtpInicio.Value,
                    dtpFin.Value
                );

                if (datos.Count == 0)
                {
                    MessageBox.Show("No hay ventas registradas en esas fechas para los productos seleccionados.");
                    return;
                }

                // 3. Dibujar y Cambiar Tab
                DibujarGraficoBarras(datos);
                tabControl1.SelectedIndex = 1; // Mover al usuario a la gráfica
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar análisis: " + ex.Message);
            }
        }
    }
}
