using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.DTO
{
    public class ReporteVentaProductoDTO
    {
        public string ClaveProducto { get; set; }
        public string Nombre { get; set; }
        public int Unidades { get; set; }
        public decimal Monto { get; set; }
    }
}
