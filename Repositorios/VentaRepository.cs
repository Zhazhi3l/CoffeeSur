using CoffeeSur.DTO;
using CoffeeSur.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Repositorios
{
    /// <summary>
    /// Repositorio encargado de las transacciones de ventas.
    /// Maneja la integridad referencial entre Venta y DetalleVenta.,
    /// </summary>
    public class VentaRepository
    {
        private ConexionBD _conexion = new ConexionBD();

        /// <summary>
        /// Realiza una venta dentro de una transacción.
        /// La venta incluye la inserción en la tabla venta,la inserción de cada detalle en detalle_venta
        /// y su respectiva actualización de stock en la tabla productos.
        /// </summary>
        /// <param name="venta">Objeto venta con su lista de detalles donde se incluyen todos los productos de la venta.</param>
        /// <exception cref="Exception">Se lanza si falla cualquier paso de la transacción.</exception>
        public void RegistrarVenta(Venta venta)
        {
            using (MySqlConnection conn = _conexion.GetConexion())
            {
                MySqlTransaction transaccion = conn.BeginTransaction();

                try
                {
                    int idVentaGenerado = 0;

                    // 1. Insertar en tabla venta.
                    using (MySqlCommand cmdVenta = new MySqlCommand("sp_InsertarVenta", conn))
                    {
                        // Amarra la transaccion
                        cmdVenta.Transaction = transaccion; 
                        cmdVenta.CommandType = CommandType.StoredProcedure;

                        cmdVenta.Parameters.AddWithValue("@p_IdUsuario", venta.IdUsuario);
                        cmdVenta.Parameters.AddWithValue("@p_Total", venta.Total);

                        // Recuperar el ID generado. El SP debe tener el parámetro de salida (p_IdVentaGenerado) configurado.
                        cmdVenta.Parameters.Add("@p_IdVentaGenerado", MySqlDbType.Int32).Direction = ParameterDirection.Output;

                        cmdVenta.ExecuteNonQuery();

                        idVentaGenerado = Convert.ToInt32(cmdVenta.Parameters["@p_IdVentaGenerado"].Value);
                    }

                    // 2. Inserta todos los objetos de DetalleVenta en la tabla detalles_venta y actualiza stock del producto.
                    foreach (var detalle in venta.Detalles)
                    {
                        //Insertar en tabla detalles_venta
                        using (MySqlCommand cmdDetalle = new MySqlCommand("sp_InsertarDetalleVenta", conn))
                        {
                            cmdDetalle.Transaction = transaccion; // AMarra la transacción
                            cmdDetalle.CommandType = CommandType.StoredProcedure;

                            cmdDetalle.Parameters.AddWithValue("@p_IdVenta", idVentaGenerado);
                            cmdDetalle.Parameters.AddWithValue("@p_IdProducto", detalle.IdProducto);
                            cmdDetalle.Parameters.AddWithValue("@p_Cantidad", detalle.Cantidad);
                            cmdDetalle.Parameters.AddWithValue("@p_PrecioUnitario", detalle.PrecioUnitario);
                            cmdDetalle.Parameters.AddWithValue("@p_Subtotal", detalle.Subtotal);

                            cmdDetalle.ExecuteNonQuery();
                        }

                        // Descontar Stock
                        using (MySqlCommand cmdStock = new MySqlCommand("sp_DescontarStock", conn))
                        {
                            cmdStock.Transaction = transaccion;
                            cmdStock.CommandType = CommandType.StoredProcedure;

                            cmdStock.Parameters.AddWithValue("@p_IdProducto", detalle.IdProducto);
                            cmdStock.Parameters.AddWithValue("@p_Cantidad", detalle.Cantidad);

                            cmdStock.ExecuteNonQuery();
                        }
                    }

                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw new Exception("Error en la transacción de venta: " + ex.Message, ex);
                }
            }
        }


        public Venta ObtenerVentaPorId(int idVenta)
        {
            Venta venta = null;
            using (MySqlConnection conx = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ObtenerVentaPorId", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_IdVenta", idVenta);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            venta = new Venta
                            {
                                IdVenta = Convert.ToInt32(reader["IdVenta"]),
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                FechaVenta = Convert.ToDateTime(reader["FechaVenta"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                Detalles = new List<DetalleVenta>()
                            };
                        }
                    }
                }

                if (venta == null)
                    return null;

                using (MySqlCommand cmdDetalles = new MySqlCommand("sp_ObtenerDetallesVenta", conx))
                {
                    cmdDetalles.CommandType = CommandType.StoredProcedure;
                    cmdDetalles.Parameters.AddWithValue("@p_IdVenta", idVenta);

                    using (MySqlDataReader readerDetalles = cmdDetalles.ExecuteReader())
                    {
                        while (readerDetalles.Read())
                        {
                            venta.Detalles.Add(new DetalleVenta
                            {
                                IdDetalleVenta = Convert.ToInt32(readerDetalles["IdDetalleVenta"]),
                                IdVenta = Convert.ToInt32(readerDetalles["IdVenta"]),
                                IdProducto = Convert.ToInt32(readerDetalles["IdProducto"]),
                                Cantidad = Convert.ToInt32(readerDetalles["Cantidad"]),
                                PrecioUnitario = Convert.ToDecimal(readerDetalles["PrecioUnitario"]),
                                Subtotal = Convert.ToDecimal(readerDetalles["Subtotal"])
                            });
                        }
                    }
                }
            }
            return venta;
        }

        public List<Venta> ObtenerTodas()
        {
            List<Venta> ventas = new List<Venta>();
            using (MySqlConnection conx = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ListarVentas", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ventas.Add(new Venta
                            {
                                IdVenta = Convert.ToInt32(reader["IdVenta"]),
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                FechaVenta = Convert.ToDateTime(reader["FechaVenta"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                Detalles = new List<DetalleVenta>()
                            });
                        }
                    }
                }
            }
            return ventas;
        }

        /// <summary>
        /// Genera un reporte de ventas por producto en un periodo determinado
        /// directamente desde la base de datos.
        /// </summary>
        /// <param name="fechaInicio">DateTime fecha de inicio.</param>
        /// <param name="fechaFin">DateTime fecha de fin</param>
        /// <returns>Una lista de un reporte. Cada fila contiene:
        ///             Clave de producto.
        ///             Nombre del producto.
        ///             Suma de las unidades vendidas de ese producto.
        ///             Suma de venta total de ese producto.
        /// </returns>
        public List<ReporteVentaProductoDTO> ObtenerVentasPorProductoPorPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteVentaProductoDTO> reporte = new List<ReporteVentaProductoDTO>();
            using (MySqlConnection conx = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ReporteVentasPorProducto", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@p_FechaFin", fechaFin);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reporte.Add(new ReporteVentaProductoDTO
                            {
                                ClaveProducto = reader["ClaveProducto"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Unidades = Convert.ToInt32(reader["Unidades"]),
                                Monto = Convert.ToDecimal(reader["Monto"])
                            });
                        }
                    }
                }
            }
            return reporte;
        }

        public List<ReporteComparacionProductosDTO> ObtenerComparacionDeProductosEntreMeses(List<int> listaIdProductos, DateTime fecha1, DateTime fecha2)
        {
            List<ReporteComparacionProductosDTO> reporte = new List<ReporteComparacionProductosDTO>();
            using (MySqlConnection conx = _conexion.GetConexion())
            {
                foreach (int idProd in listaIdProductos)
                {
                    using (MySqlCommand cmd = new MySqlCommand("sp_ReporteComparativoProductos", conx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_IdProducto", idProd);
                        cmd.Parameters.AddWithValue("@p_Fecha1", fecha1);
                        cmd.Parameters.AddWithValue("@p_Fecha2", fecha2);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reporte.Add(new ReporteComparacionProductosDTO()
                                {
                                    IdProducto = reader["IdProducto"].ToString(),
                                    Nombre = reader.GetString("NombreProducto"),
                                    MontoTotalMesUno = reader.GetDecimal("VentaMes1"),
                                    MontoTotalMesDos = reader.GetDecimal("VentaMes2")
                                });
                            }
                        }
                    }
                }
            }
            return reporte;
        }
    }
}
