//Desarrolle un programa que calcule el volumen total en metros cúbicos de agua recolectada en un tanque en una finca de Masaya,
//utilizando como entradas la longitud, el ancho y la altura del tanque, todos proporcionados por el usuario.

namespace Programa_basico__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double longitud, ancho, altura, volumen_total;

            Console.WriteLine ("Programa de calculo de volumen total en metros cúbicos de agua recolectada en un tanque en una finca de Masaya\n");

            Console.Write("Ingrese la longitud del tanque en metros:");
            longitud = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Ingrese el ancho del tanque en metros:");
            ancho = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Ingrese la altura del tanque en metros:");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            volumen_total = longitud * ancho * altura;

            Console.WriteLine($"El volumen total de agua recolectada en el tanque con una longitud de {longitud} metros, un ancho de {ancho} metros y una altura de {altura} metros es de {Math.Round(volumen_total, 2)} metros cúbicos.");
        }
    }
}
