using CoffeeSur.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSur.Repositorios
{
    public class AuditoriaRepository
    {
        private readonly ConexionBD _conexion = new ConexionBD();

        private List<AuditoriaGenericaDTO> EjecutarSPAuditoria(string nombreSP)
        {
            List<AuditoriaGenericaDTO> listaAuditorias = new List<AuditoriaGenericaDTO>();
            using (MySqlConnection conx = _conexion.GetConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand(nombreSP, conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaAuditorias.Add(new AuditoriaGenericaDTO
                            {
                                IdAuditoria = Convert.ToInt32(reader["IdAuditoria"]),
                                IdReferenciaObjeto = Convert.ToInt32(reader["IdReferenciaObjeto"]),
                                Accion = reader["Accion"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Usuario = reader["Usuario"].ToString(),
                                Detalles = reader.IsDBNull(reader.GetOrdinal("Detalles")) ? "" : reader.GetString("Detalles")
                            });
                        }
                    }
                }
            }
            return listaAuditorias;
        }

        public List<AuditoriaGenericaDTO> ObtenerAuditoriaProductos()
        {
            return EjecutarSPAuditoria("sp_ObtenerAuditoriaProductos");
        }

        public List<AuditoriaGenericaDTO> ObtenerAuditoriaUsuarios()
        {
            return EjecutarSPAuditoria("sp_ObtenerAuditoriaUsuarios");
        }

        public List<AuditoriaGenericaDTO> ObtenerAuditoriaVentas()
        {
            return EjecutarSPAuditoria("sp_ObtenerAuditoriaVentas");
        }
    }
}
