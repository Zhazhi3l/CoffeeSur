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
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = System.Drawing.Image.FromFile(ofd.FileName);
            }
        }

        private byte[] ConvertirImagenABytes()
        {
            if (pbImagen.Image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                pbImagen.Image.Save(ms, pbImagen.Image.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto
            {
                Clave = txtClave.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = nudPrecio.Value,
                Stock = (int)nudStock.Value,
                Descuento = nudDescuento.Value,
                Imagen = ConvertirImagenABytes(),
                Activo = chkActivo.Checked
            };

            try
            {
                ProductoService service = new ProductoService();
                service.RegistrarNuevoProducto(producto);

                MessageBox.Show("Producto registrado correctamente");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtClave.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            nudPrecio.Value = 0;
            nudStock.Value = 0;
            nudDescuento.Value = 0;
            chkActivo.Checked = false;
            pbImagen.Image = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
