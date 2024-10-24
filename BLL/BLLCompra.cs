using BE;
using MPP;
using System.Collections.Generic;
using System;

namespace BLL
{
    public class BLLCompra
    {
        public static bool Agregar(BECompra compra)
        {
            try
            {
                return MPPCompra.Agregar(compra);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool Editar(BECompra compra)
        {
            try
            {
                return MPPCompra.Editar(compra);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool Eliminar(int id)
        {
            try
            {
                return MPPCompra.Baja(id);
            }
            catch (Exception ex) { throw ex; }
        }

        //public static List<BECompra> Listar()
        //{
        //    try
        //    {
        //        return MPPCompra.Listar();
        //    }
        //    catch (Exception ex) { throw ex; }
        //}

        public static BECompra BuscarCompraXId(int id)
        {
            try
            {
                return MPPCompra.BuscarCompraXId(id);
            }
            catch (Exception ex) { throw ex; }
        }

        public static BECompra ObtenerUltimaCompra()
        {
            try
            {
                return MPPCompra.ObtenerUltimaCompra();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
