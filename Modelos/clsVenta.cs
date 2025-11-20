using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Modelos
{
    public class clsVenta
    {
        public int IdVenta { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public List<clsProducto> ProductosVendidos { get; set; }
    }
}
