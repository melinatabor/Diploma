using BE;
using MPP;
using System.Collections.Generic;
using Servicios.Encriptador;
using System;
using Servicios.SesionManager;
using static BE.BEBitacora;
using Servicios.DigitoVerificador;
using Abstraccion;

namespace BLL
{
    public class BLLUsuario
    {
        public static bool Agregar(BEUsuario usuario)
        {
            try
            {
                usuario.Activo = true;
                usuario.Password = Encriptador.Run(usuario.Password);
                usuario.DigitoVerificadorH = DigitoVerificador.Run(usuario);
                return MPPUsuario.Agregar(usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool Editar(BEUsuario usuario)
        {
            try
            {
                usuario.DigitoVerificadorH = DigitoVerificador.Run(usuario);
                return MPPUsuario.Editar(usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<BEUsuario> Listar()
        {
            try
            {
                return MPPUsuario.Listar();
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEUsuario ObtenerUsuario(int idUsuario)
        {
            try
            {
                return MPPUsuario.Obtener(idUsuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool Eliminar(BEUsuario usuario)
        {
            try
            {
                return MPPUsuario.Baja(usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEUsuario BuscarUsuario(BEUsuario usuario)
        {
            try
            {
                usuario.Password = Encriptador.Run(usuario.Password);
                return MPPUsuario.BuscarUsuario(usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEUsuario BuscarUsuarioPorUsername(string username)
        {
            try
            {
                return MPPUsuario.BuscarUsuarioPorUsername(username);
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<BEUsuario> FiltrarHistoricosPorUsuario(int usuarioId)
        {
            try
            {
                return MPPUsuario.FiltrarHistoricosPorUsuario(usuarioId);
            }
            catch (Exception ex) { throw ex; }
        }

        public static void Login(BEUsuario usuario)
        {
            try
            {
                BEUsuario usuarioExistente = BLLUsuario.BuscarUsuario(usuario) 
                    ?? throw new Exception("Credenciales incorrectas. Por favor vuelva a ingresar los datos correctamente.");

                if (HuboModificacionesExternas(usuarioExistente)) 
                    throw new Exception("El usuario ha sido modificado. Por favor contacte al administrador.");

                if (InformacionCorrupta())
                    throw new Exception("La base de datos ha sido modificada. Por favor contacte al administrador.");

                ObtenerPermisosUsuario(usuarioExistente);

                SesionManager.Login(usuarioExistente);

                BEBitacora bitacora = new BEBitacora()
                {
                    Usuario = usuarioExistente.Id,
                    Tipo    = BitacoraTipo.INFO,
                    Mensaje = "El usuario inició sesión"
                };

                BLLBitacora.Agregar(bitacora);
            }
            catch (Exception ex) { throw ex; }
        }

        private static bool InformacionCorrupta()
        {
            // Generar Digito Verificador Vertical con los datos de la tabla de usuarios.
            // El valor dvvCalculado deberia coincidir con el de la tabla DigitoVerificadorVertical
            string dvvCalculado = DigitoVerificador.RunVertical(BLLUsuario.Listar());
            return dvvCalculado != MPPUsuario.ObtenerDigitoVerificadorVertical();
        }

        private static bool HuboModificacionesExternas(BEUsuario usuarioExistente)
        {
            return usuarioExistente.DigitoVerificadorH != DigitoVerificador.Run(usuarioExistente);
        }

        private static void ObtenerPermisosUsuario(BEUsuario usuario)
        {
            try
            {
                MPPUsuario.ObtenerPermisosUsuario(usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool AsignarPermiso(BEUsuario usuario, BEPermiso permiso)
        {
            try
            {
                return MPPUsuario.AsignarPermiso(usuario, permiso);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool VerificarPermiso(int permiso)
        {
            try
            {
                List<int> permisosUsuario = SesionManager.GetUsuario().ListaPermisos;
                return permisosUsuario.Contains(permiso);
            }
            catch (Exception ex) { throw ex; }
        }

        public static void RecalcularDigitoVerificadorVertical()
        {
            try
            {
                string dvvCalculado = DigitoVerificador.RunVertical(BLLUsuario.Listar());
                MPPUsuario.ActualizarDigitoVerificadorVertical(dvvCalculado);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool RestaurarVersion(BEUsuario usuarioHistorico, BEUsuario usuario)
        {
            try
            {
                usuarioHistorico.DigitoVerificadorH = DigitoVerificador.Run(usuarioHistorico);
                return MPPUsuario.RestaurarVersion(usuarioHistorico, usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<BEPermiso> ObtenerPermisos(BEUsuario usuario)
        {
            try
            {
                return MPPUsuario.ObtenerPermisos(usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool EliminarPermisos(BEUsuario usuario)
        {
            try
            {
                return MPPUsuario.EliminarPermisos(usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool RealizarBackup(string backupPath)
        {
            try
            {
                return MPPUsuario.RealizarBackup(backupPath);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool RestaurarBackup(string rutaBackup)
        {
            try
            {
                return MPPUsuario.RestaurarBackup(rutaBackup);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
