using CoffeeSur.Modelos;
using CoffeeSur.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Servicios
{
    /// <summary>
    /// Servicio para gestionar la lógica de negocio de las Ventas.
    /// </summary>
    public class VentaService
    {
        private VentaRepository _ventaRepo = new VentaRepository();
        private ProductoRepository _productoRepo = new ProductoRepository();

        /// <summary>
        /// Procesa una nueva venta validando stock y calculando totales.
        /// </summary>
        /// <param name="venta">Objeto venta (el Total se recalcula aquí por seguridad).</param>
        public void RealizarVenta(Venta venta)
        {
            try
            {
                if (venta.Detalles == null || venta.Detalles.Count == 0)
                    throw new Exception("La venta debe tener al menos un detalle.");

                if (venta.IdUsuario <= 0)
                    throw new Exception("No se ha encontrado el ID del usuario que realiza la venta.");

                decimal totalVenta = 0;
                ProductoService _productoService = new ProductoService();

                foreach (var detalle in venta.Detalles)
                {
                    var producto = _productoRepo.ObtenerPorId(detalle.IdProducto);

                    if (producto == null)
                        throw new Exception($"El producto con ID {detalle.IdProducto} no existe.");

                    if (!producto.Activo)
                        throw new Exception($"El producto '{producto.Nombre}' no está disponible para venta.");

                    _productoService.ValidarStockSuficiente(producto, detalle.Cantidad);

                    detalle.PrecioUnitario = producto.Precio;
                    detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;

                    totalVenta += detalle.Subtotal;
                }

                venta.Total = totalVenta;

                _ventaRepo.RegistrarVenta(venta);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar la venta", ex);
            }
        }
    }
}
