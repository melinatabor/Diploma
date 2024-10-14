using BE;
using DAL;
using MPP.StoredProcedures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPTraduccion
    {
        private static bool Agregar(BEIdioma idioma, BETraduccion traduccion, string trad)
        {
            try
            {
                Hashtable parametros = new Hashtable
                {
                    { "@Idioma", idioma.Id },
                    { "@Tag", traduccion.Id },
                    { "@Traduccion", trad }
                };

                return Acceso.ExecuteNonQuery(IdiomaStoredProcedures.SP_AgregarTraduccion, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BETraduccion> Listar(int idIdioma)
        {
            try
            {
                Hashtable parametro = new Hashtable
                {
                    { "@IdIdioma", idIdioma }
                };

                List<BETraduccion> traducciones = new List<BETraduccion>();

                DataTable table = Acceso.ExecuteDataTable(IdiomaStoredProcedures.SP_ListarTraducciones, parametro, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BETraduccion traduccion = new BETraduccion()
                        {
                            Id = Convert.ToInt32(fila["Id"].ToString()),
                            Tag = fila["Tag"].ToString(),
                            Neutro = fila["Neutro"].ToString(),
                            Traduccion = fila["Traduccion"].ToString()
                        };
                        traducciones.Add(traduccion);
                    }
                }

                return traducciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Modificar(BEIdioma idioma, BETraduccion traduccion, string trad)
        {
            try
            {
                Hashtable parametros = new Hashtable
                {
                    { "@Idioma", idioma.Id },
                    { "@Tag", traduccion.Id },
                    { "@NuevaTraduccion", trad }
                };

                //Buscar si existe la traduccion, al ser unico el tag e idioma no deberia haber mas de una
                string query = "SELECT Idioma, Tag FROM Traduccion WHERE Idioma = @Idioma AND Tag = @Tag";

                bool existe = Convert.ToBoolean(Acceso.ExecuteScalar(query, parametros, false));
                
                // Si existe, se modifica
                if (existe)
                    return Acceso.ExecuteNonQuery(IdiomaStoredProcedures.SP_ModificarTraduccion, parametros, true);

                // De lo contrario, se agrega
                return Agregar(idioma, traduccion, trad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
