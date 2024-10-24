using Abstraccion;
using System;
using System.Collections.Generic;

namespace BE
{
    public class BECompra
    {
        #region Propiedades
        public int Id { get; set; }
        public float Total { get; set; }
        public DateTime Fecha { get; set; }
        #endregion

        #region Constructores
        public BECompra() 
        { 
        }
        public BECompra(int id) {
            Id = id;
        }
        #endregion
    }
}
