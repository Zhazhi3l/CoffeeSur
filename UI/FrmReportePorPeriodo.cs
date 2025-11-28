using CoffeeSur.DTO;
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
    public partial class FrmReportePorPeriodo : Form
    {
        private readonly VentaService _servicioVenta = new VentaService();
        private readonly ProductoService _servicioProducto = new ProductoService();

        public FrmReportePorPeriodo()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime inicio = dtpFechaInicio.Value.Date;
                DateTime fin = dtpFechaFin.Value.Date;

                List<ReporteVentaProductoPorPeriodoDTO> reporte = _servicioVenta.VentasDeProductosPorPeriodo(inicio, fin);

                if (reporte == null || reporte.Count == 0)
                {
                    MessageBox.Show("No hubo ventas de ningún producto en este periodo.",
                                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvReporteProductos.DataSource = null;
                    return;
                }

                dgvReporteProductos.DataSource = reporte;
                ConfigurarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            if (dgvReporteProductos.Columns["Monto"] != null)
            {
                dgvReporteProductos.Columns["Monto"].DefaultCellStyle.Format = "C2"; // Formato Moneda
            }

            dgvReporteProductos.AutoResizeColumns();
        }
    }
}
