using Abstraccion;
using System;
using System.Collections.Generic;

namespace BE
{
    public class BEVenta
    {
        #region Propiedades
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public float Total { get; set; }
        public DateTime Fecha { get; set; }
        #endregion

        #region Constructores
        public BEVenta() 
        { 
        }
        public BEVenta(int id) {
            Id = id;
        }
        #endregion
    }
}
