using Abstraccion;
using System.Collections.Generic;

namespace BE
{
    public class BEUsuario : IUsuario
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
        public string DigitoVerificadorH { get; set; }
        public List<BEPermiso> Permisos { get; set; }
        public List<int> ListaPermisos { get; set; }
        #endregion

        #region Constructores
        public BEUsuario() 
        { 
            Permisos = new List<BEPermiso>();
            ListaPermisos = new List<int>();
        }
        public BEUsuario(int id) {
            Id = id;
        }
        #endregion
    }
}
