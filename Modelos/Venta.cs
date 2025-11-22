using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Modelos
{
    /// <summary>
    /// Objeto que representa una venta realizada en el sistema.
    /// </summary>
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
    }
}
