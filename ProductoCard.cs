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
            this.Click += Control_Click;
            foreach (Control c in this.Controls)
                c.Click += Control_Click;
        }

        // Ajuste de nulabilidad en sender y e
        private void Control_Click(object? sender, EventArgs? e)
        {
            ProductoClick?.Invoke(this, EventArgs.Empty);
        }

        // Evento ahora nullable
        public event EventHandler? ProductoClick;

        public string Nombre
        {
            get => lblNombre.Text;
            set => lblNombre.Text = value;
        }

        public decimal Precio
        {
            get => decimal.TryParse(lblPrecio.Text.Replace("$", ""), out var p) ? p : 0;
            set => lblPrecio.Text = $"${value:0.00}";
        }

        public Image Imagen
        {
            get => picImagen.Image;
            set
            {
                picImagen.Image?.Dispose();
                picImagen.Image = value;
            }
        }
    }
}

