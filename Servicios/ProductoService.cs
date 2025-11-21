using CoffeeSur.Modelos;
using CoffeeSur.Repositorios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Servicios
{
    public class ProductoService
    {
        private ProductoRepository _repo = new ProductoRepository();
        public void RegistrarNuevoProducto(Producto nuevoProd)
        {
            try
            {
                if (nuevoProd.Precio <= 0)
                {
                    throw new Exception("El precio debe ser mayor a 0.");
                }
                if (string.IsNullOrWhiteSpace(nuevoProd.Nombre))
                {
                    throw new Exception("El nombre del producto no puede estar vacío.");
                }
                if (nuevoProd.Stock < 0){
                    throw new Exception("EL Stock del NUEVO producto, no puede ser negativo.");
                }

                _repo.AgregarProducto(nuevoProd);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar producto: " + ex.Message);
            }
        }
    }
}
