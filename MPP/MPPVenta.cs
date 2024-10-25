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
    public class MPPVenta
    {
        public static bool Agregar(BEVenta venta)
        {
            try
            {
                Hashtable parametros = new Hashtable();
                parametros.Add("@Total", venta.Total);
                parametros.Add("@Total", venta.Total);
                parametros.Add("@Fecha", venta.Fecha);

                return Acceso.ExecuteNonQuery(VentaStoredProcedures.SP_AgregarVenta, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Editar(BEVenta venta)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", venta.Id);
                parametros.Add("@Total", venta.Total);

                return Acceso.ExecuteNonQuery(VentaStoredProcedures.SP_EditarVenta, parametros, true);
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

                return Acceso.ExecuteNonQuery(VentaStoredProcedures.SP_EliminarVenta, parametros, true);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BEVenta BuscarVentaXId(int id)
        {
            try
            {
                Hashtable parametros = new Hashtable();
                parametros.Add("@Id", id);

                DataTable dt = Acceso.ExecuteDataTable(VentaStoredProcedures.SP_BuscarVentaXId, parametros, true);

                BEVenta venta = new BEVenta();

                if (dt.Rows.Count > 0)
                {
                    DataRow item = dt.Rows[0];

                    venta.Id = Convert.ToInt32(item["Id"]);
                    venta.Total = Convert.ToSingle(item["Total"]);
                    venta.Fecha = Convert.ToDateTime(item["Fecha"]);
                }

                return venta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
    }
}
