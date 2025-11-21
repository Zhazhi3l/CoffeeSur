using CoffeeSur.Modelos;
using CoffeeSur.Repositorios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Servicios
{
    public class ProductoService
    {
        private ProductoRepository _repo = new ProductoRepository();

        /// <summary>
        /// Método para registrar un nuevo producto. Recibe un objeto Producto con los datos del nuevo producto.
        /// </summary>
        /// <param name="nuevoProd"></param>
        /// <exception cref="Exception"></exception>
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
                nuevoProd.Imagen = ConvertirImagenABytes(imagenUI);

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

        /// <summary>
        /// Método para modificar un producto existente. Rrecibe un objeto Producto con los datos actualizados.
        /// Los datos originales se obtienen de la base de datos usando el IdProducto y de ahí se actualizan los campos.
        /// </summary>
        /// <param name="prodModificado"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Método para eliminar un producto por su ID. El borrado funciona de forma lógica.
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Método para validar si hay stock suficiente de un producto.
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="cantidadSolicitada"></param>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Método para convertir una imagen a un arreglo de bytes para almacenar en BD.
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public byte[] ConvertirImagenABytes(Image img)
        {
            // Si no mandaron imagen, retornamos null para que se guarde como NULL en BD
            if (img == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                // Guardamos como PNG para mantener calidad y transparencia
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
