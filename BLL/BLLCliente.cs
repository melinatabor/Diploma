using BE;
using MPP;
using System.Collections.Generic;
using System;

namespace BLL
{
    public class BLLCliente
    {
       public static bool Agregar(BECliente cliente)
        {
            try
            {
                return MPPCliente.Agregar(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Editar(BECliente cliente)
        {
            try
            {
                return MPPCliente.Editar(cliente);
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
                return MPPCliente.Baja(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BECliente> Listar()
        {
            try
            {
                return MPPCliente.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
