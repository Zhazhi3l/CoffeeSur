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
        VentaService _servicioVenta = new VentaService();
        ProductoService _servicioProducto = new ProductoService();
        

        public FrmReportePorPeriodo()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
