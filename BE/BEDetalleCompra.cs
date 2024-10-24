using Abstraccion;
using System;
using System.Collections.Generic;

namespace BE
{
    public class BEDetalleCompra
    {
        #region Propiedades
        public int Id { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public float Subtotal { get; set; }
        #endregion

        #region Constructores
        public BEDetalleCompra() 
        { 
        }
        public BEDetalleCompra(int id) {
            Id = id;
        }
        #endregion
    }
}
