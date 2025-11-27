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
    /// <summary>
    /// Servicio que encapsula la lógica de negocio para Productos.
    /// Realiza validaciones antes de llamar al repositorio.
    /// </summary>
    public class ProductoService
    {
        private readonly ProductoRepository _repoProducto = new ProductoRepository();

        /// <summary>
        /// Valida y registra un nuevo producto.
        /// </summary>
        /// <param name="nuevoProd">Objeto producto ya poblado (incluyendo imagen en bytes si aplica).</param>
        public void RegistrarNuevoProducto(Producto nuevoProd)
        {
            try
            {
                if (nuevoProd.Precio <= 0)
                    throw new ArgumentException("El precio debe ser mayor a 0.");

                if (string.IsNullOrWhiteSpace(nuevoProd.Nombre))
                    throw new ArgumentException("El nombre del producto es obligatorio.");

                if (nuevoProd.Stock < 0)
                    throw new ArgumentException("El stock inicial no puede ser negativo.");

                _repoProducto.AgregarProducto(nuevoProd);
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Error de base de datos (Código {ex.Number}): {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el producto.", ex);
            }
        }

        public Producto ObtenerProductoPorId(int IdProducto)
        {
            if (IdProducto <= 0)
                throw new Exception("El ID del producto no es válido.");

            return _repoProducto.ObtenerPorId(IdProducto);
        }

        public Producto BuscarProductoPorClave(string clave)
        {
            if (string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException("La clave del producto no puede estar vacía.");

            try
            {
                Producto producto = _repoProducto.ObtenerPorClave(clave);

                if (producto == null)
                    throw new Exception("No se encontró ningún producto con la clave proporcionada.");
                
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el producto por clave: " + ex.Message);
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

                bool seActualizo = _repoProducto.ActualizarProducto(prodModificado);

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

                bool eliminado = _repoProducto.EliminarProducto(idProducto);
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
        /// Lista todos los productos disponibles en la base de datos.
        /// </summary>
        /// <returns>Una lista de productos.</returns>
        /// <exception cref="Exception"></exception>
        public List<Producto> ObtenerTodosProductos()
        {
            try
            {
                return _repoProducto.ObtenerTodos();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos: " + ex.Message);
            }
        }

        /// <summary>
        /// Verifica si existe stock suficiente para realizar una venta.
        /// Realiza la consulta a la base de datos para obtener el stock actual
        /// trayendo el producto por su ID.
        /// </summary>
        /// <param name="idProducto">ID del producto a vender.</param>
        /// <param name="cantidadSolicitada">Cantidad requerida.</param>
        /// <exception cref="Exception">Lanza excepción si no hay stock o el producto no existe.</exception>
        public void ValidarStockSuficiente(int idProducto, int cantidadSolicitada)
        {
            Producto prodEnBD = _repoProducto.ObtenerPorId(idProducto);

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
        /// Valida si hay stock suficiente en el objeto Producto que recibe.
        /// </summary>
        /// <param name="producto">Producto ya poblado, generado previamente o traído de la BD.</param>
        /// <param name="cantidadSolicitada"></param>
        /// <exception cref="Exception"></exception>
        public void ValidarStockSuficiente(Producto producto, int cantidadSolicitada)
        {
            if(producto == null)
                throw new Exception("El producto no existe o no se encontró.");

            if (producto.Stock < cantidadSolicitada)
            {
                throw new Exception($"Stock insuficiente para '{producto.Nombre}'. Disponibles: {producto.Stock}, Solicitados: {cantidadSolicitada}.");
            }

            // Si llega aquí, es que hay stock.
        }

        /// <summary>
        /// Herramienta auxiliar para convertir una imagen de UI (PictureBox) a array de bytes.
        /// Debe ser llamada por la capa de Presentación antes de enviar el objeto Producto.
        /// </summary>
        /// <param name="img">Imagen proveniente del control visual.</param>
        /// <returns>Arreglo de bytes listo para BD.</returns>
        public byte[] ConvertirImagenABytes(Image img)
        {
            if (img == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (Bitmap bmp = new Bitmap(img))
                {
                    bmp.Save(ms, ImageFormat.Png);
                }
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Recibe un arreglo de bytes proveniente de la base de datos y lo convierte a un objeto Image.
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns>Un objeto Image con la imagen preparada para PictureBox.</returns>
        public Image ConvertirBytesAImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return new Bitmap(Image.FromStream(ms));
            }
        }
    }
}
