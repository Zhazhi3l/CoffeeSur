using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.DTO
{
    public class AuditoriaGenericaDTO
    {
        public int IdAuditoria { get; set; }
        public int IdReferenciaObjeto { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Detalles { get; set; }
    }
}
