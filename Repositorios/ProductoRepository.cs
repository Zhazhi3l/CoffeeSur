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
    /// Repositorio para la gestión del inventario de productos.
    /// </summary>
    public class ProductoRepository
    {
        private ConexionBD _conexion = new ConexionBD();

        /// <summary>
        /// Agrega un producto al inventario invocando el SP correspondiente.
        /// </summary>
        /// <param name="producto">Objeto Producto completo.</param>
        /// <returns>True si la inserción fue exitosa.</returns>
        public bool AgregarProducto(Producto producto)
        {
            using (MySqlConnection conex = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_InsertarProducto", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_Clave", producto.Clave ?? "");
                    cmd.Parameters.AddWithValue("@p_Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@p_Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@p_Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@p_Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@p_Descuento", producto.Descuento);
                    cmd.Parameters.AddWithValue("@p_Activo", producto.Activo);
                    // Manejo de la imagen como parámetro BLOB
                    if (producto.Imagen != null && producto.Imagen.Length > 0)
                        cmd.Parameters.Add("@p_Imagen", MySqlDbType.LongBlob).Value = producto.Imagen;
                    else
                        cmd.Parameters.Add("@p_Imagen", MySqlDbType.LongBlob).Value = DBNull.Value;

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        /// <summary>
        /// 
        /// Modifica un producto al inventario invocando el SP correspondiente.
        /// </summary>
        /// <param name="producto">Objeto Producto completo.</param>
        /// <returns>True si la actualización fue exitosa.</returns>
        public bool ActualizarProducto(Producto producto)
        {
            using (MySqlConnection conex = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ActualizarProducto", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_IdProducto", producto.IdProducto);
                    cmd.Parameters.AddWithValue("@p_Clave", producto.Clave ?? "");
                    cmd.Parameters.AddWithValue("@p_Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@p_Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@p_Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@p_Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@p_Descuento", producto.Descuento);
                    cmd.Parameters.AddWithValue("@p_Activo", producto.Activo);
                    // Manejo de la imagen como parámetro BLOB
                    if (producto.Imagen != null && producto.Imagen.Length > 0)
                        cmd.Parameters.Add("@p_Imagen", MySqlDbType.LongBlob).Value = producto.Imagen;
                    else
                        cmd.Parameters.Add("@p_Imagen", MySqlDbType.LongBlob).Value = DBNull.Value;

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        /// <summary>
        /// Realiza un borrado lógico del producto (Lo marca como inactivo).
        /// </summary>
        /// <param name="idProducto">Id del producto a eliminar.</param>
        /// <returns>True si se eliminó correctamente.</returns>
        public bool EliminarProducto(int idProducto)
        {
            using (MySqlConnection conex = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_EliminarProducto", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_IdProducto", idProducto);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        /// <summary>
        /// Obtiene un producto por su ID numérico interno.
        /// </summary>
        /// <param name="idProducto">Identificador único del producto.</param>
        /// <returns>Objeto Producto o null si no existe.</returns>
        public Producto ObtenerPorId(int idProducto)
        {
            Producto p = null;
            using (MySqlConnection conex = _conexion.GetConexion())
            {
                string query = @"SELECT IdProducto, Clave, Nombre, Precio, Stock, Descuento, Descripcion, Imagen, Activo 
                                 FROM productos 
                                 WHERE IdProducto = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conex))
                {
                    cmd.Parameters.AddWithValue("@id", idProducto);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            p = new Producto
                            {
                                IdProducto = reader.GetInt32("IdProducto"),
                                Clave = reader.GetString("Clave"),
                                Nombre = reader.GetString("Nombre"),
                                Precio = reader.GetDecimal("Precio"),
                                Stock = reader.GetInt32("Stock"),
                                Descuento = reader.IsDBNull(reader.GetOrdinal("Descuento")) ? 0 : reader.GetDecimal("Descuento"),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "" : reader.GetString("Descripcion"),
                                Activo = reader.GetBoolean("Activo")
                            };

                            if (!reader.IsDBNull(reader.GetOrdinal("Imagen")))
                            {
                                p.Imagen = (byte[])reader["Imagen"];
                            }
                        }
                    }
                }
            }
            return p;
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> productos = new List<Producto>();
            using (MySqlConnection conx = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ListarProductos", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto p = new Producto
                            {
                                IdProducto = reader.GetInt32("IdProducto"),
                                Clave = reader.IsDBNull(reader.GetOrdinal("Clave")) ? "" : reader.GetString("Clave"),
                                Nombre = reader.GetString("Nombre"),
                                Precio = reader.GetDecimal("Precio"),
                                Stock = reader.GetInt32("Stock"),
                                Descuento = reader.GetDecimal("Descuento"),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "" : reader.GetString("Descripcion"),
                                Activo = reader.GetBoolean("Activo")
                            };
                            if (!reader.IsDBNull(reader.GetOrdinal("Imagen")))
                            {
                                p.Imagen = (byte[])reader["Imagen"];
                            }
                            productos.Add(p);
                        }
                    }
                }
            }
            return productos;
        }
        public Producto ObtenerPorClave(string clave)
        {
            Producto p = null;
            using (MySqlConnection conex = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ObtenerProductoPorClave", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@clave", clave);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            p = new Producto
                            {
                                IdProducto = reader.GetInt32("IdProducto"),
                                Clave = reader.GetString("Clave"),
                                Nombre = reader.GetString("Nombre"),
                                Precio = reader.GetDecimal("Precio"),
                                Stock = reader.GetInt32("Stock"),
                                Descuento = reader.IsDBNull(reader.GetOrdinal("Descuento")) ? 0 : reader.GetDecimal("Descuento"),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "" : reader.GetString("Descripcion"),
                                Activo = reader.GetBoolean("Activo")
                            };
                            if (!reader.IsDBNull(reader.GetOrdinal("Imagen")))
                            {
                                p.Imagen = (byte[])reader["Imagen"];
                            }
                        }
                    }
                }
            }
            return p;
        }

        public bool AcualizarStock(int idProducto, int nuevaCantidad)
        {
            try
            {
                using (MySqlConnection conex = _conexion.GetConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand("sp_ActualizarStock", conex))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@p_NuevaCantidad", nuevaCantidad);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
