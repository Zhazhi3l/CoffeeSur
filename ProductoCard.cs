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
        public ProductoCard()
        {
            InitializeComponent();
            this.Click += PropagarClick;
            foreach (Control c in Controls)
                c.Click += PropagarClick;
        }

        private void PropagarClick(object? sender, EventArgs? e)
        {
            ProductoClick?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? ProductoClick;

        public string Nombre
        {
            get => lblNombre.Text;
            set => lblNombre.Text = value ?? "";
        }

        public decimal Precio
        {
            get => decimal.TryParse(lblPrecio.Text.Replace("$", ""), out var p) ? p : 0;
            set => lblPrecio.Text = $"${value:0.00}";
        }

        public Image Imagen
        {
            get => picImagen.Image!;
            set
            {
                if (picImagen.Image != null && picImagen.Image != value)
                    picImagen.Image.Dispose();

                picImagen.Image = value;
            }
        }
    }
}

