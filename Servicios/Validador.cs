using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Servicios
{
    public class Validador
    {
        public enum TipoValidacion
        {
            Email,
            Password
        }

        public static bool Validar(string input, TipoValidacion tipo)
        {
            try
            {
                string patron = "";

                switch (tipo)
                {
                    case TipoValidacion.Email:
                        patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                        break;
                    case TipoValidacion.Password:
                        patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
                        break;
                    default:
                        throw new ArgumentException("Tipo de validación no válido", nameof(tipo));
                }

                return Regex.IsMatch(input, patron);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
