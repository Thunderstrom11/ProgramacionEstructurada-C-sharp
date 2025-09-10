//Número positivo o negativo
//Solicita un número al usuario e indica si es positivo, negativo o cero usando una estructura if

namespace Ejercicio__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Determinador de número positivo, negativo o cero\n");

            Console.Write("Ingrese un número: ");

            try
            {
                numero = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Error:Entrada no válida. Por favor, ingrese un número válido.");
                return;
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Error:{ex.Message}");
                return;
            }
            if (numero > 0)
            {
                Console.WriteLine($"El número {numero} es positivo\n");
            }
            else if (numero < 0)
            {
                Console.WriteLine($"El número {numero} es negativo\n");
            }
            if (numero == 0)
            {
                Console.WriteLine("El número es cero\n");
            }
        }
    }
}
