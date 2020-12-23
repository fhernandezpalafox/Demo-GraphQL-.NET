using System;
using DemoGraphQL.Models;
using GraphQL.Types;

namespace DemoGraphQL.GraphQL.Types
{
    public class LugaresType: ObjectGraphType<Lugares>
    {
        public LugaresType()
        {
            Name = "Lugar";
            Field(x => x.id).Description("Id del lugar");
            Field(x => x.nombre).Description("Nombre del lugar");
            Field(x => x.descripcion);
            Field(x => x.direccion);
            Field(x => x.telefono);
            Field(x => x.website);
            Field(x => x.imagen_nombre);
            Field(x => x.importancia);
            Field(x => x.latitud);
            Field(x => x.longitud);
            Field(x => x.title);
            Field(x => x.reaction).Description("Muestra la calificacion del lugar");
            Field(x => x.rating);

        }
    }
}
