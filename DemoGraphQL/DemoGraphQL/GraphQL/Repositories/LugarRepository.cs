using System;
using System.Collections.Generic;
using System.Linq;
using DemoGraphQL.Models;

namespace DemoGraphQL.GraphQL.Repositories
{
    public class LugarRepository
    {
        private readonly List<Lugares> lugares;

        public LugarRepository()
        {

            lugares = new List<Lugares>()
            {
                new Lugares() {
                      id=1,
                      nombre="Universidad De Lasalle",
                      descripcion="La Universidad Privada m\u00e1s grande de la regi\u00f3n, ubicada en Le\u00f3n y Salamanca, contamos con posgrados y diplomados en Le\u00f3n.",
                      direccion="Av. Universidad 602 Col. Lomas del Campestre\n C.P. 37150, Le\u00f3n, Gto, M\u00e9xico",
                      telefono="477 712 3700",
                      website="http://bajio.delasalle.edu.mx",
                      imagen_nombre="https://mtwdm.kicks-ass.net/lugaresApi/img/1.jpg",
                      importancia="",
                      latitud=21.1071,
                      longitud=-101.6952,
                      rating=5,
                      title="Universidad De Lasalle",
                      reaction=""
                },
                new Lugares() {
                     id=2,
                      nombre="Arco de mi Casa",
                      descripcion="El Arco Triunfal de la Calzada de Los H\u00e9roes, mejor conocido como \"Arco de la Calzada\", es el emblema representativo de la ciudad de Le\u00f3n.",
                      direccion="Calle Calz. de los H\u00e9roes 104, \nCentro, 37370 Le\u00f3n, Gto.",
                      telefono="",
                      website="https://es.wikipedia.org/wiki/Arco_de_La_Calzada",
                      imagen_nombre="https://mtwdm.kicks-ass.net/lugaresApi/img/2.jpg",
                      importancia="",
                      latitud=21.1239,
                      longitud=-101.6712,
                      rating=4.3,
                      title="Arco de mi Casa",
                      reaction=""
                },
                new Lugares(){
                      id=3,
                      nombre="Templo Expiatorio ",
                      descripcion="El Templo Expiatorio Diocesano del Sagrado Coraz\u00f3n de Jes\u00fas tambi\u00e9n conocido simplemente como \"El Expiatorio\" es un templo dedicado al Sagrado Coraz\u00f3n de Jes\u00fas, ubicado en Le\u00f3n, Guanajuato, en M\u00e9xico.",
                      direccion="Calle Francisco I. Madero 721, \nCentro, 37000 Le\u00f3n, Gto.",
                      telefono="",
                      website="https://elsagradocorazon.org/templo-expiatorio-diocesano-del-sagrado-corazon-de-jesus/",
                      imagen_nombre="https://mtwdm.kicks-ass.net/lugaresApi/img/3.jpg",
                      importancia="",
                      latitud=21.1205,
                      longitud=-101.6748,
                      rating=5,
                      title="Templo Expiatorio ",
                      reaction=""
                },
                new Lugares(){
                      id=4,
                      nombre="Parque Zool\u00f3gico de Le\u00f3n",
                      descripcion="La colecci\u00f3n faun\u00edstica inici\u00f3 con algunas aves de la regi\u00f3n, venados cola blanca, patos dom\u00e9sticos y caballos, para posteriormente sumar especies de animales herb\u00edvoros a la familia del ZooLe\u00f3n.",
                      direccion="CARRETERA IBARRILLA KM 6, \n37207 LE\u00d3N, M\u00c9XICO",
                      telefono="477 210 2335",
                      website="https://www.zooleon.org.mx",
                      imagen_nombre="https://mtwdm.kicks-ass.net/lugaresApi/img/4.jpg",
                      importancia="",
                      latitud=21.1822,
                      longitud=-101.6505,
                      rating=4.6,
                      title="Parque Zool\u00f3gico de Le\u00f3n",
                      reaction=""
                },
                new Lugares(){
                      id=5,
                      nombre="Museo de Arte e Historia de Guanajuato",
                      descripcion="Museo de historia y arte con arquitectura notable, exhibiciones de esculturas mexicanas y cultura regional.",
                      direccion="Prol, Calle Calz. de los Heroes 908,\n La Martinica, 37500 Le\u00f3n, Gto.",
                      telefono="477 104 1100",
                      website="https://sic.cultura.gob.mx/ficha.php?table=museo&table_id=1274",
                      imagen_nombre="https://mtwdm.kicks-ass.net/lugaresApi/img/5.jpg",
                      importancia="",
                      latitud=21.1181,
                      longitud=-101.6603,
                      rating=3.2,
                      title="Museo de Arte e Historia de Guanajuato",
                      reaction=""
                }
            };
        }

        public List<Lugares> GetAllLugares()
        {
            return this.lugares;
        }
        public Lugares GetLugarById(int id)
        {
            return lugares.Where(lug => lug.id == id).FirstOrDefault<Lugares>();
        }
    }
}
