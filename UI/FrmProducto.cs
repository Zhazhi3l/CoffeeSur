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
        private readonly ProductoService _productoService = new ProductoService();
        private Producto _productoEditar = null;

        public FrmProducto()
        {
            InitializeComponent();
        }

        public FrmProducto(Producto producto) : this()
        {
            _productoEditar = producto;
            CargarDatosProducto();
        }

        private void CargarDatosProducto()
        {
            txtClave.Text = _productoEditar.Clave;
            txtNombre.Text = _productoEditar.Nombre;
            txtDescripcion.Text = _productoEditar.Descripcion;
            nudPrecio.Value = _productoEditar.Precio;
            nudStock.Value = _productoEditar.Stock;
            nudDescuento.Value = _productoEditar.Descuento;
            chkActivo.Checked = _productoEditar.Activo;

            if (_productoEditar.Imagen != null)
                pbImagen.Image = _productoService.ConvertirBytesAImagen(_productoEditar.Imagen);
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Imágenes|*.png;*.jpg;*.jpeg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatos()) return;

                Producto p = new Producto()
                {
                    IdProducto = _productoEditar?.IdProducto ?? 0,
                    Clave = txtClave.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Precio = nudPrecio.Value,
                    Stock = (int)nudStock.Value,
                    Descuento = nudDescuento.Value,
                    Activo = chkActivo.Checked,
                    Imagen = pbImagen.Image != null
                        ? _productoService.ConvertirImagenABytes(pbImagen.Image)
                        : _productoEditar?.Imagen 
                };

                if (_productoEditar == null)
                    _productoService.RegistrarNuevoProducto(p);
                else
                    _productoService.ModificarProductoExistente(p);

                MessageBox.Show("Producto guardado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtClave.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                nudPrecio.Value <= 0)
            {
                MessageBox.Show("Complete todos los campos obligatorios y que el precio sea mayor a 0.");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

