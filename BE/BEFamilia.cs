using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEFamilia : BEPermiso
    {
        public List<BEPermiso> hijos;
        public override List<BEPermiso> Hijos { get { return hijos; } }

        public BEFamilia() 
        {
            EsPadre = true;
            hijos = new List<BEPermiso>();
        }

        public override void AgregarHijo(BEPermiso hijo)
        {
            hijos.Add(hijo);
        }

        public override void EliminarHijos()
        {
            hijos = new List<BEPermiso>();
        }
    }
}
