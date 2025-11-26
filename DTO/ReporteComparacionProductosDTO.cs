using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.DTO
{
    public class ReporteComparacionProductosDTO
    {
        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal MontoTotalMesUno { get; set; }
        public decimal MontoTotalMesDos { get; set; }
    }
}
