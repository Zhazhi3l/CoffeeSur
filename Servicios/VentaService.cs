using CoffeeSur.DTO;
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
        private readonly VentaRepository _ventaRepo = new VentaRepository();
        private readonly ProductoRepository _productoRepo = new ProductoRepository();

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
                    var producto = _productoService.ObtenerProductoPorId(detalle.IdProducto);

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

        /// <summary>
        /// Genera un reporte de ventas por producto en un periodo determinado.
        /// </summary>
        /// <param name="fechaInicio">DateTime Fecha de inicio del periodo.</param>
        /// <param name="fechaFin">DateTime Fecha de fin del periodo.</param>
        /// <returns>Devuelve una lista que representa el reporte de venta.</returns>
        /// <exception cref="Exception"></exception>
        public List<ReporteVentaProductoDTO> ReporteVentaPorProducto(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
                throw new Exception("La fecha de inicio no puede ser mayor que la fecha de fin.");

            if (fechaFin > DateTime.Now)
                throw new Exception("La fecha de fin no puede ser mayor que la fecha actual.");

            if (fechaInicio > DateTime.Now)
                throw new Exception("La fecha de inicio no puede ser mayor que la fecha actual.");

            // Asegurar que se busque hasta el último segundo del día.
            DateTime finAjustado = new DateTime(fechaFin.Year, fechaFin.Month, fechaFin.Day, 23, 59, 59);

            return _ventaRepo.ObtenerVentasPorProductoPorPeriodo(fechaInicio, finAjustado);
        }

        /// <summary>
        /// Devuelve el historial completo de todas las ventas.
        /// </summary>
        /// <returns>Una lista con todas las ventas.</returns>
        /// <exception cref="Exception"></exception>
        public List<Venta> ObtenerTodasVentas()
        {
            try
            {
                return _ventaRepo.ObtenerTodas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el historial de ventas: " + ex.Message);
            }
        }


        /// <summary>
        /// Busca una venta por su id junto con su atributo detalle ventas.
        /// </summary>
        /// <param name="idVenta">Valor int del id de la venta.</param>
        /// <returns>Una venta con todos sus atributos y su atributo 
        ///             DetallesVenta con una lista llena de los detalles de esa venta.</returns>
        /// <exception cref="Exception"></exception>
        public Venta BuscarVentaPorId(int idVenta)
        {
            if (idVenta <= 0)
                throw new Exception("El ID de la venta no es válido.");

            try
            {
                Venta venta = _ventaRepo.ObtenerVentaPorId(idVenta);
                if (venta == null)
                    throw new Exception("No se encontró ninguna venta con el ID proporcionado.");
                return venta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la venta: " + ex.Message);
            }
        }

        public List<ReporteComparacionProductosDTO> GenerarReporteComparativo(List<Producto> productosSeleccionados, DateTime fecha1, DateTime fecha2)
        {
            if (productosSeleccionados == null || productosSeleccionados.Count == 0)
                throw new Exception("La lista de productos para comparar está vacía.");

            // if (fecha1 > DateTime.Now || fecha2 > DateTime.Now)
            
           List<int> idsUnicos = productosSeleccionados
                                    .Select(p => p.IdProducto)
                                    .Distinct()
                                    .ToList();

            // 3. Llamada eficiente al repositorio
            return _ventaRepo.ObtenerComparacionDeProductosEntreMeses(idsUnicos, fecha1, fecha2);
        }

    }
}
