using Abstraccion;
using System.Collections.Generic;

namespace BE
{
    public class BEInventario
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Stock { get; set; }
        public float CostoUnitario { get; set; }
        public float PrecioVenta { get; set; }
        public float GananciaXUnidad { get; set; }
        public float GananciaTotal { get; set; }
        #endregion

        #region Constructores
        public BEInventario() 
        { 
        }
        public BEInventario(int id) {
            Id = id;
        }
        #endregion
    }
}
