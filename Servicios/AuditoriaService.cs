using CoffeeSur.DTO;
using CoffeeSur.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Servicios
{
    public class AuditoriaService
    {
        private readonly AuditoriaRepository _repoAuditoria = new AuditoriaRepository();

        public List<AuditoriaGenericaDTO> ObtenerAuditoriaProductos()
        {
            try
            {
                return _repoAuditoria.ObtenerAuditoriaProductos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar auditoría de productos: " + ex.Message);
            }
        }

        public List<AuditoriaGenericaDTO> GetHistorialUsuarios()
        {
            try
            {
                return _repoAuditoria.ObtenerAuditoriaUsuarios();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar auditoría de usuarios: " + ex.Message);
            }
        }

        public List<AuditoriaGenericaDTO> GetHistorialVentas()
        {
            try
            {
                return _repoAuditoria.ObtenerAuditoriaVentas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar auditoría de ventas: " + ex.Message);
            }
        }
    }
}
