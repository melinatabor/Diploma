using Abstraccion;
using System.Collections.Generic;

namespace BE
{
    public class BEProveedor
    {
        #region Propiedades
        public int Id { get; set; }
        public string Marca { get; set; } 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        #endregion

        #region Constructores
        public BEProveedor() 
        { 
        }
        public BEProveedor(int id) {
            Id = id;
        }
        #endregion
    }
}
