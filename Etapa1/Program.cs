using System;
using CoreEscuela.Entidades;

namespace Etapa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012,TiposEscuela.Primaria, ciudad: "Bogota", pais: "Colombia" );
            // escuela.Pais = "Colombia";
            // escuela.Ciudad = "Bogota";
            // escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
        }
    }
}
