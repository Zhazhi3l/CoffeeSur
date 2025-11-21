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

        public bool ModificarProductoExistente(Producto prodModificado)
        {
            try
            {
                if (prodModificado.Precio <= 0)
                {
                    throw new Exception("El precio debe ser mayor a 0.");
                }
                if (string.IsNullOrWhiteSpace(prodModificado.Nombre))
                {
                    throw new Exception("El nombre del producto no puede estar vacío.");
                }
                if (prodModificado.Stock < 0)
                {
                    throw new Exception("EL Stock del producto, no puede ser negativo.");
                }
                if (prodModificado.Descuento < 0)
                {
                    throw new Exception("El descuento no puede ser negativo.");
                }

                bool seActualizo = _repo.ActualizarProducto(prodModificado);

                if (!seActualizo)
                {
                    throw new Exception("No se encontró el producto a modificar.");
                }

                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar producto: " + ex.Message);
            }
        }

        public bool EliminarProducto(int idProducto)
        {
            try
            { 
                if (idProducto <= 0)
                {
                    throw new Exception("El ID del producto no es válido.");
                }

                bool eliminado = _repo.EliminarProducto(idProducto);
                if (!eliminado) 
                {
                    throw new Exception("No se encontró el producto para eliminar.");
                }
                return eliminado;

            }
            catch (MySqlException ex)
            {
                throw new Exception("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar producto: " + ex.Message);
            }
        }

        public void ValidarStockSuficiente(int idProducto, int cantidadSolicitada)
        {
            Producto prodEnBD = _repo.ObtenerPorId(idProducto);

            if (prodEnBD == null)
            {
                throw new Exception($"El producto con ID {idProducto} no existe.");
            }

            if (prodEnBD.Stock < cantidadSolicitada)
            {
                throw new Exception($"Stock insuficiente para '{prodEnBD.Nombre}'. Disponibles: {prodEnBD.Stock}, Solicitados: {cantidadSolicitada}.");
            }

            // Si llega aquí, es que hay stock.
        }
    }
}
