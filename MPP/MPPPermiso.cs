using BE;
using DAL;
using MPP.StoredProcedures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPPermiso
    {
        public static bool AgregarPermiso(BEPermiso permiso)
        {
			try
			{
                Hashtable parametros = new Hashtable();

                parametros.Add("@Nombre", permiso.Nombre);
                parametros.Add("@EsPadre", permiso.EsPadre);

                return Acceso.ExecuteNonQuery(PermisoStoredProcedures.SP_AgregarPermiso, parametros, true);
            }
            catch (Exception ex)
			{
				throw ex;
			}
        }

        public static bool AgregarPermisoAFamilia(BEPermiso permisoHijo, BEPermiso permisoPadre)
        {
            try
            {
                if (permisoHijo.Id == permisoPadre.Id)
                    throw new Exception("No se puede agregar un permiso a si mismo.");

                Hashtable parametros = new Hashtable();

                parametros.Add("@PermisoHijo", permisoHijo.Id);
                parametros.Add("@PermisoPadre", permisoPadre.Id);

                return Acceso.ExecuteNonQuery(PermisoStoredProcedures.SP_AgregarPermisoFamilia, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BEPermiso BuscarFamilia(int idFamilia)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", idFamilia);

                DataTable table = Acceso.ExecuteDataTable(PermisoStoredProcedures.SP_BuscarFamilia, parametros, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEPermiso permiso = new BEFamilia()
                        {
                            Id = Convert.ToInt32(fila["Id"].ToString()),
                            Nombre = fila["Nombre"].ToString()
                        };

                        return permiso;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BEPermiso BuscarPermiso(int id)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", id);

                DataTable table = Acceso.ExecuteDataTable(PermisoStoredProcedures.SP_BuscarPermiso, parametros, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEPermiso permiso = new BEPermisoSimple()
                        {
                            Id = Convert.ToInt32(fila["Id"].ToString()),
                            Nombre = fila["Nombre"].ToString(),
                            EsPadre = Convert.ToBoolean(fila["EsPadre"].ToString())
                        };

                        return permiso;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool EliminarFamilia(BEPermiso familia)
        {
            try
            {
                bool eliminado = false;

                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", familia.Id);

                string query = "DELETE FROM PermisoPermiso WHERE PermisoHijo = @Id";

                eliminado = Acceso.ExecuteNonQuery(query, parametros, false);

                if (eliminado)
                {
                    query = "DELETE FROM PermisoPermiso WHERE PermisoPadre = @Id";

                    eliminado = Acceso.ExecuteNonQuery(query, parametros, false);

                    if (eliminado) 
                    {
                        query = "DELETE FROM Permiso WHERE Id = @Id";
                        eliminado = Acceso.ExecuteNonQuery(query, parametros, false);
                    }
                }

                return eliminado;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public static List<BEPermiso> ListarFamilias()
        {
            try
            {
                List<BEPermiso> lista = new List<BEPermiso>();

                DataTable table = Acceso.ExecuteDataTable(PermisoStoredProcedures.SP_ListarFamilias, null, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEPermiso permiso = new BEFamilia()
                        {
                            Id = Convert.ToInt32(fila["Id"].ToString()),
                            Nombre = fila["Nombre"].ToString()
                        };
                        lista.Add(permiso);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEPermiso> ListarHijosRecursivo(BEPermiso familia)
        {
            try
            {
                List<BEPermiso> lista = new List<BEPermiso>();

                Hashtable parametros = new Hashtable();

                int? condition = null;

                if (familia is BEPermiso)
                    condition = familia.Id;

                parametros.Add("@FamiliaId", condition);

                DataTable table = Acceso.ExecuteDataTable(PermisoStoredProcedures.SP_ListarHijosRecursivo, parametros, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        int idPadre = 0;

                        if (fila["PermisoPadre"] != DBNull.Value)
                            idPadre = Convert.ToInt32(fila["PermisoPadre"]);

                        int id          = Convert.ToInt32(fila["Id"]);
                        string nombre   = fila["Nombre"].ToString();
                        bool esPadre    = Convert.ToBoolean(fila["EsPadre"]);

                        BEPermiso permiso;

                        if (!esPadre)
                            permiso = new BEPermisoSimple() { EsPadre = false };
                        else
                            permiso = new BEFamilia();

                        permiso.Id      = id;
                        permiso.Nombre  = nombre;

                        BEPermiso padre = ObtenerPadre(idPadre, lista);

                        if (padre == null)
                            lista.Add(permiso);
                        else
                            padre.AgregarHijo(permiso);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEPermiso> ListarPermisos()
        {
            try
            {
                List<BEPermiso> lista = new List<BEPermiso>();

                DataTable table = Acceso.ExecuteDataTable(PermisoStoredProcedures.SP_ListarPermisos, null, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEPermiso permiso = new BEPermisoSimple()
                        {
                            Id = Convert.ToInt32(fila["Id"].ToString()),
                            Nombre = fila["Nombre"].ToString(),
                            EsPadre = Convert.ToBoolean(fila["EsPadre"].ToString())
                        };
                        lista.Add(permiso);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEPermiso> ObtenerPadres(int id)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                List<BEPermiso> lista = new List<BEPermiso>();

                parametros.Add("@Id", id);

                string query = "select pp.PermisoPadre, p.Nombre from permisoPermiso pp inner join permiso p on p.id = pp.PermisoPadre where pp.PermisoHijo = @Id";
                DataTable table = Acceso.ExecuteDataTable(query, parametros, false);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEPermiso permiso = new BEPermisoSimple()
                        {
                            Id = Convert.ToInt32(fila["PermisoPadre"].ToString()),
                            Nombre = fila["Nombre"].ToString(),
                            EsPadre = true
                        };

                        lista.Add( permiso);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static BEPermiso ObtenerPadre(int id, List<BEPermiso> lista)
        {
            /*
             * Buscar el permiso en la lista, y se obtiene el primer elemento que coincida
             */
            BEPermiso padre = lista.Count() != 0 ? lista.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;

            if (padre == null && lista != null)
            {
                // Buscar en los hijos
                foreach (BEPermiso permiso in lista)
                {
                    BEPermiso p = ObtenerPadre(id, permiso.Hijos);

                    // Retornar padre o seguir buscando
                    if (p != null && p.Id == id) 
                        return p;
                    else if (p != null)
                        return ObtenerPadre(id, p.Hijos);
                }
            }

            return padre;
        }
    }
}
