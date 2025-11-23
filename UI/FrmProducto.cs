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
        private ProductoService _servicio = new ProductoService();
        private Producto _productoEditar = null;

        public FrmProducto()
        {
            InitializeComponent();
        }

        public FrmProducto(Producto prodEditar)
        {
            InitializeComponent();
            _productoEditar = prodEditar;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            if (_productoEditar != null)
                CargarDatos();
        }

        private void CargarDatos()
        {
            txtClave.Text = _productoEditar.Clave;
            txtNombre.Text = _productoEditar.Nombre;
            txtDescripcion.Text = _productoEditar.Descripcion;
            nudPrecio.Value = _productoEditar.Precio;
            nudStock.Value = _productoEditar.Stock;
            nudDescuento.Value = _productoEditar.Descuento;
            chkActivo.Checked = _productoEditar.Activo;

            if (_productoEditar.Imagen != null)
                pbImagen.Image = _servicio.ConvertirBytesAImagen(_productoEditar.Imagen);
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
                Producto p = new Producto()
                {
                    IdProducto = _productoEditar?.IdProducto ?? 0,
                    Clave = txtClave.Text,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = nudPrecio.Value,
                    Stock = (int)nudStock.Value,
                    Descuento = nudDescuento.Value,
                    Activo = chkActivo.Checked,
                    Imagen = pbImagen.Image != null
                        ? _servicio.ConvertirImagenABytes(pbImagen.Image)
                        : null
                };

                if (_productoEditar == null)
                {
                    _servicio.RegistrarNuevoProducto(p);
                }
                else
                {
                    _servicio.ModificarProductoExistente(p);
                }

                MessageBox.Show("Producto guardado correctamente.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

