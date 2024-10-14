
using System;
using System.Collections.Generic;

namespace BE
{
    public abstract class BEPermiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool EsPadre { get; set; }
        public abstract List<BEPermiso> Hijos { get; }
        public abstract void AgregarHijo(BEPermiso hijo);
        public abstract void EliminarHijos();
    }
}
