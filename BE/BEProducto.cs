using Abstraccion;
using System;
using System.Collections.Generic;

namespace BE
{
    [Serializable]
    public class BEProducto
    {
        #region Propiedades
        public int Id { get; set; }
        public string Codigo { get; set; } 
        public string Nombre { get; set; }
        public int Proveedor { get; set; }
        public string Descripcion { get; set; }
        public int Gramos { get; set; }
        public int? Bandeja { get; set; }
        public float CostoUnitario { get; set; }
        public float PrecioVenta { get; set; }
        public float Ganancia { get; set; }
        public int? Cantidad { get; set; }
        #endregion

        #region Constructores
        public BEProducto() 
        { 
        }
        public BEProducto(int id) {
            Id = id;
        }
        #endregion
    }
}
