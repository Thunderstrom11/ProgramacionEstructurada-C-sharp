//Convertidor de días a semanas y días
//Pide al usuario un número de días e indica cuántas semanas completas y cuántos días sobran.
//Usa operaciones básicas y estructuras if

namespace Ejercicio__10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias, semanas, dias_sobrantes;

            Console.Write("Ingrese un número de días: ");

            try
            {
                dias = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Error:Entrada no válida. Por favor, ingrese un número entero.");
                return;
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Error:{ex.Message}");
                return;
            }

            if (dias < 0)
            {
                Console.Clear();
                Console.WriteLine("Error:El número de días no puede ser negativo.");
                return;
            }

            semanas = dias / 7;
            dias_sobrantes = dias % 7;


            if (semanas > 0)
            {
                if (dias_sobrantes > 0)
                {
                    Console.Clear();
                    Console.WriteLine($"[{dias} días] equivale a {semanas} semanas y {dias_sobrantes} días\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"[{dias} días] equivale a {semanas} semanas\n");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"[{dias} días] son menos de una semana y equivale a {dias_sobrantes} días\n");
            }
        }
    }
}
