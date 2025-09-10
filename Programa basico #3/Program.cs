//Desarrolle un programa que calcule la distancia total recorrida en kilómetros por un ciclista en el malecón de San Juan del Sur,
//utilizando como entradas la velocidad promedio en kilómetros por hora y el tiempo recorrido,
//ambos proporcionados por el usuario.

namespace Programa_basico__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double velocidad_promedio, tiempo_recorrido, distancia_total;

            Console.WriteLine("Programa de calculo de distancia total recorrida en kilómetros por un ciclista en el malecón de San Juan del Sur\n");

            Console.Write("Ingrese la velocidad promedio del ciclista en kilómetros por hora:");
            velocidad_promedio = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Ingrese el tiempo recorrido en horas:");
            tiempo_recorrido = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            distancia_total = velocidad_promedio * tiempo_recorrido;
            Console.WriteLine($"La distancia total recorrida por el ciclista a una velocidad promedio de {velocidad_promedio} km/h durante {tiempo_recorrido} horas es de {Math.Round(distancia_total, 2)} kilómetros.");
        }
    }
}
