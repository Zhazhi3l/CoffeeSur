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
        private readonly ProductoService _service = new ProductoService();

        private int _idProductoEditar = 0;

        public FrmProducto()
        {
            InitializeComponent();
        }

        public FrmProducto(Producto productoEditar)
        {
            InitializeComponent();
            CargarProductoEnFormulario(productoEditar);
            _idProductoEditar = productoEditar.IdProducto;
        }

        private void CargarProductoEnFormulario(Producto p)
        {
            txtClave.Text = p.Clave;
            txtNombre.Text = p.Nombre;
            txtDescripcion.Text = p.Descripcion;
            nudPrecio.Value = p.Precio;
            nudStock.Value = p.Stock;
            nudDescuento.Value = p.Descuento;
            chkActivo.Checked = p.Activo;

            if (p.Imagen != null)
            {
                using (MemoryStream ms = new MemoryStream(p.Imagen))
                {
                    pbImagen.Image = System.Drawing.Image.FromStream(ms);
                }
            }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto
                {
                    IdProducto = _idProductoEditar, 
                    Clave = txtClave.Text,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = nudPrecio.Value,
                    Stock = (int)nudStock.Value,
                    Descuento = nudDescuento.Value,
                    Activo = chkActivo.Checked,
                    Imagen = _service.ConvertirImagenABytes(pbImagen.Image)
                };

                if (_idProductoEditar == 0)
                {
                    _service.RegistrarNuevoProducto(producto);
                    MessageBox.Show("Producto registrado correctamente.");
                }
                else
                {
                    _service.ModificarProductoExistente(producto);
                    MessageBox.Show("Producto modificado correctamente.");
                }

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
            _idProductoEditar = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
