using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeSur
{
    public partial class ProductoCard : UserControl
    {
        public event EventHandler ProductoClick;

        public int IdProducto { get; set; }

        public string Nombre
        {
            get => lblNombre.Text;
            set => lblNombre.Text = value;
        }

        public decimal Precio
        {
            get => decimal.Parse(lblPrecio.Text.Replace("$", ""));
            set => lblPrecio.Text = "$" + value.ToString("0.00");
        }

        public Image Imagen
        {
            get => picImagen.Image;
            set => picImagen.Image = value;
        }

        public ProductoCard()
        {
            InitializeComponent();
            this.Click += (s, e) => ProductoClick?.Invoke(this, EventArgs.Empty);
            picImagen.Click += (s, e) => ProductoClick?.Invoke(this, EventArgs.Empty);
            lblNombre.Click += (s, e) => ProductoClick?.Invoke(this, EventArgs.Empty);
            lblPrecio.Click += (s, e) => ProductoClick?.Invoke(this, EventArgs.Empty);
        }
    }

}

