//Número mayor entre tres valores
//Solicita tres números diferentes al usuario y usa estructuras if para determinar cuál es el mayor.

namespace Ejercicio__9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3;

            Console.WriteLine("Determinador de número mayor entre tres valores\n");

            try
                {
                Console.Write("Ingrese el primer número: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el tercer número: ");
                numero3 = Convert.ToDouble(Console.ReadLine());
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
            if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
            {
                Console.Clear();
                Console.WriteLine("Error:Los números deben ser diferentes entre sí.");
                return;
            }

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.Clear();
                Console.WriteLine($"El número mayor es el primer numero: {numero1}\n");
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.Clear();
                Console.WriteLine($"El número mayor es el segundo número: {numero2}\n");
            }
            else // (numero3 > numero1 && numero3 > numero2)
            {
                Console.Clear();
                Console.WriteLine($"El número mayor es el tercer número: {numero3}\n");
            }
        }
    }
}
