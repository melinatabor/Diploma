using Abstraccion;
using System;
using System.Collections.Generic;

namespace BE
{
    public class BECliente
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public int Telefono { get; set; }
        #endregion

        #region Constructores
        public BECliente() 
        { 
        }
        public BECliente(int id) {
            Id = id;
        }
        #endregion
    }
}
