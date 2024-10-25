using Abstraccion;
using System;
using System.Collections.Generic;

namespace BE
{
    public class BEDetalleVenta
    {
        #region Propiedades
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public float Subtotal { get; set; }
        #endregion

        #region Constructores
        public BEDetalleVenta() 
        { 
        }
        public BEDetalleVenta(int id) {
            Id = id;
        }
        #endregion
    }
}
