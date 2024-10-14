using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPermisoSimple : BEPermiso
    {
        public override List<BEPermiso> Hijos => new List<BEPermiso>();

        public override void AgregarHijo(BEPermiso hijo)
        {
            throw new NotImplementedException();
        }

        public override void EliminarHijos()
        {
            throw new NotImplementedException();
        }
    }
}
