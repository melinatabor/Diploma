using BE;
using MPP;
using System.Collections.Generic;
using System;

namespace BLL
{
    public class BLLDetalleCompra
    {
        public static bool Agregar(BEDetalleCompra detalleCompra)
        {
            try
            {
                return MPPDetalleCompra.Agregar(detalleCompra);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool Eliminar(int id)
        {
            try
            {
                return MPPDetalleCompra.Baja(id);
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<BEDetalleCompra> ListarXCompra(int id)
        {
            try
            {
                return MPPDetalleCompra.ListarXCompra(id);
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEDetalleCompra BuscarDetalleCompraXId(int id)
        {
            try
            {
                return MPPDetalleCompra.BuscarDetalleCompraXId(id);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
