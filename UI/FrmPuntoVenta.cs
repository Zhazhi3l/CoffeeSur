using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeSur.Modelos;

namespace CoffeeSur.UI
{
    public partial class FrmPuntoVenta : Form
    {
        private int usuarioLogueadoId;

        public FrmPuntoVenta(int idUsuario)
        {
            InitializeComponent();
            usuarioLogueadoId = idUsuario;
            ConfigurarReloj();
            lblUsuario.Text = $"Usuario: {usuarioLogueadoId}";
        }

        private void ConfigurarReloj()
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += (s, e) =>
            {
                lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
                lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
            };
            t.Start();
        }


        private Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }


        private void CargarProductosDesdeBD()
        {
            flpProductos.Controls.Clear();

            List<Producto> productos = ObtenerProductosBD(); 

            foreach (var p in productos)
            {
                ProductoCard card = new ProductoCard()
                {
                    Nombre = p.Nombre,
                    Precio = p.Precio,
                    Imagen = ByteArrayToImage(p.Imagen) 
                };

                card.ProductoClick += (s, e) => MostrarDetalles(card);
                flpProductos.Controls.Add(card);
            }
        }

        private List<Producto> ObtenerProductosBD()
        {
            return new List<Producto>()
        {
            new Producto(){ Nombre="Capuccino", Precio=25, Imagen=null },
            new Producto(){ Nombre="Latte", Precio=28, Imagen=null }
        };
        }

        
        private void CargarProductosEjemplo()
        {
            for (int i = 1; i <= 10; i++)
            {
                ProductoCard card = new ProductoCard()
                {
                    Nombre = "Producto " + i,
                    Precio = 10 + i,
                    Imagen = null 
                };

                card.ProductoClick += (s, e) => MostrarDetalles(card);
                flpProductos.Controls.Add(card);
            }
        }

        private void MostrarDetalles(ProductoCard card)
        {
            lblDetalleNombre.Text = card.Nombre;
            lblDetallePrecio.Text = "$" + card.Precio;
            picDetalle.Image = card.Imagen;
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Precio"].Value);
            }
            return total;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Venta v = new Venta()
            {
                IdUsuario = usuarioLogueadoId,
                FechaVenta = DateTime.Now,
                Total = CalcularTotal()
            };

            MessageBox.Show("Venta registrada correctamente");
        }

        private void flpProductos_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
