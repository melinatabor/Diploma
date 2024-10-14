
using System.Collections.Generic;

namespace Abstraccion
{
    public interface IUsuario
    {
        string Username { get; set; }
        string Password { get; set; }
        List<int> ListaPermisos { get; set; }
    }
}
