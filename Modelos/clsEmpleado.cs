using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Modelos
{
    public class clsEmpleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
     
        public DateTime FechaContratacion { get; set; }
        public decimal Salario { get; set; }
    }
}
