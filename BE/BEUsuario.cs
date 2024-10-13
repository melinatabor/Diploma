using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEUsuario : IUsuario
    {
        #region Props:
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        #endregion

        #region Constructores:
        public BEUsuario()
        {
        }

        public BEUsuario(int id)
        {
            Id = id;
        }
        #endregion
    }
}
