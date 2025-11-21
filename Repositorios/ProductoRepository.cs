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
    public class ProductoRepository
    {
        private ConexionBD conexion = new ConexionBD();

        public bool AgregarProducto(Producto producto)
        {
            using (MySqlConnection conex = conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_InsertarProducto", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@p_Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@p_Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@p_Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@p_Descuento", producto.Descuento);
                    cmd.Parameters.AddWithValue("@p_Activo", producto.Activo);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool ActualizarProducto(Producto producto)
        {
            using (MySqlConnection conex = conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ActualizarProducto", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_IdProducto", producto.IdProducto);
                    cmd.Parameters.AddWithValue("@p_Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@p_Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@p_Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@p_Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@p_Descuento", producto.Descuento);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool EliminarProducto(int idProducto)
        {
            using (MySqlConnection conex = conexion.GetConexion())
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

        public Producto ObtenerPorId(int idProducto)
        {
            Producto p = null;
            using (MySqlConnection conex = conexion.GetConexion())
            {
                string query = "SELECT Clave AS IdProducto, Nombre, Precio, Stock FROM Productos WHERE Clave = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conex))
                {
                    cmd.Parameters.AddWithValue("@id", idProducto);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            p = new Producto();
                            p.IdProducto = reader.GetInt32("IdProducto");
                            p.Nombre = reader.GetString("Nombre");
                            p.Precio = reader.GetDecimal("Precio");
                            p.Stock = reader.GetInt32("Stock");
                        }
                    }
                }
            }
            return p;
        }
    }
}
