using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP.StoredProcedures
{
    internal static class PermisoStoredProcedures
    {
        public const string SP_AgregarPermiso = "SP_Agregar_Permiso";
        public const string SP_AgregarPermisoFamilia = "SP_Agregar_Permiso_Familia";
        public const string SP_BuscarFamilia = "SP_Buscar_Familia";
        public const string SP_BuscarPermiso = "SP_Buscar_Permiso";
        public const string SP_ListarFamilias = "SP_Listar_Familias"; 
        public const string SP_ListarHijosRecursivo = "SP_Listar_Hijos_Recursivo";
        public const string SP_ListarPermisos = "SP_Listar_Permisos";
    }
}
