//Desarrolle un programa que calcule el área total en manzanas de un terreno rectangular en una finca nicaragüense,
//donde el usuario ingresa la longitud y el ancho en varas
//(1 manzana = 1,428.8 varas²), utilizando una cantidad fija de 5 varas de ancho y la longitud como entrada.
namespace Programa_basico__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ancho = 5; // ancho fijo en varas
            double longitud;
            double area_varasCuadradas;
            double area_manzanas;

            Console.WriteLine("Programa de calculo de área total en manaznas (El ancho del terreno es fijo en 5 varas)\n");

            Console.Write("Ingrese la longitud del terreno en varas:");
            longitud = Convert.ToDouble(Console.ReadLine ());
            Console.Clear();

            area_varasCuadradas = ancho * longitud;
            area_manzanas = area_varasCuadradas / 1428.8;

            Console.WriteLine($"El área total del terreno con un ancho de {ancho} varas y una longitud de {longitud} varas es de {Math.Round(area_manzanas,2)} manzanas^2.");
        }
    }
}
