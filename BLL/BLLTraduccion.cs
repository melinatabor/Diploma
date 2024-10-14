using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTraduccion
    {
        public static List<BETraduccion> Listar(int idIdioma)
        {
            try
            {
                return MPPTraduccion.Listar(idIdioma);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool Modificar(BEIdioma idioma, BETraduccion traduccion, string trad)
        {
            try
            {
                return MPPTraduccion.Modificar(idioma, traduccion, trad);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
