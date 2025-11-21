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
    public partial class FrmProducto : Form
    {
        private ProductoService _productoService = new ProductoService();

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevo = new Producto()
                {
                    Nombre = txtNombre.Text.Trim(),
                    Precio = Convert.ToDecimal(txtPrecio.Text.Trim()),
                    Stock = Convert.ToInt32(txtStock.Text.Trim())
                };

                _productoService.RegistrarNuevoProducto(nuevo);

                MessageBox.Show("Producto registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique que el precio y el stock tengan valores numéricos válidos.",
                    "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        
    }
}
