//Contar números pares e impares
//Pide al usuario que ingrese 10 números. Usa un bucle for y estructuras if para contar cuántos son pares y cuántos impares.

namespace Ejercicio__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int control, num_pares = 0, num_impares = 0;
            double numero;

            Console.WriteLine("Contador de números pares e impares\n");

            for (control = 1; control <= 10; control++) 
            {
                Console.Write($"Ingrese el {control} número : ");
                try
                {
                    numero = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Error:Entrada no válida. Por favor, ingrese un número entero.");
                    control--; // resta 1 al control para no avanzar en el rango del bucle
                    continue; 
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Error:{ex.Message}");
                    control--; 
                    continue; 
                }
                if (numero % 2 == 0)
                {
                    num_pares++;
                }
                else
                {
                    num_impares++;
                }

            }
            Console.Clear();
            Console.WriteLine($"Se han ingresado {num_pares} números pares y {num_impares} números impares\n");
        }
    }
}
