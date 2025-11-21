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
        private string conexion = new ConexionBD().GetConnectionString();

        public void AgregarProducto(Producto producto)
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_InsertarProducto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@p_Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@p_Stock", producto.Stock);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
