using Abstraccion;
using System;

namespace Servicios
{
    public class SessionManager
    {
        private static SessionManager _session = null;
        private IUsuario _usuario { get; set; }
        private SessionManager() { }

        public static void Login(IUsuario usuario)
        {
            try
            {
                if (_session == null)
                {
                    _session = new SessionManager();
                    _session._usuario = usuario;
                }
                else
                    throw new Exception("Sesion no iniciada");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Logout()
        {
            try
            {
                if (_session != null) _session = null;
                else throw new Exception("La sesion no esta iniciada");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetUsername()
        {
            try
            {
                return _session._usuario.Username;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SessionManager GetSession()
        {
            SessionManager sessionManager = _session ?? null;
            return sessionManager;
        }

        public static IUsuario GetUsuario()
        {
            try
            {
                return _session._usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
