using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public interface IBitacora
    {
        int Id { get; set; }
        int Usuario { get; set; }
        string Mensaje { get; set; }
        DateTime Fecha { get; set; }
    }
}
