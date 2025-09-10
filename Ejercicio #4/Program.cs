//4)Tabla de multiplicar con do-while
//Solicita un número al usuario y usa un bucle do while para mostrar su tabla de multiplicar del 1 al 10

namespace Ejercicio__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            int multiplicacion = 1;

            Console.Write("Ingrese un número para ver su tabla de multiplicar: ");

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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Tabla de multiplicar del {numero}:");
            Console.ResetColor();

            do
            {
                Console.WriteLine($"{Math.Round(numero,2)} x {multiplicacion} = {Math.Round(numero * multiplicacion,2)}");
                multiplicacion++;
            }
            while (multiplicacion <= 10);
        }
    }
}
