//Desarrolle un programa que calcule el tiempo total en horas de un viaje en bus desde Managua a Granada,
//donde el usuario ingresa la velocidad promedio en kilómetros por hora como entrada, asumiendo una distancia fija de
//40 kilómetros.

using System.Drawing;

namespace Programa_basico__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distancia = 40; // distancia fija en kilómetros
            double velocidad, tiempo;

            Console.WriteLine("Programa de calculo de tiempo total en horas de un viaje en bus desde Managua a Granada con distancia fija de 40km\n");
            Console.Write("Ingrese la velocidad promedio del bus en kilómetros por hora:");
            velocidad = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            tiempo = distancia / velocidad;

            Console.WriteLine($"El tiempo total del viaje en bus desde Managua a Granada a una velocidad promedio de {velocidad} km/h es de {Math.Round(tiempo, 2)} horas.");
        }
    }
}
