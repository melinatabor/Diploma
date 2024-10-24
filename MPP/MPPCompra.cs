using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPCompra
    {
        public static bool Agregar(BECompra compra)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Total", compra.Total);
                parametros.Add("@Fecha", compra.Fecha);

                return Acceso.ExecuteNonQuery(CompraStoredProcedures.SP_AgregarCompra, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Editar(BECompra compra)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", compra.Id);
                parametros.Add("@Total", compra.Total);

                return Acceso.ExecuteNonQuery(CompraStoredProcedures.SP_EditarCompra, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Baja(int id)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", id);

                return Acceso.ExecuteNonQuery(CompraStoredProcedures.SP_EliminarCompra, parametros, true);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
        public static BECompra BuscarCompraXId(int id)
        {
            try
            {
                Hashtable parametros = new Hashtable();
                parametros.Add("@Id", id);

                DataTable dt = Acceso.ExecuteDataTable(CompraStoredProcedures.SP_BuscarCompraXId, parametros, true);

                BECompra compra = new BECompra();

                if (dt.Rows.Count > 0)
                {
                    DataRow item = dt.Rows[0];

                    compra.Id = Convert.ToInt32(item["Id"]);
                    compra.Total = Convert.ToSingle(item["Total"]);
                    compra.Fecha = Convert.ToDateTime(item["Fecha"]);
                }

                return compra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BECompra ObtenerUltimaCompra()
        {
            try
            {
                DataTable table = Acceso.ExecuteDataTable(CompraStoredProcedures.SP_ObtenerUltimaCompra, null, true);

                BECompra compra = new BECompra();

                if (table.Rows.Count > 0)
                {
                    DataRow item = table.Rows[0];

                    compra.Id = Convert.ToInt32(item["Id"]);
                    compra.Total = Convert.ToSingle(item["Total"]);
                    compra.Fecha = Convert.ToDateTime(item["Fecha"]);
                }

                return compra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
