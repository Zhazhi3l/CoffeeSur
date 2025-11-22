using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Modelos
{
    /// <summary>
    /// Representa un producto en el inventario del sistema con sus propiedades básicas.
    /// </summary>
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public decimal Descuento { get; set; }
        public byte[] Imagen { get; set; }
        public bool Activo { get; set; }
        
    }
}
