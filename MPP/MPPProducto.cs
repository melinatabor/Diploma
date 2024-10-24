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
    public class MPPProducto
    {
        public static float CalcularGanancia(float costo, float precio)
        {
            return precio - costo;
        }

        public static bool Agregar(BEProducto producto)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Codigo", producto.Codigo);
                parametros.Add("@Nombre", producto.Nombre);
                parametros.Add("@Proveedor", producto.Proveedor);
                parametros.Add("@Descripcion", producto.Descripcion);
                parametros.Add("@Gramos", producto.Gramos);
                parametros.Add("@Bandeja", producto.Bandeja);
                parametros.Add("@CostoUnitario", producto.CostoUnitario);
                parametros.Add("@PrecioVenta", producto.PrecioVenta);
                parametros.Add("@Ganancia", CalcularGanancia(producto.CostoUnitario, producto.PrecioVenta));
                parametros.Add("@Cantidad", producto.Cantidad);

                return Acceso.ExecuteNonQuery(ProductoStoredProcedures.SP_AgregarProducto, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Editar(BEProducto producto)
        {
            try
            {
                Hashtable parametros = new Hashtable();
                parametros.Add("@Id", producto.Id);
                parametros.Add("@Codigo", producto.Codigo);
                parametros.Add("@Nombre", producto.Nombre);
                parametros.Add("@Proveedor", producto.Proveedor);
                parametros.Add("@Descripcion", producto.Descripcion);
                parametros.Add("@Gramos", producto.Gramos);
                parametros.Add("@Bandeja", producto.Bandeja);
                parametros.Add("@CostoUnitario", producto.CostoUnitario);
                parametros.Add("@PrecioVenta", producto.PrecioVenta);
                parametros.Add("@Cantidad", producto.Cantidad);
                parametros.Add("@Ganancia", CalcularGanancia(producto.CostoUnitario, producto.PrecioVenta));

                return Acceso.ExecuteNonQuery(ProductoStoredProcedures.SP_EditarProducto, parametros, true);
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

                return Acceso.ExecuteNonQuery(ProductoStoredProcedures.SP_EliminarProducto, parametros, true);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEProducto> Listar()
        {
            try
            {
                List<BEProducto> lista = new List<BEProducto>();

                DataTable table = Acceso.ExecuteDataTable(ProductoStoredProcedures.SP_ListarProductos, null, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEProducto producto = new BEProducto();
                        Llenar(fila, producto);
                        lista.Add(producto);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private static BEProducto Llenar(DataRow row, BEProducto producto)
        {
            try
            {
                producto.Id = Convert.ToInt32(row["Id"].ToString());
                producto.Codigo = row["Codigo"].ToString();
                producto.Nombre = row["Nombre"].ToString();
                producto.Proveedor = Convert.ToInt32(row["Proveedor"].ToString());
                producto.Descripcion = row["Descripcion"].ToString();
                producto.Gramos = Convert.ToInt32(row["Gramos"].ToString());
                producto.Bandeja = string.IsNullOrEmpty(row["Bandeja"].ToString()) ? 1 : Convert.ToInt32(row["Bandeja"]);
                producto.CostoUnitario = Convert.ToSingle(row["CostoUnitario"].ToString());
                producto.PrecioVenta = Convert.ToSingle(row["PrecioVenta"].ToString());
                producto.Ganancia = Convert.ToSingle(row["Ganancia"].ToString());
                producto.Cantidad = string.IsNullOrEmpty(row["Cantidad"].ToString()) ? 0 : Convert.ToInt32(row["Cantidad"]);
                return producto;
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEProducto BuscarProductoXId(int id)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", id);

                DataTable tabla = Acceso.ExecuteDataTable(ProductoStoredProcedures.SP_BuscarProductoXId, parametros, true);

                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BEProducto producto = new BEProducto();
                        return Llenar(fila, producto);
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static float CalcularSubtotal(int cantidad, int productoId)
        {
            BEProducto producto = BuscarProductoXId(productoId);
            return cantidad * producto.CostoUnitario;
        }

        public static bool RestarStock(int cantidad, int productoId)
        {
            try
            {
                BEProducto producto = BuscarProductoXId(productoId);
                producto.Cantidad -= cantidad;

                return Editar(producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool SumarStock(int cantidad, int productoId)
        {
            try
            {
                BEProducto producto = BuscarProductoXId(productoId);
                producto.Cantidad += cantidad;

                return Editar(producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
