//Solicita al usuario un número entero positivo y usa un bucle while para calcular
//la suma de todos los números desde 1 hasta ese número.

namespace Ejercicio__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, suma = 0, contador = 1;

            Console.Write("Ingrese un número entero positivo:");

            try
            {
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 1)
                {
                    Console.WriteLine("Por favor, ingrese un número entero positivo.");
                }
                else
                {
                    while (contador <= numero) //menor o igual que el número ingresado
                    {
                        suma += contador;
                        contador++; // contador = contador + 1
                    }
                    Console.WriteLine($"La suma de los números desde 1 hasta el {numero} es: {suma}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }
        }
    }
}
