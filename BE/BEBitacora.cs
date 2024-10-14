using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEBitacora : IBitacora
    {
        public int Id { get; set; }
        public int Usuario { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }
        public BitacoraTipo Tipo { get; set; }

        public enum BitacoraTipo
        {
            INFO    = 1,
            ERROR   = 2
        }
    }
}
