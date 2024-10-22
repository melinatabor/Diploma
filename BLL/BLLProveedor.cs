using BE;
using MPP;
using System.Collections.Generic;
using System;

namespace BLL
{
    public class BLLProveedor
    {
        public static bool Agregar(BEProveedor proveedor)
        {
            try
            {
                return MPPProveedor.Agregar(proveedor);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool Editar(BEProveedor proveedor)
        {
            try
            {
                return MPPProveedor.Editar(proveedor);
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<BEProveedor> Listar()
        {
            try
            {
                return MPPProveedor.Listar();
            }
            catch (Exception ex) { throw ex; }
        }


        public static bool Eliminar(int id)
        {
            try
            {
                return MPPProveedor.Baja(id);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
