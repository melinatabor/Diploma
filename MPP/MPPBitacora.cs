using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPPBitacora
    {
        public static bool Agregar(BEBitacora bitacora)
        {
            try
            {
                Hashtable parametros = new Hashtable
                {
                    { "@Usuario", bitacora.Usuario },
                    { "@Tipo", bitacora.Tipo },
                    { "@Mensaje", bitacora.Mensaje }
                };

                return Acceso.ExecuteNonQuery(BitacoraStoredProcedures.SP_AgregarBitacora, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static BEBitacoraFiltrada Llenar(DataRow fila, BEBitacoraFiltrada bitacora)
        {
            try
            {
                bitacora.Id      = Convert.ToInt32(fila["Id"]);
                bitacora.Usuario = fila["Usuario"].ToString();
                bitacora.Tipo    = fila["Tipo"].ToString();
                bitacora.Mensaje = fila["Mensaje"].ToString();
                bitacora.Fecha   = Convert.ToDateTime(fila["Fecha"]);

                return bitacora;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEBitacoraFiltrada> Filtrar(BEBitacoraCriteria criteria)
        {
            try
            {
                List<BEBitacoraFiltrada> lista = new List<BEBitacoraFiltrada>();

                Hashtable parametros = ExtraerParametros(criteria);
                
                DataTable table = Acceso.ExecuteDataTable(BitacoraStoredProcedures.SP_FiltrarBitacora, parametros, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEBitacoraFiltrada bitacora = new BEBitacoraFiltrada();
                        lista.Add(Llenar(fila, bitacora));
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static Hashtable ExtraerParametros(BEBitacoraCriteria criteria)
        {
            try
            {
                Hashtable parametros = new Hashtable
                {
                    { "@Tipo", criteria.Tipo ?? (object)DBNull.Value },
                    { "@Usuario", criteria.Usuario ?? (object)DBNull.Value },
                    { "@Desde", criteria.Desde },
                    { "@Hasta", criteria.Hasta }
                };

                parametros["@Page"] = (criteria.Page - 1) * criteria.RowPerPage;
                parametros["@Filas"] = criteria.RowPerPage;

                if (string.IsNullOrEmpty(criteria.Usuario))
                    parametros["@Usuario"] = DBNull.Value;
                if (criteria.Tipo == 0 || criteria.Tipo == null)
                    parametros["@Tipo"] = DBNull.Value;

                return parametros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
