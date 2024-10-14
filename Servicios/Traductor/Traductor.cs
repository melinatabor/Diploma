using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Traductor
{
    public class Traductor
    {
        public int Idioma;
        private List<ISubscriptor> Subscriptores { get; set; }

        public Traductor() 
        {
            Subscriptores = new List<ISubscriptor>();
        }

        public void AgregarSuscriptor(ISubscriptor sub)
        {
            Subscriptores.Add(sub);
        }

        private void Notificar()
        {
            foreach (ISubscriptor sub in Subscriptores)
                sub.Actualizar();
        }

        public void SetIdioma(int value)
        {
            this.Idioma = value;
            Notificar();
        }

        public int GetIdioma()
        {
            return this.Idioma;
        }
    }
}
