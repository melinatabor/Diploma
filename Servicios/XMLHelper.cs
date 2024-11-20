using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BE;

namespace Servicios
{
    public class XMLHelper
    {
        public static List<BEProducto> DeserializarListaDeProductos(string ruta)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<BEProducto>));

            using (FileStream fileStream = new FileStream(ruta, FileMode.Open))
            {
                return (List<BEProducto>)xmlSerializer.Deserialize(fileStream);
            }
        }

        public  static void SerializarListaDeProductos(List<BEProducto> listaProductos, string ruta)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<BEProducto>));

            using (FileStream filestream = new FileStream(ruta, FileMode.Create))
            {
                serializador.Serialize(filestream, listaProductos);
            }
        }
    }
}
