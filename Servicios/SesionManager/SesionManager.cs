using System;
using Abstraccion;

namespace Servicios.SesionManager
{
    public class SesionManager
    {
        private static SesionManager _session = null;

        private IUsuario _usuario { get; set; }

        public Traductor.Traductor traductor { get; set; }

        private SesionManager() { }

        public static void Login(IUsuario usuario)
        {
            try
            {
                if (_session == null)
                {
                    _session = new SesionManager();
                    _session._usuario = usuario;
                    _session.traductor = new Traductor.Traductor();
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

        public static SesionManager GetSession()
        {
            SesionManager s = _session ?? null;
            return s;
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
