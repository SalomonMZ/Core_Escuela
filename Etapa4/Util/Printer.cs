using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 20)
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void DibujarTitulo(string titulo)
        {
            var size = titulo.Length + 4;
            DibujarLinea(size);
            WriteLine($"| {titulo} |");
            DibujarLinea(size);
        }

        
        public static void Pitar(int hz, int t, int i)
        {
            while(i-- > 0)
            {
                Beep(hz, t);
            }
        }
    }
}