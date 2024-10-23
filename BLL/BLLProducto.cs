using BE;
using MPP;
using System.Collections.Generic;
using System;

namespace BLL
{
    public class BLLProducto
    {
        public static bool Agregar(BEProducto producto)
        {
            try
            {
                return MPPProducto.Agregar(producto);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool Editar(BEProducto producto)
        {
            try
            {
                return MPPProducto.Editar(producto);
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<BEProducto> Listar()
        {
            try
            {
                return MPPProducto.Listar();
            }
            catch (Exception ex) { throw ex; }
        }


        public static bool Eliminar(int id)
        {
            try
            {
                return MPPProducto.Baja(id);
            }
            catch (Exception ex) { throw ex; }
        }

    }
}
