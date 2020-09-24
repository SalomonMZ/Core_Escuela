using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");

            CargarCursos();
            CargarAlumnos();
            CargarAsignaturas();
           // CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            
            foreach (var curs in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>() {
                    new Asignatura {Nombre = "Matematicas"},
                    new Asignatura {Nombre = "EdFisica"}, 
                    new Asignatura {Nombre = "Biologia"},
                    new Asignatura {Nombre = "Quimica"},
                    new Asignatura {Nombre = "Sociales"}
                };
                curs.Asignaturas = listaAsignaturas;
            }
        }

        private void CargarAlumnos()
        {
            string[] primerNombre = {"Freddy", "Martha", "Laura", "Luis", "Carlos", "Cristian", "Bernardo"};
            string[] segundoNombre = {"Alejandro", "Andres", "Lucia", "Cristina", "Camilo", "Isabella", "Felipe"};
            string[] apellido = {"Ruiz", "Sarmiento", "Moreno", "Velez", "Gomez", "Rodriguez", "Lopez"};

            var listaAlumnos = from pn in primerNombre
                               from sn in segundoNombre
                               from a in apellido
                               select new Alumno{ Nombre = $"{pn} {sn} {a}"};
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>() {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "401", Jornada = TiposJornada.Tarde },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde }
            };
        }
    }
}