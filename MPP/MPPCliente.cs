using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPCliente
    {
        public static bool Agregar(BECliente cliente)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Nombre", cliente.Nombre);
                parametros.Add("@Telefono", cliente.Telefono);
                parametros.Add("@Domicilio", cliente.Domicilio);
                parametros.Add("@Localidad", cliente.Localidad);

                return Acceso.ExecuteNonQuery(ClienteStoredProcedures.SP_AgregarCliente, parametros, true);
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
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", cliente.Id);
                parametros.Add("@Nombre", cliente.Nombre);
                parametros.Add("@Telefono", cliente.Telefono);
                parametros.Add("@Domicilio", cliente.Domicilio);
                parametros.Add("@Localidad", cliente.Localidad);

                return Acceso.ExecuteNonQuery(ClienteStoredProcedures.SP_EditarCliente, parametros, true);
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
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", id);

                return Acceso.ExecuteNonQuery(ClienteStoredProcedures.SP_EliminarCliente, parametros, true);

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
                List<BECliente> lista = new List<BECliente>();

                DataTable table = Acceso.ExecuteDataTable(ClienteStoredProcedures.SP_ListarClientes, null, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BECliente cliente = new BECliente();
                        cliente.Domicilio = fila["Domicilio"].ToString();
                        cliente.Id = Convert.ToInt32(fila["Id"].ToString());
                        cliente.Localidad = fila["Localidad"].ToString();
                        cliente.Nombre = fila["Nombre"].ToString();
                        cliente.Telefono = Convert.ToInt32(fila["Telefono"].ToString());
                        lista.Add(cliente);
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
