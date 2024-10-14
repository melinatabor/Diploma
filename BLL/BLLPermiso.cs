using BE;
using MPP;
using Servicios.Encriptador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPermiso
    {
        public static bool AgregarFamilia(BEPermiso permiso)
        {
            try
            {
                permiso.EsPadre = true;
                return MPPPermiso.AgregarPermiso(permiso);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool AgregarPermisoAFamilia(BEPermiso permiso, BEPermiso familia)
        {
            try
            {
                return MPPPermiso.AgregarPermisoAFamilia(permiso, familia);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool AgregarPermisoSimple(BEPermiso permiso)
        {
            try
            {
                permiso.EsPadre = false;
                return MPPPermiso.AgregarPermiso(permiso);
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEPermiso BuscarFamilia(int idFamilia)
        {
            try
            {
                return MPPPermiso.BuscarFamilia(idFamilia);
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEPermiso BuscarPermiso(int id)
        {
            try
            {
                return MPPPermiso.BuscarPermiso(id);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool EliminarFamilia(BEPermiso familia)
        {
            try
            {
                return MPPPermiso.EliminarFamilia(familia);
            }
            catch (Exception ex) { throw ex; }
        }

        public static object ListarFamilias()
        {
            try
            {
                return MPPPermiso.ListarFamilias();
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<BEPermiso> ListarHijosRecursivo(BEPermiso familia)
        {
            try
            {
                return MPPPermiso.ListarHijosRecursivo(familia);
            }
            catch (Exception ex) { throw ex; }
        }

        public static object ListarPermisos()
        {
            try
            {
                return MPPPermiso.ListarPermisos();
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<BEPermiso> ObtenerPadres(BEPermiso familia)
        {
            List<BEPermiso> padres = new List<BEPermiso>();

            ObtenerPadresRecursivo(familia, padres);

            return padres;
        }

        private static void ObtenerPadresRecursivo(BEPermiso permiso, List<BEPermiso> listaPadres)
        {
            var padres = MPPPermiso.ObtenerPadres(permiso.Id);

            foreach (var padre in padres)
            {
                listaPadres.Add(padre);
                ObtenerPadresRecursivo(padre, listaPadres);
            }
        }
    }
}
