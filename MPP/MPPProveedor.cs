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
    public class MPPProveedor
    {
        public static bool Agregar(BEProveedor proveedor)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Marca", proveedor.Marca);
                parametros.Add("@Nombre", proveedor.Nombre);
                parametros.Add("@Apellido", proveedor.Apellido);
                parametros.Add("@Telefono", proveedor.Telefono);
                parametros.Add("@Domicilio", proveedor.Domicilio);
                parametros.Add("@Localidad", proveedor.Localidad);

                return Acceso.ExecuteNonQuery(ProveedorStoredProcedures.SP_AgregarProveedor, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Editar(BEProveedor proveedor)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", proveedor.Id);
                parametros.Add("@Marca", proveedor.Marca);
                parametros.Add("@Nombre", proveedor.Nombre);
                parametros.Add("@Apellido", proveedor.Apellido);
                parametros.Add("@Telefono", proveedor.Telefono);
                parametros.Add("@Domicilio", proveedor.Domicilio);
                parametros.Add("@Localidad", proveedor.Localidad);

                return Acceso.ExecuteNonQuery(ProveedorStoredProcedures.SP_EditarProveedor, parametros, true);
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

                return Acceso.ExecuteNonQuery(ProveedorStoredProcedures.SP_EliminarProveedor, parametros, true);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEProveedor> Listar()
        {
            try
            {
                List<BEProveedor> lista = new List<BEProveedor>();

                DataTable table = Acceso.ExecuteDataTable(ProveedorStoredProcedures.SP_ListarProveedores, null, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEProveedor proveedor = new BEProveedor();
                        Llenar(fila, proveedor);
                        lista.Add(proveedor);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private static BEProveedor Llenar(DataRow row, BEProveedor proveedor)
        {
            try
            {
                proveedor.Id = Convert.ToInt32(row["Id"].ToString());
                proveedor.Marca = row["Marca"].ToString();
                proveedor.Nombre = row["Nombre"].ToString();
                proveedor.Apellido = row["Apellido"].ToString();
                proveedor.Telefono = row["Telefono"].ToString();
                proveedor.Domicilio = row["Domicilio"].ToString();
                proveedor.Localidad = row["Localidad"].ToString();
                return proveedor;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
