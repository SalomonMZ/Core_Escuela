using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int YearOfFundation { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        // public Curso[] Cursos { get; set; }
        public List<Curso> Cursos {get; set;}

        // public Escuela (string nombre, int año)
        // {
        //     this.nombre = nombre;
        //     YearOfFundation = año;
        // }

        public Escuela (string nombre, int año) => (Nombre, YearOfFundation) = (nombre, año);

        public Escuela (string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad="")
        {
            (Nombre, YearOfFundation) = (nombre, año);
            (Pais, Ciudad) = (pais, ciudad);
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}