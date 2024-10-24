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
    public class MPPDetalleCompra
    {
        public static bool Agregar(BEDetalleCompra detalle)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@CompraId", detalle.CompraId);
                parametros.Add("@ProductoId", detalle.ProductoId);
                parametros.Add("@Cantidad", detalle.Cantidad);
                parametros.Add("@Subtotal",detalle.Subtotal);

                return Acceso.ExecuteNonQuery(DetalleCompraStoredProcedures.SP_AgregarDetalleCompra, parametros, true);
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

                return Acceso.ExecuteNonQuery(DetalleCompraStoredProcedures.SP_EliminarDetalleCompra, parametros, true);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEDetalleCompra> ListarXCompra(int id)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@CompraId", id);

                DataTable table = Acceso.ExecuteDataTable(DetalleCompraStoredProcedures.SP_ListarXCompra, parametros, true);

                List<BEDetalleCompra> lista = new List<BEDetalleCompra>();

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEDetalleCompra detalle = new BEDetalleCompra();
                        Llenar(fila, detalle);
                        lista.Add(detalle);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private static BEDetalleCompra Llenar(DataRow row, BEDetalleCompra detalle)
        {
            try
            {
                detalle.Id = Convert.ToInt32(row["Id"].ToString());
                detalle.CompraId = Convert.ToInt32(row["CompraId"].ToString());
                detalle.ProductoId = Convert.ToInt32(row["ProductoId"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["Cantidad"].ToString());
                detalle.Subtotal = Convert.ToSingle(row["Subtotal"].ToString());
       
                return detalle;
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEDetalleCompra BuscarDetalleCompraXId(int id)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", id);

                DataTable tabla = Acceso.ExecuteDataTable(DetalleCompraStoredProcedures.SP_BuscarDetalleXId, parametros, true);

                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BEDetalleCompra detalle = new BEDetalleCompra();
                        return Llenar(fila, detalle);
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
