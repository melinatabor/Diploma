using BE;
using DAL;
using MPP.StoredProcedures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPPIdioma
    {
        public static bool Agregar(BEIdioma idioma)
        {
            try
            {
                Hashtable parametros = new Hashtable
                {
                    { "@Idioma", idioma.Idioma }
                };
                
                return Acceso.ExecuteNonQuery(IdiomaStoredProcedures.SP_AgregarIdioma, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEIdioma> Listar()
        {
            try
            {
                List<BEIdioma> lista = new List<BEIdioma>();

                DataTable table = Acceso.ExecuteDataTable(IdiomaStoredProcedures.SP_ListarIdiomas, null, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEIdioma idioma = new BEIdioma()
                        {
                            Id      = Convert.ToInt32(fila["Id"].ToString()),
                            Idioma  = fila["Idioma"].ToString()
                        };
                        lista.Add(idioma);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<BEPalabra> ObtenerTags(int idioma)
        {
            try
            {
                List<BEPalabra> lista = new List<BEPalabra>();

                Hashtable parametros = new Hashtable();

                parametros.Add("@IdiomaId", idioma);
                
                DataTable table = Acceso.ExecuteDataTable(IdiomaStoredProcedures.SP_ObtenerTags, parametros, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEPalabra palabra = new BEPalabra()
                        {
                            Id          = Convert.ToInt32(fila["TagId"].ToString()),
                            Tag         = fila["Tag"].ToString(),
                            Traduccion  = fila["Traduccion"].ToString(),
                        };
                        lista.Add(palabra);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
