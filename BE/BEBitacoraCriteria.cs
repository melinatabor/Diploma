using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEBitacoraCriteria
    {
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public int? Tipo { get; set; }
        public string Usuario { get; set; }
        public int Page { get; set; }
        public int RowPerPage { get; set; }
    }
}
