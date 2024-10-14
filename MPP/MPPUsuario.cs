using BE;
using DAL;
using MPP.StoredProcedures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MPP
{
    public class MPPUsuario
    {
        public static bool Agregar(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Nombre",   usuario.Nombre);
                parametros.Add("@Apellido", usuario.Apellido);
                parametros.Add("@Email",    usuario.Email);
                parametros.Add("@Username", usuario.Username);
                parametros.Add("@Password", usuario.Password);
                parametros.Add("@Activo",   usuario.Activo);
                parametros.Add("@DVH",      usuario.DigitoVerificadorH);

                bool guardado = Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_AgregarUsuario, parametros, true);


                if (guardado)
                {
                    // Obtener ultimo guardado
                    BEUsuario u = BuscarUsuarioPorUsername(usuario.Username);

                    // Guardar en historico
                    Hashtable parametrosHistorico = new Hashtable();

                    parametrosHistorico.Add("@UsuarioId", u.Id);
                    parametrosHistorico.Add("@Nombre", usuario.Nombre);
                    parametrosHistorico.Add("@Apellido", usuario.Apellido);
                    parametrosHistorico.Add("@Email", usuario.Email);
                    parametrosHistorico.Add("@Username", usuario.Username);
                    parametrosHistorico.Add("@Activo", usuario.Activo);

                    guardado = Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_AgregarUsuarioHistorico, parametrosHistorico, true);
                }

                return guardado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Editar(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();
             
                parametros.Add("@Nombre",   usuario.Nombre);
                parametros.Add("@Apellido", usuario.Apellido);
                parametros.Add("@Email",    usuario.Email);
                parametros.Add("@Username", usuario.Username);
                parametros.Add("@Id",       usuario.Id);
                parametros.Add("@DVH",      usuario.DigitoVerificadorH);

                bool guardado = Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_EditarUsuario, parametros, true);

                if (guardado)
                {
                    // Guardar en historico
                    Hashtable parametrosHistorico = new Hashtable();

                    parametrosHistorico.Add("@UsuarioId", usuario.Id);
                    parametrosHistorico.Add("@Nombre", usuario.Nombre);
                    parametrosHistorico.Add("@Apellido", usuario.Apellido);
                    parametrosHistorico.Add("@Email", usuario.Email);
                    parametrosHistorico.Add("@Username", usuario.Username);
                    parametrosHistorico.Add("@Activo", true);

                    guardado = Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_AgregarUsuarioHistorico, parametrosHistorico, true);
                }

                return guardado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Baja(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Activo", false);
                parametros.Add("@Id", usuario.Id);
                
                bool eliminado = Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_EliminarUsuario, parametros, true);

                if (eliminado)
                {
                    // Guardar en historico
                    Hashtable parametrosHistorico = new Hashtable();

                    parametrosHistorico.Add("@UsuarioId", usuario.Id);
                    parametrosHistorico.Add("@Nombre", usuario.Nombre);
                    parametrosHistorico.Add("@Apellido", usuario.Apellido);
                    parametrosHistorico.Add("@Email", usuario.Email);
                    parametrosHistorico.Add("@Username", usuario.Username);
                    parametrosHistorico.Add("@Activo", false);

                    eliminado = Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_AgregarUsuarioHistorico, parametrosHistorico, true);
                }

                return eliminado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BEUsuario BuscarUsuario(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Password", usuario.Password);
                parametros.Add("@Username", usuario.Username);

                DataTable table = Acceso.ExecuteDataTable(UsuarioStoredProcedures.SP_BuscarUsuarioXPswUsername, parametros, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEUsuario u = new BEUsuario();
                        u.DigitoVerificadorH = fila["DigitoVerificadorH"].ToString();
                        return Llenar(fila, u);
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEUsuario> Listar()
        {
            try
            {
                List<BEUsuario> lista = new List<BEUsuario>();

                DataTable table = Acceso.ExecuteDataTable(UsuarioStoredProcedures.SP_ListarUsuarios, null, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEUsuario usuario = new BEUsuario();
                        Llenar(fila, usuario);
                        lista.Add(usuario);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static BEUsuario Obtener(int idUsuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", idUsuario);

                DataTable tabla = Acceso.ExecuteDataTable(UsuarioStoredProcedures.SP_BuscarUsuarioXId, parametros, true);

                if (tabla.Rows.Count > 0)
                {
                    BEUsuario usuario = new BEUsuario(idUsuario);
                    Llenar(tabla.Rows[0], usuario);
                    return usuario;
                }
                return null;
            }
            catch (Exception ex) 
            { 
                throw ex; 
            }
        }

        private static BEUsuario Llenar(DataRow row, BEUsuario usuario)
        {
            try
            {
                usuario.Id = Convert.ToInt32(row["Id"].ToString());
                usuario.Nombre = row["Nombre"].ToString();
                usuario.Apellido = row["Apellido"].ToString();
                usuario.Email = row["Email"].ToString();
                usuario.Username = row["Username"].ToString();
                usuario.Password = row["Password"].ToString();
                usuario.Activo = Convert.ToBoolean(row["Activo"]);
                return usuario;
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEUsuario BuscarUsuarioPorUsername(string username)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Username", username);

                DataTable table = Acceso.ExecuteDataTable(UsuarioStoredProcedures.SP_BuscarUsuarioXUsername, parametros, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEUsuario u = new BEUsuario();
                        return Llenar(fila, u);
                    }
                }

                return null;
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool AsignarPermiso(BEUsuario usuario, BEPermiso permiso)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@IdUsuario", usuario.Id);
                parametros.Add("@IdPermiso", permiso.Id);

                return Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_AsignarPermiso, parametros, true);
            }
            catch (Exception ex) { throw ex; }
        }

        public static void ObtenerPermisosUsuario(BEUsuario usuario)
        {
            try
            {
                List<BEPermiso> lista = new List<BEPermiso>();

                Hashtable parametros = new Hashtable();

                parametros.Add("@IdUsuario", usuario.Id);

                DataTable table = Acceso.ExecuteDataTable(UsuarioStoredProcedures.SP_ObtenerPermisosUsuario, parametros, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        int id = Convert.ToInt32(fila["Id"]);

                        BEPermiso permiso = MPPPermiso.BuscarPermiso(id);

                        List<BEPermiso> hijos = MPPPermiso.ListarHijosRecursivo(permiso);

                        if (hijos.Count > 0)
                        {
                            lista.AddRange(hijos);
                            lista.Add(permiso);
                        }
                        else
                            lista.Add(permiso);
                    }
                }

                foreach (BEPermiso permiso in lista)
                {
                    usuario.ListaPermisos.Add(permiso.Id);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEUsuario> FiltrarHistoricosPorUsuario(int usuarioId)
        {
            try
            {
                List<BEUsuario> lista = new List<BEUsuario>();

                Hashtable parametros = new Hashtable();

                parametros.Add("@UsuarioId", usuarioId);

                DataTable table = Acceso.ExecuteDataTable(UsuarioStoredProcedures.SP_FiltrarHistoricosXUsuario, parametros, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        BEUsuario usuario = new BEUsuario();
                        usuario.Id = Convert.ToInt32(row["Id"].ToString());
                        usuario.Nombre = row["Nombre"].ToString();
                        usuario.Apellido = row["Apellido"].ToString();
                        usuario.Email = row["Email"].ToString();
                        usuario.Username = row["Username"].ToString();
                        usuario.Activo = Convert.ToBoolean(row["Activo"]);
                        lista.Add(usuario);
                    }
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string ObtenerDigitoVerificadorVertical()
        {
            try
            {
                DataTable table = Acceso.ExecuteDataTable(DigitoVerificadorVerticalStoredProcedures.SP_ObtenerDigitoVerificadorVertical, null, true);

                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    return row["DigitoVerificadorVertical"].ToString();
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void ActualizarDigitoVerificadorVertical(string dvvCalculado)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@DigitoVerificadorVertical", dvvCalculado);

                Acceso.ExecuteNonQuery(DigitoVerificadorVerticalStoredProcedures.SP_ActualizarDigitoVerificadorVertical, parametros, true);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool RestaurarVersion(BEUsuario usuarioHistorico, BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Nombre", usuarioHistorico.Nombre);
                parametros.Add("@Apellido", usuarioHistorico.Apellido);
                parametros.Add("@Email", usuarioHistorico.Email);
                parametros.Add("@Username", usuarioHistorico.Username);
                parametros.Add("@Id", usuario.Id);
                parametros.Add("@DVH", usuarioHistorico.DigitoVerificadorH);

                bool guardado = Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_EditarUsuario, parametros, true);

                if (guardado)
                {
                    // Guardar en historico
                    Hashtable parametrosHistorico = new Hashtable();

                    parametrosHistorico.Add("@UsuarioId", usuario.Id);
                    parametrosHistorico.Add("@Nombre", usuarioHistorico.Nombre);
                    parametrosHistorico.Add("@Apellido", usuarioHistorico.Apellido);
                    parametrosHistorico.Add("@Email", usuarioHistorico.Email);
                    parametrosHistorico.Add("@Username", usuarioHistorico.Username);
                    parametrosHistorico.Add("@Activo", usuarioHistorico.Activo);

                    guardado = Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_AgregarUsuarioHistorico, parametrosHistorico, true);
                }

                return guardado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<BEPermiso> ObtenerPermisos(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Usuario", usuario.Id);

                string query = "SELECT p.Id, p.Nombre, p.EsPadre FROM UsuarioPermiso up inner join Permiso p on p.id = up.Permiso WHERE Usuario = @Usuario";

                List<BEPermiso> lista = new List<BEPermiso>();

                DataTable table = Acceso.ExecuteDataTable(query, parametros, false);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        BEPermiso permiso = new BEPermisoSimple()
                        {
                            Id = Convert.ToInt32(row["Id"].ToString()),
                            Nombre = row["Nombre"].ToString(),
                            EsPadre = Convert.ToBoolean(row["EsPadre"].ToString())
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

        public static bool EliminarPermisos(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", usuario.Id);

                string query = "DELETE FROM UsuarioPermiso WHERE Usuario = @Id";

                bool eliminado = Acceso.ExecuteNonQuery(query, parametros, false);

                return eliminado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
