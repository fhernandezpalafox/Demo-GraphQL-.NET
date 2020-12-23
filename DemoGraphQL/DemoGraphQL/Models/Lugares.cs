using System;
namespace DemoGraphQL.Models
{
    public class Lugares
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string website { get; set; }
        public string imagen_nombre { get; set; }
        public string importancia { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
        public string title { get; set; }
        public string reaction { get; set; }
        public double rating { get; set; }
    }
}
