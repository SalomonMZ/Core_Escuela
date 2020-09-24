using System;
using static System.Console;
using CoreEscuela.Entidades;
using System.Collections.Generic;

namespace Etapa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");
            // escuela.Pais = "Colombia";
            // escuela.Ciudad = "Bogota";
            // escuela.TipoEscuela = TiposEscuela.Primaria;
            /* var arregloCursos = new Curso[3]{
                                new Curso() {Nombre = "101"},
                                new Curso() {Nombre = "201"},
                                new Curso {Nombre = "301" }
            } */
            ;
            // escuela.Cursos = new Curso[] {
            //     new Curso() { Nombre = "101" },
            //     new Curso() { Nombre = "201" },
            //     new Curso() { Nombre = "301" }
            // };


            escuela.Cursos = new List<Curso>() {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Mañana }
            };

            escuela.Cursos.Add(new Curso { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso { Nombre = "202", Jornada = TiposJornada.Tarde });

            var otrosCursos = new List<Curso>{
                new Curso() { Nombre = "401", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "502", Jornada = TiposJornada.Tarde }
            };

            // Curso cTemp = new Curso { Nombre = "101-vacacional", Jornada = TiposJornada.Noche };
            escuela.Cursos.AddRange(otrosCursos);
            // escuela.Cursos.Add(cTemp);
            ImprimirCursosEscuela(escuela);
            WriteLine("=================");
            // Predicate<Curso> miAlgoritmo = Predicado;
            escuela.Cursos.RemoveAll(delegate(Curso cur){
                                            return cur.Nombre == "301";
                                            });
            // escuela.Cursos.Remove(cTemp);
            escuela.Cursos.RemoveAll((cur) => cur.Nombre == "401");
            ImprimirCursosEscuela(escuela);

        }

        // private static bool Predicado(Curso objCurso)
        // {
        //     return objCurso.Nombre == "301";
        // }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("==================");
            WriteLine("Cursos de la Escuela");
            WriteLine("==================");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
                }

            }

        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int i = 0;
            while (i < arregloCursos.Length)
            {
                WriteLine($"Nombre: {arregloCursos[i].Nombre}, Id: {arregloCursos[i].UniqueId}");
                i++;
            }
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                WriteLine($"Nombre: {arregloCursos[i].Nombre}, Id: {arregloCursos[i].UniqueId}");
            }

            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
            }
        }
    }
}
