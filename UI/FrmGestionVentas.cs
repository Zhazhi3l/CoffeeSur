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
            CargarVentasEnGrid();
        }


        private void CargarVentasEnGrid()
        {
            ventas = _ventaService.ObtenerTodasVentas();
            dgvTablaVentas.DataSource = ventas;
        }

        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltros.SelectedIndex.ToString().Equals("Ventas de hoy"))
            {
                Venta = _ventaService.ObtenerVentasDeHoy(DateTime.Today);
            }
        }
    }
}
