using CoffeeSur.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Repositorios
{
    public class EmpleadoRepository
    {
        private string conexion = new ConexionBD().GetConnectionString();
        public void AgregarEmpleado(clsEmpleado empleado)
        {
            // Lógica para agregar un empleado a la base de datos
        }
    }
}
