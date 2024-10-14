using Abstraccion;
using BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios.DigitoVerificador
{
    public class DigitoVerificador
    {
        private static string _digitoVerificador;
        private static StringBuilder _digitoVerificadorVertical;
        public static string Run(BEUsuario usuario)
        {
			try
			{
                _digitoVerificador = usuario.Nombre + usuario.Apellido + usuario.Email + usuario.Username;
                
                return Encriptador.Encriptador.Run(_digitoVerificador);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ha ocurrido un error al generar el digito verificador: {ex.Message}");
            }
        }

        public static string RunVertical(List<BEUsuario> usuarios)
        {
            try
            {
                _digitoVerificadorVertical = new StringBuilder();

                foreach (var usuario in usuarios)
                    _digitoVerificadorVertical.Append(Run(usuario));

                return Encriptador.Encriptador.Run(_digitoVerificadorVertical.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"Ha ocurrido un error al generar el digito verificador vertical: {ex.Message}");
            }
        }
    }
}
