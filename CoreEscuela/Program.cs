using System;

namespace CoreEscuela
{

    class Escuela
    {
        public string nombre;
        public string direccion;
        public int yearFundation;

        public string ceo;

        public void Timbrar ()
        {
            //To Do
            Console.Beep(3500, 3000);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var miEscuela = new Escuela();
            miEscuela.nombre = "Platzi Academy";
            miEscuela.yearFundation = 2012;
            miEscuela.direccion = "Cra 9 con calle 72";
            Console.WriteLine("TIMBRE");
            miEscuela.Timbrar();

        }
    }
}
