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
    public partial class FrmGestionVentas : Form
    {
        private readonly VentaService _ventaService = new VentaService();
        private List<Venta> ventas;

        public FrmGestionVentas()
        {
            InitializeComponent();
        }

        private void FrmGestionVentas_Load(object sender, EventArgs e)
        {
            cmbFiltros.Items.Clear();
            cmbFiltros.Items.Add("Ninguno (Todas)");
            cmbFiltros.Items.Add("Ventas de hoy");
            cmbFiltros.SelectedIndex = 0;
            CargarVentasEnGrid();
        }


        private void CargarVentasEnGrid()
        {
            ventas = _ventaService.ObtenerTodasVentas();
            dgvTablaVentas.DataSource = ventas;
        }

        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltros.SelectedItem.ToString() == "Ventas de hoy")
                {
                    ventas = _ventaService.ObtenerVentasDeHoy();
                    dgvTablaVentas.DataSource = ventas;
                }
                else
                {
                    CargarVentasEnGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTablaVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTablaVentas.CurrentRow == null) return;

            Venta ventaSeleccionada = (Venta)dgvTablaVentas.CurrentRow.DataBoundItem;

            if (ventaSeleccionada.Detalles == null || ventaSeleccionada.Detalles.Count == 0)
            {
                MessageBox.Show("La venta seleccionada no tiene detalles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvDetallesVenta.DataSource = ventaSeleccionada.Detalles;
            tabCtrlVentas.SelectedTab = tabPgDetallesVenta;
        }
    }
}
